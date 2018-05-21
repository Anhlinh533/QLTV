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
        public void Them(string tb_IDAdMin, string tb_HoTenAdmin, string dtp_NgaySinhAdmin, string tb_DiaChiAdmin, string tb_EmailAdmin)
        {
            SCRIPT.formatCTAdmin.Instance.returnIDCTAdmin(ref tb_IDCTAdMin);
            string sqlInsert = "INSERT INTO CT_USERADMIN VALUES ('" + tb_IDAdMin + "', N'" + tb_HoTenAdmin + "', '" + dtp_NgaySinhAdmin + "', N'" + tb_DiaChiAdmin + "', '" + tb_EmailAdmin + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDAdMin)
        {
            //SCRIPT.formatCTAdmin.Instance.returnIDCTAdmin(ref tb_IDCTAdMin);
            string sqlDelete = "DELETE FROM CT_USERADMIN WHERE IDAdMin ='" + tb_IDAdMin + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDAdMin, string tb_HoTenAdmin, string dtp_NgaySinhAdmin, string tb_DiaChiAdmin, string tb_EmailAdmin)
        {
            //SCRIPT.formatCTAdmin.Instance.returnIDCTAdmin(ref tb_IDCTAdMin);
            string sqlUpdate = "UPDATE CT_USERADMIN SET HoTenAdmin = N'" + tb_HoTenAdmin + "', NgaySinhAdmin = '" + dtp_NgaySinhAdmin + "', DiaChiAdmin = N'" + tb_DiaChiAdmin + "', EmailAdmin = '" + tb_EmailAdmin + "' WHERE IDAdMin = '" + tb_IDAdMin + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion

    }
}
