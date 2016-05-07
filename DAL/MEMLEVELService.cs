using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class MEMLEVELService
    {
        //填充
        public DataSet GetAllMEMLEVEL()
        {
            DataSet ds = new DataSet();
            string sSql = string.Format("select  * from MEMLEVEL");
            ds = Models.BDHelper.Execute(sSql);
            return ds;
        }

        //添加
        public int AddMEMLEVEL(MEMLEVEL aa)
        {
            int i = 0;
            string sSql = string.Format("insert into MEMLEVEL values('{0}',{1},{2},{3})",aa.MEMLEVEL_NAME,aa.MEMLEVEL_DISCOUNT,aa.MEMLEVEL_LOWSCORE,aa.MEMLEVEL_HIGHSCORE);
            i = Models.BDHelper.ExecuteNonQuery(sSql);
            return i;
        }
       
        //修改
        public int UpdateMEMLEVEL(MEMLEVEL aa)
        {
            int i = 0;
            string sSql = string.Format("update MEMLEVEL set MEMLEVEL_NAME='{0}',MEMLEVEL_DISCOUNT={1},MEMLEVEL_LOWSCORE='{2}',MEMLEVEL_HIGHSCORE={3} where MHY_Jibei={4}", aa.MEMLEVEL_NAME, aa.MEMLEVEL_DISCOUNT, aa.MEMLEVEL_LOWSCORE, aa.MEMLEVEL_HIGHSCORE,aa.MHY_Jibei);
            i = Models.BDHelper.ExecuteNonQuery(sSql);
            return i;
        }

        //删除
        public int deleteMEMLEVEL(MEMLEVEL aa)
        {
            int i = 0;
            string sSql = string.Format("delete MEMLEVEL where MHY_Jibei={0}",aa.MHY_Jibei);
            i = Models.BDHelper.ExecuteNonQuery(sSql);
            return i;
        }


        //查询
        public DataSet selectMEMLEVEL(int aa)
        {
            string sSql = string.Format("select * from MEMLEVEL where MHY_Jibei={0}", aa);
            DataSet ds = Models.BDHelper.Execute(sSql);
            return ds;
        }

    }
}
