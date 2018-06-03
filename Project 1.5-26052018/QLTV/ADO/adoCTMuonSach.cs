using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoCTMuonSach
    {
        private static adoCTMuonSach instance;

        internal static adoCTMuonSach Instance
        {
            get
            {
                if (instance == null) instance = new adoCTMuonSach(); return ADO.adoCTMuonSach.instance;
            }

            private set
            {
                ADO.adoCTMuonSach.instance = value;
            }
        }

        #region Insert
        public void Them(string tb_IDCTPhieuMuon, string cbb_IDPhieuMuon, string cbb_IDCuonSach)
        {
            SCRIPT.formatCTMuonSach.Instance.returnIDCTMuonSach(ref tb_IDCTPhieuMuon);
            string sqlInsert = "INSERT INTO CT_PHIEUMUON VALUES ('" + tb_IDCTPhieuMuon + "','" + cbb_IDPhieuMuon + "','" + cbb_IDCuonSach + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDCTPhieuMuon, string cbb_IDCuonSach)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM CT_PHIEUMUON WHERE IDCTPhieuMuon ='" + tb_IDCTPhieuMuon + "' AND IDCuonSach ='" + cbb_IDCuonSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDCTPhieuMuon, string cbb_IDPhieuMuon, string cbb_IDCuonSach)
        {
            //SCRIPT.formatCTMuonSach.Instance.returnIDCTMuonSach(ref tb_IDCTPhieuMuon);
            string sqlUpdate = "UPDATE CT_PHIEUMUON SET IDPhieuMuon = '" + cbb_IDPhieuMuon + "', IDCuonSach = '" + cbb_IDCuonSach + "' WHERE IDCTPhieuMuon = '" + tb_IDCTPhieuMuon + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }

        public string GetIDCuonSach(string tb_TenSach, string tb_TenTG)
        {
            string sql = "", IDCTTacGia = "";

            if (tb_TenTG == "")
                sql = "SELECT TOP 1 C.IDCuonSach FROM DAUSACH A, SACH B, CUONSACH C WHERE B.IDDauSach = A.IDDauSach AND C.IDSach = B.IDSach AND A.TenDauSach = N'" + tb_TenSach + "' AND C.TinhTrang = N'Chưa cho mượn' ORDER BY C.IDCuonSach";
            else
            {
                IDCTTacGia = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDCTTacGia FROM CT_TACGIA A, DAUSACH B, TACGIA C WHERE A.IDDauSach = B.IDDauSach AND A.IDTacGia = C.IDTacGia AND B.TenDauSach = N'" + tb_TenSach + "' AND C.TenTacGia = N'" + tb_TenTG + "'");
                sql = "SELECT TOP 1 C.IDCuonSach FROM DAUSACH A, SACH B, CUONSACH C WHERE B.IDDauSach = A.IDDauSach AND C.IDSach = B.IDSach AND A.TenDauSach = N'" + tb_TenSach + "' AND B.IDCTTacGia = '" + IDCTTacGia + "' AND C.TinhTrang = N'Chưa cho mượn' ORDER BY C.IDCuonSach";
            }

            string s = ADO.ConnectionSQL.Instance.ExcuteString(sql);
            return s;
        }
        #endregion

        #region Tim Kiem
        public string TKIDCTPhieuMuon(string IDCTPhieuMuon)
        {
            IDCTPhieuMuon = "Select * from CT_PHIEUMUON where IDCTPhieuMuon like '%" + IDCTPhieuMuon + "%' ";
            return IDCTPhieuMuon;
        }

        public string TKIDPhieuMuon(string IDPhieuMuon)
        {
            IDPhieuMuon = "Select * from CT_PHIEUMUON where IDPhieuMuon like '%" + IDPhieuMuon + "%' ";
            return IDPhieuMuon;
        }

        public string TKIDCuonSach(string IDCuonSach)
        {
            IDCuonSach = "Select * from CT_PHIEUMUON where IDCuonSach like '%" + IDCuonSach + "%' ";
            return IDCuonSach;
        }
        #endregion

        public bool checkID(string ID)
        {
            string sql = "Select *from CT_PHIEUMUON where IDCTPhieuMuon='CPM" + ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true)
                return true;
            return false;
        }
    }
}
