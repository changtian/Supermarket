using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data;

namespace BLL
{
   public  class YG_xinxiManager
    {
       YG_xinxiService ys = new YG_xinxiService();
       public List<YG_xinxi> chaxun()
       {
           return ys.chaxun();
       }
     
       public DataSet YG_xinxi()
       {
           return ys.xinxi();
       }
       public bool addYG_xinxi(YG_xinxi yg, ref string name)
       {
           bool b = false;
           int i = ys.addYG_xinxi(yg);
           if (i > 0)
           {
               b = true;
               name = "新增成功！";
           }
           else
           {
               name = "新增失败！";
           }
           return b;

       }
       public int updateYG_xinxi(YG_xinxi yg)
       {
           int i = 0;
           i = ys.updateYG_xinxi(yg);
           if (i > 0)
           {
               Console.WriteLine("修改成功!");

           }
           else
           {
               Console.WriteLine("修改失败!");
           }
           return i;
       }
       public DataSet likexixi(string name, string sname)
       {
           return ys.likexixi(name, sname);
       }
       //这才是填充
       public DataSet GetFillYG_xinxi()
       {
           return ys.GetFillYG_xinxi();
       }

       //新增
       public int GetAddYG_xinxi(YG_xinxi aa)
       {
           return ys.GetAddYG_xinxi(aa);
       }
       //判断是否新增成功
       public string ShowGetAddYG_xinxi(YG_xinxi aa)
       {
           string Message = "";
           int i = GetAddYG_xinxi(aa);
           if (i > 0)
           {
               Message = "新增成功";
           }
           return Message;
       }


       //修改
       public int GetUpdateYG_xinxi(YG_xinxi aa)
       {
           return ys.GetUpdateYG_xinxi(aa);
       }
       //判断是否修改成功
       public string ShowGetUpdateYG_xinxi(YG_xinxi aa)
       {
           string Message = "";
           int i = GetUpdateYG_xinxi(aa);
           if (i > 0)
           {
               Message = "修改成功";
           }
           return Message;
       }


       //删除
       public int GetDeleteYG_xinxi(YG_xinxi aa)
       {
           return ys.GetDeleteYG_xinxi(aa);
       }

       //查询
       public DataSet GetSelectYG_xinxi(YG_xinxi aa)
       {
           return ys.GetSelectYG_xinxi(aa);
       }
      
    }
}
