using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class HY_guanli
    {
        //会员编号
        private int hY_Id;

        public int HY_Id
        {
            get { return hY_Id; }
            set { hY_Id = value; }
        }


        //会员级别
        private int hY_Jibei;

        public int  HY_Jibei
        {
            get { return hY_Jibei; }
            set { hY_Jibei = value; }
        }


        //账户金额
        private double hY_ACOUNT;

        public double HY_ACOUNT 
        {
            get { return hY_ACOUNT; }
            set { hY_ACOUNT = value; }
        }


        //总消费额
        private double hY_ALLCOST;

        public double HY_ALLCOST
        {
            get { return hY_ALLCOST; }
            set { hY_ALLCOST = value; }
        }


        //消费次数
        private int  hY_COSTNUM;

        public int  HY_COSTNUM
        {
            get { return hY_COSTNUM; }
            set { hY_COSTNUM = value; }
        }




        //会员名称
        private string hY_Name;

        public string HY_Name
        {
            get { return hY_Name; }
            set { hY_Name = value; }
        }


        //会员密码
        private string hY_Password;

        public string HY_Password
        {
            get { return hY_Password; }
            set { hY_Password = value; }
        }



        //会员生日
        private DateTime hY_Shengri;

        public DateTime HY_Shengri
        {
            get { return hY_Shengri; }
            set { hY_Shengri = value; }
        }


        //会员积分
        private int hY_Jifen;

        public int HY_Jifen
        {
            get { return hY_Jifen; }
            set { hY_Jifen = value; }
        }


        //会员电话
        private string hY_Dianhua;

        public string HY_Dianhua
        {
            get { return hY_Dianhua; }
            set { hY_Dianhua = value; }
        }


        //会员加入日期
        private DateTime hY_Jiarutime;

        public DateTime HY_Jiarutime
        {
            get { return hY_Jiarutime; }
            set { hY_Jiarutime = value; }
        }

        //会员到期日期
        private DateTime hY_Daoqitime;

        public DateTime HY_Daoqitime
        {
            get { return hY_Daoqitime; }
            set { hY_Daoqitime = value; }
        }


        //会员状态
        private int hY_Zhuangtai;

        public int HY_Zhuangtai
        {
            get { return hY_Zhuangtai; }
            set { hY_Zhuangtai = value; }
        }



        //会员升级
        private int hY_Shengji;

        public int HY_Shengji
        {
            get { return hY_Shengji; }
            set { hY_Shengji = value; }
        }


        //会员备注
        private string hY_Beizhu;

        public string HY_Beizhu
        {
            get { return hY_Beizhu; }
            set { hY_Beizhu = value; }
        }

        //使用期限
        private string hY_SYQX;

        public string HY_SYQX
        {
            get { return hY_SYQX; }
            set { hY_SYQX = value; }
        }

    }
}
