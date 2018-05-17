using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLTV.SCRIPT
{
    class formatCTTraSach
    {
        private static formatCTTraSach instance;

        internal static formatCTTraSach Instance
        {
            get
            {
                if (instance == null) instance = new formatCTTraSach(); return SCRIPT.formatCTTraSach.instance;
            }

            private set
            {
                SCRIPT.formatCTTraSach.instance = value;
            }
        }

        public void returnIDCTTraSach(ref string id)
        {
            id = "CPT" + id;
        }

        public void checkCTTraSach(string IDChiTietPhieuTra, string IDPhieuTra, string IDCuonSach)
        {
            if (IDChiTietPhieuTra == "") MessageBox.Show("Không được để trống ID chi tiết phiếu trả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDPhieuTra == "") MessageBox.Show("Không được để trống ID phiếu trả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDCuonSach == "") MessageBox.Show("Không được để trống ID cuốn sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
