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
    public partial class H_SM_adminlevelSetupUpdate : Form
    {
        public delegate void delaaa();
        public event delaaa ffff;

        MEMLEVELManager mm = new MEMLEVELManager();

        int b;

        MEMLEVEL ss = null;
        public H_SM_adminlevelSetupUpdate(int a,MEMLEVEL a1)
        {
            b = a;
            ss = a1;
            InitializeComponent();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (cboname.Text=="")
            {
                MessageBox.Show("请输入会员姓名");
                cboname.Focus();
                return;
            }
    
            if (txtdiscount.Text=="")
            {
                MessageBox.Show("请输入会员折扣");
                txtdiscount.Focus();
                return;
            }
    
            if (txtdown.Text=="")
            {
                MessageBox.Show("请输入会员积分下限");
                txtdown.Focus();
                return;
            }
    
            if (txtup.Text=="")
            {
                MessageBox.Show("请输入会员积分上限");
                txtup.Focus();
                return;
            }


            MEMLEVEL aa = new MEMLEVEL();
            aa.MHY_Jibei = b;
            aa.MEMLEVEL_NAME = cboname.Text;
            aa.MEMLEVEL_DISCOUNT = Convert.ToDouble(txtdiscount.Text);
            aa.MEMLEVEL_HIGHSCORE = Convert.ToDouble(txtdown.Text);
            aa.MEMLEVEL_LOWSCORE = Convert.ToDouble(txtup.Text);

            string aaaaa = mm.ShowUpdateMEMLEVEL(aa);
            MessageBox.Show(aaaaa);
            ffff();
            if (aaaaa=="修改成功")
            {
                this.Close();
            }
            else
            {
                cboname.Text = aa.MEMLEVEL_NAME;
                txtdiscount.Text = aa.MEMLEVEL_DISCOUNT.ToString();
                txtdown.Text = aa.MEMLEVEL_LOWSCORE.ToString() ;
                txtup.Text = aa.MEMLEVEL_HIGHSCORE.ToString();
            }
        }

        private void H_SM_adminlevelSetupUpdate_Load(object sender, EventArgs e)
        {
            //没有必要这样做
            //cboname.ValueMember = "MHY_Jibei";
            //cboname.DisplayMember = "MEMLEVEL_NAME";
            //cboname.DataSource = mm.GetAllMEMLEVEL().Tables[0];

            txtnumber.Text = b.ToString();
            cboname.Text = ss.MEMLEVEL_NAME;
            txtdiscount.Text = ss.MEMLEVEL_DISCOUNT.ToString();
            txtdown.Text = ss.MEMLEVEL_LOWSCORE.ToString();
            txtup.Text = ss.MEMLEVEL_HIGHSCORE.ToString();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}