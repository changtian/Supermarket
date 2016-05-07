using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace BLL
{
   public class CommonMethod
    {
        public static void PrintExcel(DataGridView dgv, string Caption)
        {
            Excel.Application app = new Excel.Application();
            app.Visible = true;

            try
            {
                object obj = System.Reflection.Missing.Value;
                Excel.Workbooks wb = app.Workbooks;
                Excel._Workbook iwk = wb.Add(obj);
                Excel._Worksheet sheet = (Excel._Worksheet)(iwk.ActiveSheet);

                app.Caption = Caption;


                //添加列
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    sheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                //添加行
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        sheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("导出时出错，可能由于你的电脑没有安装Excel");
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
