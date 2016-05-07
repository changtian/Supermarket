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
    public partial class H_SM_adminUpdate : Form
    {
        HY_guanliManager gm = new HY_guanliManager();

        public delegate void delssss();
        public event delssss ssss;

        int i;
        HY_guanli aa;
        public H_SM_adminUpdate(int a1,HY_guanli a2)
        {
            i = a1;
            aa = a2;
            InitializeComponent();
        }

        //退出
        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //填充
        private void H_SM_adminUpdate_Load(object sender, EventArgs e)
        {
            //aa.HY_Jibei = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HY_Jibei"].Value);
            //aa.HY_Name = dataGridView1.CurrentRow.Cells["HY_Name"].Value.ToString();
            //aa.HY_Password = dataGridView1.CurrentRow.Cells["HY_Password"].Value.ToString();
            //aa.HY_Shengri = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HY_Shengri"].Value);
            //aa.HY_Jifen = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HY_Jifen"].Value);
            //aa.HY_Dianhua = dataGridView1.CurrentRow.Cells["HY_Dianhua"].Value.ToString();
            //aa.HY_Jiarutime = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HY_Jiarutime"].Value);
            //aa.HY_Daoqitime = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HY_Daoqitime"].Value);
            //aa.HY_Zhuangtai = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HY_Zhuangtai"].Value);
            //aa.HY_SYQX = dataGridView1.CurrentRow.Cells["HY_SYQX"].Value.ToString();
            //aa.HY_Beizhu = dataGridView1.CurrentRow.Cells["HY_Beizhu"].Value.ToString();
            //int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HY_Id"].Value);

            txtnum.Text = i.ToString();
            txtname.Text = aa.HY_Name;
           
            txtpassword.Text = aa.HY_Password;
            dtpbirth.Text = aa.HY_Shengri.ToString() ;
            
            dtpjoindate.Text = aa.HY_Jiarutime.ToString();
            txtintegral.Text = aa.HY_Jifen.ToString();
            txtphone.Text = aa.HY_Dianhua;
            txtremark.Text = aa.HY_Beizhu;

            if (aa.HY_Jibei == 1)
            {
                cbolevel.Text ="高级会员"; ;
            }
            if (aa.HY_Jibei==2)
            {
                cbolevel.Text = "中级会员";
            }
            if (aa.HY_Jibei==3)
            {
                cbolevel.Text = "普通会员";
            }

            //到期日期
            if (aa.HY_SYQX=="有")
            {
                cbendday.Checked = true;
                dtpenddate.Text = aa.HY_Daoqitime.ToString();
            }
            else
            {
                cbendday.Checked = false;
                dtpenddate.Enabled = false; 
            }

            //
            if (aa.HY_Shengji == 1)
            {
                cbremove.Checked = true;
            }
            else
            {
                cbremove.Checked = false;
            }

            //会员状态
            if (aa.HY_Zhuangtai==1)
            {
                cbstartnumber.Checked = true;
            }
            else
            {
                cbstartnumber.Checked = false;
            }
        }

        //保存按钮
        private void btsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text=="")
            {
                MessageBox.Show("请输入姓名");
                txtname.Focus();
                return;
            }
            if (txtphone.Text == "")
            {
                MessageBox.Show("请输入电话");
                txtphone.Focus();
                return;
            }
            if (txtintegral.Text == "")
            {
                MessageBox.Show("请输入积分");
                txtintegral.Focus();
                return;
            }
          

            HY_guanli aa = new HY_guanli();
            aa.HY_Id = i;
            if (cbolevel.Text=="高级会员")
            {
                aa.HY_Jibei = 1;
            }
            if (cbolevel.Text=="中级会员")
            {
                aa.HY_Jibei = 2;
            }
            if (cbolevel.Text=="普通会员")
            {
                aa.HY_Jibei = 3;
            }
            aa.HY_Name = txtname.Text;
            aa.HY_Password = txtpassword.Text;
            aa.HY_Shengri =dtpbirth.Value;
            aa.HY_Jifen = Convert.ToInt32(txtintegral.Text.ToString());
            aa.HY_Dianhua = txtphone.Text;
            aa.HY_Jiarutime =Convert.ToDateTime( dtpjoindate.Text);
            aa.HY_Daoqitime =Convert.ToDateTime( dtpenddate.Text);
            aa.HY_Beizhu = txtremark.Text;
            if (cbendday.Checked)
            {
                aa.HY_SYQX ="无";
            }
            else
            {
                aa.HY_SYQX = "有";
            }
            if (cbstartnumber.Checked)
            {
                aa.HY_Zhuangtai = 1;
            }
            else
            {
                aa.HY_Zhuangtai = 0;
            }
            if (cbremove.Checked )
            {
                aa.HY_Shengji = 1;
            }
            else
            {
                aa.HY_Shengji = 0;
            }

            if (txtpassword.Text != txtaginpassword.Text)
            {
                MessageBox.Show("密码输入错误"); ;
                txtaginpassword.Focus();
                return;
            }
            string aaaaa = gm.ShowupdateHY_guanli(aa);
            ssss();
       
            MessageBox.Show(aaaaa);
            if (aaaaa=="修改成功")
            {
                this.Close();
            }
        }
    }
}