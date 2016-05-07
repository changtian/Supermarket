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
    public partial class B_IntoAllGoods : Form
    {
        public B_IntoAllGoods()
        {
            InitializeComponent();
        }

        SP_goodsManager sm = new SP_goodsManager();
        DH_tabelManager dm = new DH_tabelManager();
        string spid;
        string sname;
        public B_IntoAllGoods(string sid,string name)
        {
            sname = name;
            spid = sid;
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Tag = "w";
            this.Close();
        }

        private void btlist_Click(object sender, EventArgs e)
        {
            B_returnpricelist aaa = new B_returnpricelist();
            aaa.ShowDialog();
        }

        private void B_IntoAllGoods_Load(object sender, EventArgs e)
        {
            if (sname!="")
            {
                this.Text = sname;
                label9.Text = "拆分单价";
                gbgoodsinfo.Text = "商品拆分记录";
            }
            try
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
                //lbmoney.Text = "￥ " + sg.SP_gJijie.ToString();
                txtmoney.Text = sg.SP_gJijie.ToString();

                SP_goods spg = new SP_goods();
                spg.SP_gTiaoma = spid;
                string stype = "采购";
                dgvjl.DataSource = dm.select(spg, stype).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btnsure_Click(object sender, EventArgs e)
        {
            this.Tag = txtnum.Text;


            this.Close();
        }
    }
}