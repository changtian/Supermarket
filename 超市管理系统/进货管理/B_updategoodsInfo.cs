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
    public partial class B_updategoodsInfo : Form
    {
        public B_updategoodsInfo()
        {
            InitializeComponent();
        }
        string spid;
        int kc;
        double money;
        public B_updategoodsInfo(string s,int shu,double qian)
        {
            money = qian;
            kc = shu;
            spid=s;
            InitializeComponent();
        }
        SP_goodsManager sm = new SP_goodsManager();
        private void B_updategoodsInfo_Load(object sender, EventArgs e)
        {
            SP_goods sg = sm.selectjiaru(spid);
            lbnum.Text = sg.SP_gTiaoma;
            lbname.Text = sg.SP_gName;
            lbtype.Text = sg.SP_gXinghao;
            lbcell.Text = sg.SP_gDanweiid;
            lbfactory.Text = sg.SP_gSchang;
            lbcolor.Text = "";
            lbreserve.Text = sg.SP_gKucuen.ToString();
            remark.Text = sg.SP_gBeizhi;
            txtnum.Text = kc.ToString();
            //lbmoney.Text = "￥ " + sg.SP_gJijie.ToString();
            lbmoney.Text = money.ToString();
        }

        private void btlist_Click(object sender, EventArgs e)
        {
            B_returnpricelist aaa = new B_returnpricelist();
            aaa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Tag = txtnum.Text;
            this.Close();
        }
    }
}