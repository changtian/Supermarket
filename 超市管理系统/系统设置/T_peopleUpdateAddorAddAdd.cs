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
    public partial class T_peopleUpdateAddorAddAdd : Form
    {
        GrantManager gm = new GrantManager();

        public T_peopleUpdateAddorAddAdd(string id,string name)
        {
            InitializeComponent();
            txtPNode.Text = name;
            txtPNode.Tag = id;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text=="")
            {
                MessageBox.Show("请输入要添加的子节点名");
                txtName.Focus();
                return;
            }
            if (txtForm.Text=="")
            {
                MessageBox.Show("请输入窗体名");
                txtForm.Focus();
                return;
            }

            Grant g = new Grant();
            g.PId = Convert.ToInt32(txtPNode.Tag);
            g.Name = txtName.Text;
            g.FormName = txtForm.Text;

            int i = gm.AddGrant(g);
            if (i>0)
            {
                MessageBox.Show("新增成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("新增失败");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void T_peopleUpdateAddorAddAdd_Load(object sender, EventArgs e)
        {

        }
    }
}