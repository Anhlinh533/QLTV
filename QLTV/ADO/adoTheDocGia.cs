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

        public void Them(string tb_IDDocGia, string tb_HoTenDocGia, string dtp_NgaySinh, string tb_DiaChi, string tb_Email, string cbb_LoaiDocGia, string dtp_NgayLapThe)
        {
            SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlInsert = "INSERT INTO THEDOCGIA(IDDocGIa, HoTenDG, NgaySinhDG, DiaChiDG, EmailDG, IDLoaiDG, NgayLapThe)  VALUES ('" + tb_IDDocGia + "',N'" + tb_HoTenDocGia + "','" + dtp_NgaySinh + "',N'" + tb_DiaChi + "','" + tb_Email + "','" + cbb_LoaiDocGia + "','" + dtp_NgayLapThe + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDDocGia)
        {
            string sqlDelete = "DELETE FROM THEDOCGIA WHERE IDDocGia ='" + tb_IDDocGia + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDDocGia, string tb_HoTenDocGia, string dtp_NgaySinh, string tb_DiaChi, string tb_Email, string cbb_LoaiDocGia, string dtp_NgayLapThe)
        {
            string sqlUpdate = "UPDATE THEDOCGIA SET HoTenDG = '" + tb_HoTenDocGia + "', NgSinhDG = '" + dtp_NgaySinh + "', DiaChiDG = '" + tb_DiaChi + "', EmailDG = '" + tb_Email + "', IDLoaiDG = '" + cbb_LoaiDocGia + "', NgLapThe = '" + dtp_NgayLapThe + "' WHERE IDDocGia = '" + tb_IDDocGia + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
    }
}
