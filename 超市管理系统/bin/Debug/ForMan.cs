using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using System.Diagnostics;

namespace 超市管理系统
{
    public partial class ForMan : Form
    {
        public ForMan()
        {
            InitializeComponent();
        }
        string sname;
        public ForMan(string name)
        {
            sname = name;
            InitializeComponent();
        }

        private void ForMan_Load(object sender, EventArgs e)
        {
            //最大化窗口
            panjinhuo.Dock = DockStyle.Fill;
            panxiaoshou.Dock = DockStyle.Fill;
            pankucuen.Dock = DockStyle.Fill;
            pantongji.Dock = DockStyle.Fill;
            panrichang.Dock = DockStyle.Fill;
            panxitong.Dock = DockStyle.Fill;
            //隐藏显示窗口
            panjinhuo.Visible = true;
            panxiaoshou.Visible = false;
            pankucuen.Visible = false;
            pantongji.Visible = false;
            panrichang.Visible = false;
            panxitong.Visible = false;

            toolname.Text = "操作员: "+sname;
            
        }
        #region 左边按钮
        
        
        private void btnjinhuo_Click(object sender, EventArgs e)
        {
            btnand(1);
        }

        private void btnxiaoshou_Click(object sender, EventArgs e)
        {
            btnand(2);
        }
       
        #region rightbtn
        /// <summary>
        /// 左边按钮点击
        /// </summary>
        /// <param name="a"></param>
        public void btnand(int a)
        {
            switch (a)
            {
                case 1:
                    panjinhuo.Visible = true;
                    panxiaoshou.Visible = false;
                    pankucuen.Visible = false;
                    pantongji.Visible = false;
                    panrichang.Visible = false;
                    panxitong.Visible = false;
                    break;
                case 2:
                    panjinhuo.Visible = false;
                    panxiaoshou.Visible = true;
                    pankucuen.Visible = false;
                    pantongji.Visible = false;
                    panrichang.Visible = false;
                    panxitong.Visible = false;
                    break;
                case 3:
                    panjinhuo.Visible = false;
                    panxiaoshou.Visible = false;
                    pankucuen.Visible = true;
                    pantongji.Visible = false;
                    panrichang.Visible = false;
                    panxitong.Visible = false;
                    break;
                case 4:
                    panjinhuo.Visible = false;
                    panxiaoshou.Visible = false;
                    pankucuen.Visible = false;
                    pantongji.Visible = true;
                    panrichang.Visible = false;
                    panxitong.Visible = false;
                    break;
                case 5:
                    panjinhuo.Visible = false;
                    panxiaoshou.Visible = false;
                    pankucuen.Visible = false;
                    pantongji.Visible = false;
                    panrichang.Visible = true;
                    panxitong.Visible = false;
                    break;
                case 6:
                    panjinhuo.Visible = false;
                    panxiaoshou.Visible = false;
                    pankucuen.Visible = false;
                    pantongji.Visible = false;
                    panrichang.Visible = false;
                    panxitong.Visible = true;
                    break;
            }
        }
        #endregion

        private void btnkucuen_Click(object sender, EventArgs e)
        {
            btnand(3);
        }

        private void btntongji_Click(object sender, EventArgs e)
        {
            btnand(4);
        }

        private void btnrichang_Click(object sender, EventArgs e)
        {
            btnand(5);
        }

        private void btnxitong_Click(object sender, EventArgs e)
        {
            btnand(6);
        }
        #endregion
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntueichutop_Click(object sender, EventArgs e)
        {
            DialogResult ff = MessageBox.Show("是否退出该系统", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ff==DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

       

        private void btnhuanbantop_Click(object sender, EventArgs e)
        {
            ForDengl1 ff = new ForDengl1();
            ff.ShowDialog();
            this.Close();
        }

        private void btntjgys_Click(object sender, EventArgs e)
        {
            统计报表.Frogonghuos ff = new 超市管理系统.统计报表.Frogonghuos();
            ff.ShowDialog();
        }

        #region 上排按钮
            
        
        private void MouseEen(Button name)
        {
            name.Location = new Point(name.Location.X - 2, name.Location.Y - 2);
        }
        private void MouseLeav(Button name)
        {
            name.Location = new Point(name.Location.X + 2, name.Location.Y + 2);
        }
        private void btnhuanbantop_MouseEnter(object sender, EventArgs e)
        {
            MouseEen(btnhuanbantop);
        }
        private void btnhuanbantop_MouseLeave(object sender, EventArgs e)
        {
            MouseLeav(btnhuanbantop);
        }

        private void btndanjutop_MouseEnter(object sender, EventArgs e)
        {
            MouseEen(btndanjutop);
        }

        private void btndanjutop_MouseLeave(object sender, EventArgs e)
        {
            MouseLeav(btndanjutop);
        }

      

        private void btnkucuentop_MouseEnter(object sender, EventArgs e)
        {
            MouseEen(btnkucuentop);
        }

        private void btnkucuentop_MouseLeave(object sender, EventArgs e)
        {
            MouseLeav(btnkucuentop);
        }

     

        private void btnruanjiantop_MouseEnter(object sender, EventArgs e)
        {
            MouseEen(btnruanjiantop);
        }

        private void btnruanjiantop_MouseLeave(object sender, EventArgs e)
        {
            MouseLeav(btnruanjiantop);
        }

        private void btntueichutop_MouseEnter(object sender, EventArgs e)
        {
            MouseEen(btntueichutop);
        }

        private void btntueichutop_MouseLeave(object sender, EventArgs e)
        {
            MouseLeav(btntueichutop);
        }
        #endregion

        private void btntjkc_Click(object sender, EventArgs e)
        {
            统计报表.Forkcuencben ff = new 超市管理系统.统计报表.Forkcuencben();
            ff.ShowDialog();
        }

        private void btnxszhangwu_Click(object sender, EventArgs e)
        {
            统计报表.Frogonghuos ff = new 超市管理系统.统计报表.Frogonghuos();
            ff.ShowDialog();
        }

        private void btntjkcbd_Click(object sender, EventArgs e)
        {
            统计报表.Forbiandong ff = new 超市管理系统.统计报表.Forbiandong();
            ff.ShowDialog();
        }

        private void btntjcg_Click(object sender, EventArgs e)
        {
            统计报表.Forshangptongji ff = new 超市管理系统.统计报表.Forshangptongji();
            ff.ShowDialog();
        }

        private void btntjywy_Click(object sender, EventArgs e)
        {
            统计报表.Forywyuan ff = new 超市管理系统.统计报表.Forywyuan();
            ff.ShowDialog();
        }

        private void btntjkhu_Click(object sender, EventArgs e)
        {
            统计报表.ForKhuxiaoshou ff = new 超市管理系统.统计报表.ForKhuxiaoshou();
            ff.ShowDialog();
        }

        private void btntjywyxs_Click(object sender, EventArgs e)
        {
            统计报表.Forywyuanxs ff = new 超市管理系统.统计报表.Forywyuanxs();
            ff.ShowDialog();
        }

        private void btntjph_Click(object sender, EventArgs e)
        {
            统计报表.ForPhang ff = new 超市管理系统.统计报表.ForPhang();
            ff.ShowDialog();
        }

        private void btncaigou_Click(object sender, EventArgs e)
        {
            进货管理.GoodsInto ff = new 超市管理系统.进货管理.GoodsInto();
            ff.ShowDialog();
        }

        private void btntueihuo_Click(object sender, EventArgs e)
        {
            进货管理.B_return ff = new 超市管理系统.进货管理.B_return();
            ff.ShowDialog();
        }

        private void btnzhangwu_Click(object sender, EventArgs e)
        {
            统计报表.Frogonghuos ff = new 超市管理系统.统计报表.Frogonghuos();
            ff.ShowDialog();
        }

    

        private void btnspxiaoshou_Click(object sender, EventArgs e)
        {
            销售管理.FrmSPxiaoshou ff = new 超市管理系统.销售管理.FrmSPxiaoshou();
            ff.ShowDialog();
        }

        private void btnxtsp_Click(object sender, EventArgs e)
        {
            系统设置.S_System ff = new 超市管理系统.系统设置.S_System();
            ff.ShowDialog();
        }

        private void btnxtghs_Click(object sender, EventArgs e)
        {
            系统设置.F_busnissInfo ff = new 超市管理系统.系统设置.F_busnissInfo();
            ff.ShowDialog();
        }

        private void btnxtczy_Click(object sender, EventArgs e)
        {
            系统设置.T_people ff = new 超市管理系统.系统设置.T_people();
            ff.ShowDialog();
        }

        private void btnxthy_Click(object sender, EventArgs e)
        {
            系统设置.H_SMember_admin ff = new 超市管理系统.系统设置.H_SMember_admin();
            ff.ShowDialog();
        }

        private void btnkcdiaobo_Click(object sender, EventArgs e)
        {
            库存管理.kdiao ff = new 超市管理系统.库存管理.kdiao();
            ff.ShowDialog();
        }

        private void btnkccfkb_Click(object sender, EventArgs e)
        {
            进货管理.Saveselect_main ff = new 超市管理系统.进货管理.Saveselect_main();
            ff.ShowDialog();
        }

        private void btnkcbsby_Click(object sender, EventArgs e)
        {
            库存管理.kbao ff = new 超市管理系统.库存管理.kbao();
            ff.ShowDialog();
        }

        private void btnkcpandian_Click(object sender, EventArgs e)
        {
            库存管理.kpan ff = new 超市管理系统.库存管理.kpan();
            ff.ShowDialog();
        }

        private void btnkcbiandong_Click(object sender, EventArgs e)
        {
            库存管理.kbian ff = new 超市管理系统.库存管理.kbian();
            ff.ShowDialog();
        }

        private void btnkcuenbaojin_Click(object sender, EventArgs e)
        {
            库存管理.kjien ff = new 超市管理系统.库存管理.kjien();
        }

        private void btngktueihuo_Click(object sender, EventArgs e)
        {
            进货管理.B_return ff = new 超市管理系统.进货管理.B_return("顾客退货");
            ff.ShowDialog();
        }

        #region 左边的按钮
        
     

        private void btnjinhuo_MouseLeave(object sender, EventArgs e)
        {
            MouseLeav(btnjinhuo);
        }

        private void btnjinhuo_MouseEnter(object sender, EventArgs e)
        {
            MouseEen(btnjinhuo);
        }

        private void btnxiaoshou_MouseEnter(object sender, EventArgs e)
        {
            MouseEen(btnxiaoshou);
        }

        private void btnxiaoshou_MouseLeave(object sender, EventArgs e)
        {
            MouseLeav(btnxiaoshou);
        }

        private void btnkucuen_MouseEnter(object sender, EventArgs e)
        {
            MouseEen(btnkucuen);
        }

        private void btnkucuen_MouseLeave(object sender, EventArgs e)
        {
            MouseLeav(btnkucuen);
        }

        private void btntongji_MouseEnter(object sender, EventArgs e)
        {
            MouseEen(btntongji);
        }

        private void btntongji_MouseLeave(object sender, EventArgs e)
        {
            MouseLeav(btntongji);
        }

        private void btnrichang_MouseEnter(object sender, EventArgs e)
        {
            MouseEen(btnrichang);
        }

        private void btnrichang_MouseLeave(object sender, EventArgs e)
        {
            MouseLeav(btnrichang);
        }

        private void btnxitong_MouseEnter(object sender, EventArgs e)
        {
            MouseEen(btnxitong);
        }

        private void btnxitong_MouseLeave(object sender, EventArgs e)
        {
            MouseLeav(btnxitong);
        }

        #endregion

        private void btnruanjiantop_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"file:///D:/S2/项目文档/美萍超市管理系统(超市销售管理软件,超市库存管理系统,超市收银系统).htm");

        }

        private void btncaigoudj_Click(object sender, EventArgs e)
        {
            进货管理.Y_stock ff = new 超市管理系统.进货管理.Y_stock();

            ff.ShowDialog();
        }

        private void btnrcgys_Click(object sender, EventArgs e)
        {
            日常管理.jgo ff = new 超市管理系统.日常管理.jgo();
            ff.ShowDialog();
        }

        private void btndangqiankc_Click(object sender, EventArgs e)
        {
            进货管理.Saveselect_main ff = new 超市管理系统.进货管理.Saveselect_main();
            ff.ShowDialog();
        }

        private void btnxtck_Click(object sender, EventArgs e)
        {
            系统设置.R_StoreSetup ff = new 超市管理系统.系统设置.R_StoreSetup();
            ff.ShowDialog();
        }

        private void btnxtkh_Click(object sender, EventArgs e)
        {
            系统设置.D_CustomerInfo ff = new 超市管理系统.系统设置.D_CustomerInfo();

            ff.ShowDialog();
        }

        private void btnxtyg_Click(object sender, EventArgs e)
        {
            系统设置.E_EmployeeInfo ff = new 超市管理系统.系统设置.E_EmployeeInfo();
            ff.ShowDialog();
        }

        private void btncangku_Click(object sender, EventArgs e)
        {
            进货管理.Saveselect_main ff = new 超市管理系统.进货管理.Saveselect_main();
            ff.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            进货管理.Saveselect_main ff = new 超市管理系统.进货管理.Saveselect_main();
            ff.ShowDialog();
        }

        private void btnxskcuen_Click(object sender, EventArgs e)
        {
            进货管理.Saveselect_main ff = new 超市管理系统.进货管理.Saveselect_main();
            ff.ShowDialog();
        }

        private void btnkccangk_Click(object sender, EventArgs e)
        {
            进货管理.Saveselect_main ff = new 超市管理系统.进货管理.Saveselect_main();
            ff.ShowDialog();
        }

        private void btntjck_Click(object sender, EventArgs e)
        {
            进货管理.Saveselect_main ff = new 超市管理系统.进货管理.Saveselect_main();
            ff.ShowDialog();
        }

        private void btnrcck_Click(object sender, EventArgs e)
        {
            进货管理.Saveselect_main ff = new 超市管理系统.进货管理.Saveselect_main();
            ff.ShowDialog();
        }

        private void btndanjutop_Click(object sender, EventArgs e)
        {

            统计报表.ForKhuxiaoshou ff = new 超市管理系统.统计报表.ForKhuxiaoshou();
            ff.ShowDialog();
        }

        private void btnkucuentop_Click(object sender, EventArgs e)
        {
             进货管理.Saveselect_main ff = new 超市管理系统.进货管理.Saveselect_main();
            ff.ShowDialog();
        }

        private void btnrckh_Click(object sender, EventArgs e)
        {
            日常管理.jkehu ff = new 超市管理系统.日常管理.jkehu();
            ff.ShowDialog();
        }

        private void btnrccw_Click(object sender, EventArgs e)
        {
            日常管理.jbaobiao ff = new 超市管理系统.日常管理.jbaobiao();
            ff.ShowDialog();
        }
        }
    }
