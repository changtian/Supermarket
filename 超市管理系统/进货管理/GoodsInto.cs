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
    public partial class GoodsInto : Form
    {
        public GoodsInto()
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
        GH_shangManager gm = new GH_shangManager();
        DataTable dt = new DataTable();
        private void button2_Click(object sender, EventArgs e)
        {

            int s = Convert.ToInt32(cbock.SelectedValue);
            IntoOldGoods aaa = new IntoOldGoods(s,dt);
            aaa.ShowDialog();
            qiouhe();

        }
        private void qiouhe()
        {
            double he = 0;
            for (int i = 0; i < dgvcg.Rows.Count; i++)
            {
                he = he + Convert.ToDouble(dgvcg.Rows[i].Cells["goodszje"].Value);
            }
            txtmoney.Text = he.ToString();
            txtsmoney.Text = he.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (plgoods.Visible==false)
            {
                plgoods.Visible = true;
            }
            else
            {
                plgoods.Visible = false;
            }
            
        }

        private void GoodsInto_Load(object sender, EventArgs e)
        {
            plgoods.Visible = false;

            dt.Columns.Add("SP_gTiaoma");
            dt.Columns.Add("SP_gName");
            dt.Columns.Add("SP_gDanweiid");
            dt.Columns.Add("SP_gXinghao");
            dt.Columns.Add("goodsys");
            dt.Columns.Add("SP_gJijie");
            dt.Columns.Add("SP_gKucuenx");
            dt.Columns.Add("goodszje");
            dgvcg.DataSource = dt;

            NewMethod();
            NewMethod1();
        }

        private void NewMethod()
        {
            lbdanhao.Text = sm.GetNo("CG");

            cbock.DisplayMember = "CK_tName";
            cbock.ValueMember = "CK_tID";
            cbock.DataSource = cm.select().Tables[0];
        }
        private void NewMethod1()
        {
            cbopeople.DisplayMember = "YG_xName";
            cbopeople.ValueMember = "YG_xId";
            cbopeople.DataSource = ym.chaxun();
            DataSet ds = gm.select("");
            dgvghs.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GoodsIntoPeople aaa = new GoodsIntoPeople();
            aaa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(cbock.SelectedValue);
            IntoNewGoods aaa = new IntoNewGoods(s);
            aaa.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtkhname.Text == "普通供货商")
            {
                panel4.Visible = false;
            }
            else
            {

                panel4.Visible = true;

            }
        }

        private void btsure_Click(object sender, EventArgs e)
        {
            if (dgvghs.CurrentRow.Cells==null)
            {
                return;
            }
            txtkhname.Text = dgvghs.CurrentRow.Cells["Column2"].Value.ToString();
            txtkhname.Tag = dgvghs.CurrentRow.Cells["GH_sId"].Value.ToString();
            lbyf.Text = dgvghs.CurrentRow.Cells["Column6"].Value.ToString();
            lbsf.Text = dgvghs.CurrentRow.Cells["Column6"].Value.ToString();
            lbwf.Text = Convert.ToString((Convert.ToDouble(lbyf.Text)) - Convert.ToDouble(lbsf.Text));
            plgoods.Visible = false;
        }

        private void dgvghs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btsure_Click(null, null);
        }

        private void btsuremain_Click(object sender, EventArgs e)
        {
            if (dgvcg.RowCount < 1)
            {
                MessageBox.Show("单据中没有业务发生不能保存");
                return;
            }
            if (txtkhname.Text=="")
            {
                MessageBox.Show("请选择供货商");
                return;
            }

            
            for (int i = 0; i < dgvcg.Rows.Count; i++)
            {
                try
                {
                DH_tabel dt = new DH_tabel();
                dt.DH_tDanhao = lbdanhao.Text;
                dt.DH_tshangpID = dgvcg.Rows[i].Cells["SP_gTiaoma"].Value.ToString();
                dt.DH_tdzl = 0.0;
                dt.DH_tdanjia = Convert.ToDouble(dgvcg.Rows[i].Cells["SP_gJijie"].Value);
                dt.DH_tShuliang = Convert.ToInt32(dgvcg.Rows[i].Cells["SP_gKucuenx"].Value);
                dt.DH_tType = "采购";
                dt.DH_tZongjine = Convert.ToDouble(dgvcg.Rows[i].Cells["goodszje"].Value);
                dm.ADD(dt);
                SP_goods sg=new SP_goods();
                sg.SP_gTiaoma=dgvcg.Rows[i].Cells["SP_gTiaoma"].Value.ToString();
                sg.SP_gKucuen=Convert.ToInt32(dgvcg.Rows[i].Cells["SP_gKucuenx"].Value);
               
                    spm.updata(sg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }

            }
            int j = 0;
            try
            {
            XS_tbale xt = new XS_tbale();
            xt.XS_tDanhao = lbdanhao.Text;
            xt.XS_tCK = Convert.ToInt32(cbock.SelectedValue);
            xt.XS_tKHname = Convert.ToInt32(txtkhname.Tag);
            xt.XS_tType = "采购";
            xt.XS_tTime = datatime.Value;
            xt.XS_tJinbanren = Convert.ToInt32(cbopeople.SelectedValue);
            xt.XS_tYanshi = txtys.Text;
            xt.DH_tSmoney = Convert.ToDouble(txtsmoney.Text);
            xt.DH_tYmoney = Convert.ToDouble(txtmoney.Text);
            xt.XS_tBeizhu = txtremark.Text;
            
           
                j = xm.add(xt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            if ( j> 0)
            {
                MessageBox.Show("数据保存成功");
                dt.Clear();
                dgvcg.DataSource = dt;
                txtkhname.Text = "";
                txtmoney.Text = "";
                txtsmoney.Text = "";
                txtys.Text = "";
                txtremark.Text = "";
                txtys.Text = "";
               
                txtkhname.Text = "";
                txtremark.Text = "";
                lbdanhao.Text = sm.GetNo("CG");
                plgoods.Visible = false;
            }
            else
            {
                MessageBox.Show("数据保存失败");
            }

        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            int i=0;
            GH_shang gg =null;
            try
            {
                gg= new GH_shang();
                gg.GH_sName = dgvghs.CurrentRow.Cells["Column2"].Value.ToString();
                gg.GH_sLianxiren = dgvghs.CurrentRow.Cells["Column3"].Value.ToString();
                gg.GH_sDizhi = dgvghs.CurrentRow.Cells["Column5"].Value.ToString();
                gg.GH_sMoney = Convert.ToDouble(dgvghs.CurrentRow.Cells["Column6"].Value);
                gg.GH_sDianhua = dgvghs.CurrentRow.Cells["Column4"].Value.ToString();
                gg.GH_sBeizhu = dgvghs.CurrentRow.Cells["GH_sBeizhu"].Value.ToString();
                gg.GH_sMoren = Convert.ToInt32(dgvghs.CurrentRow.Cells["GH_sMoren"].Value);


                 i= Convert.ToInt32(dgvghs.CurrentRow.Cells["GH_sId"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            系统设置.B_updatebusniss ff = new 超市管理系统.系统设置.B_updatebusniss(i, gg);
            ff.ddd += reset;
            ff.ShowDialog();
        }

        private void reset()
        {
            dgvghs.AutoGenerateColumns = false;          //让它不出现多佘的项
            dgvghs.DataSource = gm.Gh_shang().Tables[0];         //它返回的是数据集，是其中的一张表
        }
        private void reset(GH_shang obj)
        {
            dgvghs.AutoGenerateColumns = false;          //让它不出现多佘的项
            dgvghs.DataSource = gm.Gh_shang(obj).Tables[0];         //它返回的是数据集，是其中的一张表
        }

        private void btaddgoods_Click(object sender, EventArgs e)
        {

            系统设置.B_addbusniss ff = new 超市管理系统.系统设置.B_addbusniss();
            ff.aaaa += reset;
            ff.ShowDialog();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dgvcg, lbdanhao.Text);
        }

        private void txtshop_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = gm.select(txtshop.Text);
            dgvghs.DataSource = ds.Tables[0];
        }
    }
}