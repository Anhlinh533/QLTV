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
        public string returnIDPhieuMuon(string id)
        {
            string IDDocGia;
            IDDocGia = "IPM" + id;
            return IDDocGia;
        }
    }
}
