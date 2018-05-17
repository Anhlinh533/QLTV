using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.ADO
{
    class adoPhieuNhapSach
    {
        private static adoPhieuNhapSach instance;

        internal static adoPhieuNhapSach Instance
        {
            get
            {
                if (instance == null) instance = new adoPhieuNhapSach(); return ADO.adoPhieuNhapSach.instance;
            }

            private set
            {
                ADO.adoPhieuNhapSach.instance = value;
            }
        }

        public void Them(string tb_IDPhieuNhap, string dtp_NgayNhap)
        {
            SCRIPT.formatPhieuNhapSach.Instance.returnIDPhieuNhapSach(ref tb_IDPhieuNhap);
            string sqlInsert = "INSERT INTO PHIEUNHAPSACH (IDPhieuNhap, NgayNhap) VALUES ('" + tb_IDPhieuNhap + "','" + dtp_NgayNhap + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDPhieuNhap)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM PHIEUNHAPSACH WHERE IDPhieuNhap ='" + tb_IDPhieuNhap + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDPhieuNhap, string dtp_NgayNhap)
        {
            //SCRIPT.formatPhieuNhapSach.Instance.returnIDPhieuNhapSach(ref tb_IDPhieuNhap);
            string sqlUpdate = "UPDATE PHIEUNHAPSACH SET NgayNhap = '" + dtp_NgayNhap + "' WHERE IDPhieuNhap = '" + tb_IDPhieuNhap + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
    }
}
