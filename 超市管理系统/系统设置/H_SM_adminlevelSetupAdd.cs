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
    public partial class H_SM_adminlevelSetupAdd : Form
    {
        MEMLEVELManager mlm = new MEMLEVELManager();

        public H_SM_adminlevelSetupAdd()
        {
            InitializeComponent();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (cboname.Text=="")
            {
                MessageBox.Show("请输入会员名");
                cboname.Focus();
                return;
            }
            if (txtdiscount.Text=="")
            {
                MessageBox.Show("请输入折扣值");
                txtdiscount.Focus();
                return;
            }
            if (txtdown.Text=="")
            {
                MessageBox.Show("请输入积分下限");
                txtdown.Focus();
                return;
            }
            if (txtup.Text=="")
            {
                MessageBox.Show("请输入积分上限");
                txtup.Focus();
                return;
            }

            MEMLEVEL aaa = new MEMLEVEL();
            aaa.MEMLEVEL_NAME = cboname.Text.ToString() ;
            aaa.MEMLEVEL_DISCOUNT =Convert.ToDouble(txtdiscount.Text);
            aaa.MEMLEVEL_LOWSCORE =Convert.ToDouble(txtdown.Text);
            aaa.MEMLEVEL_HIGHSCORE =Convert.ToDouble(txtup.Text);

            string a = mlm.ShowAddMEMLEVEL(aaa);
            MessageBox.Show(a);

            if (a=="新增成功")
            {
                this.Close();
            }
            else
            {
                //txtname.Text = "";
                //txtdiscount.Text = "";
                //txtdown.Text = "";
                //txtup.Text = "";
            }


        }

        private void H_SM_adminlevelSetupAdd_Load(object sender, EventArgs e)
        {
            //cboname.ValueMember="MHY_Jibei";
            //cboname.DisplayMember = "MEMLEVEL_NAME";
            //cboname.DataSource = mlm.GetAllMEMLEVEL().Tables[0];
        }
    }
}