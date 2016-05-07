using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class CW_guding
    {
        private int cW_gId;
        public int CW_gId
        {
            get
            {
                return cW_gId;
            }
            set
            {
                if (this.cW_gId != value)
                    this.cW_gId = value;
            }
        }

        private DateTime cW_gtime;
        public DateTime CW_gtime
        {
            get
            {
                return cW_gtime;
            }
            set
            {
                if (this.cW_gtime != value)
                    this.cW_gtime = value;
            }
        }

        private string cW_gtype;
        public string CW_gtype
        {
            get
            {
                return cW_gtype;
            }
            set
            {
                if (this.cW_gtype != value)
                    this.cW_gtype = value;
            }
        }

        private double cW_gmoney;
       public double CW_gmoney
        {
            get
            {
                return cW_gmoney;
            }
            set
            {
                if (this.cW_gmoney != value)
                    this.cW_gmoney = value;
            }
        }

        private string cW_gjbren;
        public string CW_gjbren
        {
            get
            {
                return cW_gjbren;
            }
            set
            {
                if (this.cW_gjbren != value)
                    this.cW_gjbren = value;
            }
        }

        private string cW_gbeizhu;
        public string CW_gbeizhu
        {
            get
            {
                return cW_gbeizhu;
            }
            set
            {
                if (this.cW_gbeizhu != value)
                    this.cW_gbeizhu = value;
            }
        }


    }
}
