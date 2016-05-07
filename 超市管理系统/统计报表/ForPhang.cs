using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.统计报表
{
    public partial class ForPhang : Form
    {
        public ForPhang()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Forjintuei ff = new Forjintuei();
            ff.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Forjintuei ff = new Forjintuei();
            ff.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}