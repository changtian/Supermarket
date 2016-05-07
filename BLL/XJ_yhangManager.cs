using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class XJ_yhangManager
    {
        XJ_yhangService yh = new XJ_yhangService();
        public DataSet XJ_yhang()
        {
            return yh.XJ_yhang();
        }

        public bool chuXJ_yhang(int i,string beizhu,string name)
        {
            bool b = false;
            int bs = yh.chuXJ_yhang(i,beizhu,name);
            if (bs > 0)
            {
                b = true;
                Console.WriteLine("更新成功");
            }
            else
            {
                Console.WriteLine("更新失败");
            }
            return b;
        }

        public bool jingXJ_yhang(int i,string beizhu,string name)
        {
            bool b = false;
            int bs = yh.jingXJ_yhang(i,beizhu,name);
            if (bs > 0)
            {
                b = true;
                Console.WriteLine("更新成功");
            }
            else
            {
                Console.WriteLine("更新失败");
            }
            return b;
        }
    }
}
