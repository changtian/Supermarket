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
    public partial class D_CustomerInfo_find : Form
    {
        KH_xinxiManager kxm = new KH_xinxiManager();

        public D_CustomerInfo_find()
        {
            InitializeComponent();
        }

        private void btsure_Click(object sender, EventArgs e)
        {
            KH_xinxi aa = new KH_xinxi();
            aa.KH_xName = txtname.Text;
            aa.KH_xlianxiren = txtpeople.Text;
            aa.KH_xDianhua = txtphone.Text;
            aa.KH_xDizhi = txtaddress.Text;


        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void D_CustomerInfo_find_Load(object sender, EventArgs e)
        {

        }


    }
}