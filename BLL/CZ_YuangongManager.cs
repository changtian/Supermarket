using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class CZ_YuangongManager
    {
        CZ_YuangongServeic cs = new CZ_YuangongServeic();
        public CZ_Yuangong chaxun(CZ_Yuangong cz)
        {
            return cs.chaxun(cz);
        }

        public bool login(CZ_Yuangong cz, ref string h)
        {
            bool b = false;
            if (cs.chaxun(cz) == null)
            {
                h = "用户名不存在";
            }
            else
            {
                if (cz.CZ_yPassword == cs.chaxun(cz).CZ_yPassword)
                {
                    h = cz.CZ_yName;
                    b = true;

                }
                else
                {
                    h = "密码错误";
                }
            }
            return b;
        }
        public List<CZ_Yuangong> add()
        {
            return cs.add();
        }



        public DataSet GetAllCZ_Yuangong()
        {
            return cs.GetAllCZ_Yuangong();
        }


        //修改
        public int GetAllCZ_Yuangong(CZ_Yuangong aa)
        {
            return cs.UpdateCZ_Yuangong(aa);
        }
        //判断修改
        public string ShowGetAllCZ_Yuangong(CZ_Yuangong aaa)
        {
            string Message;
            int i = cs.UpdateCZ_Yuangong(aaa);
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
        public int DeleteCZ_Yuangong(CZ_Yuangong aa)
        {
            return cs.DeleteCZ_Yuangong(aa);
        }

        //修改
        public int UpdateCZ_Yuangong(CZ_Yuangong aa)
        {
            return cs.UpdateCZ_Yuangong(aa);
        }
        //判断修改
        public string ShowUpdateCZ_Yuangong(CZ_Yuangong aaa)
        {
            string Message;
            int i = UpdateCZ_Yuangong(aaa);
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
        //新增
        public int GetAddCZ_Yuangong(CZ_Yuangong aa)
        {
            return cs.GetAddCZ_Yuangong(aa);
        }
        //判断新增是否成功
        public string ShowGetAddCZ_Yuangong(CZ_Yuangong aa)
        {
            string Message = "";
            int i = GetAddCZ_Yuangong(aa);
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

    }
}
