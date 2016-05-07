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
    public partial class kdiaobachaxun4 : Form
    {
        YG_xinxiManager ma = new YG_xinxiManager();
        public kdiaobachaxun4()
        {
            InitializeComponent();

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (tb1.Text == "")
            {
                MessageBox.Show("员工姓名不能为空！");
                textBox1.Focus();
                return;
            }
            YG_xinxi xi = new YG_xinxi();
            xi.YG_xName = tb1.Text;
            xi.YG_xZhiwu = tb2.Text;
            xi.YG_xDianhua = tb3.Text;
            xi.YG_xDizhi = tb4.Text;
            xi.YG_xBeizhu = tb5.Text;

            if (checkBox6.Checked)
            {
                xi.YG_xCaigou = 1;
            }
            else
            {
                xi.YG_xCaigou = 0;
            }


            if (checkBox5.Checked)
            {
                xi.YG_xXiaoshou = 1;
            }
            else
            {
                xi.YG_xXiaoshou = 0;
            }


            if (checkBox4.Checked)
            {
                xi.YG_xkucuen = 1;
            }
            else
            {
                xi.YG_xkucuen = 0;
            }

            string sname = "";
            bool b = ma.addYG_xinxi(xi, ref sname);
            MessageBox.Show(sname);
            if (b)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}