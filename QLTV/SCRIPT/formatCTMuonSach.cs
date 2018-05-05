using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLTV.SCRIPT
{
    class formatCTMuonSach
    {
        private static formatCTMuonSach instance;

        internal static formatCTMuonSach Instance
        {
            get
            {
                if (instance == null) instance = new formatCTMuonSach(); return SCRIPT.formatCTMuonSach.instance;
            }

            private set
            {
                SCRIPT.formatCTMuonSach.instance = value;
            }
        }
        public void returnIDCTMuonSach(ref string id)
        {
            id = "CPM" + id;        
        }
        public void checkCTMuonSach(string IDCTPhieuMuon, string IDPhieuMuon, string IDCuonSach)
        {
            if(IDCTPhieuMuon=="") MessageBox.Show("Không được để trống ID chi tiết phiếu mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(IDPhieuMuon=="") MessageBox.Show("Không được để trống ID phiếu mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(IDCuonSach=="") MessageBox.Show("Không được để trống ID cuốn sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
