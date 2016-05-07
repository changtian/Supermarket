using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.统计报表
{
    public partial class Forbdgjchaxun : Form
    {
        public Forbdgjchaxun()
        {
            InitializeComponent();
        }

        private void Forbdgjchaxun_Load(object sender, EventArgs e)
        {
            palcha.Visible = false;
        }

        private void btncha_Click(object sender, EventArgs e)
        {
            if (palcha.Visible==true)
            {
                palcha.Visible = false;
            }
            else
            {
                palcha.Visible = true;
            }
        }

        private void btnpalqu_Click(object sender, EventArgs e)
        {
            palcha.Visible = false;
        }

      

        private void btnquxiao_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}