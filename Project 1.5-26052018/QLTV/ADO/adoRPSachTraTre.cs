using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV.ADO
{
    class adoRPSachTraTre
    {
        private static adoRPSachTraTre instance;

        internal static adoRPSachTraTre Instance
        {
            get
            {
                if (instance == null) instance = new adoRPSachTraTre(); return ADO.adoRPSachTraTre.instance;
            }

            private set
            {
                ADO.adoRPSachTraTre.instance = value;
            }
        }

        public SqlDataAdapter Chons(string dtp_NgayThangNam)
        {            
            string sql = "SELECT TenDauSach FROM BCSACHTRATRE A, DAUSACH B, SACH C, CUONSACH D WHERE B.IDDauSach = C.IDDauSach AND C.IDSach = D.IDSach AND D.IDCuonSach = A.IDCuonSach AND A.NgayThangNam <= '" + dtp_NgayThangNam + "' AND A.SoNgayTraTre <> 0";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public SqlDataAdapter Chonm(string dtp_NgayThangNam)
        {
            string sql = "SELECT B.NgayMuon FROM BCSACHTRATRE A, PHIEUMUON B WHERE B.IDPhieuMuon = A.IDPhieuMuon AND A.NgayThangNam <= '" + dtp_NgayThangNam + "' AND A.SoNgayTraTre <> 0";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public SqlDataAdapter Chonr(string dtp_NgayThangNam)
        {
            string sql = "SELECT * FROM BCSACHTRATRE WHERE NgayThangNam <= '" + dtp_NgayThangNam + "' AND SoNgayTraTre <> 0" ;
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }
    }
}
