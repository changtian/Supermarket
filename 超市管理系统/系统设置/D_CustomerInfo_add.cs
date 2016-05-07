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
    public partial class D_CustomerInfo_add : Form
    {
        KH_xinxiManager kxm = new KH_xinxiManager();
        public delegate void delwwwwwwwwwwww();
        public event delwwwwwwwwwwww wwwwwwwwwww;

       
        public D_CustomerInfo_add()
        {
         
            InitializeComponent();
        }

        private void btsure_Click(object sender, EventArgs e)
        {
            if (txtname.Text=="")
            {
                MessageBox.Show("请输入姓名");
                txtname.Focus();
                return;
            }
            if (txtpeople.Text=="")
            {
                MessageBox.Show("请输入联系人");
                txtpeople.Focus();
                return;
            }

            KH_xinxi d = new KH_xinxi();
            d.KH_xName = txtname.Text;
            d.KH_xBeizhu = txtremarks.Text;
            d.KH_xDianhua = txtphone.Text;
            d.KH_xDizhi = txtaddress.Text;
            d.KH_xlianxiren = txtpeople.Text;
            d.KH_xMoney =Convert.ToDouble( txtmoney.Text);
            if (cbmr.Checked)
            {
                d.KH_xMoren = 1;
            }

            string a = kxm.ShowGetAddKH_xinxi(d);
            if (a=="新增成功")
            {
                MessageBox.Show(a);
                wwwwwwwwwww();
                this.Close();
            }

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void D_CustomerInfo_add_Load(object sender, EventArgs e)
        {

        }



    }
}