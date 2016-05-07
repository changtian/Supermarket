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

namespace 超市管理系统.进货管理
{
    public partial class Y_stockfindfind : Form
    {
        GH_shangManager sm = new GH_shangManager();

        public Y_stockfindfind()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btreturnupdate_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridView3.CurrentRow.Cells["GH_sId"].Value);
           
            GH_shang gg = new GH_shang();
            gg.GH_sBeizhu = dataGridView3.CurrentRow.Cells["GH_sBeizhu"].Value.ToString();
            gg.GH_sDianhua = dataGridView3.CurrentRow.Cells["GH_sDianhua"].Value.ToString();
            gg.GH_sLianxiren = dataGridView3.CurrentRow.Cells["GH_sLianxiren"].Value.ToString();
            gg.GH_sName = dataGridView3.CurrentRow.Cells["GH_sName"].Value.ToString();
            gg.GH_sMoney =Convert.ToDouble(dataGridView3.CurrentRow.Cells["GH_sMoney"].Value.ToString());
            gg.GH_sDizhi = dataGridView3.CurrentRow.Cells["GH_sDizhi"].Value.ToString();
            gg.GH_sMoren =Convert.ToInt32(dataGridView3.CurrentRow.Cells["GH_sMoren"].Value.ToString());
            B_updatebusniss aaa = new B_updatebusniss(i,gg);
            aaa.ddd += reset;
            aaa.ShowDialog();
        }

        private void Y_stockfindfind_Load(object sender, EventArgs e)
        {
            reset();

        }

        private void reset()
        {
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = sm.Gh_shang().Tables[0];
        }

        private void txtbusniss_TextChanged(object sender, EventArgs e)
        {
            if (txtbusniss.Text=="")
            {
                dataGridView3.DataSource = sm.Gh_shang().Tables[0];
            }
            dataGridView3.DataSource = sm.Gh_shang2(Convert.ToInt32(txtbusniss.Text)).Tables[0];
        }

        private void btsure_Click(object sender, EventArgs e)
        {
            this.Tag = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void dataGridView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btsure_Click(null, null);
        }

    }
}