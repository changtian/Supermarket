using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.统计报表
{
    public partial class Forjintueichax : Form
    {
        int u;
        public Forjintueichax(int i)
        {
            InitializeComponent();
            this.u = i;
        }

        

        private void Forjintueichax_Load(object sender, EventArgs e)
        {
            if (u==1)
            {
                Text = "添加参考进货商品";
                btntjianadd.Text = "添加到参考进货";
                btnshangpadd.Text = "添加到参考进货";
                btnghsadd.Text = "添加到参考进货";
            }
            else
            {
                Text = "添加参考退货商品";
                btntjianadd.Text = "添加到参考退货";
                btnshangpadd.Text = "添加到参考退货";
                btnghsadd.Text = "添加到参考退货";
            }
            palghshang.Visible = false;
            palshangp.Visible = false;
            paltiaojian.Visible = true;
        }

        private void btntiaojian_Click(object sender, EventArgs e)
        {
            palghshang.Visible = false;
            palshangp.Visible = false;
            paltiaojian.Visible = true;
        }

        private void btnshangping_Click(object sender, EventArgs e)
        {
            palghshang.Visible = false;
            palshangp.Visible = true;
            paltiaojian.Visible = false;
        }

        private void btnghs_Click(object sender, EventArgs e)
        {
            palghshang.Visible = true;
            palshangp.Visible = false;
            paltiaojian.Visible = false;
        }

        private void btntjianadd_Click(object sender, EventArgs e)
        {
            ForCKsl ff = new ForCKsl(u);
            ff.ShowDialog();
        }

        private void btnghsadd_Click(object sender, EventArgs e)
        {
            ForCKsl ff = new ForCKsl(u);
            ff.ShowDialog();
        }

        private void btnshangpadd_Click(object sender, EventArgs e)
        {
            ForCKsl ff = new ForCKsl(u);
            ff.ShowDialog();
        }
    }
}