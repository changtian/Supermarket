using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
   public class YsheService
    {

       public DataTable add()
       {
           DataTable dt = new DataTable();

           string sql = "select * from Yshe";
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
       
       }
       //Моід
       public DataSet GetAllYshe()
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select * from Yshe");
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }
    }
}
