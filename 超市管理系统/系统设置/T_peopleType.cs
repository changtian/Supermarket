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
    public partial class T_peopleType : Form
    {
        public T_peopleType()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsure_Click(object sender, EventArgs e)
        {
            T_peopleAdd aaa = new T_peopleAdd();
            aaa.ShowDialog();
            this.Close();
        }

        private void T_peopleType_Load(object sender, EventArgs e)
        {

        }
    }
}