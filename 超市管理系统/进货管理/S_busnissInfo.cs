using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.进货管理
{
    public partial class S_busnissInfo : Form
    {
        public S_busnissInfo()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            B_addbusniss aaa = new B_addbusniss();
            aaa.ShowDialog();
        }

        private void btupdate_Click_1(object sender, EventArgs e)
        {
            B_updatebusniss aaa = new B_updatebusniss();
            aaa.ShowDialog();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btfind_Click(object sender, EventArgs e)
        {
            S_businessfind aaa = new S_businessfind();
            aaa.ShowDialog();
        }
    }
}