using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoSach
    {
        private static adoSach instance;

        internal static adoSach Instance
        {
            get
            {
                if (instance == null) instance = new adoSach(); return ADO.adoSach.instance;
            }

            private set
            {
                ADO.adoSach.instance = value;
            }
        }

        #region Insert
        public void Them(string tb_IDSach, string cbb_IDDauSach, string cbb_IDCTTacGia, string tb_NXB, string cbb_NXB, string tb_SoLuongTon, string tb_GiaTien)
        {
            cbb_IDDauSach = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDDauSach FROM DAUSACH A WHERE TenDauSach = N'" + cbb_IDDauSach + "'");
            cbb_IDCTTacGia = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDCTTacGia FROM TACGIA A, CT_TACGIA B WHERE A.IDTacGia = B.IDTacGia AND B.IDDauSach = N'" + cbb_IDDauSach + "' AND A.TenTacGia = N'" + cbb_IDCTTacGia + "'");

            SCRIPT.formatSach.Instance.returnIDSach(ref tb_IDSach);
            string sqlInsert = "INSERT INTO SACH VALUES ('" + tb_IDSach + "', '" + cbb_IDDauSach + "', '" + cbb_IDCTTacGia + "', N'" + tb_NXB + "', '" + cbb_NXB + "', '" + tb_SoLuongTon + "', '" + tb_GiaTien + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDSach)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM SACH WHERE IDSach ='" + tb_IDSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDSach, string cbb_IDDauSach, string cbb_IDCTTacGia, string tb_NXB, string cbb_NXB, string tb_SoLuongTon, string tb_GiaTien)
        {
            //SCRIPT.formatSach.Instance.returnIDSach(ref tb_IDSach);
            string sqlUpdate = "UPDATE SACH SET IDDauSach = '" + cbb_IDDauSach + "', IDCTTacGia = '" + cbb_IDCTTacGia + "', NhaXB = N'" + tb_NXB + "', NamXB = '" + cbb_NXB + "', SoLuongTon = '" + tb_SoLuongTon + "', GiaTien = '" + tb_GiaTien + "' WHERE IDSach = '" + tb_IDSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion

        #region Tim Kiem
        public string TKIDSach(string IDSach)
        {
            IDSach = "Select * from SACH where IDSach like '%" + IDSach + "%' ";
            return IDSach;
        }
        public string TKIDDauSach(string IDDauSach)
        {
            IDDauSach = "Select * from SACH where IDDauSach like '%" + IDDauSach + "%' ";
            return IDDauSach;
        }

        public string TKNhaXB(string NhaXB)
        {
            NhaXB = "Select * from SACH where NhaXB like '%" + NhaXB + "%' ";
            return NhaXB;
        }

        public string TKNamXB(string NamXB)
        {
            NamXB = "Select * from SACH where NamXB like '%" + NamXB + "%' ";
            return NamXB;
        }

        public string TKSoLuongTon(string SoLuongTon)
        {
            SoLuongTon = "Select * from SACH where SoLuongTon like '%" + SoLuongTon + "%' ";
            return SoLuongTon;
        }

        public string TKGiaTien(string GiaTien)
        {
            GiaTien = "Select * from SACH where GiaTien like '%" + GiaTien + "%' ";
            return GiaTien;
        }

        public string TKCuonSach(string IDCuonSach)
        {
            IDCuonSach = "select * from CUONSACH where IDCuonSach like '%" + IDCuonSach + "%'";
            return IDCuonSach;
        }
        public string TKIDSachCS(string IDSach)
        {
            IDSach = "select * from CUONSACH where IDSach like '%" + IDSach + "%'";
            return IDSach;
        }

        public string TKTinhTrang(string TinhTrang)
        {
            TinhTrang = "select * from CUONSACH where TinhTrang=" + TinhTrang;
            return TinhTrang;
        }
        #endregion

        public bool checkID(string ID)
        {
            SCRIPT.formatSach.Instance.returnIDSach(ref ID);
            string sql = "Select *from SACH where IDSach='" + ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true)
                return true;
            return false;
        }
    }
}
