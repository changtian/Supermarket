using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;
using Models;

namespace BLL
{
    public class CW_feiyManager
    {
        CW_feiyService fe = new CW_feiyService();
        public DataSet CW_feiy()
        {
            return fe.CW_feiy();
        }

        public bool AddCW_feiy(CW_feiy cw, ref string name)
        {
            bool b = false;
            int i = fe.AddCW_feiy(cw);
            if (i > 0)
            {
                b = true;
                name = "新增成功";
            }
            else
            {
                name = "新增失败";
            }
            return b;
        }

        public DataSet CW_feiyshou()
        {
            return fe.CW_feiyshou();
        }

        public bool shouCW_feiy(CW_feiy cw,ref string name)
        {
            bool b = false;
            int i = fe.shouCW_feiy(cw);
            if (i > 0)
            {
                b = true;
                name = "新增成功";
            }
            else
            {
                name = "新增失败";
            }
            return b;
        }
    }
}
