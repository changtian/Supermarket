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
    public partial class D_CustomerInfo_update : Form
    {
        KH_xinxiManager kcm = new KH_xinxiManager();
        public delegate void delwwwwwwwwwww();
        public event delwwwwwwwwwww wwwwwwwwww;

        KH_xinxi aa;
        public D_CustomerInfo_update(KH_xinxi a)
        {
            aa = a;
            InitializeComponent();
        }

        private void D_CustomerInfo_update_Load(object sender, EventArgs e)
        {
            txtname.Text = aa.KH_xName;
            txtpeople.Text = aa.KH_xlianxiren;
            txtphone.Text = aa.KH_xDianhua;
            txtremarks.Text = aa.KH_xBeizhu;
            txtaddress.Text = aa.KH_xDizhi;
            txtmoney.Text = aa.KH_xMoney.ToString();
            if (aa.KH_xMoren == 1)
            {
                cbmr.Checked = true;
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsure_Click(object sender, EventArgs e)
        {
            KH_xinxi aaa = new KH_xinxi();
            aaa.KH_xId = aa.KH_xId;
            aaa.KH_xName = txtname.Text;
            aaa.KH_xlianxiren = txtpeople.Text;
            aaa.KH_xDianhua = txtphone.Text;
            aaa.KH_xBeizhu = txtremarks.Text;
            aaa.KH_xDizhi = txtaddress.Text;
            aaa.KH_xMoney = Convert.ToInt32(txtmoney.Text);
            if (cbmr.Checked)
            {
                aaa.KH_xMoren = 1;
            }

            string a = kcm.ShowGetUpdateKH_xinxi(aaa);
            if (a=="修改成功")
            {
                MessageBox.Show(a);
                wwwwwwwwww();
                this.Close();
            }

        }

    }
}