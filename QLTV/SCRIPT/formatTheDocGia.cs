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

    }
}
