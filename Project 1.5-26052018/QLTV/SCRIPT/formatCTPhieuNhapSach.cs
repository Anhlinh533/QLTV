using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatCTPhieuNhapSach
    {
        private static formatCTPhieuNhapSach instance;

        internal static formatCTPhieuNhapSach Instance
        {
            get
            {
                if (instance == null) instance = new formatCTPhieuNhapSach(); return SCRIPT.formatCTPhieuNhapSach.instance;
            }

            private set
            {
                SCRIPT.formatCTPhieuNhapSach.instance = value;
            }
        }

        public void returnCTPhieuNhapSach(ref string id)
        {
            id = "CNS" + id;
        }

        public void checkCTPhieuNhapSach(string IDChiTietPhieuNhap, string IDPhieuNhap, string IDSach, string TenTG, string NhaXB, string NamXB, string SoLuong, string DonGia)
        {
            if (IDChiTietPhieuNhap == "") MessageBox.Show("Không được để trống ID chi tiết phiếu nhập.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDPhieuNhap == "") MessageBox.Show("Không được để trống ID phiếu nhập.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDSach == "") MessageBox.Show("Không được để trống tên sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (TenTG == "") MessageBox.Show("Không được để trống tên tác giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (NhaXB == "") MessageBox.Show("Không được để trống nhà xuất bản.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (NamXB == "") MessageBox.Show("Không được để trống năm xuất bản", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (SoLuong == "") MessageBox.Show("Không được để trống số lượng.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DonGia == "") MessageBox.Show("Không được để trống đơn giá", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void checkNull(Control IDCTPhieuNhap,Control IDPhieuNhap, Control IDSach, Control TacGia, Control NhaXB, Control NamXB, Control SoLuong, Control DonGia)
        {
            if (useForm.Instance.checkNull(IDCTPhieuNhap) == true) useForm.Instance.Focus(IDCTPhieuNhap);
            else if (useForm.Instance.checkNull(IDPhieuNhap) == true) useForm.Instance.Focus(IDPhieuNhap);
            else if (useForm.Instance.checkNull(IDSach) == true) useForm.Instance.Focus(IDSach);
            else if (useForm.Instance.checkNull(TacGia) == true) useForm.Instance.Focus(TacGia);
            else if (useForm.Instance.checkNull(NhaXB) == true) useForm.Instance.Focus(NhaXB);
            else if (useForm.Instance.checkNull(NamXB) == true) useForm.Instance.Focus(NamXB);
            else if (useForm.Instance.checkNull(SoLuong) == true) useForm.Instance.Focus(SoLuong);
            else if (useForm.Instance.checkNull(DonGia) == true) useForm.Instance.Focus(DonGia);
        }
    }
}
