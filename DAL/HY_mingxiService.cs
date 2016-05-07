using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;

namespace DAL
{
    public class HY_mingxiService
    {

        //填充所有
        public DataSet GetAllHY_mingxi()
        {
            DataSet ds = new DataSet();
            string sSql = string.Format("select * from HY_mingxi");
            ds = Models.BDHelper.Execute(sSql);
            return ds;
        }


        //查询
        public DataSet SelectHY_mingxi(DateTime a1, DateTime a2, int a3)
        {
            DataSet ds = new DataSet();
            string sSql = string.Format("select * from HY_mingxi where HY_mTime between '{0}' and '{1}' and HY_id={2}",a1,a2,a3);
            ds = Models.BDHelper.Execute(sSql);
            return ds;
        }


        //填充dataGridView3
        public DataSet GetdataGridView3HY_mingxi()
        {
            DataSet ds = new DataSet();
            string sSql = string.Format("select * from HY_mingxi,HY_guanli where HY_guanli.HY_Id=HY_mingxi.HY_Id");
            ds = Models.BDHelper.Execute(sSql);
            return ds;
        }


        //查询dataGridView3
        public DataSet SelectdataGridView3HY_mingxi(DateTime a1, DateTime a2,string a3)
        {
            DataSet ds = new DataSet();
            string sSql = string.Format("select * from HY_mingxi,HY_guanli where HY_guanli.HY_Id=HY_mingxi.HY_Id and HY_mTime>'{0}' and HY_mTime<'{1}'and HY_name like '%{2}%'", a1, a2,a3);
            ds = Models.BDHelper.Execute(sSql);
            return ds;
        }


    }
}
