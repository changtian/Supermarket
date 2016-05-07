using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data;

namespace BLL
{
   public class CK_tableManager
    {
       CK_tableService cs=new CK_tableService();
       public DataSet select()
       {
           return cs.select();
       }
       public DataSet gegt()
       {
           return cs.geon();
       }
       public DataSet GetAllCK_table()
       {
           return cs.GetAllCK_table();
       }
      
   


       //新增
       public int GetAddCK_table(CK_table a)
       {
           return cs.GetAddCK_table(a);
       }
       //判断是否成功
       public string ShowGetAddCK_table(CK_table a)
       {
           string Message = "";
           int aa = GetAddCK_table(a);
           if (aa > 0)
           {
               Message = "新增成功";
           }
           return Message;
       }

       public int GetUpdateCK_table(CK_table a)
       {
           return cs.GetUpdateCK_table(a);
       }
       //判断新增是否成功
       public string ShowGetUpdateCK_table(CK_table a)
       {
           string Message = "";
           int aa = GetUpdateCK_table(a);
           if (aa > 0)
           {
               Message = "修改成功";
           }
           return Message;
       }

       public int GetDeleteCK_table(CK_table a)
       {
           return cs.GetDeleteCK_table(a);
       }
       //判断删除是否成功
       public string ShowGetDeleteCK_table(CK_table a)
       {
           string Message = "";
           int aa = GetDeleteCK_table(a);
           if (aa > 0)
           {
               Message = "删除成功";
           }
           return Message;
       }
      
    }
}
