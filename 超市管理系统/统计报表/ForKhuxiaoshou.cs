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
    public partial class ForKhuxiaoshou : Form
    {
        public ForKhuxiaoshou()
        {
            InitializeComponent();
        }
        XS_tbaleManager xm = new XS_tbaleManager();
        KH_xinxiManager km = new KH_xinxiManager();
        DH_tabelManager dm = new DH_tabelManager();
        SP_goodsManager sm = new SP_goodsManager();

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选择供货商", "系统提示");
                return;
            }
            string name = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
            double qiankuan = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["Column7"].Value.ToString() == dataGridView1.CurrentRow.Cells["Column7"].Value.ToString())
                {
                    qiankuan = qiankuan + Convert.ToDouble(dataGridView1.Rows[i].Cells["Column7"].Value);
                }

            }
            string id = dataGridView1.CurrentRow.Cells["Column19"].Value.ToString();

            Forshoukuan ff = new Forshoukuan(qiankuan,name,id);
            ff.ShowDialog();
            dv1 = xm.xiaoshou().DefaultView;
            if (textBox1.Text != "全部供货商" && textBox1.Text.Trim() != "")
            {
                dv1.RowFilter = string.Format(" GH_sName='{0}'", textBox1.Text);
            }

            dataGridView1.DataSource = dv1;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选择供货商", "系统提示");
                return;
            }
            if (dataGridView2.CurrentRow==null)
            {
                MessageBox.Show("付款单不能退货");
                return;
            }
            DataTable dgv = (DataTable)dataGridView2.DataSource;
            string ghsname = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
            string id = dataGridView1.CurrentRow.Cells["Column19"].Value.ToString();
            进货管理.B_return ff = new 超市管理系统.进货管理.B_return(dgv, ghsname, id);
            ff.ShowDialog();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
        DataView dv1 = new DataView();
        DataView dvkh = new DataView();
        DataView dv2 = new DataView();
        DataView dv3 = new DataView();

        private void ForKhuxiaoshou_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage3);
            plliushuei.Visible = true;
            palsuoyou.Visible = false;
            palxf.Visible = false;
            palzw.Visible = false;
            dvkh = km.khxxi("").Tables[0].DefaultView;
            dataGridView9.AutoGenerateColumns = false;
            dataGridView9.DataSource = dvkh;
            dataGridView7.AutoGenerateColumns = false;
            dataGridView7.DataSource = dvkh;
            dataGridView13.AutoGenerateColumns = false;
            dataGridView13.DataSource = dvkh;
            dv1 = xm.xiaoshou().DefaultView;
            dv3 = sm.shangp().DefaultView;
            

        }

        private void toolxfbtnchax_Click(object sender, EventArgs e)
        {
            Forkhxiaoscx ff = new Forkhxiaoscx();
            ff.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (palsuoyou.Visible == false)
            {
                palsuoyou.Visible = true;
            }
            else
            {
                palsuoyou.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (palxf.Visible==false)
            {
                palxf.Visible = true;
            }
            else
            {
                palxf.Visible = false;
            }
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            if (palzw.Visible==false)
            {
                palzw.Visible = true;
            }
            else
            {
                palzw.Visible = false;
            }
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox1.Text.Trim() != "全部客户")
            {
                dv1.RowFilter = string.Format("KH_xName='{0}'", textBox1.Text.Trim());
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dv1;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                textBox1.Text = "全部客户";
            }
            palsuoyou.Visible = false;
            checkBox1.Checked = false;
        }

        private void btntueichu_Click(object sender, EventArgs e)
        {
            palsuoyou.Visible = false;
        }

        private void btnquding_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView9.CurrentRow.Cells["Column68"].Value.ToString();
            palsuoyou.Visible = false;
        }

        private void txttiaojian_TextChanged(object sender, EventArgs e)
        {
            if (txttiaojian.Text.Trim()!="")
            {
                dvkh.RowFilter = string.Format("KH_xId = '{0}' or KH_xName = '{0}'",txttiaojian.Text);
            }
            dataGridView9.DataSource = dvkh;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count==0)
            {
                return;
            }
            label5.Text = dataGridView1.CurrentRow.Cells["Column3"].Value.ToString();
            label6.Text = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
           
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dm.shangpmxi(label5.Text);

        }

        private void toolsybtnchakan_Click(object sender, EventArgs e)
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
            ForDelete ff = new ForDelete(ghname, danhao, sfu, yfu);
            ff.ShowDialog();
            dv1 = xm.xiaoshou().DefaultView;
    

            dataGridView1.DataSource = dv1;
        }

        private void toolsybtntueih_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dataGridView1, "销售账务");
        }

        private void dataGridView9_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView9.CurrentRow.Cells["Column68"].Value.ToString();
            palsuoyou.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Text = "全部客户";
            }
            palxf.Visible = false;
            checkBox2.Checked = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView9.CurrentRow.Cells["name2"].Value.ToString();
            palxf.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txttiaojian.Text.Trim() != "")
            {
                dvkh.RowFilter = string.Format("KH_xId = '{0}' or KH_xName = '{0}'", txttiaojian.Text);
            }
            dataGridView7.DataSource = dvkh;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            palxf.Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                txtkhname.Text = "全部客户";
            }
            palzw.Visible = false;
            checkBox4.Checked = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtkhname.Text = dataGridView9.CurrentRow.Cells["name3"].Value.ToString();
            palzw.Visible = false;
        }

        private void dataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkhname.Text = dataGridView9.CurrentRow.Cells["name3"].Value.ToString();
            palzw.Visible = false;
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView9.CurrentRow==null)
            {
                return;
            }
            textBox2.Text = dataGridView9.CurrentRow.Cells["name2"].Value.ToString();
            palxf.Visible = false;
        }

        private void palzw_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dv3 = sm.shangp().DefaultView;
            if (textBox2.Text.Trim() != "")
            {
                dv3.RowFilter = string.Format(" SP_gName like '%{0}%'", textBox2.Text);
            }
            dataGridView6.AutoGenerateColumns = false;
            dataGridView6.DataSource=dv3;
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label8.Text = dataGridView6.CurrentRow.Cells["Column8"].Value.ToString();
            string spg = dataGridView6.CurrentRow.Cells["Column27"].Value.ToString();
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = sm.shangxx(spg);
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}