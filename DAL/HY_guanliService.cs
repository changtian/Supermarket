using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Data;


namespace DAL
{
    public class HY_guanliService
    {
        //填充所有
        public DataSet GetAllHY_guanli()
        {//select * from HY_guanli,MEMLEVEL where MEMLEVEL.mHY_Jibei=HY_guanli.HY_Jibei
            DataSet ds = new DataSet();
            string sSql = string.Format("select * from HY_guanli");
            ds = Models.BDHelper.Execute(sSql);
            return ds;
        }

        //查询填充
        public DataSet SelectAllHY_guanli(int a)
        {
            DataSet ds = new DataSet();
            string sSql = string.Format("select * from HY_guanli where HY_Id={0}", a);
            ds = Models.BDHelper.Execute(sSql);
            return ds;
        }


        //增加
        public int AddHY_guanli(HY_guanli aa)
        {
            int i;
            string sSql = string.Format("insert into  HY_guanli values({0},{1},{2},{3},'{4}','{5}','{6}','{7}',{8},'{9}','{10}',{11},{12},'{13}','{14}')", aa.HY_Jibei, aa.HY_ACOUNT, aa.HY_ALLCOST, aa.HY_COSTNUM, aa.HY_Name, aa.HY_Password, aa.HY_Shengri, aa.HY_Jifen, aa.HY_Dianhua, aa.HY_Jiarutime, aa.HY_Daoqitime, aa.HY_Zhuangtai, aa.HY_Shengji, aa.HY_SYQX, aa.HY_Beizhu);
            i = Models.BDHelper.ExecuteNonQuery(sSql);
            return i;
        }

        //修改
        public int updateHY_guanli(HY_guanli aa)
        {
            int i = 0;
            string sSql = string.Format("update HY_guanli set HY_Jibei={0},HY_Name='{1}',HY_Password='{2}',HY_Shengri='{3}',HY_Jifen={4},HY_Dianhua='{5}',HY_Jiarutime='{6}',HY_Daoqitime='{7}',HY_Zhuangtai={8},HY_Shengji={9},HY_SYQX='{10}',HY_Beizhu='{11}' where HY_Id={12}",aa.HY_Jibei, aa.HY_Name, aa.HY_Password, aa.HY_Shengri, aa.HY_Jifen, aa.HY_Dianhua, aa.HY_Jiarutime, aa.HY_Daoqitime, aa.HY_Zhuangtai,aa.HY_Shengji, aa.HY_SYQX, aa.HY_Beizhu,aa.HY_Id);
            i = Models.BDHelper.ExecuteNonQuery(sSql);
            return i;
        }

        //删除
        public int deleteHY_guanli(HY_guanli aa)
        {
            int i = 0;
            string sSql = string.Format("delete HY_guanli where HY_Id={0}",aa.HY_Id);
            i = Models.BDHelper.ExecuteNonQuery(sSql);
            return i;
        }

    }
}
