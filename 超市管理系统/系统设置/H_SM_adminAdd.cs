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
    public partial class H_SM_adminAdd : Form
    {
        HY_guanliManager hgm = new HY_guanliManager();

        public delegate void delaaa();

        public event delaaa ddd;

        public H_SM_adminAdd()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void H_SM_adminAdd_Load(object sender, EventArgs e)
        {
            txtnum.ReadOnly = true;
            txtnum.Text = "自动生成";

            //comboBox1.ValueMember = "HY_Id";
            //comboBox1.DisplayMember = "HY_Jibei";
            //comboBox1.DataSource = hgm.GetAllHY_guanli().Tables[0];




        }


        //保存
        private void btsave_Click(object sender, EventArgs e)
        {
            if (txtnum.Text == "")
            {
                MessageBox.Show("请输入姓名");
                txtnum.Focus();
                return;
            }

            if (txtpassword.Text == "")
            {
                MessageBox.Show("请输入密码");
                txtpassword.Focus();
                return;
            }

            if (txtphone.Text == "")
            {
                MessageBox.Show("请输入电话");
                txtphone.Focus();
                return;
            }

            if (dtpjoindate.Text == "")
            {
                MessageBox.Show("请输入姓名");
                dtpjoindate.Focus();
                return;
            }

            if (txtnum.Text == "")
            {
                MessageBox.Show("请输入姓名");
                txtnum.Focus();
                return;
            }

            if (txtnum.Text == "")
            {
                MessageBox.Show("请输入姓名");
                txtnum.Focus();
                return;
            }

            if (txtnum.Text == "")
            {
                MessageBox.Show("请输入姓名");
                txtnum.Focus();
                return;
            }

            if (txtnum.Text == "")
            {
                MessageBox.Show("请输入姓名");
                txtnum.Focus();
                return;
            }

            if (txtnum.Text == "")
            {
                MessageBox.Show("请输入姓名");
                txtnum.Focus();
                return;
            }

            if (txtnum.Text == "")
            {
                MessageBox.Show("请输入姓名");
                txtnum.Focus();
                return;
            }

            if (txtnum.Text == "")
            {
                MessageBox.Show("请输入姓名");
                txtnum.Focus();
                return;
            }

            HY_guanli gg = new HY_guanli();
            if (cbonum.Text == "高级会员")
            {
                gg.HY_Jibei = 1;
            }
            if (cbonum.Text == "中级会员")
            {
                gg.HY_Jibei = 2;
            }
            if (cbonum.Text == "普通会员")
            {
                gg.HY_Jibei = 3;
            }

            gg.HY_ACOUNT = 0;
            gg.HY_ALLCOST = 0;
            gg.HY_COSTNUM = 0;
            gg.HY_Name = txtname.Text;
            gg.HY_Password = txtpassword.Text;
            gg.HY_Shengri = dtpbirth.Value;
            gg.HY_Jifen = 0;
            gg.HY_Dianhua = txtphone.Text;
            gg.HY_Jiarutime = dtpjoindate.Value;


            gg.HY_Daoqitime = dtpenddate.Value;

            if (cbremove.Checked)
            {
                gg.HY_Shengji = 1;
            }
            else
            {
                gg.HY_Shengji = 0;
            }

            if (cbendday.Checked)
            {
                gg.HY_SYQX = "有";
            }
            else
            {
                gg.HY_SYQX = "无";
            }
            if (cbstartnumber.Checked)
            {
                gg.HY_Zhuangtai = 1;
            }
            else
            {
                gg.HY_Zhuangtai = 0;
            }

            gg.HY_Beizhu = txtremark.Text;


            if (txtpassword.Text!=txtaginpassword.Text)
            {
                MessageBox.Show("密码输入错误");
                return;
            }

            string aaa = hgm.showAddHY_guanli(gg);
            ddd();
            MessageBox.Show(aaa);

        }

        //cbendday的选择事件
        private void cbendday_CheckedChanged(object sender, EventArgs e)
        {
            if (cbendday.Checked)
            {
                dtpenddate.Enabled = true;
            }
            else
            {
                dtpenddate.Enabled = false;
            }
        }


    }
}