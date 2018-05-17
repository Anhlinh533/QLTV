using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLTV.SCRIPT
{
    class formatMuonSach
    {
        private static formatMuonSach instance;

        internal static formatMuonSach Instance
        {
            get
            {
                if (instance == null) instance = new formatMuonSach(); return SCRIPT.formatMuonSach.instance;
            }

            private set
            {
                SCRIPT.formatMuonSach.instance = value;
            }
        }

        public void returnIDPhieuMuon(ref string id)
        {
            id = "IPM" + id;
        }

        public void checkPhieuMuonSach(string IDPhieuMuon, string IDDocGia, string NgayMuon)
        {
            if (IDPhieuMuon == "") MessageBox.Show("Không được để trống ID phiếu mượn", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDDocGia == "") MessageBox.Show("Không được để trống ID độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (NgayMuon == "") MessageBox.Show("Không được để trống ngày mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
