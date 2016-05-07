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
    public partial class Y_stock : Form
    {
        XS_tbaleManager tm = new XS_tbaleManager();

        SP_goodsManager gm = new SP_goodsManager();

        public Y_stock()
        {
            InitializeComponent();
        }

        //单据表
        private void rbDJ_CheckedChanged(object sender, EventArgs e)
        {
            this.plfrist.Visible = true;
            this.plfrist.Dock = DockStyle.Fill;
            this.plsecond.Dock = DockStyle.None ;
            this.plthird.Dock = DockStyle.None ;
            this.plsecond.Visible = false;
            this.plthird.Visible = false;
        }

        //汇总表
        private void rbHZ_CheckedChanged(object sender, EventArgs e)
        {
            this.plsecond.Visible = true;
            this.plfrist.Dock = DockStyle.None;
            this.plsecond.Dock = DockStyle.Fill;
            this.plthird.Dock = DockStyle.None;
            this.plfrist.Visible = false;
            this.plthird.Visible = false;
        }

        //明细表
        private void rbMX_CheckedChanged(object sender, EventArgs e)
        {
            this.plthird.Visible = true;
            this.plfrist.Dock = DockStyle.None;
            this.plsecond.Dock = DockStyle.None;
            this.plthird.Dock = DockStyle.Fill;
            this.plfrist.Visible = false;
            this.plsecond.Visible = false;
        }

        //退出
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Load
        private void Y_stock_Load(object sender, EventArgs e)
        {
            rbDJ.Checked = true;

            lbbusiness2.Text = "";
            lbnum.Text = "";
            lbbusiness.Text = "";

            reset();

        }

        //填充
        private void reset()
        {
            //第一层
            dgbDJ1.AutoGenerateColumns = false;

            dgvDJ2.AutoGenerateColumns = false;


            //第二层
            dgvplsecond1.AutoGenerateColumns = false;


            dgvplsecond2.AutoGenerateColumns = false;


            //第三层
            dataGridView1.AutoGenerateColumns = false;
        }


      

        private void btnfind_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text.Equals(dateTimePicker2.Text))
            {
                MessageBox.Show("输入日期有误");
                return;
            }

            if (dateTimePicker1.Text==dateTimePicker2.Text && txtinfo.Text=="")
            {
                reset();
            }

            //第一层
            dgbDJ1.DataSource = tm.SelectAllXS_tbale(Convert.ToDateTime(dateTimePicker1.Value).ToString(), Convert.ToDateTime(dateTimePicker2.Value).ToString(), txtinfo.Text).Tables[0];
            
            //第二层----查不到东西
            dgvplsecond1.DataSource = gm.GetAllY_stock(txtinfo.Text).Tables[0];
        
            //第三层
            dataGridView1.DataSource=tm.Getthird(Convert.ToDateTime(dateTimePicker1.Value).ToString(), Convert.ToDateTime(dateTimePicker2.Value).ToString(), txtinfo.Text).Tables[0];


            //lbnum.Text = dgbDJ1.CurrentRow.Cells["XS_tDanhao"].Value.ToString();
            


            //lbbusiness2.Text = dgvplsecond1.CurrentRow.Cells["SP_gName"].Value.ToString();
            //dgvplsecond2.DataSource = tm.Getdgvplsecond2(lbbusiness2.Text);
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            string a = dateTimePicker1.Value.ToString();
            string b = dateTimePicker2.Value.ToString();
            Y_stockFind aaa = new Y_stockFind(a,b);
            aaa.ShowDialog();
            if (aaa.Tag==null)
            {
                return;
            }
            txtinfo.Text = aaa.Tag.ToString();
        }

        private void dgbDJ1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgbDJ1.Rows.Count == 0)
            {
                return;
            }
            try
            {
                lbnum.Text = dgbDJ1.CurrentRow.Cells["XS_tDanhao"].Value.ToString();
                dgvDJ2.DataSource = tm.SelectAllXS_tbale2(lbnum.Text).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btnbackgoods_Click(object sender, EventArgs e)
        {
            if (dgbDJ1.Rows.Count==0&&dgvDJ2.Rows.Count==0)
            {
                return;
            }
            DataTable dt = (DataTable)dgvDJ2.DataSource;
            string ghsname = dgbDJ1.CurrentRow.Cells["GH_sName"].Value.ToString();
            string id = dgbDJ1.CurrentRow.Cells["Column1"].Value.ToString();
            进货管理.B_return ff = new 超市管理系统.进货管理.B_return(dt, ghsname, id);
            ff.ShowDialog();
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dgbDJ1, "采购单据");
        }

    }
}