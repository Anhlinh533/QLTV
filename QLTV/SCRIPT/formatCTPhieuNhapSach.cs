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
        public string returnCTPhieuNhapSach(string id)
        {
            string IDDocGia;
            IDDocGia = "CNS" + id;
            return IDDocGia;
        }
        public void checkCTPhieuNhapSach(string IDChiTietPhieuNhap,string IDPhieuNhap,string IDSach,string SoLuong,string DonGia, string ThanhTien)
        {
            if(IDChiTietPhieuNhap=="") MessageBox.Show("Không được để trống ID chi tiết phiếu nhập.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(IDPhieuNhap=="") MessageBox.Show("Không được để trống ID phiếu nhập.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(IDSach=="") MessageBox.Show("Không được để trống ID sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(SoLuong=="") MessageBox.Show("Không được để trống số lượng.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(DonGia=="") MessageBox.Show("Không được để trống đơn giá", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(ThanhTien=="") MessageBox.Show("Không được để trống thành tiền.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
