using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data;

namespace BLL
{
   public class GH_shangManager
    {
       GH_shangService gs=new GH_shangService();
       public DataSet select(string name)
       {
           return gs.select(name);
       }
      


       //填充
       public DataSet Gh_shang()
       {
           return gs.Gh_shang();
       }


       public DataSet Gh_shang(GH_shang gh)
       {
           return gs.Gh_shang(gh);
       }

       #region 新增
       public int AddGH_shang(GH_shang aa)
       {
           return gs.AddGH_shang(aa);
       }

       public string showAdd(GH_shang aa)
       {
           string Message = "";
           int a = gs.AddGH_shang(aa);
           if (a > 0)
           {
               Message = "新增成功";
           }
           else
           {
               Message = "新增失败";
           }
           return Message;
       }
       #endregion



       #region 修改
       public int UpdateGH_shang(GH_shang bb)
       {
           return gs.UpdateGH_shang(bb);
       }

       public string showUpdate(GH_shang gg)
       {
           string Message = " ";
           int a = gs.UpdateGH_shang(gg);
           if (a > 0)
           {
               Message = "修改成功";
           }
           else
           {
               Message = "修改失败";
           }
           return Message;
       }


       //public GH_shang aaa(GH_shang ss)
       //{
       //    return gs.aaa(ss);
       //}
       #endregion



       //删除
       public int deleteGH_shang(GH_shang aaa)
       {
           return gs.deleteGH_shang(aaa);
       }

       public string showdelete(GH_shang aaa)
       {
           string Message = " ";
           int a = gs.deleteGH_shang(aaa);
           if (a > 0)
           {
               Message = "删除成功";
           }
           else
           {
               Message = "删除失败";
           }
           return Message;
       }



       public string FindGH_shang(GH_shang aaa)
       {
           string aa = "";

           return aa;
       }

       public DataSet Gh_shang2(int a)
       {
           return gs.Gh_shang2(a);
       }

       public DataSet bllGH_shang()
       {
           return gs.GH_shang();
       }

       public DataSet chaGH_shang(string name)
       {
           return gs.chaGH_shang(name);
       }

       public DataSet likeGH_shang(string name)
       {
           return gs.likeGH_shang(name);
       }

   }
}
