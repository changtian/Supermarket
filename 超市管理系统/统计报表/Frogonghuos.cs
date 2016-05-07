using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;

namespace 超市管理系统.统计报表
{
    public partial class Frogonghuos : Form
    {
        public Frogonghuos()
        {
            InitializeComponent();
        }
        GH_shangManager gm = new GH_shangManager();
        DataView dv = new DataView();
        DataView dvdj = new DataView();
        DataView dvsp = new DataView();
        DataView dvls = new DataView();
        DataView dvxs = new DataView();
        
        DH_tabelManager dm = new DH_tabelManager();
        XS_tbaleManager xm = new XS_tbaleManager();

        private void Frogonghuos_Load(object sender, EventArgs e)
        {
            palsuoyou.Visible = false;
            palgonghuo.Visible = false;
            palxiaoshou.Visible = false;
            radioButton4.Checked = true;

           
            dgvsyghs.AutoGenerateColumns = false;
            dgvsyghs.DataSource = gm.Gh_shang().Tables[0];
            dgvqk.AutoGenerateColumns = false;
            dgvqk.DataSource = gm.Gh_shang().Tables[0];
            dgvxs.AutoGenerateColumns = false;
            dgvxs.DataSource = gm.Gh_shang().Tables[0];
            dvsp = xm.select().DefaultView;
            dv = dm.GHSsuoyou().DefaultView;
            dvls = xm.selectls().DefaultView;
            dvxs = xm.xiaoshou().DefaultView;
            
            dataGridView2.AutoGenerateColumns = false;

            tabmingxi.TabPages.Remove(tapxiaoshou);
            
        }
        #region 窗体退出
        
        
        private void topbtntueichu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolbtnmxtc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region 窗体跳转
        
        
        private void topbtnfuk_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow==null)
            {
                MessageBox.Show("请选择供货商","系统提示");
                return;
            }
            double qiankuan = 0;
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["Column1"].Value.ToString() == dataGridView1.CurrentRow.Cells["Column1"].Value.ToString())
                    {
                        qiankuan = qiankuan + Convert.ToDouble(dataGridView1.Rows[i].Cells["Column7"].Value);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            string ghname = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
            string ghsid = dataGridView1.CurrentRow.Cells["GH_sId"].Value.ToString();
            Frofukuan ff = new Frofukuan(qiankuan,ghname,ghsid);
            ff.ShowDialog();
            dv = dm.GHSsuoyou().DefaultView;
            if (txtgysname.Text != "全部供货商" && txtgysname.Text.Trim() != "")
            {
                dv.RowFilter = string.Format(" GH_sName='{0}'", txtgysname.Text);
            }

            dataGridView1.DataSource = dv;
           


        }

        private void topbtnshanc_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选择供货商", "系统提示");
                return;
            }
            string ghname = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
            string danhao = dataGridView1.CurrentRow.Cells["Column3"].Value.ToString();
            string yfu = dataGridView1.CurrentRow.Cells["Column5"].Value.ToString();
            string sfu = dataGridView1.CurrentRow.Cells["Column6"].Value.ToString();
            ForDelete ff = new ForDelete(ghname,danhao,sfu,yfu);
            ff.ShowDialog();
            dv = dm.GHSsuoyou().DefaultView;
            if (txtgysname.Text != "全部供货商" && txtgysname.Text.Trim() != "")
            {
                dv.RowFilter = string.Format(" GH_sName='{0}'", txtgysname.Text);
            }

            dataGridView1.DataSource = dv;

        }
       
        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            Forghxs ff = new Forghxs(1, dataxsqtime.Text,dataxshtime.Text,txtxsghname.Text);
            ff.Show();

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Forghxs ff = new Forghxs(0, "", "", txtghname.Text);
            ff.Show();
        }
        #endregion


        #region 供货商查询
        
        
        private void btnname_Click(object sender, EventArgs e)
        {
            if (palsuoyou.Visible==false)
            {
                palsuoyou.Visible = true;
            }
            else
            {
                palsuoyou.Visible = false;
            }
        }

        private void btntueichu_Click(object sender, EventArgs e)
        {
            palsuoyou.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (palgonghuo.Visible == false)
            {
                palgonghuo.Visible = true;
            }
            else
            {
                palgonghuo.Visible = false;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            palgonghuo.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (palxiaoshou.Visible == false)
            {
                palxiaoshou.Visible = true;
            }
            else
            {
                palxiaoshou.Visible = false;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            palxiaoshou.Visible = false;
        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                palsuoyou.Visible = false;
                txtgysname.Text = "全部供货商";
                
            }
        }

        private void btnquding_Click(object sender, EventArgs e)
        {
            txtgysname.Text = dgvsyghs.CurrentRow.Cells[1].Value.ToString();
            txtgysname.Tag = dgvsyghs.CurrentRow.Cells[0].Value.ToString();
            palsuoyou.Visible = false;
        }

        private void txttiaojian_TextChanged(object sender, EventArgs e)
        {
            GH_shang gs = new GH_shang();
            gs.GH_sName = txttiaojian.Text;
            gs.GH_sId = txttiaojian.Text;
            dgvsyghs.AutoGenerateColumns = false;
           dgvsyghs.DataSource= gm.Gh_shang(gs).Tables[0];
        }

        private void btnchax_Click(object sender, EventArgs e)
        {
            if (txtgysname.Text != "全部供货商" && txtgysname.Text.Trim()!="")
            {
                dv.RowFilter = string.Format(" GH_sName='{0}'", txtgysname.Text);
            }
            
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow==null)
            {
                return;
            }
            label5.Text = dataGridView1.CurrentRow.Cells["Column3"].Value.ToString();

            try
            {

                dataGridView2.DataSource = dm.djxx(dataGridView1.CurrentRow.Cells["Column3"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GH_shang gs = new GH_shang();
                gs.GH_sName = txttiaojian.Text;
                gs.GH_sId = txttiaojian.Text;
                dgvqk.AutoGenerateColumns = false;
                dgvqk.DataSource = gm.Gh_shang(gs).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
            GH_shang gs = new GH_shang();
            gs.GH_sName = txttiaojian.Text;
            gs.GH_sId = txttiaojian.Text;
            dgvxs.AutoGenerateColumns = false;
            dgvxs.DataSource = gm.Gh_shang(gs).Tables[0];
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);

        }
        }


        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
            txtghname.Text = dgvqk.CurrentRow.Cells[1].Value.ToString();
            txtghname.Tag = dgvqk.CurrentRow.Cells[0].Value.ToString();
            palgonghuo.Visible = false;
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                txtxsghname.Text = dgvxs.CurrentRow.Cells[1].Value.ToString();
                txtxsghname.Tag = dgvxs.CurrentRow.Cells[0].Value.ToString();
                palxiaoshou.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                palgonghuo.Visible = false;
                txtghname.Text = "全部供货商";

            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                palxiaoshou.Visible = false;
                txtxsghname.Text = "全部供货商";

            }
        }

        private void topbtntueih_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells["Column4"].Value.ToString() == "采购")
                {
                    DataTable dgv = (DataTable)dataGridView2.DataSource;
                    string ghsname = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
                    string id = dataGridView1.CurrentRow.Cells["Column10"].Value.ToString();
                    进货管理.B_return ff = new 超市管理系统.进货管理.B_return(dgv, ghsname, id);
                    ff.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }              

        private void topbtndaoru_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dataGridView1, "账务往来单据");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtghname.Text.Trim() != "")
            {
                dvsp.RowFilter = string.Format(" SP_gName='{0}'", txtghname.Text);
                dvls.RowFilter = string.Format(" SP_gName='{0}'", txtghname.Text);
            }
            dataGridView4.DataSource=dvsp;
            dataGridView3.DataSource = dvls;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked==true)
            {
                palzh.Visible = true;
                palls.Visible = false;
            }
            else
            {
                palzh.Visible =false ;
                palls.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = dvxs;
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dataGridView5, "商品销售情况");
        }

        private void dgvxs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtxsghname.Text = dgvxs.CurrentRow.Cells[1].Value.ToString();
            txtxsghname.Tag = dgvxs.CurrentRow.Cells[0].Value.ToString();
            palxiaoshou.Visible = false;
        }

        private void dgvsyghs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtgysname.Text = dgvsyghs.CurrentRow.Cells[1].Value.ToString();
            txtgysname.Tag = dgvsyghs.CurrentRow.Cells[0].Value.ToString();
            palsuoyou.Visible = false;
        }

    }
}