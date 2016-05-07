using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;

namespace 超市管理系统.库存管理
{
    public partial class kdiaobachaxun5 : Form
    {
        YG_xinxiManager xi = new YG_xinxiManager();
        YG_xinxi xx;
        public kdiaobachaxun5(YG_xinxi aa)
        {
            xx = aa;
            InitializeComponent();
        }

        private void kdiaobachaxun5_Load(object sender, EventArgs e)
        {                     
            textBox1.Text = xx.YG_xName;
            textBox2.Text = xx.YG_xZhiwu;
            textBox3.Text = xx.YG_xDianhua;
            textBox4.Text = xx.YG_xDizhi;
            textBox5.Text = xx.YG_xBeizhu;
            if (xx.YG_xXiaoshou==1)
            {
                checkBox3.Checked = true;
            }
            if (xx.YG_xkucuen==1)
            {
                checkBox2.Checked = true;

            }
            if (xx.YG_xCaigou==1)
            {
                checkBox1.Checked = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YG_xinxi yg = new YG_xinxi();
            yg.YG_xId = xx.YG_xId;
            yg.YG_xName = textBox1.Text;
            yg.YG_xZhiwu = textBox2.Text;
            yg.YG_xDianhua = textBox3.Text;
            yg.YG_xDizhi = textBox4.Text;
            yg.YG_xBeizhu = textBox5.Text;
            if (checkBox1.Checked)
            {
                yg.YG_xCaigou = 1;
            }
            else
            {
                yg.YG_xCaigou = 0;
            }
            if (checkBox2.Checked)
            {
                yg.YG_xXiaoshou = 1;
            }
            else
            {
                yg.YG_xkucuen = 0;
            }
            if (checkBox3.Checked)
            {
                yg.YG_xkucuen = 1;
            }
            else
            {
                yg.YG_xkucuen = 0;
            }
            xi.updateYG_xinxi(yg);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}