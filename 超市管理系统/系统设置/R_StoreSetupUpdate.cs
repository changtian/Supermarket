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
    public partial class R_StoreSetupUpdate : Form
    {
        CK_tableManager ctm = new CK_tableManager();

        public delegate void delfffffff();
        public event delfffffff fffffff;

        CK_table dd;
        public R_StoreSetupUpdate(CK_table a)
        {
            dd = a;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            int i=dd.CK_tID;
            CK_table aa = new CK_table();
            aa.CK_tID = i;
            aa.CK_tName = txtname.Text;
            aa.CK_tfuzren = txtpeople.Text;
            aa.CK_tDizhi = txtaddress.Text;
            aa.CK_tBeizhu = txtremark.Text;
            aa.CK_tDianhua = txtphone.Text;
            if (cbmr.Checked)
            {
                aa.CK_tPOS = 1;
            }
            if (cbpos.Checked)
            {
                aa.CK_tMoren = 1;
            }

            string gg = ctm.ShowGetUpdateCK_table(aa);
            if (gg=="修改成功")
            {
                MessageBox.Show(gg);
                this.Close();
                fffffff();
            }
        }

        private void R_StoreSetupUpdate_Load(object sender, EventArgs e)
        {
            txtname.Text = dd.CK_tName;
            txtpeople.Text = dd.CK_tfuzren;
            txtphone.Text = dd.CK_tDianhua;
            txtremark.Text = dd.CK_tBeizhu;
            txtaddress.Text = dd.CK_tDizhi;
            if (dd.CK_tMoren==1)
            {
                cbmr.Checked = true;
            }
            if (dd.CK_tPOS==1)
            {
                cbpos.Checked = true;
            }
        }
    }
}