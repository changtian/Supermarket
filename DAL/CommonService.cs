using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class CommonService
    {
        /// <summary>
        /// 获取单据流水号
        /// </summary>
        /// <param name="sType">XS、XT、JH、TH</param>
        /// <returns></returns>
        public string GetNo(string sType)
        {
            string strSql = "select convert(numeric(16, 0), convert(varchar,getdate(),112) + ISNULL(max(right(XS_tDanhao, 4)), '0000')) + 1"
                        + " from XS_tbale"
                        + " where XS_tDanhao like '%" + sType + "' + convert(varchar,getdate(),112) + '%'";
            object obj = null;

            try
            {
                obj = DBHelper.ExecuteScalar(strSql);
            }
            catch
            {                
                throw;
            }

            return sType + obj.ToString();

        }

       public string GoodsID(string sType)
       {
           string strSql = "select convert(numeric(12, 0), convert(varchar,getdate(),112) + ISNULL(max(right(SP_gTiaoma, 3)), '000')) + 1"
                       + " from SP_goods"
                       + " where SP_gTiaoma like '%" + sType + "' + convert(varchar,getdate(),112) + '%'";
           object obj = null;

           try
           {
               obj = DBHelper.ExecuteScalar(strSql);
           }
           catch
           {
               throw;
           }

           return sType + obj.ToString();

       }

       public string GetNo2(string sType)
       {
           string strSql = "select convert(numeric(16, 0), convert(varchar,getdate(),112) + ISNULL(max(right(CF_tdanhao, 4)), '0000')) + 1"
                       + " from CG_table"
                       + " where CF_tdanhao like '%" + sType + "' + convert(varchar,getdate(),112) + '%'";
           object obj = null;

           try
           {
               obj = DBHelper.ExecuteScalar(strSql);
           }
           catch
           {
               throw;
           }

           return sType + obj.ToString();

       }
       
    }
}
