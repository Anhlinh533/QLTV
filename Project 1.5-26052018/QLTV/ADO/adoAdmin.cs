using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLTV.ADO
{
    class adoAdmin
    {
        private static adoAdmin instance;

        internal static adoAdmin Instance
        {
            get
            {
                if (instance == null) instance = new adoAdmin(); return ADO.adoAdmin.instance;
            }

            private set
            {
                ADO.adoAdmin.instance = value;
            }
        }

        #region Query
        public void Them(string tb_UserNameAdmin, string tb_PasswordAdmin, string tb_IDAdmin)
        {
            //SCRIPT.formatAdmin.Instance.returnIDAdmin(ref tb_IDAdmin);
            string sqlInsert = "INSERT INTO USERADMIN VALUES ('" + tb_UserNameAdmin + "', '" + tb_PasswordAdmin + "', '" + tb_IDAdmin + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_UserNameAdmin)
        {
            //SCRIPT.formatAdmin.Instance.returnIDAdmin(ref tb_IDAdmin);
            string sqlDelete = "DELETE FROM USERADMIN WHERE UserNameAdmin ='" + tb_UserNameAdmin + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_UserNameAdmin, string tb_PasswordAdmin, string tb_IDAdmin)
        {
            //SCRIPT.formatAdmin.Instance.returnIDAdmin(ref tb_IDAdmin);
            string sqlUpdate = "UPDATE USERADMIN SET PasswordAdmin = '" + tb_PasswordAdmin + "', IDAdmin = '" + tb_IDAdmin + "' WHERE UserNameAdmin = '" + tb_UserNameAdmin + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion

        public void XuatExcel(ref DataGridView dgv, string sql, string DuongDan)
        {
            ADO.ConnectionSQL.Instance.FillDgv(ref dgv, sql);

            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;

            for (int i = 1; i < dgv.Columns.Count + 1; i++)
                obj.Cells[1, i] = dgv.Columns[i - 1].HeaderText;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                        obj.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            obj.ActiveWorkbook.SaveCopyAs(DuongDan + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        public string GetQueryFillDgv()
        {
            string sql = "SELECT UserNameAdmin, PasswordAdmin, A.IDAdmin, HoTenAdmin FROM USERADMIN A, CT_USERADMIN B WHERE A.IDAdmin = B.IDAdmin";
            return sql;
        }
        
        public bool checkAdmin(string ID)
        {
            string sql = "Select IDAdmin USERADMIN where IDAdmin = 'IDA"+ ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true)
                return true;
            return false;
        }
    }
}
