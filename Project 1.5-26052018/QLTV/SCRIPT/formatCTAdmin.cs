using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatCTAdmin
    {
        private static formatCTAdmin instance;

        internal static formatCTAdmin Instance
        {
            get
            {
                if (instance == null) instance = new formatCTAdmin(); return SCRIPT.formatCTAdmin.instance;
            }

            private set
            {
                SCRIPT.formatCTAdmin.instance = value;
            }
        }

        public void returnIDCTAdmin(ref string id)
        {
            id = "CAD" + id;
        }

        public void checkCTAdmin(string IDAdmin, string HoTen, string NgaySinh, string DiaChi, string Email)
        {
            if (IDAdmin == "") MessageBox.Show("Không được để trống ID admin.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (HoTen == "") MessageBox.Show("Không được để trống Họ tên.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (NgaySinh == "") MessageBox.Show("Không được để trống Ngày sinh.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DiaChi == "") MessageBox.Show("Không được để trống Địa chỉ.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Email == "") MessageBox.Show("Không được để trống ID Email.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void checkNull(Control IDAdmin, Control HoTen, Control DiaChi, Control Email)
        {
            if (useForm.Instance.checkNull(IDAdmin) == true) useForm.Instance.Focus(IDAdmin);
            else if (useForm.Instance.checkNull(HoTen) == true) useForm.Instance.Focus(HoTen);
            else if (useForm.Instance.checkNull(DiaChi) == true) useForm.Instance.Focus(DiaChi);
            else if (useForm.Instance.checkNull(Email) == true) useForm.Instance.Focus(Email);
        }
    }    
}
