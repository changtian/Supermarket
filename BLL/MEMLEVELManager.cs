using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class MEMLEVELManager
    {
        MEMLEVELService mms = new MEMLEVELService();


        //填充
        public DataSet GetAllMEMLEVEL()
        {
            return mms.GetAllMEMLEVEL();
        }


        //添加
        public int AddMEMLEVEL(MEMLEVEL aa)
        {
            return mms.AddMEMLEVEL(aa);
        }

        //添加判断
        public string ShowAddMEMLEVEL(MEMLEVEL bb)
        {
            string Message;
            int i = AddMEMLEVEL(bb);
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
        public int UpdateMEMLEVEL(MEMLEVEL aa)
        {
            return mms.UpdateMEMLEVEL(aa);
        }

        //修改判断
        public string ShowUpdateMEMLEVEL(MEMLEVEL bb)
        {
            string Message = "";
            int a = UpdateMEMLEVEL(bb);
            if (a > 0)
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
        public int deleteMEMLEVEL(MEMLEVEL aa)
        {
            return mms.deleteMEMLEVEL(aa);
        }

        public string ShowdeleteMEMLEVEL(MEMLEVEL aa)
        {
            string Message;
            int i = deleteMEMLEVEL(aa);
            if (i > 0)
            {
                Message = "删除成功";
            }
            else
            {
                Message = "删除失败";
            }
            return Message;
        }

        
        //查询
        public DataSet selectMEMLEVEL(int aa)
        {
            return mms.selectMEMLEVEL(aa);
        }



     
    }
}
