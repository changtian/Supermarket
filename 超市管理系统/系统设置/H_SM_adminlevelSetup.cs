using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;
using Models;

namespace 超市管理系统.系统设置
{
    public partial class H_SM_adminlevelSetup : Form
    {
        MEMLEVELManager mem = new MEMLEVELManager();

        public H_SM_adminlevelSetup()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            H_SM_adminlevelSetupAdd aaa = new H_SM_adminlevelSetupAdd();
            aaa.ShowDialog();

            H_SM_adminlevelSetup_Load(null,null);
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            MEMLEVEL aa = new MEMLEVEL();
            aa.MEMLEVEL_NAME = dataGridView1.CurrentRow.Cells["mEMLEVEL_NAME"].Value.ToString();
            aa.MEMLEVEL_DISCOUNT = Convert.ToDouble(dataGridView1.CurrentRow.Cells["MEMLEVEL_DISCOUNT"].Value);
            aa.MEMLEVEL_LOWSCORE = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MEMLEVEL_LOWSCORE"].Value);
            aa.MEMLEVEL_HIGHSCORE = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MEMLEVEL_HIGHSCORE"].Value);

            //把表中的ID用传参的方法传过去
            int i =Convert.ToInt32(dataGridView1.CurrentRow.Cells["MHY_Jibei"].Value);

            H_SM_adminlevelSetupUpdate aaa = new H_SM_adminlevelSetupUpdate(i,aa);
            aaa.ffff += reset;
            aaa.ShowDialog();
        }

    
        private void H_SM_adminlevelSetup_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mem.GetAllMEMLEVEL().Tables[0];
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btupdate_Click(null,null);
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            MEMLEVEL ss = new MEMLEVEL();
            ss.MHY_Jibei = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MHY_Jibei"].Value);
            string aa= mem.ShowdeleteMEMLEVEL(ss);
            MessageBox.Show(aa);
            reset();
        }

        private void btfind_Click(object sender, EventArgs e)
        {

            if (txtinfo.Text.Trim()!="")
            {
                dataGridView1.DataSource = mem.selectMEMLEVEL(Convert.ToInt32(txtinfo.Text)).Tables[0];
            }
            else
            {
                reset();
            }
           
        }

    
    }
}