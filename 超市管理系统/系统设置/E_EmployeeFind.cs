using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Models;
using BLL;

namespace 超市管理系统.系统设置
{
    public partial class E_EmployeeFind : Form
    {
        YG_xinxiManager yxm = new YG_xinxiManager();

        public delegate void delrrrrrrrrrrr(YG_xinxi aa);
        public event delrrrrrrrrrrr rrrrrrrrr;

        public E_EmployeeFind()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            YG_xinxi aa = new YG_xinxi();
            aa.YG_xName = txtname.Text;
            aa.YG_xDianhua = txtname.Text;
            aa.YG_xBeizhu = txtname.Text;
            aa.YG_xZhiwu = txtwork.Text;
            rrrrrrrrr(aa);
        }

        private void E_EmployeeFind_Load(object sender, EventArgs e)
        {

        }
    }
}