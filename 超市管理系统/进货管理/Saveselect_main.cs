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


namespace 超市管理系统.进货管理
{
    public partial class Saveselect_main : Form
    {
        CK_tableManager tm = new CK_tableManager();

        SP_goodsManager gm = new SP_goodsManager();

        SP_typeManager stm = new SP_typeManager();


        public Saveselect_main()
        {
            InitializeComponent();
        }


        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMX_Click(object sender, EventArgs e)
        {
            Saveselect_savelist aaa = new Saveselect_savelist(dataGridView1.CurrentRow.Cells["SP_gName1"].Value.ToString(), dataGridView1.CurrentRow.Cells["SP_gKucuen1"].Value.ToString(),dataGridView1.CurrentRow.Cells["SP_gXijie1"].Value.ToString());
            aaa.ShowDialog();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {

        }

        private void btOut_Click(object sender, EventArgs e)
        {
            CommonMethod.PrintExcel(dataGridView1,"当前库存状态");
        }

        ////高级查询
        //private void btBestFind_Click(object sender, EventArgs e)
        //{
        //    Saveselect_BestFind aaa = new Saveselect_BestFind();
        //    aaa.hhhh += reset;
          
        //    aaa.ShowDialog();
        //      Dictionary<string, string> d = aaa.Tag as Dictionary<string, string>;
        //      dataGridView1.DataSource = gm.GetFristBestFind(d["cK_tName"], Convert.ToInt32(d["aaaa"]), d["SP_gName"]).Tables[0];
        //}

        //查找全部
        private void btAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = gm.GetAlllFrist().Tables[0];
        }

        private void btjoinprice_Click(object sender, EventArgs e)
        {
            Saveselect_inorout aaa = new Saveselect_inorout();
            aaa.ShowDialog();
        }

        private void btExitGoods_Click(object sender, EventArgs e)
        {
            Saveselect_inorout aaa = new Saveselect_inorout();
            aaa.ShowDialog();
        }

        private void btCFKB_Click(object sender, EventArgs e)
        {

        }

        private void btUpdatePrice_Click(object sender, EventArgs e)
        {

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            reset();
        }

        //查看明细----面2
        private void btBestFind2_Click(object sender, EventArgs e)
        {

        }

        private void btexit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFind2_Click(object sender, EventArgs e)
        {

        }
        DataView dv = new DataView();
        private void Saveselect_main_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            cbosave.DisplayMember = "CK_tName";
            cbosave.ValueMember = "CK_tID";
            cbosave.DataSource=tm.GetAllCK_table().Tables[0];
            dv = gm.GetThird("","").Tables[0].DefaultView;
           
            reset();
        }

        private void reset()
        {

            dataGridView1.DataSource = gm.GetFrist(cbosave.Text,txttype.Text,txtnum.Text).Tables[0];
            tvtype.Nodes.Clear();
            treeView1.Nodes.Clear();
            DataTable dt=  stm.GetAllSP_type().Tables[0];
            InitTreeView("0",tvtype.Nodes,dt);
            InitTreeView("0",treeView1.Nodes,dt);
            tvtype.ExpandAll();
            tvtype.ItemHeight = 20;
            treeView1.ExpandAll();
            treeView1.ItemHeight = 20;

            //dataGridView3.DataSource = gm.GetThird(treeView1.SelectedNode.Text, txtgoodsselect.Text).Tables[0];
            //treeView1_AfterSelect(null, null);
        }

        private void InitTreeView(string SP_tId, TreeNodeCollection tnc,DataTable dt)
        {
           
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["SP_tNid"].ToString() == SP_tId)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = dr["SP_tName"].ToString();
                    tnc.Add(tn);

                    InitTreeView(dr["SP_tId"].ToString(), tn.Nodes,dt);
                }
            }
        }
        //private void InitTreeView(string SP_tId, TreeNodeCollection tnc)
        //{
        //    foreach (DataRow dr in stm.GetAllSP_type().Tables[0].Rows)
        //    {
        //        if (dr["SP_tNid"].ToString() == SP_tId)
        //        {
        //            TreeNode tn = new TreeNode();
        //            tn.Text = dr["SP_tName"].ToString();
        //            tnc.Add(tn);

        //            //初始化当前节点下的子节点
        //            InitTreeView(dr["SP_tId"].ToString(), tn.Nodes);
        //        }
        //    }
        //}


        private void btpanelexit_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btsure_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            tvtype_MouseDoubleClick(null, null);
        }


        private void tvtype_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txttype.Text = tvtype.SelectedNode.Text;
                panel1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void txttype_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = true;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridView3.DataSource = gm.GetThird(treeView1.SelectedNode.Text,txtgoodsselect.Text).Tables[0];
        }

        private void txtgoodsselect_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format(" SP_gName like '%{0}%' or SP_gTiaoma like '%{0}%'", txtgoodsselect.Text);
            dataGridView3.DataSource = dv;
        }
    }
}