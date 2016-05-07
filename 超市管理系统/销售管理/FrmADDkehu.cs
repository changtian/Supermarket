using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;

namespace 超市管理系统.销售管理
{
    public partial class FrmADDkehu : Form
    {
        public FrmADDkehu()
        {
            InitializeComponent();
        }
        string s;
        public FrmADDkehu(string i)
        {
            this.s = i;
            InitializeComponent();
        }
        KH_xinxiManager km = new KH_xinxiManager();
        private void btnqued_Click(object sender, EventArgs e)
        {
            if (s==null)
            {
                KH_xinxi kh = new KH_xinxi();
                kh.KH_xName = txtname.Text;
                kh.KH_xlianxiren = txtlxr.Text;
                kh.KH_xDianhua = txtdh.Text;
                kh.KH_xDizhi = txtdz.Text;
                kh.KH_xBeizhu = txtbz.Text;
                int i = 0;
                if (cbmr.Checked == false)
                {
                    i = 0;

                }
                else
                {
                    i = 1;
                }
                kh.KH_xMoren = i;
                MessageBox.Show(km.kh( kh));
                this.Close();
            }
            else
            {
                KH_xinxi kh = new KH_xinxi();
                kh.KH_xId = Convert.ToInt32(s);
                kh.KH_xName = txtname.Text;
                kh.KH_xlianxiren = txtlxr.Text;
                kh.KH_xDianhua = txtdh.Text;
                kh.KH_xDizhi = txtdz.Text;
                kh.KH_xBeizhu = txtbz.Text;
                kh.KH_xMoney =Convert.ToDouble( txtmoney.Text);
                int i = 0;
                if (cbmr.Checked == false)
                {
                    i = 0;

                }
                else
                {
                    i = 1;
                }
                kh.KH_xMoren = i;
                MessageBox.Show(km.khxiougai(kh));
                this.Close();
            }
          
        }

        private void FrmADDkehu_Load(object sender, EventArgs e)
        {
            if (s!="")
            {
                KH_xinxi ks = new KH_xinxi();
                ks.KH_xId = Convert.ToInt32(s);
                DataSet ds = km.xiougai(ks);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    txtname.Text = dr["KH_xName"].ToString();
                    txtlxr.Text=dr["KH_xlianxiren"].ToString();
                    txtdh.Text=dr["KH_xDianhua"].ToString();
                    txtdz.Text = dr["KH_xDizhi"].ToString();
                    txtbz.Text = dr["kH_xBeizhu"].ToString();
                    txtmoney.Text = dr["KH_xMoney"].ToString();
                    int i = Convert.ToInt32(dr["KH_xMoren"]);
                    if (i==0)
                    {
                        cbmr.Checked = false;
                    }
                    else
                    {
                        cbmr.Checked = true;
                    }
                }
               
        
            }
        }

        private void btnqx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}