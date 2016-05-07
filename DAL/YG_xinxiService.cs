using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Models;
using System.Data.SqlClient;

namespace DAL
{
  public class YG_xinxiService
    {
       public List<YG_xinxi> chaxun()
       {
           List<YG_xinxi> lst = new List<YG_xinxi>();
           string sql = string.Format("select * from YG_xinxi");
           DataSet ds = DBHelper.Execute(sql);
           foreach (DataRow dr in ds.Tables[0].Rows)
           {
               YG_xinxi yg = new YG_xinxi();
               yg.YG_xId = Convert.ToInt32(dr["YG_xId"]);
               yg.YG_xName = dr["YG_xName"].ToString();
               lst.Add(yg);
           }

           return lst;
       }
       public DataSet xinxi()
       {
           string sSql = "select * from YG_xinxi";
           DataSet set = DBHelper.Execute(sSql);
           return set;
       }
       public DataSet likexixi(string name, string sname)
       {
           DataSet set;
           string sSql = string.Format("select * from YG_xinxi where YG_xName like '%{0}%' or YG_xZhiwu like'%{1}%'", name, sname);
           set = DBHelper.Execute(sSql);
           return set;

       }
       public int addYG_xinxi(YG_xinxi yg)
       {
           int i = 0;
           string sSql = string.Format("insert into YG_xinxi(YG_xName,YG_xZhiwu,YG_xDianhua,YG_xDizhi,YG_xBeizhu,YG_xCaigou,YG_xXiaoshou,YG_xkucuen)"
               + " values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')"
               , yg.YG_xName, yg.YG_xZhiwu, yg.YG_xDianhua, yg.YG_xDizhi, yg.YG_xBeizhu, yg.YG_xCaigou, yg.YG_xXiaoshou, yg.YG_xkucuen);
           i = DBHelper.ExecuteNonQuery(sSql);
           return i;
       }
       public SqlDataReader rad()
       {
           SqlDataReader i;
           string sSql = "select * from YG_xinxi";
           i = DBHelper.ExecuteReader(sSql);
           return i;
       }
       public int updateYG_xinxi(YG_xinxi yg)
       {
           int i = 0;
           string sSql = string.Format("update YG_xinxi set YG_xName='{0}',YG_xZhiwu='{1}',YG_xDianhua='{2}',YG_xDizhi='{3}',YG_xBeizhu='{4} ',"
               + "YG_xCaigou={5},YG_xXiaoshou={6},YG_xkucuen={7} where YG_xId={8}", yg.YG_xName, yg.YG_xZhiwu, yg.YG_xDianhua, yg.YG_xDizhi, yg.YG_xBeizhu, yg.YG_xCaigou, yg.YG_xXiaoshou, yg.YG_xXiaoshou, yg.YG_xId);
           i = DBHelper.ExecuteNonQuery(sSql);
           return i;
       }
       //这才是填充
       public DataSet GetFillYG_xinxi()
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select * from YG_xinxi");
           ds = BDHelper.Execute(sSql);
           return ds;
       }

       //新增
       public int GetAddYG_xinxi(YG_xinxi aa)
       {
           int i = 0;
           string sSql = string.Format("insert into yg_xinxi(YG_xName, YG_xZhiwu, YG_xDianhua, YG_xDizhi, YG_xBeizhu, YG_xCaigou, YG_xXiaoshou, YG_xkucuen) values('{0}','{1}','{2}','{3}','{4}',{5},{6},{7})", aa.YG_xName, aa.YG_xZhiwu, aa.YG_xDianhua, aa.YG_xDizhi, aa.YG_xBeizhu, aa.YG_xCaigou, aa.YG_xXiaoshou, aa.YG_xkucuen);
           i = Models.BDHelper.ExecuteNonQuery(sSql);
           return i;
       }

       //修改
       public int GetUpdateYG_xinxi(YG_xinxi aa)
       {
           int i = 0;
           string sSql = string.Format("update yg_xinxi set YG_xName='{0}', YG_xZhiwu='{1}', YG_xDianhua='{2}', YG_xDizhi='{3}', YG_xBeizhu='{4}', YG_xCaigou={5}, YG_xXiaoshou={6}, YG_xkucuen={7} where YG_xId={8}", aa.YG_xName, aa.YG_xZhiwu, aa.YG_xDianhua, aa.YG_xDizhi, aa.YG_xBeizhu, aa.YG_xCaigou, aa.YG_xXiaoshou, aa.YG_xkucuen, aa.YG_xId);
           i = Models.BDHelper.ExecuteNonQuery(sSql);
           return i;
       }

       //删除
       public int GetDeleteYG_xinxi(YG_xinxi aa)
       {
           int i = 0;
           string sSql = string.Format("delete yg_xinxi where YG_xId={0}", aa.YG_xId);
           i = Models.BDHelper.ExecuteNonQuery(sSql);
           return i;
       }

       //查询
       public DataSet GetSelectYG_xinxi(YG_xinxi aa)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select * from YG_xinxi where YG_xName like '%{0}%' or YG_xZhiwu like '%{1}%'or  YG_xDianhua like '%{2}%' or  YG_xDizhi  like '%{3}%'", aa.YG_xName, aa.YG_xZhiwu, aa.YG_xDianhua, aa.YG_xDizhi);
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }
    }
}
