using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.统计报表
{
    public partial class Forghxs : Form
    {
        int s;
        string qtime;
        string htime;
        string spname;
        public Forghxs(int i,string q,string h,string name)
        {
            InitializeComponent();
            this.s = i;
            this.qtime = q;
            this.htime = h;
            this.spname = name;
        }

        private void Forghxs_Load(object sender, EventArgs e)
        {
            if (s==1)
            {
                this.Text = "供货商商品销售情况高级查询";

            }
            if (s==0)
            {
                this.Text = "供货商供货情况高级查询";
            }
            lbqtime.Text = qtime;
            lbhtime.Text = htime;
            lbghname.Text = spname;
        }

        private void btntueichu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}