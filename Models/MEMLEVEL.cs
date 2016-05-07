using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class MEMLEVEL
    {
        //级别编号
        private int mHY_Jibei;

        public int MHY_Jibei
        {
            get { return mHY_Jibei; }
            set { mHY_Jibei = value; }
        }


        //级别名称
        private string mEMLEVEL_NAME;

        public string MEMLEVEL_NAME
        {
            get { return mEMLEVEL_NAME; }
            set { mEMLEVEL_NAME = value; }
        }

        //级别折扣
        private double mEMLEVEL_DISCOUNT;

        public double MEMLEVEL_DISCOUNT
        {
            get { return mEMLEVEL_DISCOUNT; }
            set { mEMLEVEL_DISCOUNT = value; }
        }


        //积分下限
        private   double   mEMLEVEL_LOWSCORE;

        public double MEMLEVEL_LOWSCORE
        {
            get { return mEMLEVEL_LOWSCORE; }
            set { mEMLEVEL_LOWSCORE = value; }
        }


        //积分上线
        private double mEMLEVEL_HIGHSCORE;

        public double MEMLEVEL_HIGHSCORE
        {
            get { return mEMLEVEL_HIGHSCORE; }
            set { mEMLEVEL_HIGHSCORE = value; }
        }


    }
}
