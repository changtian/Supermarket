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
    public partial class B_updatebusniss : Form
    {
        public delegate void delaaa();
        public event delaaa ddd;

        GH_shangManager gsh = new GH_shangManager();

        int ee = 0;
        GH_shang hh =null;

        public B_updatebusniss(int i,GH_shang aa)
        {
            ee = i;
            hh = aa;
            InitializeComponent();
        }

        public B_updatebusniss(int i)
        {
            ee = i;
            InitializeComponent();
        }


        public B_updatebusniss()
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

            GH_shang sh = new GH_shang();
            sh.GH_sId = ee.ToString();
            sh.GH_sName = txtname.Text;
            sh.GH_sLianxiren = txtpeople.Text;
            sh.GH_sDianhua = txtphone.Text;
            sh.GH_sBeizhu = txtremarks.Text;
            sh.GH_sDizhi = txtaddress.Text;
            sh.GH_sMoney =Convert.ToInt32(txtmoney.Text);
            if (ckbusiness.Checked)
            {
                sh.GH_sMoren = 1;

            }
            else
            {
                sh.GH_sMoren =0;

            }

            string sss = gsh.showUpdate(sh);

            ddd();

            MessageBox.Show(sss);
            if (sss == "修改成功")
            {
                this.Close();
            }
        }

        private void B_updatebusniss_Load(object sender, EventArgs e)
        {
            txtname.Text = hh.GH_sName;
            txtpeople.Text = hh.GH_sLianxiren;
            txtremarks.Text =hh.GH_sBeizhu;
            txtphone.Text = hh.GH_sDianhua;
            txtmoney.Text = hh.GH_sMoney.ToString();
            txtaddress.Text = hh.GH_sDizhi;
            if (hh.GH_sMoren.ToString()=="1")
            {
                ckbusiness.Checked = true;
            }
            else
            {
                ckbusiness.Checked = false;
            }
            //ckbusiness.Text =(hh.GH_sMoren).ToString();
        }
    }
}