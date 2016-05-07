using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;

namespace 超市管理系统.统计报表
{
    public partial class Frofukuan : Form
    {
        public Frofukuan()
        {
            InitializeComponent();
        }
        double qiankuan;
        string ghs;
        string ghid;
        public Frofukuan(double qk,string gh,string ghsid)
        {
            ghid = ghsid;
            qiankuan = qk;
            ghs = gh;
            InitializeComponent();
        }
        CommonManager cm = new CommonManager();
        YG_xinxiManager ym = new YG_xinxiManager();
        XS_tbaleManager xm = new XS_tbaleManager();
        DH_tabelManager dm = new DH_tabelManager();

        

        private void btnquxiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frofukuan_Load(object sender, EventArgs e)
        {
            lbqmoney.Text = qiankuan.ToString();
            lbname.Text = ghs;
            txtmoney.Text = qiankuan.ToString();
            label10.Text = cm.GetNo("GF");
            cobname.ValueMember = "YG_xId";
            cobname.DisplayMember = "YG_xName";
            cobname.DataSource = ym.YG_xinxi().Tables[0];
            cobmtype.SelectedIndex = 0;

        }

        private void btnqueding_Click(object sender, EventArgs e)
        {

           DialogResult dr= MessageBox.Show("单据保存后不能被修改,是否确认保存");
           if (dr==DialogResult.No)
           {
               return;
           }
            if (true)
            {
                
            }
            XS_tbale xt = new XS_tbale();

            xt.XS_tDanhao = label10.Text;
            xt.XS_tJinbanren = Convert.ToInt32(cobname.SelectedValue);
            xt.XS_tKHname =Convert.ToInt32( ghid);
            xt.XS_tType = cobmtype.Text;
            xt.XS_tTime =Convert.ToDateTime( datime.Value);
            xt.XS_tBeizhu = txtshuom.Text;
            xt.DH_tSmoney = Convert.ToDouble(txtmoney.Text);
            xt.DH_tYmoney =Convert.ToDouble( lbqmoney.Text);
            
            if (dm.insertfukuan(xt)>0)
            {
                MessageBox.Show("新增成功");
            }

            this.Close();

        }
    }
}