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

namespace 超市管理系统.进货管理
{
    public partial class Saveselect_savelist : Form
    {
        SP_goodsManager gm = new SP_goodsManager();

        string aa;
        string bb;
        string cc;
        public Saveselect_savelist(string a,string b,string c)
        {
            aa= a;
            bb = b;
            cc = c;
            InitializeComponent();
        }

        private void Saveselect_savelist_Load(object sender, EventArgs e)
        {
            lbname.Text = "";
            lbsavenum.Text = "";
            lbshowprice.Text = "";
            lbname.Text = aa;
            lbsavenum.Text = bb+"元";
            lbshowprice.Text = cc + "元";


         
        }

        //填充
        private void btfind_Click(object sender, EventArgs e)
        {
            //传４什参数（商品名称，时间1，时间2，仓库）
            //dataGridView1.DataSource=g       //填充
        }

        private void btselectout_Click(object sender, EventArgs e)
        {
            //传入一个参，写3个SQL语句就可以了
        }
    }
}