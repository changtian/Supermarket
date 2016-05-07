using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class HY_guanliManager
    {
        HY_guanliService hgs = new HY_guanliService();

        //所有
        public DataSet GetAllHY_guanli()
        {
            return hgs.GetAllHY_guanli();
        }

        //查询填充
        public DataSet SelectAllHY_guanli(int a)
        {
            return hgs.SelectAllHY_guanli(a);
        }


        //添加
        public int AddHY_guanli(HY_guanli aa)
        {
            return hgs.AddHY_guanli(aa);
        }
        //添加判断
        public string showAddHY_guanli(HY_guanli bb)
        {
            string Message = "";
            int i = AddHY_guanli(bb);
            if (i > 0)
            {
                Message = "新增成功";
            }
            else
            {
                Message = "新增失败";
            }
            return Message;
        }



        //修改
        public int updateHY_guanli(HY_guanli aa)
        {
            return hgs.updateHY_guanli(aa);
        }
        //修改判断
        public string ShowupdateHY_guanli(HY_guanli aa)
        {
            string Message;
            int i = updateHY_guanli(aa);
            if (i > 0)
            {
                Message = "修改成功";
            }
            else
            {
                Message = "修改失败";
            }
            return Message;
        }


        //删除
        public int deleteHY_guanli(HY_guanli aa)
        {
            return hgs.deleteHY_guanli(aa);
        }

    }
}
