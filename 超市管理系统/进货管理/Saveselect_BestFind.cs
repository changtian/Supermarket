using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using System.Data.SqlClient;
using BLL;
using System.Collections;

namespace 超市管理系统.进货管理
{
    public partial class Saveselect_BestFind : Form
    {
        SP_goodsManager gm = new SP_goodsManager();

        GH_shangManager sm = new GH_shangManager();

        CK_tableManager tm = new CK_tableManager();


        public delegate void delhhhh();
        public event delhhhh hhhh;

        public Saveselect_BestFind()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Saveselect_BestFind_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            reset();
        }

        private void reset()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = gm.GetAllSP_goods().Tables[0];

            cbosaveaddress.ValueMember = "CK_tID";
            cbosaveaddress.DisplayMember = "CK_tName";
            cbosaveaddress.DataSource=tm.GetAllCK_table().Tables[0];
        }

        private void btfind_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btexit2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btsure2_Click(object sender, EventArgs e)
        {
            dataGridView1_MouseDoubleClick(null, null);
            panel1.Visible = false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtbusiness.Text = dataGridView1.CurrentRow.Cells["SP_gName"].Value.ToString();
            panel1.Visible = false;
        }

        //private void btsure_Click(object sender, EventArgs e)
        //{
        //    Dictionary<string, string> d = new Dictionary<string, string>();
        //    d.Add("SP_gName", txtbusiness.Text);
        //    d.Add("aaaa",txtsavenum.Text);
        //    d.Add("cK_tName", cbosaveaddress.Text);
        //    this.Tag = d;
        //    hhhh();
        //    this.Close();
        //}
    }
}