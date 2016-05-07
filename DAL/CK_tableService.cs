using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;


namespace DAL
{
   public class CK_tableService
    {
       public DataSet select()
       {
           DataSet ds = new DataSet();

           string sql = "select * from CK_table";
           ds = DBHelper.Execute(sql);

           return ds;
       }
       public DataSet geon()
       {

           string sSql = "select * from CK_table";
           DataSet set = DBHelper.Execute(sSql);
           return set;
       }

       public DataSet GetAllCK_table()
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select * from CK_table");
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }
       //新增
       public int GetAddCK_table(CK_table a)
       {
           int i;
           string sSql = string.Format("insert into ck_table(CK_tName, CK_tfuzren, CK_tDianhua, CK_tDizhi, CK_tBeizhu, CK_tMoren, CK_tPOS) values('{0}','{1}','{2}','{3}','{4}',{5},{6})", a.CK_tName, a.CK_tfuzren, a.CK_tDianhua, a.CK_tDizhi, a.CK_tBeizhu, a.CK_tMoren, a.CK_tPOS);
           i = Models.BDHelper.ExecuteNonQuery(sSql);
           return i;
       }

       //修改
       public int GetUpdateCK_table(CK_table a)
       {
           int i;
           string sSql = string.Format("update ck_table set CK_tName='{0}',CK_tfuzren='{1}', CK_tDianhua='{2}', CK_tDizhi='{3}', CK_tBeizhu='{4}', CK_tMoren={5}, CK_tPOS={6} where CK_tID={7}", a.CK_tName, a.CK_tfuzren, a.CK_tDianhua, a.CK_tDizhi, a.CK_tBeizhu, a.CK_tMoren, a.CK_tPOS, a.CK_tID);
           i = Models.BDHelper.ExecuteNonQuery(sSql);
           return i;
       }


       //删除
       public int GetDeleteCK_table(CK_table a)
       {
           int i;
           string sSql = string.Format("delete from ck_table where CK_tID={0}", a.CK_tID);
           i = Models.BDHelper.ExecuteNonQuery(sSql);
           return i;
       }

       //查找
       public DataSet GetFindCK_table(CK_table a)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select * from ck_tname where CK_tName like '%{0}%',CK_tfuzren like '%{1}%', CK_tDianhua  like '%{2}%', CK_tDizhi like '%{3}%'", a.CK_tName, a.CK_tfuzren, a.CK_tDianhua, a.CK_tDizhi);
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }

    }
}
