using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data;

namespace BLL
{
    
   public class CG_tableManager
    {
       CG_tableService cs = new CG_tableService();
       public int insert(CG_table gt)
       {
           return cs.insert(gt);
       
       }
       public DataTable kbcf(string stype, string spname,string time1,string time2)
       {
           return cs.kbcf(stype, spname,time1,time2);
       }
    }
}
