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

        public void AutoCbb(ComboBox cbb, string TenText, string Ten1, string Ten2, string TenBox)
        {
            if (TenBox == "cbb_IDSach")
                ADO.ConnectionSQL.Instance.FillCbb(cbb, "SELECT TenTacGia FROM TACGIA A, CT_TACGIA B, DAUSACH C WHERE A.IDTacGia = B.IDTacGia AND B.IDDauSach = C.IDDauSach AND C.TenDauSach = N'" + TenText + "'");
            else
            {
                string IDDauSach = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDDauSach FROM DAUSACH WHERE TenDauSach = N'" + Ten1 + "'");
                string IDCTTacGia = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDCTTacGia FROM CT_TACGIA A, TACGIA B WHERE A.IDTacGia = B.IDTacGia AND A.IDDauSach = '" + IDDauSach + "'AND B.TenTacGia = N'" + Ten2 + "'");

                if (TenBox == "cbb_TacGia")
                {
                    ADO.ConnectionSQL.Instance.FillCbb(cbb, "SELECT NhaXB FROM SACH WHERE IDDauSach = N'" + IDDauSach + "' AND IDCTTacGia = '" + IDCTTacGia + "'");
                }
                else if (TenBox == "cbb_NhaXB")
                    ADO.ConnectionSQL.Instance.FillCbb(cbb, "SELECT NamXB FROM SACH WHERE IDDauSach = N'" + IDDauSach + "' AND IDCTTacGia = '" + IDCTTacGia + "' AND NhaXB = N'" + TenText + "'");
            }
        }

        public string GetQueryFillDgv()
        {
            string sql = "SELECT IDCTPhieuNhap, IDPhieuNhap, A.IDSach, TenDauSach, SoLuong, DonGia, ThanhTien FROM CT_PHIEUNHAPSACH A, DAUSACH B, SACH C WHERE A.IDSach = C.IDSach AND B.IDDauSach = C.IDDauSach";
            return sql;
        }

        public string AutoFill(string ids, string TenBox)
        {
            string str = "";

            if (TenBox == "cbb_IDSach")
            {
                string sql = "SELECT TenDauSach FROM DAUSACH A, SACH B, CT_PHIEUNHAPSACH C WHERE A.IDDauSach = B.IDDauSach AND B.IDSach = C.IDSach AND C.IDSach = '" + ids + "'";
                str = ADO.ConnectionSQL.Instance.ExcuteString(sql);
            }
            else if (TenBox == "cbb_TacGia")
            {
                string sql = "SELECT TenTacGia FROM TACGIA A, CT_TACGIA B, CT_PHIEUNHAPSACH C, SACH D WHERE A.IDTacGia = B.IDTacGia AND C.IDSach = D.IDSach AND D.IDCTTacGia = B.IDCTTacGia AND C.IDSach = '" + ids + "'";
                str = ADO.ConnectionSQL.Instance.ExcuteString(sql);
            }
            else if (TenBox == "cbb_NhaXB")
            {
                string sql = "SELECT NhaXB FROM SACH A, CT_PHIEUNHAPSACH B WHERE A.IDSach = B.IDSach AND B.IDSach = '" + ids + "'";
                str = ADO.ConnectionSQL.Instance.ExcuteString(sql);
            }
            else if (TenBox == "cbb_NamXB")
            {
                string sql = "SELECT NamXB FROM SACH A, CT_PHIEUNHAPSACH B WHERE A.IDSach = B.IDSach AND B.IDSach = '" + ids + "'";
                str = ADO.ConnectionSQL.Instance.ExcuteInt(sql).ToString();
            }

            return str;
        }
    }
}
