using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public  class RoleManager
    {
        RoleService rsg = new RoleService();
        public DataSet GetAllRole()
        {
            return  rsg.GetAllRole();
        }

    }
}
