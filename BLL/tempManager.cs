using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;
using DAL;

namespace BLL
{
   public class tempManager
    {
       tempService ts = new tempService();
       public DataSet select()
       {
           return ts.select();
       }
       public DataSet select(int sid)
       {
           return ts.select(sid);
       }
     
       public int add(temp tp)
       {
           return ts.add(tp);
       }
       public int del()
       {
           return ts.del();
       }
       public int del2(temp tp)
       {
           return ts.del2(tp);
       }
       public int update(temp tp)
       {
           return ts.update(tp);
       }
       public DataSet duqu()
       {
           return ts.duqu();
       }
       public double zongjia()
       {
           return ts.zongjia();
       }
    }
}
