using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
   public  class RoleGrantManager
    {
       RoleGrantService rgs = new RoleGrantService();


       public List<RoleGrant> GetAllRoleGrantByRID(string rid)
       {
           return rgs.GetAllRoleGrantByRID(rid);
       }


       public bool SaveRoleGrant(string rid, List<RoleGrant> lst)
       {
           return rgs.SaveRoleGrant(rid, lst);
       }

       public List<RoleGrant> GetAllGrantByCurrentRID()
       {
           return rgs.GetAllRoleGrantByRID(UserHelper.rId);
       }
    }
}
