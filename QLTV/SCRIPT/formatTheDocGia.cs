using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.ADO;

namespace QLTV.SCRIPT
{
    class formatTheDocGia
    {
        private static formatTheDocGia instance;

        internal static formatTheDocGia Instance
        {
            get
            {
                if (instance == null) instance = new formatTheDocGia(); return SCRIPT.formatTheDocGia.instance;
            }

            private set
            {
                SCRIPT.formatTheDocGia.instance = value;
            }
        }



        public void returnIDDocGia(ref string id)
        {
            id = "IDG" + id;
        }

        public void checkTheDocGia(string IDDocGia, string HoTen, string NgaySinh, string DiaChi, string Email, string LoaiDocGia, string NgayLapThe)
        {
            if (IDDocGia == "") MessageBox.Show("Không được để trống ID độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (HoTen == "") MessageBox.Show("Không được để trống họ tên độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Email == "") MessageBox.Show("Không được để trống Email.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DiaChi == "") MessageBox.Show("Không được để trống địa chỉ.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (NgayLapThe == "") MessageBox.Show("Không được để trống ngày lập thẻ.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (NgaySinh == "") MessageBox.Show("Không được để trống ngày sinh.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (LoaiDocGia == "") MessageBox.Show("Không được để trống loại độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!checkType.Instance.checkIsMail(Email)) MessageBox.Show("Email sai định dạng vui lòng nhập lại Email.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            //else if (IDDocGia != "" && HoTen != "" && Email != "" && DiaChi != "" && LoaiDocGia != "" && NgayLapThe != null && NgaySinh != null)
            //{
            //    sql = "INSERT INTO THEDOCGIA VALUES ("+IDDocGia+", "+HoTen+"," +NgaySinh+"," + DiaChi + ", "+Email+", "+LoaiDocGia+", "+ NgayLapThe+", NULL, NULL";
            //    ADO.ConnectionSQL.Instance.Execute(sql);
            //}            
        }
        #region TimKiem
        public string TKIDDocGia(string IDDocGia)
        {
            IDDocGia="Select * from THEDOCGIA where IDDocGia like '%" + IDDocGia + "%' ";
            return IDDocGia;
        }

        public string TKHoTenDG(string HoTenDG)
        {
            HoTenDG = "Select * from THEDOCGIA where HoTenDG like '%" + HoTenDG + "%' ";
            return HoTenDG;
        }

        public string TKNgaySinhDG(string NgaySinhDG)
        {
            NgaySinhDG = "Select * from THEDOCGIA where NgaySinhDG like '%" + NgaySinhDG + "%' ";
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
            NgayLapThe = "Select * from THEDOCGIA where NgayLapThe like '%" + NgayLapThe + "%' ";
            return NgayLapThe;
        }

        public string TKDiaChiDG(string DiaChiDG)
        {
            DiaChiDG = "Select * from THEDOCGIA where DiaChiDG like '%" + DiaChiDG + "%' ";
            return DiaChiDG;
        }
        #endregion
    }
}
