using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoCTPhieuNhapSach
    {
        private static adoCTPhieuNhapSach instance;

        internal static adoCTPhieuNhapSach Instance
        {
            get
            {
                if (instance == null) instance = new adoCTPhieuNhapSach(); return ADO.adoCTPhieuNhapSach.instance;
            }

            private set
            {
                ADO.adoCTPhieuNhapSach.instance = value;
            }
        }

        public void Them(string tb_IDCTPhieuNhap, string cbb_IDPhieuNhap, string cbb_IDSach, string cbb_TacGia, string cbb_NamXB, string tb_SoLuong, string tb_DonGia)
        {
            cbb_IDSach = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDDauSach FROM DAUSACH WHERE TenDauSach = N'" + cbb_IDSach + "'");
            cbb_TacGia = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDCTTacGia FROM CT_TACGIA A, TACGIA B WHERE A.IDTacGia = B.IDTacGia AND A.IDDauSach = '" + cbb_IDSach + "'AND B.TenTacGia = N'" + cbb_TacGia + "'");
            cbb_IDSach = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDSach FROM SACH WHERE IDDauSach = '" + cbb_IDSach + "' AND IDCTTacGia = '" + cbb_TacGia + "' AND NamXB = '" + cbb_NamXB +"'");

            SCRIPT.formatCTPhieuNhapSach.Instance.returnCTPhieuNhapSach(ref tb_IDCTPhieuNhap);
            string sqlInsert = "INSERT INTO CT_PHIEUNHAPSACH (IDCTPhieuNhap, IDPhieuNhap, IDSach, SoLuong, DonGia) VALUES ('" + tb_IDCTPhieuNhap + "','" + cbb_IDPhieuNhap + "','" + cbb_IDSach + "','" + tb_SoLuong + "','" + tb_DonGia + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDCTPhieuNhap)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM CT_PHIEUNHAPSACH WHERE IDCTPhieuNhap ='" + tb_IDCTPhieuNhap + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDCTPhieuNhap, string cbb_IDPhieuNhap, string cbb_IDSach, string tb_SoLuong, string tb_DonGia)
        {
            //SCRIPT.formatCTPhieuNhapSach.Instance.returnCTPhieuNhapSach(ref tb_IDCTPhieuNhap);
            string sqlUpdate = "UPDATE CT_PHIEUNHAPSACH SET IDPhieuNhap = '" + cbb_IDPhieuNhap + "', IDSach = '" + cbb_IDSach + "', SoLuong = '" + tb_SoLuong + "', DonGia = '" + tb_DonGia + "' WHERE IDCTPhieuNhap = '" + tb_IDCTPhieuNhap + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }

        public bool checkID(string ID)
        {
            string sql = "Select *from CT_PHIEUNHAPSACH where IDCTPhieuNhap='CNS" + ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true)
                return true;
            return false;
        }
    }
}
