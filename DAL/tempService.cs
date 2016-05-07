using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class tempService
    {
       public DataSet select()
       {
           DataSet ds = new DataSet();
           string sql = "select * from temp";
           ds = DBHelper.Execute(sql);
           return ds;
       }
       public DataSet select(int sid)
       {
           DataSet ds = new DataSet();
           string sql = "select * from temp where id="+sid;
           ds = DBHelper.Execute(sql);
           return ds;
       }

      
       public int add(temp tp)
       {
           int i = 0;
           string sql = string.Format("exec proc_temp '{0}','{1}','{2}',{3},{4},{5},{6},{7}",tp.Spbianhao,tp.Spname,tp.SPdanwei,tp.Danjia,tp.Dazhel,tp.Zhj,tp.Shuliang,tp.Zje);
           i = DBHelper.ExecuteNonQuery(sql);

           return i;
       }
       public int del()
       {
           int i = 0;
           string sql = "delete temp";
           i = DBHelper.ExecuteNonQuery(sql);
           return i;
       }
       public int del2(temp tp)
       {
           int i = 0;
           string sql = string.Format("delete temp where id={0}", tp.Id);
           i = DBHelper.ExecuteNonQuery(sql);
           return i;
       }
       public int update(temp tp)
       {
           int i = 0;
           string sql = string.Format("update temp set danjia='{0}',dazhel='{1}',shuliang='{2}',zhj='{3}',zje='{4}' where id='{5}'", tp.Danjia, tp.Dazhel,tp.Shuliang, tp.Zhj, tp.Zje, tp.Id);
           i = DBHelper.ExecuteNonQuery(sql);
           return i;
       }
       public DataSet duqu()
       {
          
           string sql = "select * from temp";
           DataSet ds = DBHelper.Execute(sql);
          
           return ds;

       }

       public double zongjia()
       {
           double ds = 0;

           string sql = "select sum(zje) from temp";
           SqlDataReader     dr = DBHelper.ExecuteReader(sql);
           if (dr.Read())
           {
               ds = Convert.ToDouble(dr[0]);
           }
           dr.Close();
           DBHelper.Close();
           return ds;
       
       }
    }

}
