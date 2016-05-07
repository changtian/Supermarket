using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.系统设置
{
    public partial class S_IntoNewGoods : Form
    {
        public S_IntoNewGoods()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            S_IntoNewGoodsSellPrice aaa = new S_IntoNewGoodsSellPrice();
            aaa.ShowDialog();
        }

        private void btexit1_Click(object sender, EventArgs e)
        {
            pltype.Visible = false;
        }

        private void IntoNewGoods_Load(object sender, EventArgs e)
        {
            pltype.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pltype.Visible = true;
        }



        private void IntoNewGoods_Load_1(object sender, EventArgs e)
        {
            txtday.Visible = false;
            if (cbxday.Checked)
            {
                txtday.Visible = true;
            }
            pltype.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pltype.Visible = true;
        }

        private void pltype_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
  
       
    }
}