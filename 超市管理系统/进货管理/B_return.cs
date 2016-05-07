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
    public partial class B_return : Form
    {
        public B_return()
        {
            InitializeComponent();
        }
        string sname;

        public B_return(string name)
        {
            
            sname = name;
            InitializeComponent();
        }
        DataTable dte = null;
        string ghs;
        string ghsid;
        public B_return(DataTable dt,string name,string id)
        {
            ghs = name;
            dte = dt;
            ghsid = id;
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
        private void B_return_Load(object sender, EventArgs e)
        {
            btupdate.Visible = false;
            btdeletegoods.Visible = false;
            plfind.Visible = false;
            plbusiness.Visible = false;
            NewMethod();
            NewMethod1();
            try
            {
                if (sname != null)
                {
                    label1.Text = sname;
                }
                else
                {
                    label1.Text = "采购退货";
                }
                if (ghs != null)
                {
                    txtkhname.Text = ghs;
                    txtkhname.Tag = ghsid;
                }


                dt.Columns.Add("SP_gTiaoma");
                dt.Columns.Add("SP_gName");
                dt.Columns.Add("SP_gDanweiid");
                dt.Columns.Add("SP_gXinghao");
                dt.Columns.Add("goodsys");
                dt.Columns.Add("SP_gJijie");
                dt.Columns.Add("SP_gKucuenx");
                dt.Columns.Add("goodszje");


                if (ghs != null)
                {
                    for (int i = 0; i < dte.Rows.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dr["SP_gTiaoma"] = dte.Rows[i]["DH_tshangpID"].ToString();
                        dr["SP_gName"] = dte.Rows[i]["SP_gName"].ToString();
                        dr["SP_gDanweiid"] = dte.Rows[i]["SP_gDanweiid"].ToString();
                        dr["SP_gXinghao"] = dte.Rows[i]["SP_gXinghao"].ToString();
                        dr["goodsys"] = dte.Rows[i]["Y_Name"].ToString();
                        dr["SP_gJijie"] = dte.Rows[i]["DH_tdanjia"].ToString();
                        dr["SP_gKucuenx"] = dte.Rows[i]["DH_tShuliang"].ToString();
                        dr["goodszje"] = dte.Rows[i]["DH_tZongjine"].ToString();

                        dt.Rows.Add(dr);
                    }
                    if (dt.Rows.Count >= 0)
                    {
                        btupdate.Visible = true;
                        btdeletegoods.Visible = true;

                    }

                }
                dgvcg.DataSource = dt;
                double sum = 0;
                for (int i = 0; i < dgvcg.Rows.Count; i++)
                {
                    sum = sum + Convert.ToDouble(dgvcg.CurrentRow.Cells["goodszje"].Value);

                }
                txtmoney.Text = sum.ToString();
                txtsmoney.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            

        }
        private void NewMethod1()
        {
            if (sname!="")
            {
                lbdanhao.Text = sm.GetNo("KT");
                label4.Text = "客户名称";
            }
            else
            {
                lbdanhao.Text = sm.GetNo("CT");
            }
            

            cbock.DisplayMember = "CK_tName";
            cbock.ValueMember = "CK_tID";
            cbock.DataSource = cm.select().Tables[0];
        }

        private void NewMethod()
        {
            cbopeople.DisplayMember = "YG_xName";
            cbopeople.ValueMember = "YG_xId";
            cbopeople.DataSource = ym.chaxun();
            DataSet ds = gm.Gh_shang();
            delkh.DataSource = ds.Tables[0];
        }

      

        private void button6_Click(object sender, EventArgs e)
        {
            B_cellInfo aaa = new B_cellInfo();
            aaa.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            C_ZW aaa = new C_ZW();
            aaa.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            D_DJCX aaa = new D_DJCX();
            aaa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(cbock.SelectedValue);
            B_IntoReturngoods aaa = new B_IntoReturngoods(s,dt,"");
            aaa.ShowDialog();
            double sum = 0;
            for (int i = 0; i < dgvcg.Rows.Count; i++)
            {
                sum = sum +Convert.ToDouble( dgvcg.CurrentRow.Cells["goodszje"].Value);
              
            }
            txtmoney.Text = sum.ToString();
            txtsmoney.Text = sum.ToString();
            if (dt.Rows.Count>=0)
            {
                btupdate.Visible = true;
                btdeletegoods.Visible = true;
            }

        }

        private void btupdate_Click(object sender, EventArgs e)
        {

            if (dgvcg.Rows.Count <= 0)
            {
                return;
            }
            int kc = Convert.ToInt32(dgvcg.CurrentRow.Cells["SP_gKucuenx"].Value.ToString());
            string s = dgvcg.CurrentRow.Cells["SP_gTiaoma"].Value.ToString();
            double q = Convert.ToDouble(dgvcg.CurrentRow.Cells["SP_gJijie"].Value.ToString());
            B_updategoodsInfo ff = new B_updategoodsInfo(s, kc, q);
            ff.ShowDialog();
            if (ff.Tag.ToString() == "")
            {
                return;
            }

            for (int i = 0; i < dgvcg.Rows.Count; i++)
            {
                if (dgvcg.Rows[i].Cells["SP_gTiaoma"].Value.ToString() == dgvcg.CurrentRow.Cells["SP_gTiaoma"].Value.ToString())
                {
                    dt.Rows[i]["SP_gKucuenx"] = ff.Tag;
                    dt.Rows[i]["goodszje"] = Convert.ToDouble(ff.Tag) * Convert.ToDouble(dgvcg.Rows[i].Cells["SP_gJijie"].Value);
                    return;
                }

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            B_returngoodsfind aaa = new B_returngoodsfind();
            aaa.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            plfind.Visible = false;
        }

        private void btfind_Click(object sender, EventArgs e)
        {
            plfind.Visible = true;
        }

        private void btreturnupdate_Click(object sender, EventArgs e)
        {
            GH_shang gg = new GH_shang();
            gg.GH_sName = delkh.CurrentRow.Cells["KH_xName"].Value.ToString();
            gg.GH_sLianxiren = delkh.CurrentRow.Cells["KH_xDianhua"].Value.ToString();
            gg.GH_sDizhi = delkh.CurrentRow.Cells["KH_xDizhi"].Value.ToString();
            gg.GH_sMoney = Convert.ToDouble(delkh.CurrentRow.Cells["KH_xMoney"].Value);
            gg.GH_sDianhua = delkh.CurrentRow.Cells["KH_xDizhi"].Value.ToString();
            gg.GH_sBeizhu = delkh.CurrentRow.Cells["GH_sBeizhu"].Value.ToString();
            gg.GH_sMoren = Convert.ToInt32(delkh.CurrentRow.Cells["GH_sMoren"].Value);


            int i = Convert.ToInt32(delkh.CurrentRow.Cells["GH_sId"].Value);
            系统设置.B_updatebusniss ff = new 超市管理系统.系统设置.B_updatebusniss(i,gg);
            ff.ddd += reset; 
            ff.ShowDialog();

        }

        private void reset()
        {
            delkh.AutoGenerateColumns = false;          //让它不出现多佘的项
            delkh.DataSource = gm.Gh_shang().Tables[0];         //它返回的是数据集，是其中的一张表
        }
        private void reset(GH_shang obj)
        {
            delkh.AutoGenerateColumns = false;          //让它不出现多佘的项
            delkh.DataSource = gm.Gh_shang(obj).Tables[0];         //它返回的是数据集，是其中的一张表
        }

        private void button14_Click(object sender, EventArgs e)
        {
            系统设置.B_addbusniss ff = new 超市管理系统.系统设置.B_addbusniss();
            ff.aaaa += reset;
            ff.ShowDialog();

        }
        int i;
        private void btsure_Click(object sender, EventArgs e)
        {

            txtkhname.Text = delkh.CurrentRow.Cells[1].Value.ToString();
            txtkhname.Tag = delkh.CurrentRow.Cells[0].Value.ToString();
            lbys.Text = delkh.CurrentRow.Cells["KH_xMoney"].Value.ToString();
            i = Convert.ToInt32(delkh.CurrentRow.Cells["GH_sId"].Value);
            lbss.Text = lbys.Text;
            lbqk.Text = Convert.ToString(Convert.ToDouble(lbys.Text) - Convert.ToDouble(lbss.Text));
            plfind.Visible = false;
        }

        private void delkh_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btsure_Click(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvcg.RowCount < 1)
            {
                MessageBox.Show("单据中没有业务发生不能保存");
                return;
            }
            int j = 0;

            try
            {
                for (int i = 0; i < dgvcg.Rows.Count; i++)
                {
                    DH_tabel dt = new DH_tabel();
                    dt.DH_tDanhao = lbdanhao.Text;
                    dt.DH_tshangpID = dgvcg.Rows[i].Cells["SP_gTiaoma"].Value.ToString();
                    dt.DH_tdzl = 0.0;
                    dt.DH_tdanjia = Convert.ToDouble(dgvcg.Rows[i].Cells["SP_gJijie"].Value);
                    dt.DH_tShuliang = Convert.ToInt32(dgvcg.Rows[i].Cells["SP_gKucuenx"].Value);
                    dt.DH_tType = "退货";
                    dt.DH_tZongjine = Convert.ToDouble(dgvcg.Rows[i].Cells["goodszje"].Value);
                    dm.ADD(dt);
                    SP_goods sg = new SP_goods();
                    sg.SP_gTiaoma = dgvcg.Rows[i].Cells["SP_gTiaoma"].Value.ToString();
                    sg.SP_gKucuen = Convert.ToInt32(dgvcg.Rows[i].Cells["SP_gKucuenx"].Value);
                }
                XS_tbale xt = new XS_tbale();
                xt.XS_tDanhao = lbdanhao.Text;
                xt.XS_tCK = Convert.ToInt32(cbock.SelectedValue);
                xt.XS_tKHname = Convert.ToInt32(txtkhname.Tag);
                xt.XS_tType = "退货";
                xt.XS_tTime = datatime.Value;
                xt.XS_tJinbanren = Convert.ToInt32(cbopeople.SelectedValue);
                xt.XS_tYanshi = "";
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
                lbdanhao.Text = sm.GetNo("TH");
                txtremark.Text = "";

                txtkhname.Tag = 4;
                txtkhname.Text = "普通客户";
                txtremark.Text = "";
            }
            else
            {
                MessageBox.Show("数据保存失败");
            }
        }

        private void txtbusniss_TextChanged(object sender, EventArgs e)
        {

            DataSet ds = km.khxxi(txtbusniss.Text);
            delkh.DataSource = ds.Tables[0];
        }

        private void txtkhname_TextChanged(object sender, EventArgs e)
        {
            if (txtkhname.Text=="普通客户"||txtkhname.Text=="")
            {
                plbusiness.Visible = false;
            }
            else
            {
                plbusiness.Visible = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {

                dgvtd.DataSource = dm.tueiduan(textBox3.Text, dttime1.Value.ToString(), dttime2.Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dgvtd, "退单记录");
        }

        private void dgvtd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvtd.Rows.Count<=0)
            {
                return;
            }
            lbname.Text = dgvtd.CurrentRow.Cells["XS_tDanhao"].Value.ToString();
            dgvxx.DataSource = dm.tdxx(dgvtd.CurrentRow.Cells["XS_tDanhao"].Value.ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dgvtd.DataSource = dm.tueiduan(textBox3.Text,dttime1.ToString(),dttime2.ToString());
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btdeletegoods_Click(object sender, EventArgs e)
        {
            if (dgvcg.CurrentRow==null)
            {
                return;
            }
            dgvcg.Rows.RemoveAt(dgvcg.CurrentRow.Index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            进货管理.Y_stock ff = new 超市管理系统.进货管理.Y_stock();

            ff.ShowDialog();
        }

   
    }
}