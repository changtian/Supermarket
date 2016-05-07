using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.统计报表
{
    public partial class ForywyCX : Form
    {
        public ForywyCX()
        {
            InitializeComponent();
        }

        private void btncha_Click(object sender, EventArgs e)
        {
            if (palkh.Visible==false)
            {
                palkh.Visible = true;

            }
            else
            {
                palkh.Visible = false;
            }
        }

        private void ForywyCX_Load(object sender, EventArgs e)
        {
            palkh.Visible = false;
        }

        private void btnpltc_Click(object sender, EventArgs e)
        {
            palkh.Visible = false;

        }
    }
}