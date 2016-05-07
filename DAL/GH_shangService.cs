using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
   public class GH_shangService
    {
       public DataSet select(string name)
       {
           DataSet ds = new DataSet();
           string sql = "select * from GH_shang";
           if (name!="")
           {
               sql += string.Format(" where GH_sName like '%{0}%'", name);
           }
           ds = DBHelper.Execute(sql);
           
           return ds;
       
       }
       //填充
       public DataSet Gh_shang()
       {
           DataSet ds = new DataSet();
           string sSql = "select * from GH_shang";

           ds = DBHelper.Execute(sSql);

           return ds;
       }

       public DataSet Gh_shang(GH_shang gh)    //这里用了，其它地方也要这要写，统一规范   
       {
           DataSet ds = new DataSet();
           string sSql = "select * from GH_shang where 1=1";
           if (gh.GH_sName != "")
           {
               sSql += string.Format(" and GH_sName like '%{0}%'", gh.GH_sName);
           }
           if (gh.GH_sLianxiren != "")
           {
               sSql += string.Format(" and GH_sLianxiren like '%{0}%'", gh.GH_sLianxiren);
           }
           if (gh.GH_sDianhua != "")
           {
               sSql += string.Format(" and GH_sDianhua like '%{0}%'", gh.GH_sDianhua);
           }
           if (gh.GH_sDizhi != "")
           {
               sSql += string.Format(" and GH_sDizhi like '%{0}%'", gh.GH_sDizhi);
           }

           ds = DBHelper.Execute(sSql);

           return ds;
       }

       //新增
       public int AddGH_shang(GH_shang aa)
       {
           int i = 0;
           string sSql = string.Format("insert into GH_shang values('{0}','{1}','{2}','{3}','{4}',{5},{6})", aa.GH_sName, aa.GH_sLianxiren, aa.GH_sDianhua, aa.GH_sDizhi, aa.GH_sBeizhu, aa.GH_sMoney, aa.GH_sMoren);
           i = DBHelper.ExecuteNonQuery(sSql);
           return i;
       }

       //修改
       public int UpdateGH_shang(GH_shang bb)
       {
           int i = 0;
           string sSql = string.Format("update Gh_shang set GH_sName='{0}',GH_sLianxiren='{1}',GH_sDianhua='{2}',GH_sDizhi='{3}',GH_sBeizhu='{4}',GH_sMoney='{5}',GH_sMoren='{6}' where GH_sId='{7}'", bb.GH_sName, bb.GH_sLianxiren, bb.GH_sDianhua, bb.GH_sDizhi, bb.GH_sBeizhu, bb.GH_sMoney, bb.GH_sMoren, bb.GH_sId);
           i = DBHelper.ExecuteNonQuery(sSql);
           return i;
       }


       ////修改填充
       //public GH_shang aaa(GH_shang ss)
       //{
       //    GH_shang s;
       //    string sSql = string.Format("select * from gh_shang where  GH_sId='{0}'",ss.GH_sId);
       //    SqlDataReader dr = new SqlDataReader(sSql);
       //    if (dr.Read())
       //    {
       //        s = new GH_shang();
       //        s.GH_sId = dr["GH_sId"];
       //    }
       //    return s;
       //}


       //删除
       public int deleteGH_shang(GH_shang aaa)
       {
           int i = 0;
           string sSql = string.Format("delete gh_shang where GH_sId='{0}'", aaa.GH_sId);
           i = DBHelper.ExecuteNonQuery(sSql);
           return i;
       }


       //填充2
       public DataSet Gh_shang2(int a)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select * from GH_shang where gH_sId like '%{0}%'", a);

           ds = Models.BDHelper.Execute(sSql);

           return ds;
       }

       public DataSet GH_shang()
       {
           DataSet set;
           string sSql = "select KH_xId,KH_xName,KH_xlianxiren,KH_xDianhua,KH_xDizhi from KH_xinxi";
           set = DBHelper.Execute(sSql);
           return set;
       }

       public DataSet likeGH_shang(string name)
       {
           DataSet i;
           string sSql = string.Format("select KH_xId,KH_xName,KH_xlianxiren,KH_xDianhua,KH_xDizhi " +
               "from KH_xinxi where KH_xName like '%{0}%'", name);
           i = DBHelper.Execute(sSql);
           return i;
       }

       public DataSet chaGH_shang(string name)
       {
           DataSet set;
           string sSql = string.Format("select XS_tDanhao,CK_tName,DH_tYmoney,DH_tSmoney,YG_xName,XS_tType,XS_tKHname" +
           "from XS_tbale as a inner join CK_table as b on(a.XS_tCK=b.CK_tID) inner join YG_xinxi as c on(a.XS_tJinbanren=c.YG_xId)" +
           "where XS_tKHname in (select KH_xId from KH_xinxi where KH_xName='{0}')", name);
           set = DBHelper.Execute(sSql);
           return set;
       }

    }
}
