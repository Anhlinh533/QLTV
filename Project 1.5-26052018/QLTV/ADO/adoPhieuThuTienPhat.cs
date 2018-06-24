using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV.ADO
{
    class adoPhieuThuTienPhat
    {
        private static adoPhieuThuTienPhat instance;

        internal static adoPhieuThuTienPhat Instance
        {
            get
            {
                if (instance == null) instance = new adoPhieuThuTienPhat(); return ADO.adoPhieuThuTienPhat.instance;
            }

            private set
            {
                ADO.adoPhieuThuTienPhat.instance = value;
            }
        }

        #region Query
        public void Them(string tb_IDPhieuThu, string tb_IDDocGia, string dtp_NgayLap, string tb_SoTienThu)
        {            
            SCRIPT.formatPhieuThuTienPhat.Instance.returnIDPhieuThu(ref tb_IDPhieuThu);
            SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlInsert = "INSERT INTO PHIEUTHUTIENPHAT (IDPhieuThu, IDDocGia, NgayLap, SoTienThu) VALUES ('" + tb_IDPhieuThu + "','" + tb_IDDocGia + "','" + dtp_NgayLap + "','" + tb_SoTienThu + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDPhieuThu)
        {
            //SCRIPT.formatPhieuThuTienPhat.Instance.returnIDPhieuThu(ref tb_IDPhieuThu);
            string sqlDelete = "DELETE FROM PHIEUTHUTIENPHAT WHERE IDPhieuThu = '" + tb_IDPhieuThu + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDPhieuThu, string tb_IDDocGia, string dtp_NgayLap, string tb_SoTienThu)
        {
            //SCRIPT.formatPhieuThuTienPhat.Instance.returnIDPhieuThu(ref tb_IDPhieuThu);
            string sqlUpdate = "UPDATE PHIEUTHUTIENPHAT SET IDDocGia = '" + tb_IDDocGia + "', NgayLap = '" + dtp_NgayLap + "', SoTienThu = '" + tb_SoTienThu + "' WHERE IDPhieuThu = '" + tb_IDPhieuThu + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion

        public SqlDataAdapter Chont(string tb_IDPhieuThu)
        {
            SCRIPT.formatPhieuThuTienPhat.Instance.returnIDPhieuThu(ref tb_IDPhieuThu);
            string sql = "SELECT HoTenDG FROM THEDOCGIA A, PHIEUTHUTIENPHAT B WHERE IDPhieuThu = '" + tb_IDPhieuThu + "' AND A.IDDocGia = B.IDDocGia";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public SqlDataAdapter Chonp(string tb_IDPhieuThu)
        {
            SCRIPT.formatPhieuThuTienPhat.Instance.returnIDPhieuThu(ref tb_IDPhieuThu);
            string sql = "SELECT * FROM PHIEUTHUTIENPHAT WHERE IDPhieuThu = '" + tb_IDPhieuThu + "'";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public SqlDataAdapter Chona(string AdminName)
        {
            string sql = "SELECT HoTenAdmin FROM USERADMIN A, CT_USERADMIN B WHERE A.IDAdmin = B.IDAdmin AND A.UserNameAdmin = '" + AdminName + "'";
            SqlDataAdapter adp = ADO.ConnectionSQL.Instance.ExcuteAdapter(sql);

            return adp;
        }

        public int IDCount()
        {
            string sql = "SELECT COUNT (IDPhieuThu) FROM PHIEUTHUTIENPHAT";
            int i = ADO.ConnectionSQL.Instance.ExcuteInt(sql);
            return i;
        }
    }
}
