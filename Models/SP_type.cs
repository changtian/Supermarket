using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class SP_type
    {
        private int sP_tId;
        public int SP_tId
        {
            get
            {
                return sP_tId;
            }
            set
            {
                if (this.sP_tId != value)
                    this.sP_tId = value;
            }
        }

        private string sP_tName;
        public string SP_tName
        {
            get
            {
                return sP_tName;
            }
            set
            {
                if (this.sP_tName != value)
                    this.sP_tName = value;
            }
        }

        private string sP_tZname;
        public string SP_tZname
        {
            get
            {
                return sP_tZname;
            }
            set
            {
                if (this.sP_tZname != value)
                    this.sP_tZname = value;
            }
        }


    }
}
