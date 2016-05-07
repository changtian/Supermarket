using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.统计报表
{
    public partial class ForCKsl : Form
    {
        int u;
        public ForCKsl(int i)
        {
            this.u = i;
            InitializeComponent();
        }

        private void ForCKsl_Load(object sender, EventArgs e)
        {
            if (u==1)
            {
                this.Text = "输入参考进货数量";
                lbjinjian.Text = "参考进货数量:";
               

            }
            else
            {
                this.Text = "输入参考退货数量";
                lbjinjian.Text = "参考退货数量:";
               
            }
        }

        private void btntc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}