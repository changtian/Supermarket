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
    public partial class E_EmployeeUpdate : Form
    {
        YG_xinxiManager yxm = new YG_xinxiManager();

        public delegate void delddddddddddd();
        public event delddddddddddd dddddddddddd;

        YG_xinxi aa;
        public E_EmployeeUpdate(YG_xinxi a)
        {
            aa = a;
            InitializeComponent();
        }

        private void E_EmployeeUpdate_Load(object sender, EventArgs e)
        {
            txtname.Visible = true;
            txtname1.Text = aa.YG_xName;
            txtphone1.Text = aa.YG_xDianhua;
            txtaddress1.Text = aa.YG_xDizhi;
            txtjob1.Text = aa.YG_xZhiwu;
            txtremarks1.Text = aa.YG_xBeizhu;

            if (aa.YG_xCaigou == 1)
            {
                ckcg.Checked = true;
            }

            if (aa.YG_xkucuen == 1)
            {
                ckkc.Checked = true;
            }
            if (aa.YG_xXiaoshou == 1)
            {
                ckqc.Checked = true;
            }

        }

        private void btexit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            YG_xinxi aaaa = new YG_xinxi();
            aaaa.YG_xName = txtname1.Text;
            aaaa.YG_xBeizhu = txtremarks1.Text;
            aaaa.YG_xDianhua = txtphone1.Text;
            aaaa.YG_xDizhi = txtaddress1.Text;
            aaaa.YG_xZhiwu = txtjob1.Text;
            if (ckcg.Checked)
            {
                aaaa.YG_xCaigou = 1;
            }
            if (ckkc.Checked)
            {
                aaaa.YG_xkucuen = 1;
            }
            if (ckqc.Checked)
            {
                aaaa.YG_xXiaoshou = 1;
            }
            aaaa.YG_xId = aa.YG_xId;

            string ss = yxm.ShowGetUpdateYG_xinxi(aaaa);
            if (ss=="修改成功")
            {
                MessageBox.Show(ss);
                dddddddddddd();
                this.Close();
            }
        }
    }
}