using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
   public class DH_tabelService
    {

       public int ADD(DH_tabel dt)
       {
           int i = 0;

           string sql = string.Format("insert DH_tabel(DH_tDanhao, DH_tshangpID, DH_tType, DH_tShuliang, DH_tdzl, DH_tdanjia, DH_tZongjine)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
               dt.DH_tDanhao,dt.DH_tshangpID,dt.DH_tType,dt.DH_tShuliang,dt.DH_tdzl,dt.DH_tdanjia,dt.DH_tZongjine);
           i = DBHelper.ExecuteNonQuery(sql);
           return i;
       }
       public DataSet select(SP_goods sg,string type)
       {
           DataSet ds = new DataSet();

           string sql = string.Format("	select XS_tTime,DH_tDanhao,DH_tdanjia,DH_tShuliang,DH_tZongjine from XS_tbale,DH_tabel where DH_tDanhao=XS_tDanhao and DH_tshangpID='{0}' and DH_tType='{1}'", sg.SP_gTiaoma, type);
           ds = DBHelper.Execute(sql);

           return ds;
        
       }
       public DataTable tueiduan(string name,string tiem1,string tiem2)
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select XS_tDanhao,XS_tTime,GH_sName,CK_tName,DH_tYmoney,DH_tSmoney,(DH_tYmoney-DH_tSmoney) as qiankuan,XS_tType,YG_xName,XS_tBeizhu"
               + " from XS_tbale,GH_shang,CK_table,YG_xinxi where XS_tKHname=GH_sId and XS_tCK=CK_tID and XS_tJinbanren=YG_xId and XS_tType='ÍË»õ'and XS_tTime>'{0}' and XS_tTime<'{1}'", tiem1, tiem2);
           if (name!="")
           {
               sql += string.Format(" and GH_sName='{0}' or XS_tDanhao='{0}'", name);
           }
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;

       }

       public DataTable tdxx(string name)
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select DH_tshangpID,SP_gName,SP_gDanweiid,DH_tdanjia,DH_tShuliang,DH_tZongjine,SP_gXinghao,Y_Name"
               + " from DH_tabel,SP_goods,Yshe where DH_tshangpID=SP_gTiaoma and Y_Id=SP_gYid and DH_tDanhao='{0}'",name);
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
       
       }

       public DataTable xiangxi(string danhao)
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select DH_tshangpID,SP_gName,DH_tdanjia,DH_tShuliang,DH_tZongjine,SP_gDanweiid,SP_gXinghao,Y_Name"
           +" from DH_tabel,SP_goods,Yshe"
           +" where DH_tshangpID=SP_gTiaoma and Y_Id=SP_gYid and DH_tDanhao='{0}'",danhao);
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
       }

       public DataTable GHSsuoyou()
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select GH_sId,GH_sName,XS_tTime,XS_tDanhao,XS_tType,DH_tYmoney,DH_tSmoney,(DH_tYmoney-DH_tSmoney) as qiankuan,YG_xName,XS_tBeizhu"
            + " from XS_tbale,GH_shang,YG_xinxi"
            + " where XS_tJinbanren=YG_xId and XS_tKHname=GH_sId");
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
       
       }

       public DataTable sghxx()
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select DH_tDanhao,DH_tshangpID,SP_gName,SP_gDanweiid,DH_tdanjia,DH_tShuliang,DH_tZongjine,SP_gXinghao,Y_Name"
            + " from DH_tabel,SP_goods,Yshe"
            + " where DH_tshangpID=SP_gTiaoma and Y_Id=SP_gYid");
           dt = DBHelper.Execute(sql).Tables[0];


           return dt;
       
       }
       public DataTable djxx(string dh)
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select DH_tDanhao,DH_tshangpID,SP_gName,SP_gDanweiid,DH_tdanjia,DH_tShuliang,DH_tZongjine,SP_gXinghao,Y_Name"
            +" from DH_tabel,SP_goods,Yshe"
            + " where DH_tshangpID=SP_gTiaoma and Y_Id=SP_gYid and DH_tDanhao='{0}'",dh);
           dt=DBHelper.Execute(sql).Tables[0];

           return dt;
       
       }

       public int insertfukuan(XS_tbale st)
       {
           int i = 0;

           string sql = string.Format("insert XS_tbale(XS_tKHname, XS_tDanhao, XS_tTime, XS_tType, XS_tBeizhu, XS_tJinbanren, DH_tYmoney, DH_tSmoney)"
            + " values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", st.XS_tKHname, st.XS_tDanhao, st.XS_tTime, st.XS_tType, st.XS_tBeizhu, st.XS_tJinbanren, st.DH_tYmoney, st.DH_tSmoney);
           i = DBHelper.ExecuteNonQuery(sql);
           return i;
       }

       public DataTable shangpmxi(string dhao)
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select DH_tDanhao,DH_tshangpID,SP_gName,SP_gDanweiid,DH_tdanjia,DH_tShuliang,(SP_gJijie*DH_tShuliang) as DH_tZongjine,SP_gXinghao,Y_Name"
            + " from DH_tabel,SP_goods,Yshe"
            + " where DH_tshangpID=SP_gTiaoma and Y_Id=SP_gYid and DH_tType='ÏúÊÛ' and DH_tDanhao='{0}'",dhao);
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
       
       }

    }
}
