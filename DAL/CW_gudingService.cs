using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class CW_gudingService
    {
        public DataSet CW_guding()
        {
            DataSet set;
            string sSql = "select * from CW_guding";
            set = DBHelper.Execute(sSql);
            return set;
        }
        //增加
        public int AddCW_guding(CW_guding gu)
        {
            int i;
            string sSql =string.Format( "insert into CW_guding(CW_gtime,CW_gtype,CW_gmoney,CW_gjbren,CW_gbeizhu) values('{0}','{1}','{2}','{3}','{4}')",gu.CW_gtime,gu.CW_gtype,gu.CW_gmoney,gu.CW_gjbren,gu.CW_gbeizhu);
            i = DBHelper.ExecuteNonQuery(sSql);
            return i;
        }
        //查询
        public DataSet dateCW_guding(DateTime a,DateTime b)
        {
            DataSet set;
            string sSql =string.Format( "select * from CW_guding where CW_gtime between '{0}' and '{1}'",a,b);
            set = DBHelper.Execute(sSql);
            return set;
        }
        //总资产
        public DataSet dateCW_guding()
        {
            DataSet set;
            string sSql = string.Format("");
            set = DBHelper.Execute(sSql);
            return set;
        }
    }
}
