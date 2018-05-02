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
        public string returnIDCTTraSach(string id)
        {
            string IDDocGia;
            IDDocGia = "CPT" + id;
            return IDDocGia;
        }
        public void checkCTTraSach(string IDChiTietPhieuTra, string IDPhieuTra, string IDPhieuMuon,string SoNgayMuon,string TienPhat)
        {
            if (IDChiTietPhieuTra=="") MessageBox.Show("Không được để trống ID chi tiết phiếu trả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(IDPhieuTra=="") MessageBox.Show("Không được để trống ID phiếu trả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(IDPhieuMuon=="") MessageBox.Show("Không được để trống ID phiếu mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(SoNgayMuon=="") MessageBox.Show("Không được để trống số ngày mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(TienPhat=="") MessageBox.Show("Không được để trống tiền phạt.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
