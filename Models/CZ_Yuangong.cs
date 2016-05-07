using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class CZ_Yuangong
    {
        private int cZ_yId;
        public int CZ_yId
        {
            get
            {
                return cZ_yId;
            }
            set
            {
                if (this.cZ_yId != value)
                    this.cZ_yId = value;
            }
        }

        private string cZ_yName;
        public string CZ_yName
        {
            get
            {
                return cZ_yName;
            }
            set
            {
                if (this.cZ_yName != value)
                    this.cZ_yName = value;
            }
        }

        private string cZ_yZhiwei;
        public string CZ_yZhiwei
        {
            get
            {
                return cZ_yZhiwei;
            }
            set
            {
                if (this.cZ_yZhiwei != value)
                    this.cZ_yZhiwei = value;
            }
        }

        private int cZ_yPOS;
        public int CZ_yPOS
        {
            get
            {
                return cZ_yPOS;
            }
            set
            {
                if (this.cZ_yPOS != value)
                    this.cZ_yPOS = value;
            }
        }

        private string cZ_yPassword;
        public string CZ_yPassword
        {
            get
            {
                return cZ_yPassword;
            }
            set
            {
                if (this.cZ_yPassword != value)
                    this.cZ_yPassword = value;
            }
        }



	
    }
}
