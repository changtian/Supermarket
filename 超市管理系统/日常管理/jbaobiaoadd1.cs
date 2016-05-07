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
    public partial class jbaobiaoadd1 : Form
    {
        YG_xinxiManager yg = new YG_xinxiManager();
        CW_feiyManager cw = new CW_feiyManager();
        XJ_yhangManager yh=new XJ_yhangManager();

        public jbaobiaoadd1()
        {
            InitializeComponent();
        }

        private void jbaobiaoadd1_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "CW_ftypename";
            comboBox1.DataSource = cw.CW_feiyshou().Tables[0];

            comboBox2.DisplayMember = "YG_xName";
            comboBox2.DataSource=yg.YG_xinxi().Tables[0];

            comboBox3.DisplayMember = "XJ_name";
            comboBox3.DataSource=yh.XJ_yhang().Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="")
            {
                MessageBox.Show("请选择用户名称！");
                return;
            }
            if (textBox1.Text=="")
            {
                MessageBox.Show("请输入金额！");
                return;
            }
            CW_feiy fei = new CW_feiy();
            fei.CW_fmoney =Convert.ToDouble(textBox1.Text);
            fei.CW_ftypename = comboBox1.Text;
            fei.CW_ftype = "收入";
            fei.CW_ffujia = textBox2.Text;
            string name="";
            bool b=cw.shouCW_feiy(fei,ref name);
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