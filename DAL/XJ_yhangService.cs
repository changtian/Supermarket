using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DAL
{
    public class XJ_yhangService
    {
        public DataSet XJ_yhang()
        {
            DataSet set;
            string sSql = "select * from XJ_yhang";
            set = DBHelper.Execute(sSql);
            return set;
        }
        public int chuXJ_yhang(int i,string beizhu,string name)
        {
            int set=0;
            string sSql = string.Format("update XJ_yhang set XJ_money=(XJ_money-{0}),XJ_beizhu='{1}' where XJ_name='{2}'", i,beizhu,name);
            set = DBHelper.ExecuteNonQuery(sSql);
            return set;
        }
        public int jingXJ_yhang(int i,string beizhu,string name)
        {
            int set = 0;
            string sSql = string.Format("update XJ_yhang set XJ_money=(XJ_money+{0}),XJ_beizhu='{1}' where XJ_name='{2}'", i,beizhu, name);
            set = DBHelper.ExecuteNonQuery(sSql);
            return set;
        }
    }
}
