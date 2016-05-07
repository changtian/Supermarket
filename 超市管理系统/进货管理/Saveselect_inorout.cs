using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using System.Data.SqlClient;
using BLL;

namespace 超市管理系统.进货管理
{
    public partial class Saveselect_inorout : Form
    {
        public Saveselect_inorout()
        {
            InitializeComponent();
        }

        private void Saveselect_inorout_Load(object sender, EventArgs e)
        {

        }

        private void btadd1_Click(object sender, EventArgs e)
        {

        }

        private void btupdate1_Click(object sender, EventArgs e)
        {
            //加东西
            Saveselect_updatenum aaa = new Saveselect_updatenum();
            aaa.ShowDialog();
        }

        private void btdelete1_Click(object sender, EventArgs e)
        {

        }

        private void btout1_Click(object sender, EventArgs e)
        {

        }

        private void btprint1_Click(object sender, EventArgs e)
        {

        }

        private void btexit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btadd2_Click(object sender, EventArgs e)
        {

        }

        private void btupdate2_Click(object sender, EventArgs e)
        {
            //里面加了一个“注备”
            Saveselect_updatenum aaa = new Saveselect_updatenum();
            aaa.ShowDialog();
        }

        private void btdelete2_Click(object sender, EventArgs e)
        {

        }

        private void btout2_Click(object sender, EventArgs e)
        {

        }

        private void btprint2_Click(object sender, EventArgs e)
        {

        }

        private void btexit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}