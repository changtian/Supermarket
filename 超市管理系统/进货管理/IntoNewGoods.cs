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
    public partial class IntoNewGoods : Form
    {
        int s;
        public IntoNewGoods()
        {
            InitializeComponent();
        }
        public IntoNewGoods(int w)
        {
            this.s = w;
            InitializeComponent();
        }
        SP_goodsManager sm = new SP_goodsManager();
        SP_typeManager smm = new SP_typeManager();
        DataTable dt = new DataTable();
        YsheManager ym = new YsheManager();
        CommonManager cm = new CommonManager();
        
        private void button2_Click(object sender, EventArgs e)
        {
            IntoNewGoodsSellPrice aaa = new IntoNewGoodsSellPrice();
            aaa.ShowDialog();
        }

        private void btexit1_Click(object sender, EventArgs e)
        {
            pltype.Visible = false;
        }

        private void IntoNewGoods_Load(object sender, EventArgs e)
        {
            pltype.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pltype.Visible = true;
        }



        private void IntoNewGoods_Load_1(object sender, EventArgs e)
        {
            pltype.Visible = false;
            txtnum.Text = cm.GoodsID("");
            tvtype.Nodes.Clear();
            InitTreeView("0", tvtype.Nodes);
            cbocolor.ValueMember = "Y_Id";
            cbocolor.DisplayMember = "Y_Name";
            cbocolor.DataSource = ym.add();
            rbstate.Checked = true;
            txtscores.Enabled = false;
            dtpday1.Enabled = false;
            dtpday2.Enabled = false;
            txtday.Enabled = false;
            tvtype.ExpandAll();//展开所有节点

            tvtype.ItemHeight = 20;


            tabControl1.TabPages.Remove(tabPage2);
            qingkongshuju();

        }
        private void qingkongshuju()
        {
            txttype.Text = "";
            txtname.Text = "";
            txtreserve.Text = "";
            txtsavelimit.Text = "0";
            txtbzq.Text = "";
            txtday.Text = "";
            txtremark.Text = "";
            txtdiscount.Text = "";
            txtscores.Text = "";
            txtsize.Text = "";
            txtxiaojia.Text = "";
            txtfactory.Text = "";
            txtspcialsprice.Text = "";

            txtmember.Text = "";
            cbxday.Checked = false;
            cbxprice.Checked = false;
            cbospcialdata.Checked = false;
            

            
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pltype.Visible == false)
            {
                pltype.Visible = true;
            }
            else
            {
                pltype.Visible = false;
            }
            
        }


        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btsure_Click(object sender, EventArgs e)
        {
            if (txttype.Text=="")
            {
                MessageBox.Show("请选择商品类型");
                txttype.Focus();
                return;
            }
            if (txtname.Text == "")
            {
                MessageBox.Show("请输入商品名称");
                txtname.Focus();
                return;

            }
            if (cbocell.Text == "")
            {
                MessageBox.Show("请选择商品单位");
                cbocell.Focus();
                return;
            }
            if (cbocolor.Text == "")
            {
                MessageBox.Show("请选择商品颜色");
                cbocolor.Focus();
                return;
            }
            if (txtbzq.Text == "")
            {
                MessageBox.Show("请输入商品进价");
                txtbzq.Focus();
                return;

            }
            if (txtxiaojia.Text == "")
            {
                MessageBox.Show("请输入商品售价");
                txtxiaojia.Focus();
                return;
            }
            if (txtdiscount.Text == "")
            {
                MessageBox.Show("请输入商品折扣");
                txtdiscount.Focus();
                return;
            }
            if (cbocolor.Text == "")
            {
                MessageBox.Show("请选择商品颜色");
                cbocolor.Focus();
                return;
            }
            int j = 0;
            try
            {
                SP_goods sg = new SP_goods();
                sg.CK_tID = s;
                sg.SP_gName = txtname.Text;
                sg.SP_gType = Convert.ToInt32(txttype.Tag);
                sg.SP_gTiaoma = txtnum.Text;
                sg.SP_gXinghao = txtreserve.Text;
                sg.SP_gDanweiid = cbocell.Text;
                sg.SP_gKucuenx = Convert.ToInt32(txtsavelimit.Text);
                sg.SP_gYid = Convert.ToInt32(cbocolor.SelectedValue);
                sg.SP_gJijie = Convert.ToDouble(txtbzq.Text);
                sg.SP_gXijie = Convert.ToDouble(txtxiaojia.Text);
                if (cbxday.Checked == true)
                {
                    sg.SP_gRiqi = Convert.ToInt32(txtday.Text);
                }

                sg.SP_gSchang = txtfactory.Text;
                sg.SP_gBeizhi = txtremark.Text;
                sg.SP_gZhekou = Convert.ToDouble(txtdiscount.Text);
                if (cbxpresent.Checked == true)
                {
                    sg.SP_gZengping = 1;
                }
                else
                {

                    sg.SP_gZengping = 0;
                }
                if (cbxpresent.Checked == true)
                {
                    sg.SP_gJifen = Convert.ToInt32(txtscores.Text);
                }

                if (cbxprice.Checked == true)
                {
                    sg.SP_gTejia = 1;
                    sg.SP_gTjjiage = Convert.ToDouble(txtspcialsprice.Text);
                    sg.SP_gHueiyuan = Convert.ToDouble(txtmember.Text);
                }
                else
                {
                    sg.SP_gTejia = 0;
                }


                if (cbospcialdata.Checked == true)
                {
                    sg.SP_gQiantime = dtpday1.Value.ToString("yyyy/MM/dd");
                    sg.SP_gHoutime = dtpday2.Value.ToString("yyyy/MM/dd");
                }
                if (rbstate.Checked == true)
                {
                    sg.SP_gZhuangtai = 1;
                }
                else
                {
                    sg.SP_gZhuangtai = 0;
                }
                j = sm.insert(sg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            if (j>0)
            {
                MessageBox.Show("新增成功");
                if (cbaddgoods.Checked == false)
                {
                    this.Close();
                }
                else
                {
                    IntoNewGoods_Load_1(null, null);
                }

            }
            else
            {
                MessageBox.Show("新增失败");

            }
            
           
        }

        private void btsure1_Click(object sender, EventArgs e)
        {
            txttype.Text = tvtype.SelectedNode.Text;
            txttype.Tag = tvtype.SelectedNode.Tag.ToString();
            pltype.Visible = false;
        }

        private void cbxpresent_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxpresent.Checked==true)
            {
                txtscores.Enabled = true;
            }
            else
            {
                txtscores.Enabled = false;
            }
        }

        private void cbospcialdata_CheckedChanged(object sender, EventArgs e)
        {
            if (cbospcialdata.Checked == true)
            {
                dtpday1.Enabled = true;
                dtpday2.Enabled = true;
            }
            else
            {
                dtpday1.Enabled = false;
                dtpday2.Enabled = false;
            }
        }

        private void cbxday_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxday.Checked == true)
            {
                txtday.Enabled = true;
            }
            else
            {
                txtday.Enabled = false;
            }
        }

        private void cbxprice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxprice.Checked == true)
            {
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.TabIndex = 1;
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage2);
            }
        }

        private void tvtype_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txttype.Text = tvtype.SelectedNode.Text;
            txttype.Tag = tvtype.SelectedNode.Tag.ToString();
            pltype.Visible = false;
        }

     

     

     
  
       
    }
}