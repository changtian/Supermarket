using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.进货管理
{
    public partial class GoodsIntoPeople : Form
    {
        public GoodsIntoPeople()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btfind_Click(object sender, EventArgs e)
        {

        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            Gpeopleupdate AAA = new Gpeopleupdate();
            AAA.ShowDialog();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            Gpeopleadd aaa = new Gpeopleadd();
            aaa.ShowDialog();
        }

     

     
    }
}