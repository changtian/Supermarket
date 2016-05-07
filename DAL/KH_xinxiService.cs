using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;
namespace DAL
{
   public class KH_xinxiService
    {
       public DataSet khxxi(string sname)
       {
           DataSet ds = new DataSet();
           string sql = string.Format("select KH_xId, KH_xName, KH_xlianxiren, KH_xDianhua, KH_xDizhi,KH_xMoney from KH_xinxi");
           if (sname!="")
           {
               sql += string.Format(" where KH_xName like '%{0}%'", sname);
           }
           ds = DBHelper.Execute(sql);
           return ds;
       }
       public int insertKH(KH_xinxi kx)
       {
           int i = 0;
           string sql=string.Format("exec procKH  '{0}','{1}','{2}','{3}','{4}','{5}','{6}'",kx.KH_xName,kx.KH_xlianxiren,kx.KH_xDianhua,kx.KH_xDizhi,kx.KH_xBeizhu,kx.KH_xMoney,kx.KH_xMoren);
           i = DBHelper.ExecuteNonQuery(sql);
           return i;
       }
       public DataSet  xiougai(KH_xinxi kh)
       {
           DataSet ds = new DataSet();

           string sql = string.Format("select * from KH_xinxi where KH_xId='{0}'", kh.KH_xId);
           ds = DBHelper.Execute(sql);
           return ds;
       }
       public int xiougaixz(KH_xinxi kx)
       {
           int i = 0;
           string sql=string.Format("update KH_xinxi set KH_xName='{0}',KH_xlianxiren='{1}',KH_xDianhua='{2}',KH_xDizhi='{3}',KH_xBeizhu='{4}',KH_xMoney='{5}',KH_xMoren='{6}' where KH_xId='{7}'",
           kx.KH_xName,kx.KH_xlianxiren,kx.KH_xDianhua,kx.KH_xDizhi,kx.KH_xBeizhu,kx.KH_xMoney,kx.KH_xMoren,kx.KH_xId);
           i=DBHelper.ExecuteNonQuery(sql);

           return i;
        }

        //全部填充
        public DataSet GetAllKH_xinxi()
        {
            DataSet ds = new DataSet();
            string sSql = string.Format("select * from KH_xinxi");
            ds = Models.BDHelper.Execute(sSql);
            return ds;
        }

        //新增
        public int GetAddKH_xinxi(KH_xinxi aa)
        {
            string sSql = string.Format("insert into KH_xinxi values('{0}','{1}','{2}','{3}','{4}','{5}',{6})", aa.KH_xName, aa.KH_xlianxiren, aa.KH_xDianhua, aa.KH_xDizhi, aa.KH_xBeizhu, aa.KH_xMoney, aa.KH_xMoren);
            int i = Models.BDHelper.ExecuteNonQuery(sSql);
            return i;
        }

        //修改
        public int GetUpdateKH_xinxi(KH_xinxi aa)
        {
            string sSql = string.Format("update KH_xinxi set KH_xName='{0}',KH_xlianxiren='{1}',KH_xDianhua='{2}',KH_xDizhi='{3}',KH_xBeizhu='{4}',KH_xMoney='{5}',KH_xMoren={6} where kh_xid={7}", aa.KH_xName, aa.KH_xlianxiren, aa.KH_xDianhua, aa.KH_xDizhi, aa.KH_xBeizhu, aa.KH_xMoney, aa.KH_xMoren, aa.KH_xId);
            int i = Models.BDHelper.ExecuteNonQuery(sSql);
            return i;
        }

        //删除
        public int GetDeleteKH_xinxi(KH_xinxi aa)
        {
            string sSql = string.Format("delete from  KH_xinxi where kh_xid={0}", aa.KH_xId);
            int i = Models.BDHelper.ExecuteNonQuery(sSql);
            return i;
        }

        //查询
        public DataSet GetSelectKH_xinxi(KH_xinxi aa)
        {
            DataSet ds = new DataSet();
            string sSql = string.Format("select * from kh_xinxi where KH_xName='{0}',KH_xlianxiren='{1}',KH_xDianhua='{2}',KH_xDizhi='{3}'", aa.KH_xName, aa.KH_xlianxiren, aa.KH_xDianhua, aa.KH_xDizhi);
            ds = Models.BDHelper.Execute(sSql);
            return ds;
        }

        public DataSet KH_xinxi()
        {
            DataSet set;
            string sSql = "select KH_xId,KH_xName,KH_xlianxiren,KH_xDianhua,KH_xDizhi from KH_xinxi";
            set = DBHelper.Execute(sSql);
            return set;
        }
        public DataSet likeKH_xinxi(string name)
        {
            DataSet set;
            string sSql = string.Format("select KH_xId,KH_xName,KH_xlianxiren,KH_xDianhua,KH_xDizhi from KH_xinxi where KH_xName like '%{0}%'", name);
            set = DBHelper.Execute(sSql);
            return set;
        }
    }
}
