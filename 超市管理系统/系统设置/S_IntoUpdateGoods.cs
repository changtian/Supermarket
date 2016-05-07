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

namespace 超市管理系统.系统设置
{
    public partial class S_IntoUpdateGoods : Form
    {
        SP_goodsManager gm = new SP_goodsManager();
        YsheManager ym = new YsheManager();

        public delegate void delgggg();
        public event delgggg gggggg;

        SP_goods a;
        SP_type b;
        Yshe c;
        public S_IntoUpdateGoods(SP_goods aa, SP_type bb, Yshe cc)
        {
            a = aa;
            b = bb;
            c = cc;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //        if (cbxprice.Checked)
            //{
            //         tabControl1.TabPages.ContainsKey=tabPage
            //}
            cbocell.DisplayMember = "SP_gDanweiid";
            cbocell.ValueMember = "SP_gId";
            cbocell.DataSource = gm.GetAllSP_goods().Tables[0];
            pltype.Visible = false;

            cbocolor.DisplayMember = "Y_Name";
            cbocolor.ValueMember = "Y_id";
            cbocolor.DataSource = ym.GetAllYshe().Tables[0];

            //SP_gId={0},SP_gName={1},SP_tName='{2}',SP_gTiaoma='{3}',SP_gDanweiid='{4}',
            //SP_gXinghao='{5}',Y_Name='{6}',SP_gRiqi='{7}',SP_gZhuangtai={8},
            //SP_gTjjiage={9},SP_gKucuenx={10},SP_gJijie={11},SP_gXijie={12},
            //SP_gZhekou={13},SP_gSchang='{14}',SP_gBeizhi='{15}'
            txttype.Text = b.SP_tName.ToString();
            txtnum.Text = a.SP_gId.ToString();
            txtname.Text = a.SP_gName;
            txtfactory.Text = a.SP_gSchang;
            txtremark.Text = a.SP_gBeizhi;
            txtsavelimit.Text = a.SP_gKucuenx.ToString();
            txtreserve.Text = a.SP_gXinghao;
            txtscores.Text = a.SP_gJifen.ToString();
            txtspcialsprice.Text = a.SP_gTjjiage.ToString();
            txtdiscount.Text = a.SP_gZhekou.ToString();
            txtsize.Text = a.SP_gTiaoma.ToString();
            txtjoinprice.Text = a.SP_gJijie.ToString();
            txtoutprice.Text = a.SP_gXijie.ToString();
            dtpday1.Text = a.SP_gQiantime.ToString();
            dtpday2.Text = a.SP_gHoutime.ToString();
            txtmemberprice.Text = a.SP_gHueiyuan.ToString();
            cbocell.Text = a.SP_gDanweiid.ToString();
            cbocolor.Text = c.Y_Name.ToString();



            if (a.SP_gZengping == 0)     //赠品
            {
                txtscores.Enabled = true;
            }
            else
            {
                txtscores.Enabled = false;
            }

            if (a.SP_gTejia == 1)          //特价
            {
                cbxprice.Checked = true;
            }
            else
            {
                cbxprice.Checked = false;
            }

            if (a.SP_gZhuangtai == 1)
            {
                rbstate.Checked = true;
            }
            else
            {
                rbstop.Checked = false;
            }

            //特价
            if (a.SP_gTejia == 1)
            {
                cbospcialdata.Checked = true;
                dtpday1.Enabled = true;
                dtpday2.Enabled = true;
            }
            else
            {
                cbospcialdata.Checked = false;
                dtpday1.Enabled = false;
                dtpday2.Enabled = false;
            }



            if (cbxday.Checked)
            {
                txtday.ReadOnly = true;
            }
            else
            {
                txtday.Text = a.SP_gRiqi.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            S_IntoNewGoodsSellPrice aaa = new S_IntoNewGoodsSellPrice();
            aaa.ShowDialog();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //保存
        private void btsure_Click(object sender, EventArgs e)
        {
            //特价
            if (cbospcialdata.Checked)
            {
                dtpday1.Enabled = true;
                dtpday2.Enabled = true;
            }
            else
            {
                dtpday1.Enabled = false;
                dtpday2.Enabled = false;
            }


            SP_goods aaa = new SP_goods();
            aaa.SP_gId =Convert.ToInt32(txtnum.Text);
            aaa.SP_gBeizhi = txtremark.Text;
            aaa.SP_gDanweiid = cbocell.Text;
            aaa.SP_gHueiyuan = Convert.ToInt32(txtmemberprice.Text.ToString());
            aaa.SP_gJifen = Convert.ToInt32(txtscores.Text.ToString());
            aaa.SP_gJijie = Convert.ToDouble(txtjoinprice.Text.ToString());
            aaa.SP_gKucuenx = Convert.ToInt32(txtsavelimit.Text.ToString());
            aaa.SP_gName = txtname.Text;
            aaa.SP_gQiantime =dtpday1.Value.ToString();
            aaa.SP_gHoutime =dtpday2.Value.ToString();
            aaa.SP_gRiqi = Convert.ToInt32(txtday.Text.ToString());
            aaa.SP_gSchang = txtfactory.Text;
            if (cbxprice.Checked)
            {
                aaa.SP_gTejia = 1;
            }
            else
            {
                aaa.SP_gTejia = 0;
            }

            aaa.SP_gTiaoma = txtsize.Text;
            aaa.SP_gTjjiage = Convert.ToInt32(txtspcialsprice.Text.ToString());
            aaa.SP_gXijie = Convert.ToDouble(txtoutprice.Text.ToString());
            aaa.SP_gXinghao = txtreserve.Text;
            if (cbxpresent.Checked)
            {
                aaa.SP_gZengping = 1;
            }
            else
            {
                aaa.SP_gZengping = 0;
            }

            aaa.SP_gZhekou = Convert.ToDouble(txtdiscount.Text.ToString());
            if (rbstate.Checked)
            {
                aaa.SP_gZhuangtai = 1;
            }
            else
            {
                aaa.SP_gZhuangtai = 0;
            }

            SP_type bbb = new SP_type();
            bbb.SP_tName = txttype.Text;

            Yshe ccc = new Yshe();
            ccc.Y_Name = cbocolor.Text;

            string fff = gm.ShowUpdateSP_goods(aaa, bbb, ccc);
            if (fff=="修改成功")
            {
                gggggg();
                this.Close();
            }

        }

        private void btexit1_Click(object sender, EventArgs e)
        {

        }

        private void btsure1_Click(object sender, EventArgs e)
        {

        }


    }
}