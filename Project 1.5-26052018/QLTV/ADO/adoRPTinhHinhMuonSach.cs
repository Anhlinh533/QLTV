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

        public void Them(string tb_IDBCMuonSach, string tb_Thang, string tb_Nam)
        {
            SCRIPT.formatRPTinhHinhMuonSach.Instance.returnIDBCMuonSach(ref tb_IDBCMuonSach);
            string sqlInsert = "INSERT INTO BCTINHHINHMUONSACH (IDBCMuonSach, Thang, Nam)  VALUES ('" + tb_IDBCMuonSach + "', '" + tb_Thang + "', '" + tb_Nam + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public SqlDataAdapter Chons(string tb_IDBCMuonSach)
        {
            SCRIPT.formatRPTinhHinhMuonSach.Instance.returnIDBCMuonSach(ref tb_IDBCMuonSach);
            string sql = "SELECT A.TenLoaiSach FROM LOAISACH A, CT_BCTINHHINHMUONSACH B WHERE B.IDBCMuonSach = '" + tb_IDBCMuonSach + "' AND A.IDLoaiSach = B.IDLoaiSach";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public SqlDataAdapter Chonr(string tb_IDBCMuonSach)
        {
            SCRIPT.formatRPTinhHinhMuonSach.Instance.returnIDBCMuonSach(ref tb_IDBCMuonSach);
            string sql = "SELECT TongSoLuotMuon FROM BCTINHHINHMUONSACH WHERE IDBCMuonSach = '" + tb_IDBCMuonSach + "'";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public SqlDataAdapter Chonrc(string tb_IDBCMuonSach)
        {
            SCRIPT.formatRPTinhHinhMuonSach.Instance.returnIDBCMuonSach(ref tb_IDBCMuonSach);
            string sql = "SELECT * FROM CT_BCTINHHINHMUONSACH WHERE IDBCMuonSach = '" + tb_IDBCMuonSach + "'";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public int IDReport()
        {
            string sql = "SELECT COUNT (IDBCMuonSach) FROM BCTINHHINHMUONSACH";
            int i = ADO.ConnectionSQL.Instance.ExcuteInt(sql);
            return i;
        }
    }
}
