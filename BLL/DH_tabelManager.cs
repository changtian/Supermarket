using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data;

namespace BLL
{
   public class DH_tabelManager
    {
        DH_tabelService ds=new DH_tabelService();
        public int ADD(DH_tabel dt)
        {
           return ds.ADD(dt);
        }
       public DataSet select(SP_goods sg,string type)
       {
           return ds.select(sg,type);
       }
       public DataTable tueiduan(string name, string tiem1, string tiem2)
       {
           return ds.tueiduan(name,tiem1,tiem2);
       }
       public DataTable tdxx(string name)
       {
           return ds.tdxx(name);
       }
       public DataTable xiangxi(string danhao)
       {
           return ds.xiangxi(danhao);
       }
       public DataTable GHSsuoyou()
       {
           return ds.GHSsuoyou();
       }
       public DataTable djxx(string dh)
       {
           return ds.djxx(dh);
       }
       public int insertfukuan(XS_tbale st)
       {
           return ds.insertfukuan(st);
       }
       public DataTable shangpmxi(string hd)
       {
           return ds.shangpmxi(hd);
       }
    }
}
