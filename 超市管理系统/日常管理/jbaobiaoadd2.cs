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
    public partial class jbaobiaoadd2 : Form
    {
        public jbaobiaoadd2()
        {
            InitializeComponent();
        }
        YG_xinxiManager yg=new YG_xinxiManager();
        CW_gudingManager gud = new CW_gudingManager();
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("请输入金额！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (comboBox1.Text=="")
            {
                MessageBox.Show("请选择经办人！","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            CW_guding gu = new CW_guding();
            gu.CW_gtime = DateTime.Now;
            gu.CW_gtype = "资产增加";
            gu.CW_gmoney = Convert.ToDouble(textBox1.Text);
            gu.CW_gjbren = comboBox1.Text;
            gu.CW_gbeizhu = textBox2.Text;
            string name="";
            bool b= gud.AddCW_guding(gu,ref name);
            Console.WriteLine(name);
            if (b)
            {
                this.Close();
            }
        }

        private void jbaobiaoadd2_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "YG_xName";
            comboBox1.DataSource=yg.YG_xinxi().Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}