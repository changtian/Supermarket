using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Dwei
    {
        private int d_Id;
        public int D_Id
        {
            get
            {
                return d_Id;
            }
            set
            {
                if (this.d_Id != value)
                    this.d_Id = value;
            }
        }

        private string d_Name;
        public string D_Name
        {
            get
            {
                return d_Name;
            }
            set
            {
                if (this.d_Name != value)
                    this.d_Name = value;
            }
        }


    }
}
