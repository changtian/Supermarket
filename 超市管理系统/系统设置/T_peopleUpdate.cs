using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using Models;


namespace 超市管理系统.系统设置
{
    public partial class T_peopleUpdate : Form
    {
        CZ_YuangongManager ym=new CZ_YuangongManager();
        RoleManager rm = new RoleManager();
        public delegate void delssssssssssssss();
        public event delssssssssssssss ssssssssssssss;

        CZ_Yuangong aa;



        GrantManager gm = new GrantManager();
        RoleGrantManager rgm = new RoleGrantManager();
        List<Grant> lst = new List<Grant>();

        public T_peopleUpdate(CZ_Yuangong a)
        {
            aa = a;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void T_peopleUpdate_Load(object sender, EventArgs e)
        {
            reset();

            cbowork.DisplayMember = "rName";
            cbowork.ValueMember = "rID";
            cbowork.DataSource= rm.GetAllRole().Tables[0];

            //InitTree();     //填充树形图
        }

      //#region    填充树形图
      //  private void InitTree()
      //  {
      //      treeView1.Nodes.Clear();    //把所有节点先删除

      //      lst = gm.GetAllGrant();
      //      //aaa("0",tvGrant.Nodes);
      //      CreateChildNodes("0", treeView1.Nodes);

      //      treeView1.ExpandAll();//展开所有节点
      //      treeView1.CheckBoxes = true;//加一个checkbox
      //      treeView1.ItemHeight = 20;
      //  }

      //  private void CreateChildNodes(string id, TreeNodeCollection tnc)
      //  {
      //      foreach (Grant g in lst)
      //      {
      //          if (g.PId.ToString() == id)
      //          {
      //              TreeNode tn = new TreeNode();
      //              tn.Text = g.Name;
      //              tn.Tag = g.Id;
      //              tnc.Add(tn);
      //              CreateChildNodes(g.Id.ToString(), tn.Nodes);    //就是自己调自己

      //          }
      //      }
      //  }
      //  #endregion



        //填充
        private void reset()
        {
            txtnum.ReadOnly = true;
            txtnum.Text = aa.CZ_yId.ToString(); 
            txtname.Text = aa.CZ_yName;
            cbowork.Text = aa.CZ_yZhiwei;
            txtpassword1.Text = aa.CZ_yPassword;
        }



        //退出
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

     
        //保存
        private void btsave_Click(object sender, EventArgs e)
        {
            //if (txtnum.Text == "")
            //{
            //    MessageBox.Show("编号不能为空");
            //    txtnum.Focus();
            //    return;
            //}
            //if (txtname.Text == "")
            //{
            //    MessageBox.Show("姓名不能为空");
            //    txtname.Focus();
            //    return;
            //}
            //if (cbowork.Text == "")
            //{
            //    MessageBox.Show("职位不能为空");
            //    cbowork.Focus();
            //    return;
            //}
            if (txtpassword2.Text == "")
            {
                MessageBox.Show("密码不能为空");
                txtpassword2.Focus();
                return;
            }

            if (txtpassword1.Text != txtpassword2.Text)
            {
                MessageBox.Show("密码输入错误");
                return;
            }
            CZ_Yuangong yy = new CZ_Yuangong();
            yy.CZ_yId = Convert.ToInt32(txtnum.Text);
            yy.CZ_yName = txtname.Text;
            yy.CZ_yZhiwei = cbowork.Text;
            yy.CZ_yPassword = txtpassword2.Text;

            string dd = ym.ShowUpdateCZ_Yuangong(yy);
            MessageBox.Show(dd);
            if (dd == "修改成功")
            {
                this.Close();
                ssssssssssssss();
            }
        }



        ////新增
        //private void btadd_Click(object sender, EventArgs e)
        //{
        //    if (treeView1.SelectedNode==null)
        //    {
        //        MessageBox.Show("请选择你要添加的节点的子节点");
        //        return;
        //    }
        //    string sText = treeView1.SelectedNode.Text;
        //    string sId = treeView1.SelectedNode.Tag.ToString();

        //    T_peopleUpdateAddorAddAdd aaa = new T_peopleUpdateAddorAddAdd(sId,sText);
        //    aaa.ShowDialog();

        //    T_peopleUpdate_Load(null,null);
        //}

    }
}