using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoCTTraSach
    {
        private static adoCTTraSach instance;

        internal static adoCTTraSach Instance
        {
            get
            {
                if (instance == null) instance = new adoCTTraSach(); return ADO.adoCTTraSach.instance;
            }

            private set
            {
                ADO.adoCTTraSach.instance = value;
            }
        }

        #region Insert
        public void Them(string tb_IDCTPhieuTra, string cbb_IDPhieuTra, string cbb_IDCuonSach)
        {
            SCRIPT.formatCTTraSach.Instance.returnIDCTTraSach(ref tb_IDCTPhieuTra);
            string sqlInsert = "INSERT INTO CT_PHIEUTRA (IDCTPhieuTra, IDPhieuTra, IDCuonSach) VALUES ('" + tb_IDCTPhieuTra + "','" + cbb_IDPhieuTra + "','" + cbb_IDCuonSach + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDCTPhieuTra, string tb_IDCuonSach)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM CT_PHIEUTRA WHERE IDCTPhieuTra ='" + tb_IDCTPhieuTra + "' AND IDCuonSach ='" + tb_IDCuonSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDCTPhieuTra, string cbb_IDPhieuTra, string cbb_IDCuonSach)
        {
            //SCRIPT.formatCTTraSach.Instance.returnIDCTTraSach(ref tb_IDCTPhieuTra);
            string sqlUpdate = "UPDATE CT_PHIEUTRA SET IDPhieuTra = '" + cbb_IDPhieuTra + "', IDCuonSach = '" + cbb_IDCuonSach + "' WHERE IDCTPhieuTra = '" + tb_IDCTPhieuTra + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion

        #region Tim Kiem
        public string TKIDCTPhieuTra(string IDCTPhieuTra)
        {
            IDCTPhieuTra = "Select * from CT_PHIEUTRA where IDCTPhieuTra like '%" + IDCTPhieuTra + "%' ";
            return IDCTPhieuTra;
        }

        public string TKIDPhieuTra(string IDPhieuTra)
        {
            IDPhieuTra = "Select * from CT_PHIEUTRA where IDPhieuTra like '%" + IDPhieuTra + "%' ";
            return IDPhieuTra;
        }

        public string TKIDCuonSach(string IDCuonSach)
        {
            IDCuonSach = "Select * from CT_PHIEUTRA where IDCuonSach like '%" + IDCuonSach + "%' ";
            return IDCuonSach;
        }

        public string TKIDCTPhieuMuon(string IDCTPhieuMuon)
        {
            IDCTPhieuMuon = "Select * from CT_PHIEUTRA where IDCTPhieuMuon like '%" + IDCTPhieuMuon + "%' ";
            return IDCTPhieuMuon;
        }

        public string TKSoNgayMuon(string SoNgayMuon)
        {
            SoNgayMuon = "Select * from CT_PHIEUTRA where SoNgayMuon like '%" + SoNgayMuon + "%' ";
            return SoNgayMuon;
        }

        public string TKTienPhat(string TienPhat)
        {
            TienPhat = "Select * from CT_PHIEUTRA where TienPhat like '%" + TienPhat + "%' ";
            return TienPhat;
        }
        #endregion

        public bool checkID(string ID)
        {
            SCRIPT.formatCTTraSach.Instance.returnIDCTTraSach(ref ID);
            string sql = "Select *from CT_PHIEUTRA where IDCTPhieuTra='" + ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true)
                return true;
            return false;
        }

        public void AutoCbb1(ComboBox cbb, string TenText)
        {
            ADO.ConnectionSQL.Instance.FillCbb1(cbb, "SELECT TenDauSach, B.IDCuonSach FROM PHIEUMUON A, CT_PHIEUMUON B, PHIEUTRA C, CUONSACH D, SACH E, DAUSACH F WHERE B.IDPhieuMuon = A.IDPhieuMuon AND A.IDDocGia = C.IDDocGia AND B.IDCuonSach = D.IDCuonSach AND D.IDSach = E.IDSach AND E.IDDauSach = F.IDDauSach AND C.IDPhieuTra = '" + TenText + "' AND D.TinhTrang = N'Đã cho mượn' AND NOT EXISTS (SELECT * FROM PHIEUMUON M, CT_PHIEUMUON N WHERE M.IDPhieuMuon = N.IDPhieuMuon AND N.IDCuonSach = B.IDCuonSach AND M.NgayMuon > A.NgayMuon)");
        }

        public string HienTG(string TenText)
        {
            string s = ADO.ConnectionSQL.Instance.ExcuteString("SELECT TenTacGia FROM TACGIA A, CT_TACGIA B, CUONSACH C, SACH D WHERE A.IDTacGia = B.IDTacGia AND D.IDSach = C.IDSach AND D.IDCTTacGia = B.IDCTTacGia AND C.IDCuonSach = '" + TenText + "'");
            return s;
        }

        public string GetQueryFillDgv()
        {
            string sql = "SELECT IDCTPhieuTra, IDPhieuTra, A.IDCuonSach, TenDauSach, IDPhieuMuon, SoNgayMuon, TienPhat FROM CT_PHIEUTRA A, DAUSACH B, SACH C, CUONSACH D WHERE A.IDCuonSach = D.IDCuonSach AND B.IDDauSach = C.IDDauSach AND C.IDSach = D.IDSach";
            return sql;
        }

        public string AutoFill(string idcs, string TenBox)
        {
            string str = "";

            if (TenBox == "cbb_IDCuonSach")
            {
                string sql = "SELECT TenDauSach FROM DAUSACH A, SACH B, CUONSACH C, CT_PHIEUTRA D WHERE A.IDDauSach = B.IDDauSach AND B.IDSach = C.IDSach AND C.IDCuonSach = D.IDCuonSach AND D.IDCuonSach = '" + idcs + "'";
                str = ADO.ConnectionSQL.Instance.ExcuteString(sql);
            }
            else if (TenBox == "tb_TenTacGia")
            {
                string sql = "SELECT TenTacGia FROM TACGIA A, CT_TACGIA B, CT_PHIEUTRA C, SACH D, CUONSACH E WHERE A.IDTacGia = B.IDTacGia AND C.IDCuonSach = E.IDCuonSach AND E.IDSach = D.IDSach AND D.IDCTTacGia = B.IDCTTacGia AND C.IDCuonSach = '" + idcs + "'";
                str = ADO.ConnectionSQL.Instance.ExcuteString(sql);                              
            }

            return str;
        }
    }
}
