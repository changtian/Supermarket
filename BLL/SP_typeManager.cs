using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data;

namespace BLL
{
   public class SP_typeManager
    {
       SP_typeService ss = new SP_typeService();
       public DataTable type()
       {
           return ss.type();
       }
          //ÃÓ≥‰SP_type
        public DataSet GetAllSP_type()
        {
            return ss.GetAllSP_type();
        }
    }
}
