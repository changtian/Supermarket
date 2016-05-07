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
    public partial class D_CustomerInfo : Form
    {
        KH_xinxiManager hxm = new KH_xinxiManager();

        public D_CustomerInfo()
        {
            InitializeComponent();
        }

        private void D_CustomerInfo_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = hxm.GetAllKH_xinxi().Tables[0];
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            D_CustomerInfo_add aaa = new D_CustomerInfo_add();
            aaa.wwwwwwwwwww += reset;
            aaa.ShowDialog();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            KH_xinxi ss = new KH_xinxi();
            ss.KH_xId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KH_xId"].Value.ToString());
            ss.KH_xName = dataGridView1.CurrentRow.Cells["KH_xName"].Value.ToString();
            ss.KH_xBeizhu = dataGridView1.CurrentRow.Cells["KH_xBeizhu"].Value.ToString();
            ss.KH_xDianhua = dataGridView1.CurrentRow.Cells["KH_xDianhua"].Value.ToString();
            ss.KH_xDizhi = dataGridView1.CurrentRow.Cells["KH_xDizhi"].Value.ToString();
            ss.KH_xlianxiren = dataGridView1.CurrentRow.Cells["KH_xlianxiren"].Value.ToString();
            ss.KH_xMoney = Convert.ToDouble(dataGridView1.CurrentRow.Cells["KH_xMoney"].Value.ToString());
            ss.KH_xMoren = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KH_xMoren"].Value.ToString());

            D_CustomerInfo_update aaa = new D_CustomerInfo_update(ss);
            aaa.wwwwwwwwww += reset;
            aaa.ShowDialog();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult aa = MessageBox.Show("确定要删除吗？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (aa.Equals(DialogResult.No))
            {
                return;
            }
            KH_xinxi ss = new KH_xinxi();
            ss.KH_xId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KH_xId"].Value.ToString());
            int i = hxm.GetDeleteKH_xinxi(ss);
            if (i>0)
            {
                reset();
            }
        }

        private void btfind_Click(object sender, EventArgs e)
        {
            D_CustomerInfo_find aaa = new D_CustomerInfo_find();
            aaa.ShowDialog();
        }

        private void btshowAll_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btout_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dataGridView1, "客户信息");
        }
    }
}