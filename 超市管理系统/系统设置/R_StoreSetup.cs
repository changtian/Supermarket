using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;
using System.Data.SqlClient;

namespace 超市管理系统.系统设置
{
    public partial class R_StoreSetup : Form
    {
        CK_tableManager ctm = new CK_tableManager();

        public R_StoreSetup()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            R_StoreSetupAdd aaa = new R_StoreSetupAdd();
            aaa.aaaaaa +=reset;
            aaa.ShowDialog();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            CK_table ss = new CK_table();
            ss.CK_tID =Convert.ToInt32(dataGridView1.CurrentRow.Cells["CK_tID"].Value.ToString());
            ss.CK_tName=dataGridView1.CurrentRow.Cells["CK_tName"].Value.ToString();
            ss.CK_tfuzren=dataGridView1.CurrentRow.Cells["CK_tfuzren"].Value.ToString();
            ss.CK_tDizhi=dataGridView1.CurrentRow.Cells["CK_tDizhi"].Value.ToString();
            ss.CK_tDianhua=dataGridView1.CurrentRow.Cells["CK_tDianhua"].Value.ToString();
            ss.CK_tBeizhu=dataGridView1.CurrentRow.Cells["CK_tBeizhu"].Value.ToString();
            ss.CK_tMoren =Convert.ToInt32(dataGridView1.CurrentRow.Cells["CK_tMoren"].Value.ToString());
            ss.CK_tPOS = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CK_tPOS"].Value.ToString());

            R_StoreSetupUpdate aaa = new R_StoreSetupUpdate(ss);
            aaa.fffffff += reset;
            aaa.ShowDialog();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void R_StoreSetup_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ctm.GetAllCK_table().Tables[0];
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btupdate_Click(null,null);
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult aaa = MessageBox.Show("确定删除吗？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (aaa.Equals(DialogResult.No))
            {
                return;
            }
            CK_table s = new CK_table();
            s.CK_tID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CK_tID"].Value.ToString());
            string aa=ctm.ShowGetDeleteCK_table(s);
            MessageBox.Show(aa);
            reset();
        }


        //有问题
        private void btfind_Click(object sender, EventArgs e)
        {
            R_StoreSetupFind aaa = new R_StoreSetupFind();
            //aaa.aaaaaaa +=reset;
            aaa.ShowDialog();
        //    Dictionary<string, string> ff = aaa.Tag as Dictionary<string, string>;
        //    dataGridView1.DataSource = ctm.GetFindCK_table(ff["1"],ff["2"],ff["3"],ff["4"]);
        }

        private void btall_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=ctm.GetAllCK_table().Tables[0];
        }

        private void btout_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dataGridView1, "仓库信息");
        }
    }
}