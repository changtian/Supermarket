using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Models;
using System.Data.SqlClient;

namespace 超市管理系统.系统设置
{
    public partial class T_people : Form
    {
        CZ_YuangongManager cym = new CZ_YuangongManager();

        //public delegate void delaaaaaa();
        //public event delaaaaaa aaaaaa;


        CZ_YuangongManager ym = new CZ_YuangongManager();

        CZ_Yuangong aa;



        GrantManager gm = new GrantManager();
        RoleGrantManager rgm = new RoleGrantManager();
        List<Grant> lst = new List<Grant>();


        public T_people(CZ_Yuangong a)
        {
            InitializeComponent();
            aa = a;
        }

        public T_people()
        {
            InitializeComponent();
        }

        //增加
        private void button1_Click(object sender, EventArgs e)
        {
            T_peopleAdd aaa = new T_peopleAdd();
            aaa.ttttttttttttttttttt += reset;
            aaa.ShowDialog();
            reset();
        }


        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            CZ_Yuangong yg = new CZ_Yuangong();
            yg.CZ_yId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CZ_yId"].Value);
            yg.CZ_yName = dataGridView1.CurrentRow.Cells["CZ_yName"].Value.ToString();
            yg.CZ_yPOS = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CZ_yPOS"].Value);
            yg.CZ_yPassword = dataGridView1.CurrentRow.Cells["CZ_yPassword"].Value.ToString();
            yg.CZ_yZhiwei = dataGridView1.CurrentRow.Cells["CZ_yZhiwei"].Value.ToString();
            if (yg.CZ_yId==1)
            {
                MessageBox.Show("该操作员不能修改","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            T_peopleUpdate aaa = new T_peopleUpdate(yg);
            aaa.ssssssssssssss += reset;
            aaa.ShowDialog();

        }


        //退出
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //填充
        private void T_people_Load(object sender, EventArgs e)
        {
            reset();

            InitTree();
        }


        #region    填充树形图
        private void InitTree()
        {
            treeView1.Nodes.Clear();    //把所有节点先删除

            lst = gm.GetAllGrant();
            //aaa("0",tvGrant.Nodes);
            CreateChildNodes("0", treeView1.Nodes);

            treeView1.ExpandAll();//展开所有节点
            treeView1.CheckBoxes = true;//加一个checkbox
            treeView1.ItemHeight = 20;

        }

        private void CreateChildNodes(string id, TreeNodeCollection tnc)
        {
            foreach (Grant g in lst)
            {
                if (g.PId.ToString() == id)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = g.Name;
                    tn.Tag = g.Id;
                    tnc.Add(tn);
                    CreateChildNodes(g.Id.ToString(), tn.Nodes);    //就是自己调自己

                }
            }
        }
        #endregion



        //刷新
        private void reset()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = cym.GetAllCZ_Yuangong().Tables[0];
        }


        //修改
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button2_Click(null, null);
        }

        //删除
        private void button3_Click(object sender, EventArgs e)
        {

            ////判断删除
            //public string ShowDeleteCZ_Yuangong(CZ_Yuangong aa)
            //{
            //    string Message;
            //    int i = Models.BDHelper.ExecuteNonQuery(aa);
            //    if (i>0)
            //    {

            //        Message = "删除成功";
            //    }
            //    return Message;
            //}


            DialogResult mes = MessageBox.Show("确定删除吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (mes == DialogResult.No)
            {
                return;
            }
            else
            {
                CZ_Yuangong a = new CZ_Yuangong();
                a.CZ_yId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CZ_yId"].Value);
                int i= cym.DeleteCZ_Yuangong(a);
            }

            reset();
        }


        //在dataGridView1中选择发生的事
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }

            string sRID = dataGridView1.CurrentRow.Cells["rid"].Value.ToString();

            List<RoleGrant> lstGrant = rgm.GetAllRoleGrantByRID(sRID);

            ChildNodesCheckedState(treeView1.Nodes, lstGrant);
        }

        private void ChildNodesCheckedState(TreeNodeCollection tnc, List<RoleGrant> lstGrant)
        {
            foreach (TreeNode tn in tnc)
            {
                tn.Checked = false;
                foreach (RoleGrant rg in lstGrant)
                {
                    if (Convert.ToInt32(tn.Tag) == rg.GId)
                    {
                        tn.Checked = true;
                        break;
                    }
                }

                ChildNodesCheckedState(tn.Nodes, lstGrant);
            }
        }

        //权限保存
        private void btnSure_Click(object sender, EventArgs e)
        {
            string sRID = dataGridView1.CurrentRow.Cells["rid"].Value.ToString();
            List<RoleGrant> lst = new List<RoleGrant>();
            SaveChildNodesChecked(lst, treeView1.Nodes);

            //初始化lst，递归
            bool b = rgm.SaveRoleGrant(sRID, lst);
            if (b)
            {
                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("保存失败");
            }
        }

        private void SaveChildNodesChecked(List<RoleGrant> lst, TreeNodeCollection tnc)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.Checked)
                {
                    RoleGrant rg = new RoleGrant();
                    rg.GId = Convert.ToInt32(tn.Tag);
                    lst.Add(rg);
                }

                SaveChildNodesChecked(lst, tn.Nodes);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("请选择你要添加的节点的子节点");
                return;
            }
            string sText = treeView1.SelectedNode.Text;
            string sId = treeView1.SelectedNode.Tag.ToString();

            T_peopleUpdateAddorAddAdd aaa = new T_peopleUpdateAddorAddAdd(sId, sText);
            aaa.ShowDialog();

            T_people_Load(null, null);
        }

        //private void btdelete_Click(object sender, EventArgs e)
        //{
        //    if (treeView1.SelectedNode == null)
        //    {
        //        MessageBox.Show("请选择你要添加的节点的子节点");
        //        return;
        //    }
        //    DialogResult a = MessageBox.Show("确定要删除吗？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        //    if (a.Equals(DialogResult.No))
        //    {
        //        return;
        //    }
        //    int i = Convert.ToInt32(treeView1.SelectedNode.Tag.ToString());
        //    if (i>0)
        //    {
        //        MessageBox.Show("删除成功");
        //    }
        //    else
        //    {
        //        MessageBox.Show("删除失败");
        //    }

        //    T_people_Load(null, null);
        //}
    }
}