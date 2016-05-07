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
    public partial class FrmADDsp_xgai : Form
    {
        public FrmADDsp_xgai()
        {
            InitializeComponent();
        }
        int s;
        public FrmADDsp_xgai(int i)
        {
            InitializeComponent();
            this.s = i;
        }
        tempManager tm = new tempManager();
        private void FrmADDsp_xgai_Load(object sender, EventArgs e)
        {
            NewMethod();

        }

        private void NewMethod()
        {
            temp tp = new temp();
            tp.Id = s;
            DataSet ds = tm.select(s);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lbid.Text = dr["spbianhao"].ToString();
                lbname.Text = dr["spname"].ToString();
                lbxh.Text = "";
                lbdw.Text = dr["SPdanwei"].ToString();
                lbsc.Text = "";
                lbys.Text = "";
                lbkc.Text = dr["shuliang"].ToString();
                lbbz.Text = "";
                txtsl.Text = dr["shuliang"].ToString();
                txtsj.Text = dr["danjia"].ToString();
                txtdz.Text = dr["dazhel"].ToString();

                lbzhj.Text = Convert.ToString(Convert.ToDouble(txtsj.Text) * Convert.ToDouble(txtdz.Text));
                lbzj.Text = Convert.ToString(Convert.ToDouble(txtsl.Text) * Convert.ToDouble(lbzhj.Text));
               
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            temp tp = new temp();
            tp.Danjia = Convert.ToDouble(txtsj.Text);
            tp.Dazhel = Convert.ToDouble(txtdz.Text);
            tp.Id = s;
            tp.Shuliang = Convert.ToInt32(txtsl.Text);
            tp.Zhj = Convert.ToDouble(lbzhj.Text);
            tp.Zje = Convert.ToDouble(lbzj.Text);
            if (tm.update(tp)>0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }

      
        }

        private void btnqx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            //lbzhj.Text = Convert.ToString(Convert.ToDouble(txtsj.Text) * Convert.ToDouble(txtdz.Text));
            //lbzj.Text = Convert.ToString(Convert.ToDouble(txtsl.Text) * Convert.ToDouble(lbzhj.Text));
        }

     

        
    }
}