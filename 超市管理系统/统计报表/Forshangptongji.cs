using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Models;

namespace 超市管理系统.统计报表
{
    public partial class Forshangptongji : Form
    {
        public Forshangptongji()
        {
            InitializeComponent();
        }
        SP_typeManager smm = new SP_typeManager();
        DataTable dt = new DataTable();
        DataView dv2 = new DataView();
        DataView dv3 = new DataView();
        SP_goodsManager sm = new SP_goodsManager();
        private void Forshangptongji_Load(object sender, EventArgs e)
        {
            pltype.Visible = false;
            InitTreeView("0", tvtype.Nodes);
            dv2 = sm.cgtji().DefaultView;
            dv3 = sm.leibietj().DefaultView;
            tabControl1.TabPages.Remove(tabPage1);
        }
        private void InitTreeView(string id, TreeNodeCollection tnc)
        {
            dt = smm.type();

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["SP_tNid"].ToString() == id)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = dr["SP_tName"].ToString();
                    tn.Tag = dr["SP_tId"].ToString();
                    tnc.Add(tn);

                    //初始化当前节点下的子节点
                    InitTreeView(dr["SP_tId"].ToString(), tn.Nodes);
                }
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btexit1_Click(object sender, EventArgs e)
        {
            pltype.Visible = false;
        }

        private void btsure1_Click(object sender, EventArgs e)
        {
            txtspname.Text = tvtype.SelectedNode.Text;
            txtspname.Tag = tvtype.SelectedNode.Tag.ToString();
            pltype.Visible = false;
        }

        private void tvtype_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            txtspname.Text = tvtype.SelectedNode.Text;
            txtspname.Tag = tvtype.SelectedNode.Tag.ToString();
            pltype.Visible = false;
        }

        private void txtspname_MouseClick(object sender, MouseEventArgs e)
        {
            pltype.Visible = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntongji_Click(object sender, EventArgs e)
        {
            if (txtspname.Text.Trim() != "" && txtspname.Text.Trim()!="所有类别")
            {
                dv2.RowFilter = string.Format("SP_tName='{0}'", txtspname.Text.Trim());
                dv3.RowFilter = string.Format("SP_tName='{0}'", txtspname.Text.Trim());
            }
            if (txtspid.Text.Trim()!="")
            {
                dv2.RowFilter = string.Format("SP_gTiaoma='{0}' or SP_gName='{0}'", txtspid.Text.Trim());
            }
            dataGridView3.DataSource = dv3;

            dataGridView2.DataSource = dv2;
        }
    }
}