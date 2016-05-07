using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Models;

namespace DAL
{
    public class CW_yingsyfService
    {
        public DataSet CW_yingsyf()
        {
            DataSet set;
            string sSql = "select CW_ydanwei,CW_ytype,CW_yyshou,CW_yyfu from CW_yingsyf";
            set = DBHelper.Execute(sSql);
            return set;
        }
        public DataSet likeCW_yingsyf(string name)
        {
            DataSet set;
            string sSql =string.Format("select CW_ytime,CW_ydanhao,CW_ynrong,CW_yyingfu,CW_yyingshou,CW_yczyuan,CW_yjbren,CW_ybeizhu from CW_yingsyf where CW_ydanwei='{0}'",name);
            set = DBHelper.Execute(sSql);
            return set;
        }

        public DataSet dateCW_yingsyf(DateTime a,DateTime b)
        {
            DataSet set;
            string sSql =string .Format("select CW_ytime,CW_ydanhao,CW_ynrong,CW_yyingfu,CW_yyingshou,CW_yczyuan,CW_yjbren,CW_ybeizhu from CW_yingsyf where CW_ytime>'{0}' and CW_ytime<'{1}'",a,b);
            set = DBHelper.Execute(sSql);
            return set;
        }
    }
}
