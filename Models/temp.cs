using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class temp
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (this.id != value)
                    this.id = value;
            }
        }

        private string spbianhao;

        public string Spbianhao
        {
            get { return spbianhao; }
            set { spbianhao = value; }
        }

        private string spname;
        public string Spname
        {
            get
            {
                return spname;
            }
            set
            {
                if (this.spname != value)
                    this.spname = value;
            }
        }

        private string sPdanwei;
        public string SPdanwei
        {
            get
            {
                return sPdanwei;
            }
            set
            {
                if (this.sPdanwei != value)
                    this.sPdanwei = value;
            }
        }

       private double danjia;
       public double Danjia
        {
            get
            {
                return danjia;
            }
            set
            {
                if (this.danjia != value)
                    this.danjia = value;
            }
        }

       private double dazhel;
       public double Dazhel
        {
            get
            {
                return dazhel;
            }
            set
            {
                if (this.dazhel != value)
                    this.dazhel = value;
            }
        }

       private double zhj;
       public double Zhj
        {
            get
            {
                return zhj;
            }
            set
            {
                if (this.zhj != value)
                    this.zhj = value;
            }
        }

        private int shuliang;
        public int Shuliang
        {
            get
            {
                return shuliang;
            }
            set
            {
                if (this.shuliang != value)
                    this.shuliang = value;
            }
        }

        private double zje;
       public double Zje
        {
            get
            {
                return zje;
            }
            set
            {
                if (this.zje != value)
                    this.zje = value;
            }
        }


    }
}
