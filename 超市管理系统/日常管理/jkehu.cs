using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace 超市管理系统.日常管理
{
    public partial class jkehu : Form
    {
        KH_xinxiManager kh = new KH_xinxiManager();
        XS_tbaleManager tb = new XS_tbaleManager();
        SP_goodsManager gd = new SP_goodsManager();
        public jkehu()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = true;
            dataGridView1.DataSource=kh.KH_xinxi().Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button7_Click(null, null);
            }
            else
            {
                button7_Click(null, null);
                return;
            }
            dataGridView1.DataSource = kh.likeKH_xinxi(textBox1.Text).Tables[0];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = false;
            string name = dataGridView1.CurrentRow.Cells["KH_xName"].Value.ToString();
            lb1.Text=dataGridView1.CurrentRow.Cells["KH_xName"].Value.ToString();
            lb2.Text=dataGridView1.CurrentRow.Cells["KH_xlianxiren"].Value.ToString();
            lb3.Text=dataGridView1.CurrentRow.Cells["KH_xDianhua"].Value.ToString();
            lb4.Text = dataGridView1.CurrentRow.Cells["KH_xDizhi"].Value.ToString();
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource=tb.XS_tbale(name,"").Tables[0];
        }
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                string name = dataGridView3.CurrentRow.Cells["XS_tDanhao"].Value.ToString();
                dataGridView4.DataSource = gd.jkehuSP_goodsdu(name).Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            系统设置.D_CustomerInfo ff = new 超市管理系统.系统设置.D_CustomerInfo();

            ff.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            统计报表.ForKhuxiaoshou ff = new 超市管理系统.统计报表.ForKhuxiaoshou();
            ff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = false;
        }
    }
}