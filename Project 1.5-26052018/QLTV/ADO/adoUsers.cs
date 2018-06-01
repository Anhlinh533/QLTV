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
        public void Them(string tb_UserName, string tb_Password, string cbb_IDDocGia)
        {
            string sqlInsert = "INSERT INTO USERS VALUES ('" + tb_UserName + "', '" + tb_Password + "', '" + cbb_IDDocGia + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_UserName)
        {
            string sqlDelete = "DELETE FROM USERS WHERE UserName ='" + tb_UserName + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_UserName, string tb_Password, string cbb_IDDocGia)
        {
            string sqlUpdate = "UPDATE USERS SET Pwd = '" + tb_Password + "', IDDocGia = '" + cbb_IDDocGia + "' WHERE UserName = '" + tb_UserName + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
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

        public bool checkID(string ID)
        {
            string sql = "Select *from USERS where UserName='" + ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true)
                return true;
            return false;
        }
    }
}
