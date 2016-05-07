using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class SP_xmingxi
    {
        //明细表ID
        private int sP_xID;

        public int SP_xID
        {
            get { return sP_xID; }
            set { sP_xID = value; }
        }

        //顾客分类
        private int sP_xType;

        public int SP_xType
        {
            get { return sP_xType; }
            set { sP_xType = value; }
        }

        //商品名称
        private int sP_xName;

        public int SP_xName
        {
            get { return sP_xName; }
            set { sP_xName = value; }
        }


        //商品单价
        private double sP_xDmoney;

        public double SP_xDmoney
        {
            get { return sP_xDmoney; }
            set { sP_xDmoney = value; }
        }

        //商品折扣
        private double sP_xSzhekou;

        public double SP_xSzhekou
        {
            get { return sP_xSzhekou; }
            set { sP_xSzhekou = value; }
        }

        //商品折扣
        private double sP_xGzhekou;

        public double SP_xGzhekou
        {
            get { return sP_xGzhekou; }
            set { sP_xGzhekou = value; }
        }

        //单项折扣
        private double sP_xDzhekou;

        public double SP_xDzhekou
        {
            get { return sP_xDzhekou; }
            set { sP_xDzhekou = value; }
        }


        //最终折扣
        private double sP_xZzhekou;

        public double SP_xZzhekou
        {
            get { return sP_xZzhekou; }
            set { sP_xZzhekou = value; }
        }


        //特价商品
        private string sP_xTejia;

        public string SP_xTejia
        {
            get { return sP_xTejia; }
            set { sP_xTejia = value; }
        }


        //顾客特价
        private double sP_xGtejia;

        public double SP_xGtejia
        {
            get { return sP_xGtejia; }
            set { sP_xGtejia = value; }
        }


        //最终单价
        private double sP_xZdanjia;

        public double SP_xZdanjia
        {
            get { return sP_xZdanjia; }
            set { sP_xZdanjia = value; }
        }


    }
}
