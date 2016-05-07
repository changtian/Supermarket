using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Models;

namespace 超市管理系统.销售管理
{
    public partial class FrmaddSP : Form
    {
        public FrmaddSP()
        {
            InitializeComponent();
        }
        string ckid;
        public FrmaddSP(string sckid)
        {
            InitializeComponent();
            ckid = sckid;
        }
        SP_goodsManager sm = new SP_goodsManager();
        tempManager tm = new tempManager();
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvqd.CurrentRow.Cells==null)
            {
                return;
            }
            string id = dgvqd.CurrentRow.Cells[0].Value.ToString();
            FrmADDsp_jiaru ff = new FrmADDsp_jiaru(id);
            ff.ShowDialog();
            add();
        }

        public void add()
        {
            DataSet ds = tm.select();
            dgvsplb.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvsplb.Rows.Count <= 0)
            {
                return;
            }
            int i = Convert.ToInt32(dgvsplb.CurrentRow.Cells["id"].Value);
            FrmADDsp_xgai ff = new FrmADDsp_xgai(i);
            ff.ShowDialog();
        }

        private void FrmaddSP_Load(object sender, EventArgs e)
        {
            SP_goods sg = new SP_goods();
            sg.SP_gTiaoma = "";
            sg.SP_gName = "";
            sg.CK_tID = Convert.ToInt32(ckid);
            DataSet ds = sm.select(sg);

            dgvqd.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SP_goods sg = new SP_goods();
            sg.SP_gTiaoma =txtID.Text ;
            sg.SP_gName = txtID.Text;
            sg.CK_tID = Convert.ToInt32(ckid);
            DataSet ds = sm.select(sg);

            dgvqd.DataSource = ds.Tables[0];
        }
        List<SP_goods> lst = new List<SP_goods>();
        private void dgvqd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvqd.CurrentRow.Cells[0].Value.ToString();
            FrmADDsp_jiaru ff = new FrmADDsp_jiaru(id);
            ff.ShowDialog();
            add();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvsplb.ColumnCount>0)
            {
              DialogResult dr= MessageBox.Show("所选商品还为保存是否保存","系统提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
              if (DialogResult.No==dr)
              {
                  tm.del();
                  this.Close();
              }
          }
          else
          {
              this.Close();
          }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvsplb.Rows.Count <= 0)
            {
                return;
            }
                temp tp = new temp();
                tp.Id = Convert.ToInt32(dgvsplb.CurrentRow.Cells["id"].Value);
                tm.del2(tp);
                add();
            
        }

        private void btnqd_Click(object sender, EventArgs e)
        {
            if (dgvsplb.Rows.Count<=0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("是否保存", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No==dr)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

       

       
    }
}