using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class CW_feiyService
    {
        public DataSet CW_feiy()
        {
            DataSet set;
            string sSql = "select CW_fId,CW_ftypename,CW_fzmoney,CW_ftype,CW_ffujia from CW_feiy";
            set = DBHelper.Execute(sSql);
            return set;
        }

        public int AddCW_feiy(CW_feiy fe)
        {
            int i;
            string sSql = string.Format("update CW_feiy set CW_fzmoney=CW_fzmoney+{0},CW_ftype='{1}',CW_ffujia='{2}' where CW_ftypename='{3}'",fe.CW_fmoney,fe.CW_ftype,fe.CW_ffujia,fe.CW_ftypename);
            i = DBHelper.ExecuteNonQuery(sSql);
            return i;
        }

        public DataSet CW_feiyshou()
        {
            DataSet set;
            string sSql = "select CW_ftypename from CW_feiy where CW_ftypename like'%收入'";
            set = DBHelper.Execute(sSql);
            return set;
        }
        public int shouCW_feiy(CW_feiy fe)
        {
            int i;
            string sSql =string.Format( "update CW_feiy set CW_fzmoney=CW_fzmoney+{0},CW_ftype='{1}',CW_ffujia='{2}' where CW_ftypename='{3}'",fe.CW_fmoney,fe.CW_ftype,fe.CW_ffujia,fe.CW_ftypename);
            i = DBHelper.ExecuteNonQuery(sSql);
            return i;
        }
    }
}
