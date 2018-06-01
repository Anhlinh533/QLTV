using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoTheDocGia
    {
        private static adoTheDocGia instance;

        internal static adoTheDocGia Instance
        {
            get
            {
                if (instance == null) instance = new adoTheDocGia(); return ADO.adoTheDocGia.instance;
            }

            private set
            {
                ADO.adoTheDocGia.instance = value;
            }
        }

        #region Insert
        public void Them(string tb_IDDocGia, string tb_HoTenDocGia, string dtp_NgaySinh, string tb_DiaChi, string tb_Email, string cbb_LoaiDocGia, string dtp_NgayLapThe)
        {
            SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlInsert = "INSERT INTO THEDOCGIA (IDDocGIa, HoTenDG, NgaySinhDG, DiaChiDG, EmailDG, IDLoaiDG, NgayLapThe)  VALUES ('" + tb_IDDocGia + "', N'" + tb_HoTenDocGia + "', '" + dtp_NgaySinh + "', N'" + tb_DiaChi + "', '" + tb_Email + "', '" + cbb_LoaiDocGia + "', '" + dtp_NgayLapThe + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDDocGia)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM THEDOCGIA WHERE IDDocGia ='" + tb_IDDocGia + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDDocGia, string tb_HoTenDocGia, string dtp_NgaySinh, string tb_DiaChi, string tb_Email, string cbb_LoaiDocGia, string dtp_NgayLapThe)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlUpdate = "UPDATE THEDOCGIA SET HoTenDG = N'" + tb_HoTenDocGia + "', NgaySinhDG = '" + dtp_NgaySinh + "', DiaChiDG = N'" + tb_DiaChi + "', EmailDG = '" + tb_Email + "', IDLoaiDG = '" + cbb_LoaiDocGia + "', NgayLapThe = '" + dtp_NgayLapThe + "' WHERE IDDocGia = '" + tb_IDDocGia + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion

        #region TimKiem
        public string TKIDDocGia(string IDDocGia)
        {
            IDDocGia = "Select * from THEDOCGIA where IDDocGia like '%" + IDDocGia + "%' ";
            return IDDocGia;
        }

        public string TKHoTenDG(string HoTenDG)
        {
            HoTenDG = "Select * from THEDOCGIA where HoTenDG like '%" + HoTenDG + "%' ";
            return HoTenDG;
        }

        public string TKNgaySinhDG(string NgaySinhDG)
        {
            NgaySinhDG = "Select * from THEDOCGIA where NgaySinhDG='" + NgaySinhDG + "' ";
            return NgaySinhDG;
        }

        public string TKEmailDG(string EmailDG)
        {
            EmailDG = "Select * from THEDOCGIA where EmailDG like '%" + EmailDG + "%' ";
            return EmailDG;
        }

        public string TKIDLoaiDG(string IDLoaiDG)
        {
            IDLoaiDG = "Select * from THEDOCGIA where IDLoaiDG like '%" + IDLoaiDG + "%' ";
            return IDLoaiDG;
        }

        public string TKNgayLapThe(string NgayLapThe)
        {
            NgayLapThe = "Select * from THEDOCGIA where NgayLapThe='" + NgayLapThe + "' ";
            return NgayLapThe;
        }

        public string TKDiaChiDG(string DiaChiDG)
        {
            DiaChiDG = "Select * from THEDOCGIA where DiaChiDG like '%" + DiaChiDG + "%' ";
            return DiaChiDG;
        }
        #endregion

        public bool checkID(string ID)
        {
            SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref ID);
            string sql = "Select *from THEDOCGIA where IDDocGia='" + ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true)
                return true;
            return false;
        }
    }
}
