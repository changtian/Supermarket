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
    public partial class jbaobiao : Form
    {
        public jbaobiao()
        {
            InitializeComponent();
        }
        CW_feiyManager fei = new CW_feiyManager();
        XJ_yhangManager yh = new XJ_yhangManager();
        CW_gudingManager gu = new CW_gudingManager();
        CW_yingsyfManager yi = new CW_yingsyfManager();
        JY_qkuangManager ku = new JY_qkuangManager();

        private void button3_Click(object sender, EventArgs e)
        {
            gbfen.Visible = true;
            gbxian.Visible = false;
            gbgu.Visible = false;
            gbchai.Visible = false;
            gbfen.Dock = DockStyle.Fill;
            gbchai.Dock = DockStyle.None;
            gbgu.Dock = DockStyle.None;
            gbxian.Dock = DockStyle.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbxian.Visible = true;
            gbgu.Visible = false;
            gbchai.Visible = false;
            gbfen.Visible = false;
            gbxian.Dock = DockStyle.Fill;
            gbchai.Dock = DockStyle.None;
            gbfen.Dock = DockStyle.None;
            gbgu.Dock = DockStyle.None;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gbgu.Visible = true;
            gbchai.Visible = false;
            gbfen.Visible = false;
            gbxian.Visible = false;
            gbgu.Dock = DockStyle.Fill;
            gbfen.Dock = DockStyle.None;
            gbxian.Dock = DockStyle.None;
            gbchai.Dock = DockStyle.None;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gbchai.Visible = true;
            gbfen.Visible = false;
            gbxian.Visible = false;
            gbgu.Visible = false;
            gbchai.Dock = DockStyle.Fill;
            gbfen.Dock = DockStyle.None;
            gbgu.Dock = DockStyle.None;
            gbxian.Dock = DockStyle.None;
            
        }

        private void jbaobiao_Load(object sender, EventArgs e)
        {
            dataGridView4.DataSource = fei.CW_feiy().Tables[0];
            
            dataGridView2.DataSource = yh.XJ_yhang().Tables[0];

            dataGridView5.DataSource=gu.CW_guding().Tables[0];

            dataGridView6.DataSource=yi.CW_yingsyf().Tables[0];

            dataGridView1.DataSource=ku.JY_qkuang().Tables[0];
            button7.Visible = false;
            gbfen.Dock = DockStyle.Fill;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            jbaobiaoadd jba = new jbaobiaoadd();
            jba.ShowDialog();
            jbaobiao_Load(null,null);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            jbaobiaoadd1 jb = new jbaobiaoadd1();
            jb.ShowDialog();
            jbaobiao_Load(null, null);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            jbaobiaoadd2 bao = new jbaobiaoadd2();
            bao.ShowDialog();
            jbaobiao_Load(null, null);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            jbaobiaoadd3 bao = new jbaobiaoadd3();
            bao.ShowDialog();
            jbaobiao_Load(null, null);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = gu.dateCW_guding(Convert.ToDateTime(date1.Text),Convert.ToDateTime(date2.Text)).Tables[0];
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            jbaobiaoadd4 bao = new jbaobiaoadd4();
            bao.ShowDialog();
            jbaobiao_Load(null, null);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            jbaobiaoadd5 bao = new jbaobiaoadd5();
            bao.ShowDialog();
            jbaobiao_Load(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView6_SelectionChanged(object sender, EventArgs e)
        {
            string sname = dataGridView6.CurrentRow.Cells["CW_ydanwei"].Value.ToString();
            dataGridView7.DataSource = yi.likeCW_yingsyf(sname).Tables[0];

            label13.Text = sname;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            dataGridView7.DataSource = yi.dateCW_yingsyf(Convert.ToDateTime(dateTimePicker7.Text),Convert.ToDateTime(dateTimePicker8.Text)).Tables[0];
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string name = dataGridView1.CurrentRow.Cells["JY_qkemu"].Value.ToString();
            dataGridView3.DataSource=ku.likeJY_qkuang(name).Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = ku.dateJY_qkuang(Convert.ToDateTime(dateTimePicker2.Text),Convert.ToDateTime(dateTimePicker1.Text)).Tables[0];
        }
    }
}