using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.系统设置
{
    public partial class S_IntoNewGoodsSellPrice : Form
    {
        public S_IntoNewGoodsSellPrice()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S_IntoNewGoodsSellPriceUpdate aaa = new S_IntoNewGoodsSellPriceUpdate();
            aaa.ShowDialog();
        }

        private void S_IntoNewGoodsSellPrice_Load(object sender, EventArgs e)
        {

        }
    }
}