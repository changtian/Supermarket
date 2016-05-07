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
    public partial class H_SMember_admin : Form
    {

        HY_guanliManager hgm = new HY_guanliManager();

        HY_mingxiManager hmm = new HY_mingxiManager();

        public H_SMember_admin()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            H_SM_adminAdd aaa = new H_SM_adminAdd();
           aaa.ddd += reset;
           aaa.ShowDialog();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btexit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            HY_guanli aa = new HY_guanli();
            aa.HY_Jibei = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HY_Jibei"].Value);
            aa.HY_Name = dataGridView1.CurrentRow.Cells["HY_Name"].Value.ToString();
            aa.HY_Password = dataGridView1.CurrentRow.Cells["HY_Password"].Value.ToString();
            aa.HY_Shengri = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HY_Shengri"].Value);
            aa.HY_Jifen = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HY_Jifen"].Value);
            aa.HY_Dianhua = dataGridView1.CurrentRow.Cells["HY_Dianhua"].Value.ToString();
            aa.HY_Jiarutime = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HY_Jiarutime"].Value);
            aa.HY_Daoqitime = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HY_Daoqitime"].Value);
            aa.HY_Zhuangtai = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HY_Zhuangtai"].Value);
            aa.HY_SYQX = dataGridView1.CurrentRow.Cells["HY_SYQX"].Value.ToString();
            aa.HY_Beizhu = dataGridView1.CurrentRow.Cells["HY_Beizhu"].Value.ToString();


            int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HY_Id"].Value);
            H_SM_adminUpdate aaa = new H_SM_adminUpdate(i, aa);
            aaa.ssss += reset;
            aaa.ShowDialog();
        }


        private void btclass_Click(object sender, EventArgs e)
        {
            H_SM_adminlevelSetup aaa = new H_SM_adminlevelSetup();
            aaa.ShowDialog();
        }

        private void H_SMember_admin_Load(object sender, EventArgs e)
        {
            reset();
        }


        //填充
        private void reset()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = hgm.GetAllHY_guanli().Tables[0];

            //dataGridView2.AutoGenerateColumns = false;
            //dataGridView2.DataSource = hmm.GetAllHY_mingxi().Tables[0];


           
        }



        //点击它，取它的第一行
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Text = dataGridView1.CurrentRow.Cells["HY_Name"].Value.ToString();
        }


        //dataGridView2的查询
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = hmm.SelectHY_mingxi(dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(dataGridView1.CurrentRow.Cells["HY_id"].Value)).Tables[0];
        }

        //双击弹出修改窗体
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btupdate_Click(null, null);
        }

        //删除判断------------有问题
        private void btdelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow==null)
            {
                return;
            }
            HY_guanli aa = new HY_guanli();
            aa.HY_Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HY_id"].Value.ToString());
            int i = hgm.deleteHY_guanli(aa);
            if (i > 0)
            {
                DialogResult aaaa = MessageBox.Show("确定删除吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (aaaa.Equals("Yes"))
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    return;
                }
            }
            reset();
        }

        //dataGridView1的查询
        private void btselect_Click(object sender, EventArgs e)
        {
            if (txtinfo.Text == "")
            {
                reset();
                return;
            }
            try
            {
                dataGridView1.DataSource = hgm.SelectAllHY_guanli(Convert.ToInt32(txtinfo.Text)).Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btout_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dataGridView1, "会员信息");
        }

   

    }
}