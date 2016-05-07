using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 超市管理系统.进货管理
{
    public partial class Saveselect_updatenum : Form
    {
        public Saveselect_updatenum()
        {
            InitializeComponent();
        }

        private void Saveselect_updatenum_Load(object sender, EventArgs e)
        {
            lbnum.Text = "";
            lbname.Text = "";
            lbcells.Text = "";
            lbtype.Text = "";
            lbsave.Text = "";
            lbcolor.Text = "";
            lbfactory.Text = "";
            lbremark.Text = "";


            Fill();
        }

        private void Fill()
        {
            //new实体，给它填充
            //lbnum.Text = ;
            //lbname.Text =;
            //lbcells.Text = ;
            //lbtype.Text =;
            //lbsave.Text =;
            //lbcolor.Text =;
            //lbfactory.Text =;
            //lbremark.Text =;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //直接把要改的作为参数传入
            //new一个对象，用来接收它
            string aa = "写上面";
            if (aa=="修改成功")
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}