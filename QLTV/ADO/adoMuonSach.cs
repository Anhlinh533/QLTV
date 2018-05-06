using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoMuonSach
    {
        private static adoMuonSach instance;

        internal static adoMuonSach Instance
        {
            get
            {
                if (instance == null) instance = new adoMuonSach(); return ADO.adoMuonSach.instance;
            }

            private set
            {
                ADO.adoMuonSach.instance = value;
            }
        }

        public void Them(string tb_IDPhieuMuon, string cbb_IDDocGia, string dtp_NgayMuon)
        {
            SCRIPT.formatMuonSach.Instance.returnIDPhieuMuon(ref tb_IDPhieuMuon);
            string sqlInsert = "INSERT INTO PHIEUMUON VALUES ('" + tb_IDPhieuMuon + "','" + cbb_IDDocGia + "','" + dtp_NgayMuon + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDPhieuMuon)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM PHIEUMUON WHERE IDPhieuMuon ='" + tb_IDPhieuMuon + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDPhieuMuon, string cbb_IDDocGia, string dtp_NgayMuon)
        {
            SCRIPT.formatMuonSach.Instance.returnIDPhieuMuon(ref tb_IDPhieuMuon);
            string sqlUpdate = "UPDATE PHIEUMUON SET IDDocGia = '" + cbb_IDDocGia + "', NgayMuon = '" + dtp_NgayMuon + "' WHERE IDPhieuMuon = '" + tb_IDPhieuMuon + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
    }
}
