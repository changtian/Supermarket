using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;


namespace 超市管理系统.统计报表
{
    public partial class ForDelete : Form
    {
        public ForDelete()
        {
            InitializeComponent();
        }
        string sghname;
        string dhao;
        string shifu;
        string yfu;
        public ForDelete(string ghs,string dh,string sf,string yf)
        {
            sghname = ghs;
            dhao = dh;
            shifu = sf;
            yfu = yf;
            InitializeComponent();
        }
        XS_tbaleManager xm = new XS_tbaleManager();
        private void btnshanchu_Click(object sender, EventArgs e)
        {
            if (txtwhy.Text=="")
            {
                MessageBox.Show("删除原因不能为空!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            xm.delete(dhao);
            this.Close();

        }

        private void btnquxiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForDelete_Load(object sender, EventArgs e)
        {
            lbid.Text = dhao;

            lbghs.Text = sghname;
            lbyingfu.Text = yfu;
            lbshifu.Text = shifu;


        }
    }
}