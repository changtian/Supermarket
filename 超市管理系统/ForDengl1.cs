using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;


namespace 超市管理系统
{
    public partial class ForDengl1 : Form
    {
        CZ_YuangongManager cm = new CZ_YuangongManager();
        public ForDengl1()
        {
            InitializeComponent();
            //this.skinEngine1.SkinFile = "vista1.ssk";
        }

        private void btndenglu_Click(object sender, EventArgs e)
        {
            if (cboname.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名");
                cboname.Focus();
                return;
            }
            CZ_Yuangong cy = new CZ_Yuangong();
            cy.CZ_yName = cboname.Text;
            cy.CZ_yPassword = txtpwd.Text;
            string h = "";
            bool b = cm.login(cy, ref h);
            
            if (b)
            {
                ForMan ff = new ForMan(h);
                ff.Show();
                this.Hide();

            }
            else
            {
               MessageBox.Show(h);
            }


        }

        private void btnquxiao_Click(object sender, EventArgs e)
        {
            DialogResult ff = MessageBox.Show("是否取消登录", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ff == DialogResult.No)
            {
                return;
            }
            this.Close();
            
        }

        private void ForDengl1_Load(object sender, EventArgs e)
        {
            cboname.DisplayMember = "CZ_yName";
            
            cboname.DataSource = cm.add(); ;

        }
    }
}