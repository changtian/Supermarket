using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;

namespace 超市管理系统.进货管理
{
    public partial class IntoOldGoods : Form
    {
        public IntoOldGoods()
        {
            InitializeComponent();
        }
        int ckid;
        DataTable dtRight = null;
        DataTable dtlift = new DataTable();
        public IntoOldGoods(int id,DataTable dt)
        {
            ckid = id;
            dtRight = dt;
            InitializeComponent();
        }
        SP_typeManager smm = new SP_typeManager();
        SP_goodsManager sm = new SP_goodsManager();
        DataTable dt = new DataTable();


        private void button6_Click(object sender, EventArgs e)
        {
            dt.Clear();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvclear.SelectedRows.Count<=0)
            {
                return;
            }
            string sid = dgvclear.CurrentRow.Cells["Column1"].Value.ToString();

            IntoAllGoods aaa = new IntoAllGoods(sid);
            aaa.ShowDialog();
            if (aaa.Tag==null)
            {
                return;
            }
           int ck=Convert.ToInt32( aaa.Tag);

           if (ck==0)
           {
               return;
           }
            bool bHave = false;
            int i = 0;
            for (; i < dgvGood2.Rows.Count; i++)
            {
                if (dgvGood2.Rows[i].Cells["Column22"].Value.ToString() == sid)
                {
                    bHave = true;
                    break;
                }
            }

            if (bHave == true)
            {
                dgvGood2.Rows[i].Cells["Column26"].Value = Convert.ToInt32(dgvGood2.Rows[i].Cells["Column26"].Value) + ck;
                dgvGood2.Rows[i].Cells["Column27"].Value = (ck +Convert.ToInt32( dgvGood2.Rows[i].Cells["Column26"].Value)) * Convert.ToDouble(dgvGood2.Rows[i].Cells["Column25"].Value);
            }
            else
            {
                //往右边网格的数据源添加一行
                DataRow dr = dtRight.NewRow();
                dr["SP_gName"] = dgvclear.SelectedRows[0].Cells["Column2"].Value.ToString();
                dr["SP_gDanweiid"] = dgvclear.SelectedRows[0].Cells["Column3"].Value.ToString();
                dr["SP_gtiaoma"] = dgvclear.SelectedRows[0].Cells["Column1"].Value.ToString();
                dr["SP_gXinghao"] = dgvclear.SelectedRows[0].Cells["Column4"].Value.ToString();
                dr["goodsys"] = dgvclear.SelectedRows[0].Cells["Column5"].Value.ToString();
                dr["SP_gJijie"] = dgvclear.SelectedRows[0].Cells["Column6"].Value.ToString();
                dr["SP_gKucuenx"] = ck;
                dr["goodszje"] = ck * Convert.ToDouble(dgvclear.SelectedRows[0].Cells["Column6"].Value.ToString());
               
               
                dtRight.Rows.Add(dr);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntoNewGoods aaa = new IntoNewGoods(ckid);
            aaa.ShowDialog();
            IntoOldGoods_Load(null,null);

        }

        private void IntoOldGoods_Load(object sender, EventArgs e)
        {
            dgvGood2.DataSource = dtRight;
            SP_goods sg = new SP_goods();
            sg.SP_gTiaoma = "";
            sg.SP_gName = "";
            sg.CK_tID = Convert.ToInt32(ckid);
            dtlift = sm.select(sg).Tables[0];

            InitTreeView("0", tvtype.Nodes);
            tvtype.ExpandAll();//展开所有节点

            tvtype.ItemHeight = 20;

            dgvclear.DataSource = dtlift;
        }

        private void InitTreeView(string id, TreeNodeCollection tnc)
        {
            tnc.Clear();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SP_goods sg = new SP_goods();
            sg.SP_gTiaoma = textBox1.Text;
            sg.SP_gName = textBox1.Text;
            sg.CK_tID = Convert.ToInt32(ckid);
            DataSet ds = sm.select(sg);

            dgvclear.DataSource = ds.Tables[0];
        }

       

      

        private void tvtype_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SP_goods sg = new SP_goods();
            sg.SP_gType = Convert.ToInt32(e.Node.Tag);
            dgvtype.DataSource = sm.selecttype(sg);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvGood2.SelectedRows.Count <= 0)
            {
                return;
            }
            for (int i = 0; i < dgvGood2.Rows.Count; i++)
            {
                if (dgvGood2.Rows[i].Cells["Column22"].Value.ToString() == dgvGood2.CurrentRow.Cells["Column22"].Value.ToString())
                {

                    dtRight.Rows[i].Delete();
                }

            }
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvGood2.Rows.Count<=0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("是否加入采购单","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.No==dr)
            {
                return;
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvGood2.Rows.Count <= 0)
            {
                return;
            }
            int kc = Convert.ToInt32(dgvGood2.CurrentRow.Cells["Column26"].Value.ToString());
            string s = dgvGood2.CurrentRow.Cells["Column22"].Value.ToString();
            double q = Convert.ToDouble(dgvGood2.CurrentRow.Cells["Column25"].Value.ToString());
            B_updategoodsInfo ff = new B_updategoodsInfo(s, kc, q);
            ff.ShowDialog();
            if (ff.Tag== null)
            {
                return;
            }

            for (int i = 0; i < dgvGood2.Rows.Count; i++)
            {
                if (dgvGood2.Rows[i].Cells["Column22"].Value.ToString() == dgvGood2.CurrentRow.Cells["Column22"].Value.ToString())
                {
                    dtRight.Rows[i]["SP_gKucuenx"] = ff.Tag;
                    return;
                }

            }
        }

     

     

        private void dgvtype_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvtype.SelectedRows.Count <= 0)
            {
                return;
            }
            string sid = dgvtype.CurrentRow.Cells["Column8"].Value.ToString();

            IntoAllGoods aaa = new IntoAllGoods(sid);
            aaa.ShowDialog();
            int ck = Convert.ToInt32(aaa.Tag);
            if (ck == 0)
            {
                return;
            }

            bool bHave = false;
            int i = 0;
            for (; i < dgvGood2.Rows.Count; i++)
            {
                if (dgvGood2.Rows[i].Cells["Column22"].Value.ToString() == sid)
                {
                    bHave = true;
                    break;
                }
            }

            if (bHave == true)
            {
                dgvGood2.Rows[i].Cells["Column26"].Value = Convert.ToInt32(dgvGood2.Rows[i].Cells["Column26"].Value) + ck;
                dgvGood2.Rows[i].Cells["Column27"].Value = ck * Convert.ToDouble(dgvGood2.Rows[i].Cells["Column25"].Value);
            }
            else
            {
                //往右边网格的数据源添加一行
                DataRow dr = dtRight.NewRow();
                dr["SP_gName"] = dgvtype.SelectedRows[0].Cells["Column9"].Value.ToString();
                dr["SP_gDanweiid"] = dgvtype.SelectedRows[0].Cells["Column10"].Value.ToString();
                dr["SP_gtiaoma"] = dgvtype.SelectedRows[0].Cells["Column8"].Value.ToString();
                dr["SP_gXinghao"] = dgvtype.SelectedRows[0].Cells["Column12"].Value.ToString();
                dr["goodsys"] = "";
                dr["SP_gJijie"] = dgvtype.SelectedRows[0].Cells["Column11"].Value.ToString();
                dr["SP_gKucuenx"] = ck;
                dr["goodszje"] = ck * Convert.ToDouble(dgvtype.SelectedRows[0].Cells["Column11"].Value.ToString());


                dtRight.Rows.Add(dr);
            }
        }

        private void dgvclear_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button2_Click(null, null);
        }

        private void dgvGood2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button3_Click(null, null);
        }


        
    }
}