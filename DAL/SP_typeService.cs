using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
   public class SP_typeService
    {
       public DataTable type()
       {
           DataTable dt = new DataTable();

           string sql = "select * from SP_type";
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
        
       }

       //ÃÓ≥‰SP_type
       public DataSet GetAllSP_type()
       {
           string sSql = string.Format("select * from sp_type");
           DataSet ds = Models.BDHelper.Execute(sSql);
           return ds;
       }
    }
}
