using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class XJ_yhang
    {
        private int xJ_ID;
        public int XJ_ID
        {
            get
            {
                return xJ_ID;
            }
            set
            {
                if (this.xJ_ID != value)
                    this.xJ_ID = value;
            }
        }

        private string xJ_name;
        public string XJ_name
        {
            get
            {
                return xJ_name;
            }
            set
            {
                if (this.xJ_name != value)
                    this.xJ_name = value;
            }
        }

        private double xJ_money;
        public double XJ_money
        {
            get
            {
                return xJ_money;
            }
            set
            {
                if (this.xJ_money != value)
                    this.xJ_money = value;
            }
        }

        private string xJ_beizhu;
        public string XJ_beizhu
        {
            get
            {
                return xJ_beizhu;
            }
            set
            {
                if (this.xJ_beizhu != value)
                    this.xJ_beizhu = value;
            }
        }


    }
}
