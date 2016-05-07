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
    public partial class R_StoreSetupFind : Form
    {
        CK_tableManager ctm = new CK_tableManager();

        public delegate void delaaaaaaa(CK_table obj);
        public event delaaaaaaa aaaaaaa;
        public R_StoreSetupFind()
        {
            InitializeComponent();
        }

        private void btsure_Click(object sender, EventArgs e)
        {
            CK_table aa = new CK_table();
            aa.CK_tName = txtname.Text;
            aa.CK_tfuzren = txtpeople.Text;
            aa.CK_tDianhua = txtphone.Text;
            aa.CK_tDizhi = txtaddress.Text;
            aaaaaaa(aa);


            //Dictionary<string, string> a =new Dictionary<string,string>();
            //a.Add("1",txtname.Text);
            //a.Add("2", txtpeople.Text);
            //a.Add("3",txtphone.Text);
            //a.Add("4",txtaddress.Text);
            //this.Tag = a;
            //aaaaaaa();
            //this.Close();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void R_StoreSetupFind_Load(object sender, EventArgs e)
        {

        }


    }
}