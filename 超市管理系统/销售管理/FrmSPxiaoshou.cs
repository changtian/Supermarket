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
    public partial class FrmSPxiaoshou : Form
    {
        public FrmSPxiaoshou()
        {
            InitializeComponent();
        }
        YG_xinxiManager ym = new YG_xinxiManager();
        KH_xinxiManager km = new KH_xinxiManager();
        CommonManager sm = new CommonManager();
        CK_tableManager cm = new CK_tableManager();
        XS_tbaleManager xm = new XS_tbaleManager();
        tempManager tm = new tempManager();
        DH_tabelManager dm = new DH_tabelManager();
        SP_goodsManager spm = new SP_goodsManager();
       
        
        private void FrmSPxiaoshou_Load(object sender, EventArgs e)
        {
            plgoods.Visible = false;
            palzhangmu.Visible = false;
           
            NewMethod();
            NewMethod1();
            NewMethod2();
            

        }

        private void NewMethod1()
        {
            lbdanhao.Text = sm.GetNo("XS");

            cbock.DisplayMember = "CK_tName";
            cbock.ValueMember = "CK_tID";
            cbock.DataSource = cm.select().Tables[0];
        }

        private void NewMethod()
        {
            cbopeople.DisplayMember = "YG_xName";
            cbopeople.ValueMember = "YG_xId";
            cbopeople.DataSource = ym.chaxun();
            DataSet ds = km.khxxi("");
            delkh.DataSource = ds.Tables[0];
        }

        private void btfind_Click(object sender, EventArgs e)
        {
            if (plgoods.Visible==false)
            {
                plgoods.Visible = true;
            }
            else
            {
                plgoods.Visible = false;
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
           plgoods.Visible = false;
        }

        private void btaddgoods_Click(object sender, EventArgs e)
        {
            FrmADDkehu ff = new FrmADDkehu();
            ff.ShowDialog();
            NewMethod();
        }

        private void btexitmain_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("单据还未保存是否退出?","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.No==dr)
            {
                return;
            }
            tm.del();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string ckid = cbock.SelectedValue.ToString();
            FrmaddSP fg = new FrmaddSP(ckid);
            fg.ShowDialog();
            dgvxiaoshou.DataSource = tm.duqu().Tables[0];
            txtmoney.Text = tm.zongjia().ToString();
            NewMethod2();

        }
        

        private void btupdate_Click(object sender, EventArgs e)
        {
            string i = delkh.CurrentRow.Cells[0].Value.ToString();
            FrmADDkehu ff = new FrmADDkehu(i);
            ff.ShowDialog();
            NewMethod();
        }
        int i;
        private void btsure_Click(object sender, EventArgs e)
        {
            txtkhname.Text = delkh.CurrentRow.Cells[1].Value.ToString();
            txtkhname.Tag = delkh.CurrentRow.Cells[0].Value.ToString();
            lbys.Text = delkh.CurrentRow.Cells["Column16"].Value.ToString();
            i =Convert.ToInt32( delkh.CurrentRow.Cells["Column1"].Value);
            lbss.Text = lbys.Text;
            lbqk.Text = Convert.ToString(Convert.ToDouble(lbys.Text) - Convert.ToDouble(lbss.Text));
            plgoods.Visible = false;
        }

        private void txtkhname_TextChanged(object sender, EventArgs e)
        {
            if (txtkhname.Text == "普通供货商" || txtkhname.Text == "")
            {
                palzhangmu.Visible = false;
            }
            else
            {

                palzhangmu.Visible = true;
                
            }
        }

        private void btndc_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dgvxiaoshou, "销售清单");
        }

        private void btsuremain_Click(object sender, EventArgs e)
        {
            if (dgvxiaoshou.RowCount < 1)
            {
                MessageBox.Show("单据中没有业务发生不能保存");
                return;
            }


            try
            {
                for (int i = 0; i < dgvxiaoshou.Rows.Count; i++)
                {
                    DH_tabel dt = new DH_tabel();
                    dt.DH_tDanhao = lbdanhao.Text;
                    dt.DH_tshangpID = dgvxiaoshou.Rows[i].Cells["Column6"].Value.ToString();
                    dt.DH_tdzl = Convert.ToDouble(dgvxiaoshou.Rows[i].Cells["Column12"].Value);
                    dt.DH_tdanjia = Convert.ToDouble(dgvxiaoshou.Rows[i].Cells["Column11"].Value);
                    dt.DH_tShuliang = Convert.ToInt32(dgvxiaoshou.Rows[i].Cells["Column14"].Value);
                    dt.DH_tType = "销售";
                    dt.DH_tZongjine = Convert.ToDouble(dgvxiaoshou.Rows[i].Cells["Column15"].Value);
                    dm.ADD(dt);
                    SP_goods sg = new SP_goods();
                    sg.SP_gTiaoma = dgvxiaoshou.Rows[i].Cells["Column6"].Value.ToString();
                    sg.SP_gKucuen = Convert.ToInt32(dgvxiaoshou.Rows[i].Cells["Column14"].Value);
                    spm.updatejian(sg);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
              
          
          tm.del();

          int j = 0;

          try
          {
              XS_tbale xt = new XS_tbale();
              xt.XS_tDanhao = lbdanhao.Text;
              xt.XS_tCK = Convert.ToInt32(cbock.SelectedValue);
              xt.XS_tKHname = Convert.ToInt32(txtkhname.Tag);
              xt.XS_tType = "销售";
              xt.XS_tTime = datatime.Value;
              xt.XS_tJinbanren = Convert.ToInt32(cbopeople.SelectedValue);
              xt.XS_tYanshi = txtys.Text;
              xt.DH_tSmoney = Convert.ToDouble(txtsf.Text);
              xt.DH_tYmoney = Convert.ToDouble(txtmoney.Text);
              xt.XS_tBeizhu = txtremark.Text;
              j = xm.add(xt);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
              
          }
          if (j>0)
          {
              MessageBox.Show("数据保存成功");
              tm.del();
              dgvxiaoshou.DataSource = tm.duqu().Tables[0];
              txtkhname.Text = "";
              txtmoney.Text = "";
              txtsf.Text = "";
              txtys.Text = "";
              txtremark.Text = "";
              lbys.Text = "";
              lbss.Text = "";
              lbqk.Text = "普通客户";
          }
          else
          {
              MessageBox.Show("数据保存失败");
          }
          
         
          NewMethod1();

        }

        private void btnxg_Click(object sender, EventArgs e)
        {
            
            FrmADDsp_xgai ff = new FrmADDsp_xgai(Convert.ToInt32(dgvxiaoshou.CurrentRow.Cells["Column9"].Value));
            ff.ShowDialog();
            dgvxiaoshou.DataSource = tm.duqu().Tables[0];

        }

        private void NewMethod2()
        {
            if (dgvxiaoshou.CurrentRow == null)
            {
                btnxg.Visible = false;
                btnsc.Visible= false;
                btndc.Visible = false;
                
            }
            else
            {
                btnxg.Visible = true;
                btnsc.Visible = true;
                btndc.Visible = true;
            }
        }

        private void btnsc_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否删除该条信息!","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.No==dr)
            {
                return;
            }
            temp tp = new temp();
            tp.Id =Convert.ToInt32( dgvxiaoshou.CurrentRow.Cells["Column9"].Value);
            tm.del2(tp);
            dgvxiaoshou.DataSource = tm.duqu().Tables[0];
        }

        private void delkh_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btsure_Click(null, null);
        }

        private void txtmoney_TextChanged(object sender, EventArgs e)
        {
            txtsf.Text = txtmoney.Text;
        }

        private void dgvxiaoshou_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnxg_Click(null, null);
        }

      

      
    }
}