using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Models;

namespace 超市管理系统.库存管理
{
    public partial class kdiaobachaxun1 : Form
    {
        SP_goodsManager gd = new SP_goodsManager();
        public kdiaobachaxun1()
        {
            InitializeComponent();
        }

        //private void kdiaobachaxun1_Load(object sender, EventArgs e)
        //{
        //    CK_table name = new CK_table();
        //    kdiao di = new kdiao();
        //    name.CK_tName = di.Tag.ToString();
        //    dataGridView2.DataSource = gd.SP_goodsdu(name).Tables[0].ToString();           
        //}
    }
}