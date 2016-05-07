using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;

namespace 超市管理系统.销售管理
{
    public partial class FrmADDsp_jiaru : Form
    {
        public FrmADDsp_jiaru()
        {
            InitializeComponent();
        }
        string id;
        public FrmADDsp_jiaru(string bianhao)
        {
            InitializeComponent();
            id = bianhao;
        }
        SP_goodsManager sm = new SP_goodsManager();
        tempManager tm = new tempManager();
        DH_tabelManager dm = new DH_tabelManager();

        private void FrmADDsp_jiaru_Load(object sender, EventArgs e)
        {
            SP_goods sg=new SP_goods();
            sg.SP_gTiaoma=id;
            NewMethod(sg);
            string stype = "销售";
            dgvjl.DataSource = dm.select(sg,stype).Tables[0];

            

        }

        private void NewMethod(SP_goods sg)
        {
            DataSet ds = sm.select2(sg);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lbID.Text = dr["SP_gTiaoma"].ToString();
                lbname.Text = dr["SP_gName"].ToString();
                lbxhao.Text = dr["SP_gXinghao"].ToString();
                lbdw.Text = dr["SP_gDanweiid"].ToString();
                lbcs.Text = dr["SP_gSchang"].ToString();
                lbys.Text = dr["Y_Name"].ToString();
                lbkc.Text = dr["SP_gKucuen"].ToString();
                lbbz.Text = dr["SP_gBeizhi"].ToString();
                txtsj.Text = dr["SP_gXijie"].ToString();
                txtdz.Text = dr["SP_gZhekou"].ToString();

                lbzh.Text = Convert.ToString((Convert.ToDouble(txtsj.Text) * Convert.ToDouble(txtdz.Text)));
                lbzj.Text = Convert.ToString(Convert.ToDouble(txtsl.Text) * Convert.ToDouble(lbzh.Text));

            }
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            lbzj.Text = Convert.ToString(Convert.ToDouble(txtsl.Text) * Convert.ToDouble(lbzh.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp tp = new temp();
            tp.Spbianhao = lbID.Text;
            tp.Spname = lbname.Text;
            tp.SPdanwei = lbdw.Text;
            tp.Danjia =Convert.ToDouble( txtsj.Text);
            tp.Dazhel = Convert.ToDouble(txtdz.Text);
            tp.Zhj =Convert.ToDouble( lbzh.Text);
            tp.Shuliang = Convert.ToInt32(txtsl.Text);
            tp.Zje = Convert.ToDouble(lbzj.Text);
            tp.Shuliang = Convert.ToInt32(txtsl.Text);
            tm.add(tp);
            this.Close();
        }
    }
}