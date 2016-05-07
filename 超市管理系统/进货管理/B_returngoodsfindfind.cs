using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.进货管理
{
    public partial class B_returngoodsfindfind : Form
    {
        public B_returngoodsfindfind()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btreturnupdate_Click(object sender, EventArgs e)
        {
            B_updatebusniss aaa = new B_updatebusniss();
            aaa.ShowDialog();
        }

        private void btsure_Click(object sender, EventArgs e)
        {

        }

    }
}