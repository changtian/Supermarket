using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Models;

namespace 超市管理系统.日常管理
{
    public partial class jgo : Form
    {
        GH_shangManager sha = new GH_shangManager();
        XS_tbaleManager tb = new XS_tbaleManager();
        SP_goodsManager gd = new SP_goodsManager();

        string name;
        public jgo()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
            if (textBox1.Text!="")
            {
                button7_Click(null,null);
            }
            else
            {
                button7_Click(null, null);
                return;
            }

            dataGridView1.DataSource = sha.likeGH_shang(textBox1.Text).Tables[0];
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            string name = dataGridView1.CurrentRow.Cells["KH_xName"].Value.ToString();
            label8.Text = dataGridView1.CurrentRow.Cells["KH_xName"].Value.ToString();
            label9.Text = dataGridView1.CurrentRow.Cells["KH_xlianxiren"].Value.ToString();
            label10.Text = dataGridView1.CurrentRow.Cells["KH_xDianhua"].Value.ToString();
            label11.Text = dataGridView1.CurrentRow.Cells["KH_xDizhi"].Value.ToString();
            groupBox6.Visible = false;
            if (dataGridView1.SelectedRows.Count>0)
            {
                dataGridView3.DataSource = tb.XS_tbale(name).Tables[0];
            }
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
        }
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count>0)
            {
                string name = dataGridView3.CurrentRow.Cells["XS_tDanhao"].Value.ToString();
                dataGridView4.DataSource=gd.jkehuSP_goodsdu(name).Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            系统设置.F_busnissInfo ff = new 超市管理系统.系统设置.F_busnissInfo();
            ff.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            统计报表.Frogonghuos ff = new 超市管理系统.统计报表.Frogonghuos();
            ff.ShowDialog();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jgo_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = sha.Gh_shang().Tables[0];
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button9_Click_1(null, null);
        }

       

        
            
        
    }
}