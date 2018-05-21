using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        #region Insert
        public void Them(string tb_UserName, string tb_Password, string cbb_IDAdmin)
        {
            SCRIPT.formatAdmin.Instance.returnIDAdmin(ref tb_IDAdmin);
            string sqlInsert = "INSERT INTO USERADMIN VALUES ('" + tb_UserName + "', '" + tb_Password + "', '" + cbb_IDAdmin + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_UserName)
        {
            //SCRIPT.formatAdmin.Instance.returnIDAdmin(ref tb_IDAdmin);
            string sqlDelete = "DELETE FROM USERADMIN WHERE UserNameAdmin ='" + tb_UserName + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_UserName, string tb_Password, string cbb_IDAdmin)
        {
            //SCRIPT.formatAdmin.Instance.returnIDAdmin(ref tb_IDAdmin);
            string sqlUpdate = "UPDATE USERADMIN SET PasswordAdmin = '" + tb_Password + "' WHERE UserNameAdmin = '" + tb_UserName + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion

    }
}
