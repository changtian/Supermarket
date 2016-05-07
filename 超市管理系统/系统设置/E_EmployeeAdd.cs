using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Models;
using BLL;

namespace 超市管理系统.系统设置
{
    public partial class E_EmployeeAdd : Form
    {
        YG_xinxiManager yxm = new YG_xinxiManager();

        public delegate void deljjjjjjjjjjj();
        public event deljjjjjjjjjjj jjjjjjjj;

        public E_EmployeeAdd()
        {
           
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsure_Click(object sender, EventArgs e)
        {
            if (txtname.Text=="")
            {
                MessageBox.Show("请输入姓名");
                txtname.Focus();
                return;
            }
            if (txtwork.Text=="")
            {
                MessageBox.Show("请输入职务");
                txtwork.Focus();
                return;
            }

            YG_xinxi aa = new YG_xinxi();
            aa.YG_xName = txtname.Text;
            aa.YG_xDianhua = txtphone.Text;
            aa.YG_xBeizhu = txtremark.Text;
            aa.YG_xDizhi = txtaddress.Text;
            aa.YG_xZhiwu = txtwork.Text;
            if (ckstock.Checked)
            {
                aa.YG_xCaigou = 1;
            }
            if (cksell.Checked)
            {
                aa.YG_xkucuen = 1;
            }
            if (ckresave.Checked)
            {
                aa.YG_xXiaoshou = 1;
            }
            string dd = yxm.ShowGetAddYG_xinxi(aa);
            if (dd=="新增成功")
            {
                MessageBox.Show(dd);
                jjjjjjjj();
                this.Close();
            }
        }

        private void E_EmployeeAdd_Load(object sender, EventArgs e)
        {

        }


    }
}