using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
   public  class GrantService
    {
       //填充
       public List<Grant> GetAllGrant()
       {
           List<Grant> lst = new List<Grant>();

           string sSql = "select * from [grant]";
           DataSet ds = Models.BDHelper.Execute(sSql);

           foreach (DataRow dr in ds.Tables[0].Rows)
           {
               Grant g = new Grant();
               g.Id = Convert.ToInt32(dr["gid"]);
               g.Name = dr["gname"].ToString();
               g.PId = Convert.ToInt32(dr["gpid"]);
               g.FormName = dr["gFormName"].ToString();
               lst.Add(g);
           }
           return lst;
       }


       //增加
       public int AddGrant(Grant g)
       {
           int i = 0;
           string sSql = string.Format("insert into [grant](gname,gpid,gformname)"
               + " values('{0}',{1},'{2}')",g.Name,g.PId,g.FormName);
           i = Models.BDHelper.ExecuteNonQuery(sSql);
           return i;
       }


       //删除
       public int DeleteGrant(Grant g)
       {
           int i = 0;
           string sSql = string.Format("delete [grant] where gpid='{0}'",g.PId);
           i = Models.BDHelper.ExecuteNonQuery(sSql);
           return i;
       }
    }
}
