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
        }

        public void checkNull(Control IDDocGia, Control HoTen, Control DiaChi, Control Email, Control LoaiDocGia)
        {
            if (useForm.Instance.checkNull(IDDocGia) == true) useForm.Instance.Focus(IDDocGia);
            else if (useForm.Instance.checkNull(HoTen) == true) useForm.Instance.Focus(HoTen);
            else if (useForm.Instance.checkNull(DiaChi) == true) useForm.Instance.Focus(DiaChi);
            else if (useForm.Instance.checkNull(Email) == true) useForm.Instance.Focus(Email);
            else if (useForm.Instance.checkNull(LoaiDocGia) == true) useForm.Instance.Focus(LoaiDocGia);
        }
    }
}
