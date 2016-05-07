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
    public partial class jbaobiaoadd5 : Form
    {
        public jbaobiaoadd5()
        {
            InitializeComponent();
        }

        XJ_yhangManager yh = new XJ_yhangManager();
        YG_xinxiManager yg = new YG_xinxiManager();

        private void jbaobiaoadd5_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "XJ_name";
            comboBox1.DataSource = yh.XJ_yhang().Tables[0];

            comboBox2.DisplayMember = "YG_xName";
            comboBox2.DataSource = yg.YG_xinxi().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择经办人！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入金额！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string name = comboBox1.Text;
            int i = Convert.ToInt32(textBox1.Text);
            string beizhu = textBox2.Text;
            bool b = yh.jingXJ_yhang(i,beizhu,name);
            if (b)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}