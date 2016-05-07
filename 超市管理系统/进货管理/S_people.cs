using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.进货管理
{
    public partial class S_people : Form
    {
        public S_people()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S_peopleType aaa = new S_peopleType();
            aaa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            S_peopleUpdate aaa = new S_peopleUpdate();
            aaa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}