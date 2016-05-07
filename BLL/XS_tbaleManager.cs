using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data;

namespace BLL
{
  public  class XS_tbaleManager
    {
        XS_tbaleService xs = new XS_tbaleService();
        public int add(XS_tbale xt)
        {
            return xs.add(xt);
        }
      public int delete(string dhao)
      {
          return xs.delete(dhao);
      }
      public DataTable select()
      {
          return xs.select();
      }
      public DataTable selectls()
      {
          return xs.selectls();
      }
      public DataTable selectxs()
      {
          return xs.selectxs();
      }

      public DataTable xiaoshou2()
       {
           DataTable dt = new DataTable();
           dt.Columns.Add("DH_tshangpID");
           dt.Columns.Add("SP_gName");
           dt.Columns.Add("SP_gDanweiid");
           dt.Columns.Add("DH_tShuliang");
           dt.Columns.Add("DH_tZongjine");
           dt.Columns.Add("liruen");
           dt.Columns.Add("maollv");
           dt.Columns.Add("Y_Name");
           dt.Columns.Add("SP_gSchang");
           dt.Columns.Add("SP_gBeizhi");
          

           DataTable dtxs = xs.selectxs();
           for (int i = 0; i < dtxs.Rows.Count; i++)
           {
               if (i==0)
               {
                   DataRow dr = dt.NewRow();
                   dr["DH_tshangpID"] = dtxs.Rows[i]["DH_tshangpID"].ToString();
                   dr["SP_gName"] = dtxs.Rows[i]["SP_gName"].ToString();
                   dr["SP_gDanweiid"] = dtxs.Rows[i]["SP_gDanweiid"].ToString();
                   dr["DH_tShuliang"] = dtxs.Rows[i]["DH_tShuliang"].ToString();
                   dr["DH_tZongjine"] = dtxs.Rows[i]["DH_tZongjine"].ToString();
                   double lr = (Convert.ToDouble(dtxs.Rows[i]["DH_tZongjine"]) - (Convert.ToDouble(dtxs.Rows[i]["SP_gJijie"]) * Convert.ToInt32(dtxs.Rows[i]["DH_tShuliang"])));
                   dr["liruen"] = lr;
                   dr["maollv"] = lr / Convert.ToDouble(dtxs.Rows[i]["DH_tZongjine"]);
                   dr["Y_Name"] = dtxs.Rows[i]["Y_Name"].ToString();
                   dr["SP_gSchang"] = dtxs.Rows[i]["SP_gSchang"].ToString();
                   dr["SP_gBeizhi"] = dtxs.Rows[i]["SP_gBeizhi"].ToString();
                   dt.Rows.Add(dr);

               }
               for (int j = 0; j < dt.Rows.Count; j++)
               {
                   if (dtxs.Rows[i]["DH_tshangpID"].ToString() == dt.Rows[j]["DH_tshangpID"].ToString())
                   {
                       dt.Rows[j]["DH_tShuliang"] =Convert.ToInt32( dt.Rows[j]["DH_tShuliang"])+Convert.ToInt32( dtxs.Rows[i]["DH_tShuliang"]);
                       dt.Rows[j]["DH_tZongjine"] = Convert.ToDouble(dtxs.Rows[i]["DH_tZongjine"]) + Convert.ToDouble(dt.Rows[j]["DH_tZongjine"]);
                       break;
                   }
                   else
                   {
                       DataRow dr = dt.NewRow();
                       dr["DH_tshangpID"] = dtxs.Rows[i]["DH_tshangpID"].ToString();
                       dr["SP_gName"] = dtxs.Rows[i]["SP_gName"].ToString();
                       dr["SP_gDanweiid"] = dtxs.Rows[i]["SP_gDanweiid"].ToString();
                       dr["DH_tShuliang"] = dtxs.Rows[i]["DH_tShuliang"].ToString();
                       dr["DH_tZongjine"] = dtxs.Rows[i]["DH_tZongjine"].ToString();
                       double lr = (Convert.ToDouble(dtxs.Rows[i]["DH_tZongjine"]) - (Convert.ToDouble(dtxs.Rows[i]["SP_gJijie"]) * Convert.ToInt32(dtxs.Rows[i]["DH_tShuliang"])));
                       dr["liruen"] = lr;
                       dr["maollv"] = lr / Convert.ToDouble(dtxs.Rows[i]["DH_tZongjine"]);
                       dr["Y_Name"] = dtxs.Rows[i]["Y_Name"].ToString();
                       dr["SP_gSchang"] = dtxs.Rows[i]["SP_gSchang"].ToString();
                       dr["SP_gBeizhi"] = dtxs.Rows[i]["SP_gBeizhi"].ToString();
                         dt.Rows.Add(dr);
                         break;
                   }
               }
               
           }



           return dt;
      
      
      
      }



      public DataTable xiaoshou()
      {
          return xs.xiaoshou();
      }


      public DataSet SelectAllXS_tbale(string gg, string a, string aa)
      {
          return xs.SelectAllXS_tbale(gg, a, aa);
      }
      //第三个Y_stock
      public DataSet Getthird(string gg, string a, string aa)
      {
          return xs.Getthird(gg, a, aa);
      }
      //查询填充  dgbDJ1    Y_stock---2   
      public DataSet SelectAllXS_tbale2(string aa)
      {
          return xs.SelectAllXS_tbale2(aa);
      }

      public DataSet XS_tbale(string name)
      {
          return xs.XS_tbale(name);
      }
      public DataSet XS_tbale(string name,string v)
      {
          return xs.XS_tbale(name,v);
      }
      public DataSet XS_tbalecmb()
      {
          return xs.XS_tbalecmb();
      }

    }
}
