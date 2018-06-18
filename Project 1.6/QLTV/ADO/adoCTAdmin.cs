using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoCTAdmin
    {
        private static adoCTAdmin instance;

        internal static adoCTAdmin Instance
        {
            get
            {
                if (instance == null) instance = new adoCTAdmin(); return ADO.adoCTAdmin.instance;
            }

            private set
            {
                ADO.adoCTAdmin.instance = value;
            }
        }

        #region Insert
        public void Them(string tb_IDAdmin, string tb_HoTenAdmin, string dtp_NgaySinhAdmin, string tb_DiaChiAdmin, string tb_EmailAdmin)
        {
            SCRIPT.formatCTAdmin.Instance.returnIDCTAdmin(ref tb_IDAdmin);
            string sqlInsert = "INSERT INTO CT_USERADMIN VALUES ('" + tb_IDAdmin + "', '" + tb_HoTenAdmin + "', N'" + dtp_NgaySinhAdmin + "', '" + tb_DiaChiAdmin + "', N'" + tb_EmailAdmin + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDAdmin)
        {
            //SCRIPT.formatCTAdmin.Instance.returnIDCTAdmin(ref tb_IDCTAdMin);
            string sqlDelete = "DELETE FROM CT_USERADMIN WHERE IDAdmin ='" + tb_IDAdmin + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDAdmin, string tb_HoTenAdmin, string dtp_NgaySinhAdmin, string tb_DiaChiAdmin, string tb_EmailAdmin)
        {
            //SCRIPT.formatCTAdmin.Instance.returnIDCTAdmin(ref tb_IDCTAdMin);
            string sqlUpdate = "UPDATE CT_USERADMIN SET HoTenAdmin = N'" + tb_HoTenAdmin + "', NgaySinhAdmin = '" + dtp_NgaySinhAdmin + "', DiaChiAdmin = N'" + tb_DiaChiAdmin + "', EmailAdmin = N'" + tb_EmailAdmin + "' WHERE IDAdmin = '" + tb_IDAdmin + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion

        public string GetQueryFillDgv()
        {
            string sql = "SELECT * FROM CT_USERADMIN";
            return sql;
        }
    }
}
