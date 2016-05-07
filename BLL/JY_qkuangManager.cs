using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;


namespace BLL
{
    public class JY_qkuangManager
    {
        JY_qkuangService qk = new JY_qkuangService();

        public DataSet JY_qkuang()
        {
            return qk.JY_qkuang();
        }
        public DataSet likeJY_qkuang(string name)
        {
            return qk.likeJY_qkuang(name);
        }
        public DataSet dateJY_qkuang(DateTime a,DateTime b)
        {
            return qk.dateJY_qkuang(a,b);
        }
    }
}
