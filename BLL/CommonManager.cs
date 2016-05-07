using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BLL
{
   public class CommonManager
    {
       CommonService cs = new CommonService();
        public string GetNo(string sType)
        {
            return cs.GetNo(sType);
        }
       public string GoodsID(string sType)
       {
           return cs.GoodsID(sType);
       }
       public string GetNo2(string sType)
       {
           return cs.GetNo2(sType);
       }
    }
}
