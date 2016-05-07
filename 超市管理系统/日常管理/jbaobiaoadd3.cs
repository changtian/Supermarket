using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;

namespace 超市管理系统.日常管理
{
    public partial class jbaobiaoadd3 : Form
    {
        YG_xinxiManager yg = new YG_xinxiManager();
        CW_gudingManager di = new CW_gudingManager();

        public jbaobiaoadd3()
        {
            InitializeComponent();
        }

        private void jbaobiaoadd3_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "YG_xName";
            comboBox1.DataSource = yg.YG_xinxi().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="")
            {
                MessageBox.Show("请选择经办人！","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            CW_guding gud = new CW_guding();
            gud.CW_gtime = DateTime.Now;
            gud.CW_gtype = "资产减少";
            gud.CW_gmoney = Convert.ToDouble(textBox1.Text);
            gud.CW_gjbren = comboBox1.Text;
            gud.CW_gbeizhu = textBox2.Text;
            string name = "";
            bool b=di.AddCW_guding(gud,ref name);
            Console.WriteLine(name);
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