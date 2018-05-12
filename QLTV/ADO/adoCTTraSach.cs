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

        public void Xoa(string tb_IDCTPhieuTra)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM CT_PHIEUTRA WHERE IDCTPhieuTra ='" + tb_IDCTPhieuTra + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDCTPhieuTra, string cbb_IDPhieuTra, string cbb_IDCuonSach)
        {
            SCRIPT.formatCTTraSach.Instance.returnIDCTTraSach(ref tb_IDCTPhieuTra);
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
    }
}
