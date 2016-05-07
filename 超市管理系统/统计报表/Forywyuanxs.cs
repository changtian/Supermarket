using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.统计报表
{
    public partial class Forywyuanxs : Form
    {
        public Forywyuanxs()
        {
            InitializeComponent();
        }

        
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttype_MouseDown(object sender, MouseEventArgs e)
        {
            if (palsptype.Visible==false)
            {
                palsptype.Visible = true;
            }
            else
            {
                palsptype.Visible = false;
            }
        }

        private void Forywyuanxs_Load(object sender, EventArgs e)
        {
            palsptype.Visible = false;
            palyji.Visible = false;
            radyjbg.Checked = true;

        }

        private void btnsptc_Click(object sender, EventArgs e)
        {
            palsptype.Visible = false;
        }

        private void toolyjbtntc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
                palyji.Visible = false;
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            palyji.Visible = true;
        }

        private void toolxsbtntc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolxsbtncx_Click(object sender, EventArgs e)
        {
            ForywyCX ff = new ForywyCX();
            ff.ShowDialog();
        }

        
    }
}