using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace 超市管理系统.库存管理
{
    public partial class kdiao : Form
    {

        CK_tableManager cm = new CK_tableManager();
        YG_xinxiManager mm = new YG_xinxiManager();
        public kdiao()
        {
            InitializeComponent();
        }

        private void kdiao_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "CK_tName";
            comboBox1.ValueMember = "CK_tID";
            comboBox1.DataSource = cm.gegt().Tables[0];


            comboBox3.DisplayMember = "YG_xName";
            comboBox3.ValueMember = "YG_xId";
            comboBox3.DataSource = mm.YG_xinxi().Tables[0];


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择调出仓库！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.Tag = comboBox1.Text;
                kdiaobachaxun1 diao = new kdiaobachaxun1();
                diao.ShowDialog();             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kdiaobachaxun3 cha = new kdiaobachaxun3();
            cha.ShowDialog();
            if (cha.Tag!=null)
            {
                comboBox3.Text = cha.Tag.ToString();
            }           
        }        
    }
}