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
    public partial class R_StoreSetupAdd : Form
    {
        CK_tableManager ctm = new CK_tableManager();

        public delegate void delaaaa();
        public event delaaaa aaaaaa;

        public R_StoreSetupAdd()
        {
            InitializeComponent();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("请输入仓库名称");
                txtname.Focus();
                return;
            }
            if (txtpeople.Text == "")
            {
                MessageBox.Show("请输入负责人");
                txtpeople.Focus();
                return;
            }

            CK_table aaa = new CK_table();
            aaa.CK_tName = txtname.Text;
            aaa.CK_tfuzren = txtpeople.Text;
            aaa.CK_tDianhua = txtphone.Text;
            aaa.CK_tDizhi = txtaddress.Text;
            aaa.CK_tBeizhu = txtremark.Text;
            if (cbmr.Checked)
            {
                aaa.CK_tMoren = 1;
            }
            if (cbpos.Checked)
            {
                aaa.CK_tPOS = 1;
            }

            string aa = ctm.ShowGetAddCK_table(aaa);

            if (aa=="新增成功")
            {
                MessageBox.Show(aa);
                aaaaaa();
                this.Close();
            }

        }

        private void R_StoreSetupAdd_Load(object sender, EventArgs e)
        {

        }


    }
}