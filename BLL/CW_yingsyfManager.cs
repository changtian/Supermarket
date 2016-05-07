using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class CW_yingsyfManager
    {
        CW_yingsyfService yi = new CW_yingsyfService ();

        public DataSet CW_yingsyf()
        {
            return yi.CW_yingsyf();
        }

        public DataSet likeCW_yingsyf(string name)
        {
            return yi.likeCW_yingsyf(name);
        }
        public DataSet dateCW_yingsyf(DateTime a,DateTime b)
        {
            return yi.dateCW_yingsyf(a,b);
        }
    }
}
