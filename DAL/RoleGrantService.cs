using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
   public  class RoleGrantService
    {
       public List<RoleGrant> GetAllRoleGrantByRID(string rid)
       {
           List<RoleGrant> lst = new List<RoleGrant>();

           string sSql = "select rgGid from roleGrant where rgRid = " + rid;
           DataTable dt = Models.BDHelper.Execute(sSql).Tables[0];

           foreach (DataRow dr in dt.Rows)
           {
               RoleGrant rg = new RoleGrant();
               rg.GId = Convert.ToInt32(dr["rgGid"]);
               lst.Add(rg);
           }

           return lst;
       }


       public bool SaveRoleGrant(string rid, List<RoleGrant> lst)
       {
           bool b = false;

           List<string> sSql = new List<string>();

           sSql.Add("delete roleGrant where rgRid = " + rid);
           foreach (RoleGrant rg in lst)
           {
               sSql.Add(string.Format("insert roleGrant(rgRID, rgGID)"
                   + "values({0}, {1})", rid, rg.GId));
           }

           b =Models.BDHelper.ExecuteNonQuery(sSql);

           return b;
       }

    }
}
