using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
    public class JY_qkuangService
    {
        public DataSet JY_qkuang()
        {
            DataSet set;
            string sSql = "select JY_qkemu,JY_qfjine,JY_qleiji from JY_qkuang";
            set = DBHelper.Execute(sSql);
            return set;
        }
        public DataSet likeJY_qkuang(string name)
        {
            DataSet set;
            string sSql = string.Format("select JY_qtime,JY_qshuom,JY_qjine,JY_qjbren,JY_qbeizhu from JY_qkuang where JY_qkemu='{0}'",name);
            set = DBHelper.Execute(sSql);
            return set;
        }
        public DataSet dateJY_qkuang(DateTime a,DateTime b)
        {
            DataSet set;
            string sSql = string.Format("select JY_qtime,JY_qshuom,JY_qjine,JY_qjbren,JY_qbeizhu from JY_qkuang where JY_qtime>'{0}'and JY_qtime<'{1}'",a,b);
            set = DBHelper.Execute(sSql);
            return set;
        }
    }
}
