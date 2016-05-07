using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Models
{
    public class BDHelper
    {

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private static string sConn = "server=.;uid=sa;pwd=1196824358;database=csgl";

        /// <summary>
        /// 数据库连接对象
        /// </summary>
        private static SqlConnection conn = new SqlConnection(sConn);

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public static void Open()
        {
            //判断数据库连接是否关闭
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public static void Close()
        {
            //判断数据库连接是否打开
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行Command对象的ExecuteScalar方法
        /// </summary>
        /// <param name="sSql">要执行的SQL语句</param>
        /// <returns></returns>
        public static object ExecuteScalar(string sSql)
        {
            object obj = null;

            SqlCommand comm = new SqlCommand(sSql, conn);

            try
            {
                //调用当前类的数据库打开方法
                Open();

                //执行Command对象的命令
                obj = comm.ExecuteScalar();
            }
            catch
            {
                //把异常抛到调用该方法的地方
                throw;
            }
            finally
            {
                //调用当前类的数据库关闭方法
                Close();
            }

            return obj;
        }

        /// <summary>
        /// 执行Command对象的ExecuteNonQuery方法
        /// </summary>
        /// <param name="sSql">要执行的SQL语句</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sSql)   
        {
            int iResult;

            SqlCommand comm = new SqlCommand(sSql, conn);

            try
            {
                //调用当前类的数据库打开方法
                Open();

                //执行Command对象的命令
                iResult = comm.ExecuteNonQuery();
            }
            catch
            {
                //把异常抛到调用该方法的地方
                throw;
            }
            finally
            {
                //调用当前类的数据库关闭方法
                Close();
            }

            return iResult;
        }

        /// <summary>
        /// 执行Command对象的ExecuteNonQuery方法
        /// </summary>
        /// <param name="sSql">要执行的SQL语句</param>
        /// <returns></returns>
        public static bool ExecuteNonQuery(List<string> sSql)
        {
            bool bResult = false;

            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;

            try
            {
                //调用当前类的数据库打开方法
                Open();
                comm.Transaction = conn.BeginTransaction();

                foreach (string s in sSql)
                {
                    comm.CommandText = s;
                    //执行Command对象的命令
                    comm.ExecuteNonQuery();
                }

                comm.Transaction.Commit();
                bResult = true;
            }
            catch
            {
                comm.Transaction.Rollback();
                //把异常抛到调用该方法的地方
                throw;
            }
            finally
            {
                //调用当前类的数据库关闭方法
                Close();
            }

            return bResult;
        }

        /// <summary>
        /// 执行Command对象的ExecuteReader方法
        /// </summary>
        /// <param name="sSql">要执行的SQL语句</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sSql)
        {
            SqlDataReader dr = null;

            SqlCommand comm = new SqlCommand(sSql, conn);

            try
            {
                //调用当前类的数据库打开方法
                Open();

                //执行Command对象的命令
                dr = comm.ExecuteReader();
            }
            catch
            {
                //把异常抛到调用该方法的地方
                throw;
            }
            //该处不能关闭数据库连接，否则返回的DataReader对象，在外面不能读取到数据

            return dr;
        }

        /// <summary>
        /// 通过适配器填充数据集
        /// </summary>
        /// <param name="sSql">要执行的SQL语句</param>
        /// <returns></returns>
        public static DataSet Execute(string sSql)
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(sSql, conn);

            try
            {
                da.Fill(ds);
            }
            catch
            {
                throw;
            }

            return ds;
        }


    }
}
