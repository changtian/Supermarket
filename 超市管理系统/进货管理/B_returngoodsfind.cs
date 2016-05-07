using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;

namespace 超市管理系统.进货管理
{
    public partial class B_returngoodsfind : Form
    {
        public B_returngoodsfind()
        {
            InitializeComponent();
        }
        KH_xinxiManager km = new KH_xinxiManager();
        private void btfind_Click(object sender, EventArgs e)
        {
            B_returngoodsfindfind aaa = new B_returngoodsfindfind();
            aaa.ShowDialog();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void B_returngoodsfind_Load(object sender, EventArgs e)
        {
            DataSet ds = km.khxxi("");
            delkh.DataSource = ds.Tables[0];
        }

        


     
    }
}