using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using System.Data.SqlClient;
using BLL;

namespace 超市管理系统.系统设置
{
    public partial class B_addbusniss : Form
    {
        public delegate void delDO();
        public event delDO aaaa;

        GH_shangManager gsh = new GH_shangManager();

        public B_addbusniss()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("请输入姓名");
                txtname.Focus();
                return;
            }
            if (txtpeople.Text == "")
            {
                MessageBox.Show("请输入联系人");
                txtpeople.Focus();
                return;
            }
            if (txtphone.Text == "")
            {
                MessageBox.Show("请输入联系人电话");
                txtphone.Focus();
                return;
            }

            // List<GH_shang> ls = new List<GH_shang>();

            GH_shang sh = new GH_shang();
            sh.GH_sName = txtname.Text;
            sh.GH_sLianxiren = txtpeople.Text;
            sh.GH_sDianhua = txtphone.Text;
            sh.GH_sMoney =Convert.ToDouble(txtmoney.Text);
;
            sh.GH_sDizhi = txtaddress.Text;
            sh.GH_sBeizhu = txtaddress.Text;

            //给checkbox填值判断
            if (ckbusiness.Checked)
            {
                sh.GH_sMoren = 1;
            }
            else
            {
                sh.GH_sMoren = 0;
            }
            string aaa = gsh.showAdd(sh);
            MessageBox.Show(aaa);

            aaaa();

            if (aaa=="新增成功")
            {
                this.Close();
            }
         
            
        }

        private void txtmoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_addbusniss_Load(object sender, EventArgs e)
        {

        }
    }
}