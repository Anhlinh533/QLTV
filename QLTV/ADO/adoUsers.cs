using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoUsers
    {
        private static adoUsers instance;

        internal static adoUsers Instance
        {
            get
            {
                if (instance == null) instance = new adoUsers(); return ADO.adoUsers.instance;
            }

            private set
            {
                ADO.adoUsers.instance = value;
            }
        }

        #region Insert
        public void TKUserName(string Username)
        {
            string SQlSearch = "Select * from USERS where UserName like '%" + Username + "%' ";
            ADO.ConnectionSQL.Instance.Execute(SQlSearch);
        }

        public void TKIDDocGia(string IDDocGia)
        {
            string SQlSearch = "Select * from USERS where IDDocGia like '%" + IDDocGia + "%' ";
            ADO.ConnectionSQL.Instance.Execute(SQlSearch);
        }
        #endregion

        #region TimKiem
        public string TKUserIDDocGia(string IDDocGia)
        {
            IDDocGia = "Select * from USERS where IDDocGia like '%" + IDDocGia + "%' ";
            return IDDocGia;
        }

        public string TKUser(string UserName)
        {
            UserName = "Select * from USERS where UserName like '%" + UserName + "%' ";
            return UserName;
        }
        #endregion
    }
}
