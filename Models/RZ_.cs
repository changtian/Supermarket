using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public  class RZ_
    {
        private int rZ_id;
        public int RZ_id
        {
            get
            {
                return rZ_id;
            }
            set
            {
                if (this.rZ_id != value)
                    this.rZ_id = value;
            }
        }

        private DateTime rZ_time;
        public DateTime RZ_time
        {
            get
            {
                return rZ_time;
            }
            set
            {
                if (this.rZ_time != value)
                    this.rZ_time = value;
            }
        }

        private string rZ_czyuan;
        public string RZ_czyuan
        {
            get
            {
                return rZ_czyuan;
            }
            set
            {
                if (this.rZ_czyuan != value)
                    this.rZ_czyuan = value;
            }
        }

        private string rZ_neirong;
        public string RZ_neirong
        {
            get
            {
                return rZ_neirong;
            }
            set
            {
                if (this.rZ_neirong != value)
                    this.rZ_neirong = value;
            }
        }


    }
}
