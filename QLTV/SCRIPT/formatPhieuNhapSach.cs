using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatPhieuNhapSach
    {
        private static formatPhieuNhapSach instance;

        internal static formatPhieuNhapSach Instance
        {
            get
            {
                if (instance == null) instance = new formatPhieuNhapSach(); return SCRIPT.formatPhieuNhapSach.instance;
            }

            private set
            {
                SCRIPT.formatPhieuNhapSach.instance = value;
            }
        }

        public void returnIDPhieuNhapSach(ref string id)
        {
            id = "INS" + id;
        }

        public void checkPhieuNhapSach(string IDPhieuNhap, string NgayNhap)
        {
            if (IDPhieuNhap == "") MessageBox.Show("Không được để trống ID phiếu nhập sách", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (NgayNhap == "") MessageBox.Show("Không được để trống ngày nhập", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void checkNull(Control IDPhieuNhap)
        {
            if (useForm.Instance.checkNull(IDPhieuNhap) == true) useForm.Instance.Focus(IDPhieuNhap);
        }
    }
}
