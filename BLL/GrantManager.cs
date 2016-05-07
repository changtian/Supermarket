using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class GrantManager
    {
        GrantService gs = new GrantService();

        //填充
        public List<Grant> GetAllGrant()
        {
            return gs.GetAllGrant();
        }

               //增加
        public int AddGrant(Grant g)
        {
            return gs.AddGrant(g);
        }


               //删除
        public int DeleteGrant(Grant g)
        {
            return gs.DeleteGrant(g);
        }
    }
}
