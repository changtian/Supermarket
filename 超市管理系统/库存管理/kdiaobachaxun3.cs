using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Models;

namespace 超市管理系统.库存管理
{
    public partial class kdiaobachaxun3 : Form
    {
        YG_xinxiManager ma = new YG_xinxiManager();
        public kdiaobachaxun3()
        {
            InitializeComponent();
        }

        private void kdiaobachaxun3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ma.YG_xinxi().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kdiaobachaxun4 di = new kdiaobachaxun4();
            di.ShowDialog();
            kdiaobachaxun3_Load(null,null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YG_xinxi xx = new YG_xinxi();
            xx.YG_xName = dataGridView1.CurrentRow.Cells["YG_xName"].Value.ToString();
            xx.YG_xZhiwu = dataGridView1.CurrentRow.Cells["YG_xZhiwu"].Value.ToString();
            xx.YG_xDianhua = dataGridView1.CurrentRow.Cells["YG_xDianhua"].Value.ToString();
            xx.YG_xDizhi = dataGridView1.CurrentRow.Cells["YG_xDizhi"].Value.ToString();
            xx.YG_xBeizhu = dataGridView1.CurrentRow.Cells["YG_xBeizhu"].Value.ToString();
            xx.YG_xCaigou = Convert.ToInt32(dataGridView1.CurrentRow.Cells["YG_xCaigou"].Value.ToString());
            xx.YG_xXiaoshou = Convert.ToInt32(dataGridView1.CurrentRow.Cells["YG_xXiaoshou"].Value.ToString());
            xx.YG_xkucuen = Convert.ToInt32(dataGridView1.CurrentRow.Cells["YG_xkucuen"].Value.ToString());
            xx.YG_xId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["YG_xId"].Value.ToString());

            kdiaobachaxun5 ba = new kdiaobachaxun5(xx);
            ba.ShowDialog();
            kdiaobachaxun3_Load(null,null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                kdiaobachaxun3_Load(null, null);
            }
            dataGridView1.DataSource = ma.likexixi(textBox1.Text, textBox1.Text).Tables[0];
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button5_Click(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.CurrentRow.Cells["YG_xName"].Value.ToString();
            this.Tag = name;
            this.Close();            
        }
    }
}