using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
   public class SP_goodsService
    {
       public DataTable spquanbu(SP_goods sg)
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select * from sp_goods,Yshe where SP_gYid=Y_Id");
           if (sg.SP_gTiaoma!="")
           {
               sql+=string.Format(" and SP_gTiaoma like '%{0}%'",sg.SP_gTiaoma);
           }
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
       
       }
       public DataSet select(SP_goods gd)
       {
           DataSet ds = new DataSet();

           string sql = string.Format("select SP_gTiaoma,SP_gName,SP_gDanweiid,SP_gXinghao,Y_Name,SP_gXijie,SP_gKucuen from SP_goods,Yshe,SP_type where SP_gYid=Y_Id and SP_gType=SP_type.SP_tId and CK_tID='{0}'", gd.CK_tID);
           if (gd.SP_gTiaoma!=""||gd.SP_gName!="")
           {
               sql += string.Format("  and SP_gTiaoma like '%{0}%' or  SP_gName like '%{0}%'", gd.SP_gName);
           }
           ds = DBHelper.Execute(sql);
           return ds;
       }
       public DataSet select2(SP_goods gd)
       {
           DataSet ds = new DataSet();
           string sql = string.Format("select * from SP_goods,Yshe,SP_type where SP_gYid=Y_Id and SP_gType=SP_type.SP_tId and  SP_gTiaoma='{0}'", gd.SP_gTiaoma);
           ds = DBHelper.Execute(sql);

           return ds;
       }
       
       public List<SP_goods> select3(temp tp)
       {
           List<SP_goods> lst = new List<SP_goods>();

           string sql = string.Format("select * from sp_goods,SP_xmingxi where SP_xName=SP_gId and SP_gTiaoma='{0}'", tp.Spbianhao);
           DataSet ds = DBHelper.Execute(sql);
           foreach (DataRow dr in ds.Tables[0].Rows)
           {
               SP_goods sg = new SP_goods();
               sg.SP_gTiaoma = dr["SP_gTiaoma"].ToString();
               sg.SP_gName = dr["SP_gName"].ToString();
               sg.SP_gDanweiid = dr["SP_gDanweiid"].ToString();
               sg.SP_gXijie = Convert.ToDouble(dr["SP_gXijie"]);
               sg.SP_gXinghao = dr["SP_gXinghao"].ToString();
               sg.SP_gYid = Convert.ToInt32(dr["SP_gYid"]);
               sg.SP_gTjjiage = tp.Danjia;
               sg.SP_gXijie = tp.Dazhel;
               sg.SP_gKucuen = tp.Shuliang;
               sg.SP_gJijie = tp.Zje;

               lst.Add(sg);
           }

           return lst;
       
       }
       public string lode()
       {
           string s = "";

           string sql = "select convert(numeric(16, 0), convert(varchar,112) + ISNULL(max(right(SP_gTiaoma, 5)), '0000')) + 1 from SP_goods where SP_gTiaoma like ' ' + convert(varchar,getdate(),112) + '%'";
           s = DBHelper.ExecuteScalar(sql).ToString();
          
           return s;
        
       }

       public int insert(SP_goods sg)
       {
           int i = 0;

           string sql = string.Format("exec proc_goods '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}'",
               sg.SP_gName, sg.SP_gTiaoma, sg.SP_gXinghao, sg.SP_gDanweiid, sg.SP_gType, sg.SP_gYid, sg.SP_gJijie, sg.SP_gXijie, sg.SP_gRiqi, sg.SP_gSchang, sg.SP_gBeizhi, sg.SP_gZhekou, sg.SP_gZengping, sg.SP_gJifen, sg.SP_gTejia,
               sg.SP_gTjjiage, sg.SP_gHueiyuan, sg.SP_gQiantime, sg.SP_gHoutime, sg.SP_gKucuen, sg.SP_gZhuangtai, sg.SP_gKucuenx,sg.CK_tID, sg.SP_gType);
           i = DBHelper.ExecuteNonQuery(sql);

           return i;
        
       }
       public DataTable selecttype(SP_goods sg)
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select SP_gTiaoma,SP_gName,SP_gDanweiid,SP_gJijie,SP_gXinghao,SP_gKucuenx from SP_goods");
           if (sg.SP_gType != 1 && sg.SP_gType != 2)
           {
               sql += string.Format(" where SP_tId='{0}'", sg.SP_gType);
           }
           if (sg.SP_gType == 2)
           {
               sql += string.Format(" where SP_tId=3 or SP_tId=4");
           }
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
        
       }
       public SP_goods selectjiaru(string sid)
       {
           SP_goods sg = new SP_goods();

           string sql = string.Format("select * from SP_Goods,Yshe where Y_Id=SP_gYid and SP_gTiaoma='{0}'", sid);
           SqlDataReader dr = DBHelper.ExecuteReader(sql);
           if (dr.Read())
           {
               
               sg.SP_gTiaoma = dr["SP_gTiaoma"].ToString();
               sg.SP_gName = dr["SP_gName"].ToString();
               sg.SP_gXinghao = dr["SP_gXinghao"].ToString();
               sg.SP_gDanweiid = dr["SP_gDanweiid"].ToString();
               sg.SP_gSchang = dr["SP_gSchang"].ToString();
              
               sg.SP_gKucuenx = Convert.ToInt32(dr["SP_gKucuenx"]);
               sg.SP_gBeizhi = dr["SP_gBeizhi"].ToString();
               sg.SP_gJijie = Convert.ToDouble(dr["SP_gJijie"]);
           }
           dr.Close();
           DBHelper.Close();

           return sg;
        
       }
       public int updata(SP_goods sg)
       {
           int i = 0;

           string sql = string.Format("update SP_goods set SP_gKucuen=(SP_gKucuen+'{0}') where SP_gTiaoma='{1}'", sg.SP_gKucuen,sg.SP_gTiaoma);
           i = DBHelper.ExecuteNonQuery(sql);

           return i;

        
       }
       public int updatejian(SP_goods sg)
       {

           int i = 0;

           string sql = string.Format("update SP_goods set SP_gKucuen=(SP_gKucuen-'{0}') where SP_gTiaoma='{1}'", sg.SP_gKucuen, sg.SP_gTiaoma);
           i = DBHelper.ExecuteNonQuery(sql);
           return i;
       }
       // 填充表格S_System
       public DataSet GetAllSP_goods()
       {
           DataSet ds = new DataSet();
           String sSql = string.Format("select * from SP_goods,SP_type,Yshe where SP_goods.SP_gType=SP_type.SP_tId and SP_goods.SP_gYid=Yshe.Y_Id");
           ds = DBHelper.Execute(sSql);
           return ds;
       }

       //新增
       public int AddSP_goods(SP_goods aa)
       {
           int i = 0;
           string sSql = string.Format("insert into SP_goods values()");
           i = DBHelper.ExecuteNonQuery(sSql);
           return i;
       }

       //查询条件
       public DataSet FindSP_goods(SP_goods aa)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select * from SP_goods,SP_type,Yshe where SP_goods.SP_gType=SP_type.SP_tId and SP_goods.SP_gYid=Yshe.Y_Id and SP_gId={0}", aa.SP_gId);
           ds = DBHelper.Execute(sSql);
           return ds;
       }

       //删除子表
       public DataSet DeleteSP_xmingxi(SP_xmingxi aa)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("delete SP_xmingxi where SP_xID={0}", aa.SP_xID);
           ds = DBHelper.Execute(sSql);
           return ds;
       }
       //删除主表
       public DataSet DeleteSP_goods(SP_goods aa)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("delete SP_goods where SP_gId={0}", aa.SP_gId);
           ds = DBHelper.Execute(sSql);
           return ds;
       }

       ////修改
       //public DataSet UpdateSP_goods(SP_goods aa)
       //{
       //    DataSet ds = new DataSet();                                                                                                                                                                                                                                                                                                                                                       //SP_gId={0},SP_gName={1},SP_tName='{2}',SP_gTiaoma='{3}',SP_gDanweiid='{4}',SP_gXinghao='{5}',Y_Name='{6}',SP_gRiqi='{7}',SP_gZhuangtai={8},SP_gTjjiage={9},SP_gKucuenx={10},SP_gJijie={11},SP_gXijie={12},SP_gZhekou={13},SP_gSchang='{14}',SP_gBeizhi='{15}'
       //    string sSql = string.Format("update from SP_goods,SP_type,Yshe where SP_goods.SP_gType=SP_type.SP_tId and SP_goods.SP_gYid=Yshe.Y_Id and SP_gId={0},SP_gName={1},SP_tName='{2}',SP_gTiaoma='{3}',SP_gDanweiid='{4}',SP_gXinghao='{5}',Y_Name='{6}',SP_gRiqi='{7}',SP_gZhuangtai={8},SP_gTjjiage={9},SP_gKucuenx={10},SP_gJijie={11},SP_gXijie={12},SP_gZhekou={13},SP_gSchang='{14}',SP_gBeizhi='{15}'",aa.SP_gId,aa.SP_gName,aa.);
       //    ds = Models.BDHelper.Execute(sSql);
       //    return ds;
       //}



       //填充Y_stock
       public DataSet GetAllY_stock()
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select * from SP_goods,Yshe where Yshe.Y_Id=SP_goods.SP_gYid");
           ds = DBHelper.Execute(sSql);
           return ds;
       }


       public DataTable cgtji()
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select SP_gTiaoma,SP_gName,SP_gDanweiid,SP_gKucuen,(SP_gJijie*SP_gKucuen) as zje,SP_gXinghao,Y_Name,SP_tName"
            + " from SP_goods,Yshe,SP_type"
            + " where SP_gYid=Y_Id and SP_goods.SP_gType=SP_type.SP_tId");
           dt = DBHelper.Execute(sql).Tables[0];
           return dt;
       
       }

       public DataTable leibietj()
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select SP_tName,SP_gKucuen,(SP_gJijie*SP_gKucuen) as zje from SP_goods,SP_type where SP_goods.SP_tId=SP_type.SP_tId");
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
       
       }

       //填充Y_stock  dgvplsecond1---------第二个在xs_tbalService
       public DataSet GetAllY_stock(string a)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select SP_gTiaoma,SP_gName,SP_gDanweiid,DH_tShuliang,SP_gKucuen,DH_tZongjine,SP_gXinghao,Y_Name,SP_gSchang,SP_gBeizhi from SP_goods,DH_tabel,Yshe,XS_tbale where SP_gTiaoma=DH_tshangpID and SP_gYid=Y_Id and XS_tbale.XS_tDanhao=DH_tabel.DH_tDanhao and DH_tDanhao='%{0}%'", a);
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }

       public DataTable shangp()
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select SP_gTiaoma,SP_gName,SP_gDanweiid,SP_gXinghao,Y_Name,SP_gSchang,SP_gBeizhi from SP_goods,Yshe where SP_gYid=Y_Id");
           dt = DBHelper.Execute(sql).Tables[0];

           return dt;
       
       }

       public DataTable shangxx(string shangp)
       {
           DataTable dt = new DataTable();

           string sql = string.Format("select DH_tDanhao,SP_gName,DH_tShuliang,SP_gDanweiid,DH_tZongjine,SP_gXinghao,Y_Name,DH_tType from SP_goods,Yshe,DH_tabel where SP_gYid=Y_Id and DH_tshangpID=SP_gTiaoma and DH_tType='销售'and DH_tshangpID='{0}'", shangp);
           dt = DBHelper.Execute(sql).Tables[0];
           return dt;
       
       }
       //Saveselect_main1   ---查出所有的
       public DataSet GetAlllFrist()
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select SP_gTiaoma,SP_gName,SP_gKucuen,SP_gJijie,SP_gJijie  as SP_gJijieCmoney,SP_gXijie,(SP_gKucuen*SP_gXijie) as Allmoney , SP_gDanweiid , SP_gXinghao,Y_Name,SP_gSchang,SP_gBeizhi,SP_tName,CK_tName "
            +"from SP_goods,Yshe,SP_type,CK_table "
            + "where SP_goods.SP_gYid=Yshe.Y_Id and SP_goods.SP_gType=SP_type.SP_tId and SP_goods.CK_tID=CK_table.CK_tID");
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }

       //Saveselect_main1          -----查找按钮
       public DataSet GetFrist(string a, string b, string c)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select SP_gTiaoma,SP_gName,SP_gKucuen,SP_gJijie,SP_gJijie  as SP_gJijieCmoney,SP_gXijie,(SP_gKucuen*SP_gXijie) as Allmoney , SP_gDanweiid , SP_gXinghao,Y_Name,SP_gSchang,SP_gBeizhi,SP_tName,CK_tName from SP_goods,Yshe,SP_type,CK_table where  SP_goods.SP_gYid=Yshe.Y_Id and SP_goods.SP_gType=SP_type.SP_tId and SP_goods.CK_tID=CK_table.CK_tID and CK_tName='{0}'and (SP_tName='%{1}%' or  SP_gTiaoma like '%{1}%')", a, c);
           if (b!="所有类别")
           {
               sSql += string.Format(" and SP_tName='{0}' ", b);
           }
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }

       public DataSet GetThird(string a, string b)
       {
           DataSet ds = new DataSet();
           string sSql = string.Format("select SP_gTiaoma,SP_gName,SP_gJijie,SP_gXijie, SP_gDanweiid , SP_gXinghao,Y_Name,SP_gSchang,SP_gBeizhi,sp_tname from SP_goods,Yshe ,SP_type where  SP_goods.SP_gYid=Yshe.Y_Id  and  SP_goods.SP_gType=SP_type.SP_tId");
           if (a!=""&&a!="所有类别")
           {
               sSql += string.Format(" and sp_tname='{0}' and SP_gTiaoma like '%{1}%'", a, b);
           }
           ds = Models.BDHelper.Execute(sSql);
           return ds;
       }


       //修改S_System           //有问题---语句
       public int UpdateSP_goods(SP_goods aa, SP_type bb, Yshe cc)
       {
           int i = 0;
           string sSql = string.Format("update from SP_goods,SP_type,Yshe  set SP_gHueiyuan={0},SP_gName={1},SP_tName='{2}',SP_gTiaoma='{3}',SP_gDanweiid='{4}',SP_gXinghao='{5}',Y_Name='{6}',SP_gRiqi='{7}',SP_gZhuangtai={8},SP_gTjjiage={9},SP_gKucuenx={10},SP_gJijie={11},SP_gXijie={12},SP_gZhekou={13},SP_gSchang='{14}',SP_gBeizhi='{15}',SP_gQiantime='{16}',SP_gHoutime='{17}' where SP_goods.SP_gType=SP_type.SP_tId and SP_goods.SP_gYid=Yshe.Y_Id and SP_gId={18}",
               aa.SP_gHueiyuan, aa.SP_gName, bb.SP_tName, aa.SP_gTiaoma, aa.SP_gDanweiid, aa.SP_gXinghao, cc.Y_Name, aa.SP_gRiqi, aa.SP_gZhuangtai, aa.SP_gTjjiage, aa.SP_gKucuenx, aa.SP_gJijie, aa.SP_gXijie, aa.SP_gZhekou, aa.SP_gSchang, aa.SP_gBeizhi, aa.SP_gQiantime, aa.SP_gHoutime, aa.SP_gId);
           i = Models.BDHelper.ExecuteNonQuery(sSql);
           return i;
       }
       public DataSet SP_goodsdu(string name)
       {
           DataSet set = null;
           string sSql = string.Format("select SP_gTiaoma,SP_gName,SP_gDanweiid,SP_gXinghao,Y_Name,SP_gXijie,SP_gKucuen,CK_tName,SP_gSchang,SP_gBeizhi" +
               " from SP_goods,Yshe,CK_table where SP_goods.SP_gYid=Yshe.Y_Id and SP_goods.CK_tID=(select CK_tID from CK_table where CK_tName='{0}')", name);
           set = DBHelper.Execute(sSql);
           return set;
       }
       public DataSet likeSP_goodsdu(string id, string name)
       {
           DataSet set = null;
           string sSql = string.Format("select SP_gTiaoma,SP_gName,SP_gDanweiid,SP_gXinghao,Y_Name,SP_gXijie,SP_gKucuen,CK_tName,SP_gSchang,SP_gBeizhi" +
               " from SP_goods as a inner join Yshe as b on(a.SP_gYid=b.Y_Id) inner join CK_table as c on(a.CK_tID=c.CK_tID) " +
               " where SP_gTiaoma like '%{0}%' or SP_gName like '%{1}%'", id, name);
           set = DBHelper.Execute(sSql);
           return set;
       }
       public DataSet jkehuSP_goodsdu(string name)
       {
           DataSet set;
           string sSql = string.Format("select DH_tshangpID,SP_gName,SP_gDanweiid,DH_tdanjia,DH_tShuliang,DH_tZongjine"
            +" from SP_goods,DH_tabel"
            +" where DH_tshangpID=SP_gTiaoma and DH_tDanhao='{0}'", name);
           set = DBHelper.Execute(sSql);
           return set;
       }
    }
}
