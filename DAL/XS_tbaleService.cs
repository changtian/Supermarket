using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
   public class XS_tbaleService
    {
       public int add(XS_tbale xt)
       {
           int i = 0;
           string sql = string.Format("insert XS_tbale(XS_tKHname, XS_tDanhao, XS_tTime, XS_tCK, XS_tType, XS_tBeizhu, XS_tJinbanren, DH_tYmoney, DH_tSmoney, XS_tYanshi)"
               +" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{0}')",xt.XS_tKHname,xt.XS_tDanhao,xt.XS_tTime,xt.XS_tCK,xt.XS_tType,xt.XS_tBeizhu,xt.XS_tJinbanren,xt.DH_tYmoney,xt.DH_tSmoney,xt.XS_tYanshi);
           i = DBHelper.ExecuteNonQuery(sql);
           return i;
        
       }

       public int delete(string dhao)
       {
           int i = 0;

           string sql = string.Format("delete XS_tbale where XS_tDanhao='{0}'",dhao);
           i = DBHelper.ExecuteNonQuery(sql);


           return i;
       
       }


       public DataTable select()
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select SP_gTiaoma,SP_gDanweiid,SP_gName,SP_gKucuen,(SP_gKucuen*SP_gJijie) as zje,SP_gXinghao,Y_Name,SP_gSchang,SP_gBeizhi from SP_goods,Yshe where SP_gYid=Y_Id");
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
       
       
       }
       public DataTable selectls()
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select DH_tDanhao,DH_tshangpID,SP_gName,DH_tdanjia,DH_tShuliang,DH_tZongjine,SP_gDanweiid,SP_gXinghao,Y_Name,CK_tName,YG_xName from XS_tbale,DH_tabel,SP_goods,GH_shang,CK_table,YG_xinxi,Yshe where XS_tDanhao=DH_tDanhao and XS_tKHname=GH_sId and XS_tCK=CK_table.CK_tID  and XS_tJinbanren=YG_xId and DH_tshangpID=SP_gTiaoma and Y_Id=SP_gYid and DH_tType='采购'");
           dt = DBHelper.Execute(sql).Tables[0];
           return dt;
       
       
       }
       public DataTable selectxs()
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select DH_tshangpID,SP_gName,SP_gDanweiid,DH_tShuliang,DH_tZongjine,SP_gJijie,Y_Name,SP_gSchang,SP_gBeizhi from DH_tabel,SP_goods,Yshe where DH_tshangpID=SP_gTiaoma and Y_Id=SP_gYid and DH_tType='销售'");
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
       }


       public DataTable xiaoshou()
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select XS_tKHname,KH_xName,XS_tTime,XS_tDanhao,XS_tType,DH_tYmoney,DH_tSmoney,(DH_tYmoney-DH_tSmoney) as qiankuan,(DH_tYmoney-DH_tSmoney) as youhuei,YG_xName,XS_tBeizhu"
            + " from XS_tbale,KH_xinxi,YG_xinxi"
            + " where XS_tJinbanren=YG_xId and XS_tKHname=KH_xId");
           dt = DBHelper.Execute(sql).Tables[0];
           return dt;
       
       }

       //查询填充  dgbDJ1    Y_stock---1   
       public DataSet SelectAllXS_tbale(string gg, string a, string aa)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select XS_tKHname,XS_tDanhao,XS_tTime,GH_sName,CK_tName,DH_tYmoney,DH_tSmoney,(DH_tYmoney-DH_tSmoney) as qiankuan,XS_tType,XS_tYanshi,YG_xName,XS_tBeizhu"
            + " from XS_tbale,YG_xinxi,CK_table,GH_shang"
            + " where XS_tKHname=GH_sId and XS_tCK=CK_tID and XS_tJinbanren=YG_xId and XS_tType='采购' and XS_tTime>'{0}' and XS_tTime<'{1}'", gg, a);
           if (aa!="")
           {
               sSql += string.Format(" and (XS_tDanhao like '%{0}%' or GH_sName like '%{0}%')", aa);
           }
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }
       //第三个Y_stock
       public DataSet Getthird(string gg, string a, string aa)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select XS_tTime,XS_tDanhao,DH_tshangpID,SP_gName,DH_tdanjia,DH_tShuliang,DH_tZongjine,SP_gDanweiid,SP_gXinghao,Y_Name,CK_tName,YG_xName,GH_sName,SP_gSchang,XS_tYanshi from XS_tbale,DH_tabel,SP_goods,GH_shang,CK_table,YG_xinxi,Yshe where XS_tDanhao=DH_tDanhao and XS_tKHname=GH_sId and XS_tCK=CK_table.CK_tID  and XS_tJinbanren=YG_xId and DH_tshangpID=SP_gTiaoma and Y_Id=SP_gYid  and XS_tTime between '{0}' and '{1}' and XS_tdanhao like '%{2}%'", gg, a, aa);
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }
       //查询填充  dgbDJ2    Y_stock---2   
       public DataSet SelectAllXS_tbale2(string aa)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select DH_tshangpID,SP_gName,SP_gDanweiid,DH_tdanjia,DH_tShuliang,DH_tZongjine,SP_gXinghao,Y_Name from DH_tabel,SP_goods,Yshe where DH_tshangpID=SP_gTiaoma and Y_Id=SP_gYid and DH_tDanhao='{0}'", aa);
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }
       public DataSet XS_tbale(string name)
       {
           DataSet set;
           string sSql = string.Format("select XS_tDanhao,CK_tName,DH_tYmoney,DH_tSmoney,YG_xName,XS_tType"
            + " from CK_table,XS_tbale,YG_xinxi,GH_shang"
            + " where XS_tCK=CK_tID and XS_tJinbanren=YG_xId and XS_tKHname=GH_sId and GH_sName='{0}'", name);
           set = DBHelper.Execute(sSql);
           return set;
       }
       public DataSet XS_tbale(string name,string v)
       {
           DataSet set;
           string sSql = string.Format("select XS_tDanhao,CK_tName,DH_tYmoney,DH_tSmoney,YG_xName,XS_tType,KH_xName"
            +" from CK_table,XS_tbale,YG_xinxi,KH_xinxi"
            +" where XS_tCK=CK_tID and XS_tJinbanren=YG_xId and XS_tKHname=KH_xId and KH_xName='{0}'", name);
           set = DBHelper.Execute(sSql);
           return set;
       }
       public DataSet XS_tbalecmb()
       {
           DataSet red;
           string sSql = "select sum(DH_tYmoney) as yinsum,sum(DH_tSmoney) as shisum from XS_tbale as a  inner join YG_xinxi as c on(a.XS_tJinbanren=c.YG_xId)";
           red = DBHelper.Execute(sSql);
           return red;
       }
    }
}
