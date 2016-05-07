using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
    public class CG_tableService
    {
        public int insert(CG_table gt)
        {
            int i = 0;
            //string sql2 = string.Format("insert DH_tabel(DH_tDanhao, DH_tshangpID, DH_tType, DH_tShuliang, DH_tdzl, DH_tdanjia, DH_tZongjine)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
            //   dt.DH_tDanhao, dt.DH_tshangpID, dt.DH_tType, dt.DH_tShuliang, dt.DH_tdzl, dt.DH_tdanjia, dt.DH_tZongjine);
            string sql = string.Format("insert CG_table(CF_tdanhao, CF_ttype, CF_tcangku, CF_ttime,CF_spbianhao, CF_tjbren, CF_beizhu,CF_shuliang)"
                + " values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", gt.CF_tdanhao, gt.CF_ttype, gt.CF_tcangku, gt.CF_ttime, gt.CF_spbianhao, gt.CF_tjbren, gt.CF_beizhu, gt.CF_tshuliang);
            //List<string> lst=new List<string>();
            //lst.Add(sql);
            //lst.Add(sql2);
            i = DBHelper.ExecuteNonQuery(sql);
            return i;

        }
        public DataTable kbcf(string stype,string spname,string time1,string time2)
        {
            DataTable dt = new DataTable();

            string sql = string.Format("select CF_tdanhao,CF_ttime,CK_tName,CF_spbianhao,SP_gName,SP_gJijie,CF_shuliang,(SP_gJijie*CF_shuliang) as zje,YG_xName,CF_beizhu"
            + " from CG_table,CK_table,YG_xinxi,SP_goods"
            + " where CF_spbianhao=SP_gTiaoma and CF_tcangku=CK_table.CK_tID and CF_tjbren=YG_xId and CF_ttype='{0}' and CF_ttime>'{1}' and CF_ttime<'{2}'", stype,time2,time1);
            if (spname != "")
            {
                sql += string.Format(" and  CF_spbianhao='{0}'",spname);
            }
            dt = DBHelper.Execute(sql).Tables[0];

            return dt;


        }
    }
}
