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
    public partial class jbaobiaoadd : Form
    {
        public jbaobiaoadd()
        {
            InitializeComponent();
        }
        CW_feiyManager fei = new CW_feiyManager();
        YG_xinxiManager yg = new YG_xinxiManager();
        XJ_yhangManager yh = new XJ_yhangManager();

        private void jbaobiaoadd_Load(object sender, EventArgs e)
        {
            cmbname.DisplayMember = "CW_ftypename";
            //comboBox1.ValueMember = "CW_fId";
            cmbname.DataSource = fei.CW_feiy().Tables[0];

            comboBox2.DisplayMember = "YG_xName";
            comboBox2.DataSource=yg.YG_xinxi().Tables[0];

            comboBox3 .DisplayMember="XJ_name";
            comboBox3.DataSource = yh.XJ_yhang().Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbname.Text=="")
            {
                MessageBox.Show("请选择用户名称！");
            }
            if (textmoney.Text=="")
            {
                MessageBox.Show("请输入金额！");
                return;
            }
            CW_feiy fe = new CW_feiy();
            fe.CW_fmoney = Convert.ToDouble(textmoney.Text);
            fe.CW_ffujia = textBox2.Text;
            fe.CW_ftypename = cmbname.Text;
            fe.CW_ftype = "费用";
            string name = "";
            bool b = fei.AddCW_feiy(fe, ref name);
            MessageBox.Show(name);
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