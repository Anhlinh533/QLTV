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
        public string returnIDCTMuonSach(string id)
        {
            string IDDocGia;
            IDDocGia = "CPM" + id;
            return IDDocGia;
        }
    }
}
