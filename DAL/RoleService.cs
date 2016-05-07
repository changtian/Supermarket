using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
   public  class RoleService
    {
       public DataSet GetAllRole()
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select distinct rName from Role");
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }
    }
}
