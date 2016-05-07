using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;
using System.Data.SqlClient;

namespace 超市管理系统.系统设置
{
    public partial class F_businessfind : Form
    {
        public delegate void delaa(GH_shang obj);

        public event delaa aaa;

        GH_shangManager gsh = new GH_shangManager();

       // DataView dv;

        public F_businessfind()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void btsure_Click(object sender, EventArgs e)
        {
            GH_shang aa = new GH_shang();
            aa.GH_sName = txtbusnessname.Text;
            aa.GH_sLianxiren = txtbusnesspeople.Text;
            aa.GH_sDianhua = txtbusnessphone.Text;
            aa.GH_sDizhi = txtbusnessaddress.Text;
            aaa(aa);
            this.Close();
        }

        private void F_businessfind_Load(object sender, EventArgs e)
        {

        }

      

        
    }
}