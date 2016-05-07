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
using 超市管理系统.系统设置;

namespace 超市管理系统.系统设置
{
    public partial class S_System : Form
    {
        SP_goodsManager sgm = new SP_goodsManager();


        public S_System()
        {
            InitializeComponent();
        }
        //关闭
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //增加
        private void button1_Click(object sender, EventArgs e)
        {
            进货管理.IntoNewGoods ff = new 超市管理系统.进货管理.IntoNewGoods();
            ff.ShowDialog();
        }


        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            SP_goods aa = new SP_goods();
            aa.SP_gId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SP_gId"].Value);
            aa.SP_gName = dataGridView1.CurrentRow.Cells["SP_gName"].Value.ToString();
            aa.SP_gTiaoma = dataGridView1.CurrentRow.Cells["SP_gTiaoma"].Value.ToString();
            aa.SP_gDanweiid = dataGridView1.CurrentRow.Cells["SP_gDanweiid"].Value.ToString();
            aa.SP_gXinghao = dataGridView1.CurrentRow.Cells["SP_gXinghao"].Value.ToString();
            aa.SP_gRiqi = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SP_gRiqi"].Value.ToString());
            aa.SP_gZhuangtai = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SP_gZhuangtai"].Value.ToString());
            aa.SP_gTjjiage = Convert.ToDouble(dataGridView1.CurrentRow.Cells["SP_gTjjiage"].Value.ToString());
            aa.SP_gKucuenx = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SP_gKucuenx"].Value.ToString());
            aa.SP_gJijie = Convert.ToDouble(dataGridView1.CurrentRow.Cells["SP_gJijie"].Value.ToString());
            aa.SP_gXijie = Convert.ToDouble(dataGridView1.CurrentRow.Cells["SP_gXijie"].Value.ToString());
            aa.SP_gZhekou = Convert.ToDouble(dataGridView1.CurrentRow.Cells["SP_gZhekou"].Value.ToString());
            aa.SP_gSchang = dataGridView1.CurrentRow.Cells["SP_gSchang"].Value.ToString();
            aa.SP_gBeizhi = dataGridView1.CurrentRow.Cells["SP_gBeizhi"].Value.ToString();
            aa.SP_gQiantime = dataGridView1.CurrentRow.Cells["SP_gQiantime"].Value.ToString();
            aa.SP_gHoutime = dataGridView1.CurrentRow.Cells["SP_gHoutime"].Value.ToString();
            aa.SP_gTejia = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SP_gTejia"].Value.ToString());
            aa.SP_gHueiyuan = Convert.ToDouble(dataGridView1.CurrentRow.Cells["SP_gHueiyuan"].Value.ToString());
            aa.SP_gJifen = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SP_gJifen"].Value.ToString());


            SP_type bb = new SP_type();
            bb.SP_tName = dataGridView1.CurrentRow.Cells["SP_tName"].Value.ToString();

            Yshe cc = new Yshe();
            cc.Y_Name = dataGridView1.CurrentRow.Cells["Y_Name"].Value.ToString();

            S_IntoUpdateGoods aaa = new S_IntoUpdateGoods(aa,bb,cc);
            aaa.gggggg += reset;
            aaa.ShowDialog();
        }

        //填充表格
        private void S_System_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = sgm.GetAllSP_goods().Tables[0];//填充的是数据集中的一张表
        }


        //编号查询
        private void bntfind_Click(object sender, EventArgs e)
        {
            if (txtnum.Text=="")
            {
                S_System_Load(null, null);
                return;
            }
            SP_goods aa = new SP_goods();
            aa.SP_gId = Convert.ToInt32(txtnum.Text);
            dataGridView1.DataSource = sgm.FindSP_goods(aa).Tables[0];
        }

        //删除  ----有问题   要同时删除2个表  
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult aa = MessageBox.Show("确定删除吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aa==DialogResult.No)
            {
                return;
            }
            SP_xmingxi cc = new SP_xmingxi();
            cc.SP_xID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SP_gId"].Value.ToString());
            dataGridView1.DataSource = sgm.DeleteSP_xmingxi(cc).Tables[0];
            SP_goods bb = new SP_goods();
            bb.SP_gId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SP_gId"].Value.ToString());
            dataGridView1.DataSource = sgm.DeleteSP_goods(bb).Tables[0];
            //S_System_Load(null, null);
        }

        //导出
        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
            S_System_Load(null, null);
            txtnum.Text = "";
        }


        //双击事件
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button2_Click(null,null);
        }
    }
}