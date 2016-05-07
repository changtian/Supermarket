using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   public class CZ_YuangongServeic
    {
       public CZ_Yuangong chaxun(CZ_Yuangong cz)
       {
           CZ_Yuangong cy = null;
           string sql = string.Format("select * from CZ_Yuangong where CZ_yName='{0}'", cz.CZ_yName);
           SqlDataReader dr = DBHelper.ExecuteReader(sql);
           if (dr.Read())
           {
               cy = new CZ_Yuangong();
               cy.CZ_yPassword = dr["CZ_yPassword"].ToString();
           }
           dr.Close();
           DBHelper.Close();
           return cy;
       }
       public List<CZ_Yuangong> add()
       {
           List<CZ_Yuangong> lst = new List<CZ_Yuangong>();

           string sql = string.Format("select CZ_yName from CZ_Yuangong");
           DataSet ds = DBHelper.Execute(sql);
           foreach (DataRow dr in ds.Tables[0].Rows)
           {
               CZ_Yuangong cy = new CZ_Yuangong();
               cy.CZ_yName = dr["CZ_yName"].ToString();
               lst.Add(cy);
           }
           return lst;
       }
       //Ìî³ä
       public DataSet GetAllCZ_Yuangong()
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select * from CZ_Yuangong,[role] where CZ_Yuangong.CZ_yZhiwei=[role].rName");
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }


       //ÐÞ¸Ä
       public int UpdateCZ_Yuangong(CZ_Yuangong aa)
       {
           int i = 0;
           string sSql = string.Format("update CZ_Yuangong set CZ_yName='{0}',CZ_yZhiwei='{1}',CZ_yPOS={2},CZ_yPassword={3} where CZ_yId={4}", aa.CZ_yName, aa.CZ_yZhiwei, aa.CZ_yPOS, aa.CZ_yPassword, aa.CZ_yId);
           i = DBHelper.ExecuteNonQuery(sSql);
           return i;
       }

       //É¾³ý
       public int DeleteCZ_Yuangong(CZ_Yuangong aa)
       {
           int i = 0;
           string sSql = string.Format("delete from CZ_Yuangong where CZ_yId={0}", aa.CZ_yId);
           i = DBHelper.ExecuteNonQuery(sSql);
           return i;
       }
       //ÐÂÔö
       public int GetAddCZ_Yuangong(CZ_Yuangong aa)
       {
           int i = 0;
           string sSql = string.Format("insert into CZ_Yuangong(CZ_yName,CZ_yZhiwei,CZ_yPassword) values('{0}','{1}','{2}')", aa.CZ_yName, aa.CZ_yZhiwei, aa.CZ_yPassword);
           i = Models.BDHelper.ExecuteNonQuery(sSql);
           return i;
       }
    }
}
