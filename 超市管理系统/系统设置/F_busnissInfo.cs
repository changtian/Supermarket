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
    public partial class F_busnissInfo : Form
    {
        GH_shangManager gsh = new GH_shangManager();

        public F_busnissInfo()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            B_addbusniss aaa = new B_addbusniss();
            aaa.aaaa += reset;
            aaa.ShowDialog();
        }

        private void btupdate_Click_1(object sender, EventArgs e)
        {
            GH_shang gg = new GH_shang();
            gg.GH_sName = dataGridView3.CurrentRow.Cells["GH_sName"].Value.ToString();
            gg.GH_sLianxiren = dataGridView3.CurrentRow.Cells["GH_sLianxiren"].Value.ToString();
            gg.GH_sDizhi = dataGridView3.CurrentRow.Cells["GH_sDizhi"].Value.ToString();
            gg.GH_sMoney =Convert.ToDouble(dataGridView3.CurrentRow.Cells["GH_sMoney"].Value);
            gg.GH_sDianhua = dataGridView3.CurrentRow.Cells["GH_sDianhua"].Value.ToString();
            gg.GH_sBeizhu = dataGridView3.CurrentRow.Cells["GH_sBeizhu"].Value.ToString();
            gg.GH_sMoren =Convert.ToInt32(dataGridView3.CurrentRow.Cells["GH_sMoren"].Value);


            int i = Convert.ToInt32(dataGridView3.CurrentRow.Cells["GH_sId"].Value);
            B_updatebusniss aaa = new B_updatebusniss(i, gg);
            aaa.ddd += reset;            //使用委托事件
            aaa.ShowDialog();

          
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btfind_Click(object sender, EventArgs e)
        {
            F_businessfind aaa = new F_businessfind();
            aaa.aaa += reset ;
            aaa.ShowDialog();
        }

     

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult aa = MessageBox.Show("确定要删除吗？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (aa==DialogResult.No)
            {
                return;
            }
            GH_shang dd = new GH_shang();
            dd.GH_sId = dataGridView3.CurrentRow.Cells["GH_sId"].Value.ToString();
            string ss = gsh.showdelete(dd);
            MessageBox.Show(ss);
            reset();
        }

        private void F_busnissInfo_Load(object sender, EventArgs e)
        {
            reset();

        }

        private void reset()
        {
            dataGridView3.AutoGenerateColumns = false;          //让它不出现多佘的项
            dataGridView3.DataSource = gsh.Gh_shang().Tables[0];         //它返回的是数据集，是其中的一张表
        }
        private void reset(GH_shang obj)
        {
            dataGridView3.AutoGenerateColumns = false;          //让它不出现多佘的项
            dataGridView3.DataSource = gsh.Gh_shang(obj).Tables[0];         //它返回的是数据集，是其中的一张表
        }
    
        private void dataGridView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btupdate_Click_1(null, null);
        }

        private void btall_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btinput_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dataGridView3, "供货商详情");
        }
    }
}