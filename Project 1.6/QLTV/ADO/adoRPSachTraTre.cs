using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTV.GUI;

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

        public SqlDataAdapter Chont(string dtp_NgayThangNam)
        {
            string sql = "SELECT B.NgayTra FROM BCSACHTRATRE A, PHIEUTRA B, CT_PHIEUTRA C WHERE C.IDPhieuMuon = A.IDPhieuMuon AND B.IDPhieuTra = C.IDPhieuTra AND C.IDCuonSach = A.IDCuonSach AND A.NgayThangNam <= '" + dtp_NgayThangNam + "' AND A.SoNgayTraTre <> 0";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public SqlDataAdapter Chonr(string dtp_NgayThangNam)
        {
            string sql = "SELECT * FROM BCSACHTRATRE WHERE NgayThangNam <= '" + dtp_NgayThangNam + "' AND SoNgayTraTre <> 0";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public SqlDataAdapter Chona(string AdminName)
        {
            string sql = "SELECT HoTenAdmin FROM USERADMIN A, CT_USERADMIN B WHERE A.IDAdmin = B.IDAdmin AND A.UserNameAdmin = '" + AdminName + "'";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }
    }
}
