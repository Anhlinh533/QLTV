using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatPhieuThuTienPhat
    {
        private static formatPhieuThuTienPhat instance;

        internal static formatPhieuThuTienPhat Instance
        {
            get
            {
                if (instance == null) instance = new formatPhieuThuTienPhat(); return SCRIPT.formatPhieuThuTienPhat.instance;
            }

            private set
            {
                SCRIPT.formatPhieuThuTienPhat.instance = value;
            }
        }

        public void returnIDPhieuThu(ref string id)
        {
            id = "ITP" + id;
        }

        public void checkPhieuThuTienPhat(string IDDocGia, string NgayLap, string SoTienThu)
        {
            if (IDDocGia == "") MessageBox.Show("Không được để trống ID độc giả", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (NgayLap == "") MessageBox.Show("Không được để trống ngày lập", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (SoTienThu == "") MessageBox.Show("Không được để trống số tiền thu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void checkNull(Control IDDocGia, Control NgayLap, Control SoTienThu)
        {
            if (useForm.Instance.checkNull(IDDocGia) == true) useForm.Instance.Focus(IDDocGia);
            else if (useForm.Instance.checkNull(NgayLap) == true) useForm.Instance.Focus(NgayLap);
            else if (useForm.Instance.checkNull(SoTienThu) == true) useForm.Instance.Focus(SoTienThu);
        }
    }
}
