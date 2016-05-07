using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;
using System.Data.SqlClient;

namespace 超市管理系统.系统设置
{
    public partial class T_peopleAdd : Form
    {
        CZ_YuangongManager ym = new CZ_YuangongManager();
        RoleManager rm = new RoleManager();

        public delegate void deltttttttttttttttt();
        public event deltttttttttttttttt ttttttttttttttttttt;

       // CZ_Yuangong aa;



        GrantManager gm = new GrantManager();
        RoleGrantManager rgm = new RoleGrantManager();
        List<Grant> lst = new List<Grant>();


        public T_peopleAdd()
        {
            InitializeComponent();
        }

        private void T_peopleAdd_Load(object sender, EventArgs e)
        {
           // InitTree();     //填驻树形图
            cbowork.DisplayMember = "rName";
            cbowork.ValueMember = "rID";
            cbowork.DataSource=rm.GetAllRole().Tables[0];

        }

        ////填充树形图
        //private void InitTree()
        //{
        //    treeView1.Nodes.Clear();    //把所有节点先删除

        //    lst = gm.GetAllGrant();
        //    //aaa("0",tvGrant.Nodes);
        //    CreateChildNodes("0", treeView1.Nodes);

        //    treeView1.ExpandAll();//展开所有节点
        //    treeView1.CheckBoxes = true;//加一个checkbox
        //    treeView1.ItemHeight = 20;
        //}

        //private void CreateChildNodes(string id, TreeNodeCollection tnc)
        //{
        //    foreach (Grant g in lst)
        //    {
        //        if (g.PId.ToString() == id)
        //        {
        //            TreeNode tn = new TreeNode();
        //            tn.Text = g.Name;
        //            tn.Tag = g.Id;
        //            tnc.Add(tn);
        //            CreateChildNodes(g.Id.ToString(), tn.Nodes);    //就是自己调自己

        //        }
        //    }
        //}



        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //保存
        private void btsave_Click(object sender, EventArgs e)
        {
            if (txtnum.Text == "")
            {
                MessageBox.Show("编号不能为空");
                txtnum.Focus();
                return;
            }
            if (txtname.Text == "")
            {
                MessageBox.Show("姓名不能为空");
                txtname.Focus();
                return;
            }
            if (cbowork.Text == "")
            {
                MessageBox.Show("职位不能为空");
                cbowork.Focus();
                return;
            }
            if (txtpassword1.Text == "")
            {
                MessageBox.Show("密码不能为空");
                txtpassword1.Focus();
                return;
            }

            if (txtpassword1.Text != txtpassword2.Text)
            {
                MessageBox.Show("密码输入错误");
                return;
            }
            CZ_Yuangong yy = new CZ_Yuangong();
            //yy.CZ_yId = Convert.ToInt32(txtnum.Text);
            yy.CZ_yName = txtname.Text;
            //yy.CZ_yPOS=txt
            yy.CZ_yZhiwei = cbowork.Text;
            yy.CZ_yPassword = txtpassword1.Text;

            string dd = ym.ShowGetAddCZ_Yuangong(yy);
            MessageBox.Show(dd);
            if (dd == "新增成功")
            {
                this.Close();
                ttttttttttttttttttt();
            }
        }
    }
}