using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.系统设置
{
    public partial class B_updategoodsInfo : Form
    {
        public B_updategoodsInfo()
        {
            InitializeComponent();
        }

        private void B_updategoodsInfo_Load(object sender, EventArgs e)
        {

        }

        private void btlist_Click(object sender, EventArgs e)
        {
            B_returnpricelist aaa = new B_returnpricelist();
            aaa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}