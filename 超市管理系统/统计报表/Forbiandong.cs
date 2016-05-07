using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.统计报表
{
    public partial class Forbiandong : Form
    {
        public Forbiandong()
        {
            InitializeComponent();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Forbdgjchaxun ff = new Forbdgjchaxun();
            ff.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Forkcuenmxi ff = new Forkcuenmxi();
            ff.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Fordaying ff = new Fordaying();
            ff.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Forjintuei ff = new Forjintuei();
            ff.ShowDialog();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}