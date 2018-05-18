using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoLogin
    {
        private static adoLogin instance;

        internal static adoLogin Instance
        {
            get
            {
                if (instance == null) instance = new adoLogin(); return ADO.adoLogin.instance;
            }

            private set
            {
                ADO.adoLogin.instance = value;
            }
        }
        public bool checkDocGia(string UserName, string Password)
        {
            string sql= "Select *from USERS where UserName='" + UserName + "' and Pwd='" + Password + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true) return true;
            return false;
        }

        public bool checkAdmin(string UserName, string Password)
        {
            string sql = "Select *from USERADMIN where UserNameAdmin='" + UserName + "' and PasswordAdmin='" + Password + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true) return true;
            return false;
        }

        public bool checkUserName(string UserName)
        {
            string sql = "Select *from USERS where UserName='" + UserName +"'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true) return true;
            return false;
        }
        public bool checkIDDocGia(string ID)
        {
            string sql = "Select *from THEDOCGIA where IDDocGia='IDG" + ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true) return true;
            return false;
        }
    }
}
