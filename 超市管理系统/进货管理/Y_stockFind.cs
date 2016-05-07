using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.进货管理
{
    public partial class Y_stockFind : Form
    {

        string a;
        string b;
        public Y_stockFind(string aa,string bb)
        {
            a = aa;
            b = bb;
            InitializeComponent();
        }

        private void txtfind_Click(object sender, EventArgs e)
        {
            Y_stockfindfind aaa = new Y_stockfindfind();
            aaa.ShowDialog();
            txtbusiness.Text = aaa.Tag.ToString();
        }

        private void Y_stockFind_Load(object sender, EventArgs e)
        {
            cbsavename.SelectedIndex = 0;
            cbemployee.SelectedIndex = 0;
            ddtpstartime.Text = a;
            dtpendtime.Text = b;

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            this.Tag = txtbusiness.Text;
            this.Close();
        }

      
    }
}