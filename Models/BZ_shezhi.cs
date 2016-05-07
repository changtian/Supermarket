using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class BZ_shezhi
    {
        private int bZ_sID;
        public int BZ_sID
        {
            get
            {
                return bZ_sID;
            }
            set
            {
                if (this.bZ_sID != value)
                    this.bZ_sID = value;
            }
        }

        private string bZ_sdcangku;
        public string BZ_sdcangku
        {
            get
            {
                return bZ_sdcangku;
            }
            set
            {
                if (this.bZ_sdcangku != value)
                    this.bZ_sdcangku = value;
            }
        }

        private string bZ_sdSPbianhao;
        public string BZ_sdSPbianhao
        {
            get
            {
                return bZ_sdSPbianhao;
            }
            set
            {
                if (this.bZ_sdSPbianhao != value)
                    this.bZ_sdSPbianhao = value;
            }
        }

        private string bZ_sxcangku;
        public string BZ_sxcangku
        {
            get
            {
                return bZ_sxcangku;
            }
            set
            {
                if (this.bZ_sxcangku != value)
                    this.bZ_sxcangku = value;
            }
        }

        private string bZ_sxSpbianhao;
        public string BZ_sxSpbianhao
        {
            get
            {
                return bZ_sxSpbianhao;
            }
            set
            {
                if (this.bZ_sxSpbianhao != value)
                    this.bZ_sxSpbianhao = value;
            }
        }

        private int bZ_sbilv;
        public int BZ_sbilv
        {
            get
            {
                return bZ_sbilv;
            }
            set
            {
                if (this.bZ_sbilv != value)
                    this.bZ_sbilv = value;
            }
        }


    }
}
