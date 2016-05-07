using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.统计报表
{
    public partial class Forjintuei : Form
    {
        public Forjintuei()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolbtnttueichu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolbtnchaxun_Click(object sender, EventArgs e)
        {
            Forjintueichax ff = new Forjintueichax(1);
            ff.ShowDialog();
        }

        private void toolbtntchax_Click(object sender, EventArgs e)
        {
            Forjintueichax ff = new Forjintueichax(0);
            ff.ShowDialog();
        }
    }
}