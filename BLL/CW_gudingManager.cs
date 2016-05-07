using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;
using Models;

namespace BLL
{
    public class CW_gudingManager
    {
        CW_gudingService iy = new CW_gudingService();
        public DataSet CW_guding()
        {
            return iy.CW_guding();
        }

        public bool AddCW_guding(CW_guding gu,ref string name)
        {
            bool b = false;
            int i= iy.AddCW_guding(gu);
            if (i > 0)
            {
                b = true;
                name="增加成功";
            }
            else
            {
                name="增加失败";
            }
            return b;
        }
        public DataSet dateCW_guding(DateTime a,DateTime b)
        {
            return iy.dateCW_guding(a,b);
        }
    }
}
