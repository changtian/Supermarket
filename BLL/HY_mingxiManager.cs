using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class HY_mingxiManager
    {
        HY_mingxiService ss = new HY_mingxiService();

        //填充所有
        public DataSet GetAllHY_mingxi()
        {
            return ss.GetAllHY_mingxi();
        }

        //查询dataGridView2
        public DataSet SelectHY_mingxi(DateTime a1, DateTime a2, int a3)
        {
            return ss.SelectHY_mingxi(a1, a2,a3);
        }

            //填充dataGridView3
        public DataSet GetdataGridView3HY_mingxi()
        {
            return ss.GetdataGridView3HY_mingxi();
        }


        
        //查询dataGridView3
        public DataSet SelectdataGridView3HY_mingxi(DateTime a1, DateTime a2,string a3)
        {
            return ss.SelectdataGridView3HY_mingxi(a1, a2,a3);
        }
    }
}
