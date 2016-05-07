using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data;

namespace BLL
{
   public class SP_goodsManager
    {
       SP_goodsService ss = new SP_goodsService();

       public DataTable spquanbu(SP_goods sg)
       {
           return ss.spquanbu(sg);
       }


       public DataSet select(SP_goods gd)
       {
           return ss.select(gd);
       }
       public DataSet select2(SP_goods gd)
       {
           return ss.select2(gd);
       }
       public List<SP_goods> select3(temp tp)
       {
           return ss.select3(tp);
       }
       public string lode()
       {
           return ss.lode();
       }
       public int insert(SP_goods sg)
       {
           return ss.insert(sg);
       }
       public DataTable selecttype(SP_goods sg)
       {
           return ss.selecttype(sg);
       }
       public SP_goods selectjiaru(string sid)
       {
           return ss.selectjiaru(sid);
       }
       public int updata(SP_goods sg)
       {
           return ss.updata(sg);
       }
       public int updatejian(SP_goods sg)
       {
           return ss.updatejian(sg);
       }

       SP_goodsService gs = new SP_goodsService();



       // 填充表格S_system
       public DataSet GetAllSP_goods()
       {
           return gs.GetAllSP_goods();
       }

       //查询条件
       public DataSet FindSP_goods(SP_goods aa)
       {
           return gs.FindSP_goods(aa);
       }



       //删除子表
       public DataSet DeleteSP_xmingxi(SP_xmingxi aa)
       {
           return gs.DeleteSP_xmingxi(aa);
       }
       //删除主表
       public DataSet DeleteSP_goods(SP_goods aa)
       {
           return gs.DeleteSP_goods(aa);
       }

       //填充Y_stock  dgvplsecond1
       public DataSet GetAllY_stock(string a)
       {
           return gs.GetAllY_stock(a);
       }


       //填充Y_stock
       public DataSet GetAllY_stock()
       {
           return gs.GetAllY_stock();
       }


       public DataTable cgtji()
       {
           return gs.cgtji();
       }

       public DataTable leibietj()
       {
           return gs.leibietj();
       }


   
       public DataSet GetAlllFrist()
       {
           return gs.GetAlllFrist();
       }
       //Saveselect_main1---普通查询
       public DataSet GetFrist(string a, string b, string c)
       {
           return gs.GetFrist(a, b, c);
       }

       //Saveselect_main3
       public DataSet GetThird(string a, string b)
       {
           return gs.GetThird(a, b);
       }

       public DataTable shangp()
       {
           return gs.shangp();
       }
       public DataTable shangxx(string shangp)
       {
           return gs.shangxx(shangp);
       }

       //修改
       public int UpdateSP_goods(SP_goods aa, SP_type bb, Yshe cc)
       {
           return gs.UpdateSP_goods(aa, bb, cc);
       }
       //修改判断
       public string ShowUpdateSP_goods(SP_goods aa, SP_type bb, Yshe cc)
       {
           string Message = "";
           int i = UpdateSP_goods(aa, bb, cc);
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


       public DataSet SP_goodsdu(string name)
       {
           return gs.SP_goodsdu(name);
       }
       public DataSet likeSP_goodsdu(string id, string name)
       {
           return gs.likeSP_goodsdu(id, name);
       }
       public DataSet jkehuSP_goodsdu(string name)
       {
           return gs.jkehuSP_goodsdu(name);
       }
    }
}
