using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Models;
using BLL;

namespace 超市管理系统.系统设置
{
    public partial class E_EmployeeInfo : Form
    {
        YG_xinxiManager yxm = new YG_xinxiManager();

        public E_EmployeeInfo()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            E_EmployeeAdd aaa = new E_EmployeeAdd();
            aaa.jjjjjjjj += reset;
            aaa.ShowDialog();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            YG_xinxi ff = new YG_xinxi();
            ff.YG_xId =Convert.ToInt32(dataGridView1.CurrentRow.Cells["YG_xId"].Value.ToString());
            ff.YG_xName = dataGridView1.CurrentRow.Cells["YG_xName"].Value.ToString();
            ff.YG_xDianhua = dataGridView1.CurrentRow.Cells["YG_xDianhua"].Value.ToString();
            ff.YG_xDizhi = dataGridView1.CurrentRow.Cells["YG_xDizhi"].Value.ToString();
            ff.YG_xZhiwu = dataGridView1.CurrentRow.Cells["YG_xZhiwu"].Value.ToString();
            ff.YG_xBeizhu = dataGridView1.CurrentRow.Cells["YG_xBeizhu"].Value.ToString();
            ff.YG_xCaigou = Convert.ToInt32(dataGridView1.CurrentRow.Cells["YG_xCaigou"].Value.ToString());
            ff.YG_xkucuen = Convert.ToInt32(dataGridView1.CurrentRow.Cells["YG_xkucuen"].Value.ToString());
            ff.YG_xXiaoshou = Convert.ToInt32(dataGridView1.CurrentRow.Cells["YG_xXiaoshou"].Value.ToString());

            E_EmployeeUpdate aaa = new E_EmployeeUpdate(ff);
            aaa.dddddddddddd += reset;
            aaa.ShowDialog();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btfind_Click(object sender, EventArgs e)
        {
            E_EmployeeFind aaa = new E_EmployeeFind();
            //aaa.rrrrrrrrr += reset;
            aaa.ShowDialog();
        }

        private void E_EmployeeInfo_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = yxm.GetFillYG_xinxi().Tables[0];
        }

        private void btall_Click(object sender, EventArgs e)
        {
            E_EmployeeInfo_Load(null, null);
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult ddd = MessageBox.Show("确定要删除吗？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (ddd.Equals(DialogResult.No))
            {
                return;
            }
            YG_xinxi ee = new YG_xinxi();
            ee.YG_xId=Convert.ToInt32(dataGridView1.CurrentRow.Cells["YG_xId"].Value.ToString());
            int ss = yxm.GetDeleteYG_xinxi(ee);
            if (ss>0)
            {
                MessageBox.Show("删除成功");
                reset();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btupdate_Click(null,null);
        }

        private void btout_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dataGridView1, "员工信息");
        }
    }
}