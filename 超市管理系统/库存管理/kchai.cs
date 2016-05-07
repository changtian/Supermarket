using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;
using 超市管理系统.进货管理;

namespace 超市管理系统.库存管理
{
    public partial class kchai : Form
    {
        public kchai()
        {
            InitializeComponent();
        }
        CK_tableManager cm = new CK_tableManager();
        YG_xinxiManager ym = new YG_xinxiManager();
        CommonManager cmm = new CommonManager();
        SP_goodsManager sm = new SP_goodsManager();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DH_tabelManager dm = new DH_tabelManager();
        CG_tableManager cgm = new CG_tableManager();
        CG_tableManager gm = new CG_tableManager();
        
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kchai_Load(object sender, EventArgs e)
        {
            chaifen();

            kuenbang();

        }

        private void kuenbang()
        {
            palcsp.Visible = false;


            dt.Columns.Add("SP_gTiaoma");
            dt.Columns.Add("SP_gName");
            dt.Columns.Add("SP_gDanweiid");
            dt.Columns.Add("SP_gXinghao");
            dt.Columns.Add("goodsys");
            dt.Columns.Add("SP_gJijie");
            dt.Columns.Add("SP_gKucuenx");
            dt.Columns.Add("goodszje");
            dgvc.AutoGenerateColumns = false;
            dgvc.DataSource = dt;

            cbokck.DisplayMember = "CK_tName";
            cbokck.ValueMember = "CK_tID";
            cbokck.DataSource = cm.select().Tables[0];

            cbokjbr.DisplayMember = "YG_xName";
            cbokjbr.ValueMember = "YG_xId";
            cbokjbr.DataSource = ym.chaxun();


            lbkdh.Text = cmm.GetNo2("KB");

            dgvcsp.AutoGenerateColumns = false;
            SP_goods sg = new SP_goods();
            sg.SP_gTiaoma = "";
            dgvcsp.DataSource = sm.spquanbu(sg);
        }

        private void chaifen()
        {
            palksp.Visible = false;


            dt2.Columns.Add("SP_gTiaoma");
            dt2.Columns.Add("SP_gName");
            dt2.Columns.Add("SP_gDanweiid");
            dt2.Columns.Add("SP_gXinghao");
            dt2.Columns.Add("goodsys");
            dt2.Columns.Add("SP_gJijie");
            dt2.Columns.Add("SP_gKucuenx");
            dt2.Columns.Add("goodszje");
            dgvkb.AutoGenerateColumns = false;
            dgvkb.DataSource = dt2;

            cbocck.DisplayMember = "CK_tName";
            cbocck.ValueMember = "CK_tID";
            cbocck.DataSource = cm.select().Tables[0];

            cbocjbr.DisplayMember = "YG_xName";
            cbocjbr.ValueMember = "YG_xId";
            cbocjbr.DataSource = ym.chaxun();

            lbdh.Text = cmm.GetNo2("CF");

            dgvksp.AutoGenerateColumns = false;
            SP_goods sg = new SP_goods();
            sg.SP_gTiaoma = "";
            dgvksp.DataSource = sm.spquanbu(sg);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (palcsp.Visible==false)
            {
                palcsp.Visible = true;
            }
            else
            {
                palcsp.Visible = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (dgvcsp.CurrentRow.Cells == null)
            {
                return;
            }
            txtbh.Text = dgvcsp.CurrentRow.Cells[0].Value.ToString();

            lbcbh.Text = dgvcsp.CurrentRow.Cells[1].Value.ToString();
            lbcxh.Text = dgvcsp.CurrentRow.Cells[2].Value.ToString();
            lbcdw.Text = dgvcsp.CurrentRow.Cells[3].Value.ToString();
            lbcys.Text = dgvcsp.CurrentRow.Cells[4].Value.ToString();
            lbckc.Text = dgvcsp.CurrentRow.Cells[5].Value.ToString();
            lbcjb.Text = dgvcsp.CurrentRow.Cells["SP_gJijie"].Value.ToString();
            lbcje.Text = dgvcsp.CurrentRow.Cells["SP_gJijie"].Value.ToString();
            palcsp.Visible = false;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            palcsp.Visible = false;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            SP_goods sg = new SP_goods();
            sg.SP_gTiaoma = textBox9.Text;
            dgvcsp.DataSource = sm.spquanbu(sg);
        }

        private void dgvcsp_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button22_Click(null, null);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            SP_goods sg = new SP_goods();
            sg.SP_gTiaoma = txtkSP.Text;
            dgvcsp.DataSource = sm.spquanbu(sg);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            palksp.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (palksp.Visible == false)
            {
                palksp.Visible = true;
            }
            else
            {
                palksp.Visible = false;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (dgvksp.CurrentRow.Cells==null)
            {
                return;
            }
            txtkspid.Text = dgvksp.CurrentRow.Cells[0].Value.ToString();
            lbkname.Text = dgvksp.CurrentRow.Cells[1].Value.ToString();
            lbkxh.Text = dgvcsp.CurrentRow.Cells[2].Value.ToString();
            lbkdw.Text = dgvcsp.CurrentRow.Cells[3].Value.ToString();
            lbkys.Text = dgvcsp.CurrentRow.Cells[4].Value.ToString();
            lbkkc.Text = dgvcsp.CurrentRow.Cells[5].Value.ToString();
            lbkcb.Text = dgvcsp.CurrentRow.Cells["SP_gJijie"].Value.ToString();
            lbkje.Text = dgvcsp.CurrentRow.Cells["SP_gJijie"].Value.ToString();
            palksp.Visible = false;
        }

        private void dgvksp_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button28_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtbh.Text=="")
            {
                MessageBox.Show("请输入被拆分的商品编号","提示");
                return;
            }
            string name = "增加商品(拆分商品)";
            int s =Convert.ToInt32( cbocck.SelectedValue);
            B_IntoReturngoods aaa = new B_IntoReturngoods(s, dt,name);
            aaa.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvc.Rows.Count<=0)
            {
                MessageBox.Show("单据没有数据 不能保存","提示");
                return;
            }
            for (int i = 0; i < dgvc.Rows.Count; i++)
            {
                DH_tabel dt = new DH_tabel();
                dt.DH_tDanhao = lbdh.Text;
                dt.DH_tshangpID = dgvc.Rows[i].Cells["Column8"].Value.ToString();
                dt.DH_tdzl = 0.0;
                dt.DH_tdanjia = Convert.ToDouble(dgvc.Rows[i].Cells["Column5"].Value);
                dt.DH_tShuliang = Convert.ToInt32(dgvc.Rows[i].Cells["Column6"].Value);
                dt.DH_tType = "拆分";
                dt.DH_tZongjine = Convert.ToDouble(dgvc.Rows[i].Cells["Column7"].Value);
                dm.ADD(dt);
                SP_goods sg = new SP_goods();
                sg.SP_gTiaoma = dgvc.Rows[i].Cells["Column8"].Value.ToString();
                sg.SP_gKucuen = Convert.ToInt32(dgvc.Rows[i].Cells["Column6"].Value);
            }

            CG_table ct = new CG_table();
            ct.CF_tdanhao = lbdh.Text;
            ct.CF_tcangku = cbocck.SelectedValue.ToString();
            ct.CF_ttime = dateTimePicker3.Value;
            ct.CF_spbianhao = txtbh.Text;
            ct.CF_tshuliang =Convert.ToInt32( textBox4.Text);
            ct.CF_tjbren =cbocjbr.SelectedValue.ToString();
            ct.CF_ttype = "拆分";
            ct.CF_beizhu = textBox5.Text;
            ct.CF_tshuliang = Convert.ToInt32(textBox4.Text);
            if (cgm.insert(ct)>0)
            {
                MessageBox.Show("数据保存成功","提示");
                lbdh.Text = cmm.GetNo2("CF");
                dt.Clear();
                dgvc.DataSource = dt;
                txtbh.Text = "";
                textBox4.Text = "1";
                textBox5.Text = "";
                lbcbh.Text = "";
                lbcxh.Text = "";
                lbcdw.Text = "";
                lbcys.Text = "";
                lbckc.Text = "";
                lbcjb.Text = "";
                lbcje.Text = "";
                

            }
            else
            {
                MessageBox.Show("数据保存失败", "提示");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtkspid.Text == "")
            {
                MessageBox.Show("请输入被捆绑的商品编号", "提示");
                return;
            }
            string name = "增加商品(捆绑商品)";
            int s = Convert.ToInt32(cbokck.SelectedValue);
            B_IntoReturngoods aaa = new B_IntoReturngoods(s, dt2, name);
            aaa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvkb.Rows.Count <= 0)
            {
                MessageBox.Show("单据没有数据 不能保存", "提示");
                return;
            }
            for (int i = 0; i < dgvkb.Rows.Count; i++)
            {
                DH_tabel dt = new DH_tabel();
                dt.DH_tDanhao = lbkdh.Text;
                dt.DH_tshangpID = dgvkb.Rows[i].Cells["Column9"].Value.ToString();
                dt.DH_tdzl = 0.0;
                dt.DH_tdanjia = Convert.ToDouble(dgvkb.Rows[i].Cells["cbj"].Value);
                dt.DH_tShuliang = Convert.ToInt32(dgvkb.Rows[i].Cells["shuliang"].Value);
                dt.DH_tType = "捆绑";
                dt.DH_tZongjine = Convert.ToDouble(dgvkb.Rows[i].Cells["zje"].Value);
                dm.ADD(dt);
                //SP_goods sg = new SP_goods();
                //sg.SP_gTiaoma = dgvkb.Rows[i].Cells["Column8"].Value.ToString();
                //sg.SP_gKucuen = Convert.ToInt32(dgvkb.Rows[i].Cells["Column6"].Value);
            }

            CG_table ct = new CG_table();
            ct.CF_tdanhao = lbkdh.Text;
            ct.CF_tcangku = cbokck.SelectedValue.ToString();
            ct.CF_ttime = dateTimePicker4.Value;
            ct.CF_spbianhao = txtkspid.Text;
            ct.CF_tshuliang = Convert.ToInt32(textBox7.Text);
            ct.CF_tjbren = cbokjbr.SelectedValue.ToString();
            ct.CF_ttype = "捆绑";
            ct.CF_beizhu = textBox8.Text;
            ct.CF_tshuliang = Convert.ToInt32(textBox7.Text);
            
            if (cgm.insert(ct)>0)
            {
                MessageBox.Show("数据保存成功", "提示");
                lbkdh.Text = cmm.GetNo2("KB");
                txtkspid.Text = "";
                textBox7.Text = "1";
                lbkname.Text = "";
                lbkxh.Text = "";
                lbkdw.Text = "";
                lbkys.Text = "";
                lbkje.Text = "";
                lbkcb.Text = "";
                lbkkc.Text = "";
                textBox8.Text = "";
                dt2.Clear();
                dgvkb.DataSource = dt2;

            }
            else
            {

                MessageBox.Show("数据保存失败", "提示");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = gm.kbcf(comboBox2.Text, textBox2.Text, dateTimePicker2.Value.ToString(), dateTimePicker1.Value.ToString());

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView4.DataSource = gm.kbcf(comboBox2.Text, textBox2.Text, dateTimePicker2.Value.ToString(), dateTimePicker1.Value.ToString());

        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView5.DataSource = dm.xiangxi(dataGridView4.CurrentRow.Cells["CF_tdanhao"].Value.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dataGridView4, "拆分/捆绑记录");
        }

       


      

      
    }
}