using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV.ADO
{
    class adoRPTinhHinhMuonSach
    {
        private static adoRPTinhHinhMuonSach instance;

        internal static adoRPTinhHinhMuonSach Instance
        {
            get
            {
                if (instance == null) instance = new adoRPTinhHinhMuonSach(); return ADO.adoRPTinhHinhMuonSach.instance;
            }

            private set
            {
                ADO.adoRPTinhHinhMuonSach.instance = value;
            }
        }

        #region Report
        public SqlDataAdapter Chons(string tb_IDBCMuonSach)
        {
            //SCRIPT.formatRPTinhHinhMuonSach.Instance.returnIDBCMuonSach(ref tb_IDBCMuonSach);
            string sql = "SELECT A.TenLoaiSach FROM LOAISACH A, CT_BCTINHHINHMUONSACH B WHERE B.IDBCMuonSach = '" + tb_IDBCMuonSach + "' AND A.IDLoaiSach = B.IDLoaiSach";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public SqlDataAdapter Chonr(string tb_IDBCMuonSach)
        {
            //SCRIPT.formatRPTinhHinhMuonSach.Instance.returnIDBCMuonSach(ref tb_IDBCMuonSach);
            string sql = "SELECT * FROM BCTINHHINHMUONSACH WHERE IDBCMuonSach = '" + tb_IDBCMuonSach + "'";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public SqlDataAdapter Chonrc(string tb_IDBCMuonSach)
        {
            //SCRIPT.formatRPTinhHinhMuonSach.Instance.returnIDBCMuonSach(ref tb_IDBCMuonSach);
            string sql = "SELECT * FROM CT_BCTINHHINHMUONSACH WHERE IDBCMuonSach = '" + tb_IDBCMuonSach + "'";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public SqlDataAdapter Chona(string AdminName)
        {
            string sql = "SELECT HoTenAdmin FROM USERADMIN A, CT_USERADMIN B WHERE A.IDAdmin = B.IDAdmin AND A.UserNameAdmin = '" + AdminName + "'";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }
        #endregion

        public string IDReport(string Thang, string Nam)
        {
            string sql = "SELECT IDBCMuonSach FROM BCTINHHINHMUONSACH WHERE Thang = '" + Thang + "' AND Nam = '" + Nam + "'";
            string i = ADO.ConnectionSQL.Instance.ExcuteString(sql);
            return i;
        }
    }
}
