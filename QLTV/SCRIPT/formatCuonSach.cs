using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatCuonSach
    {
        private static formatCuonSach instance;

        internal static formatCuonSach Instance
        {
            get
            {
                if (instance == null) instance = new formatCuonSach(); return SCRIPT.formatCuonSach.instance;
            }

            private set
            {
                SCRIPT.formatCuonSach.instance = value;
            }
        }
        public string returnIDCuonSach(string id)
        {
            string IDDocGia;
            IDDocGia = "CSA" + id;
            return IDDocGia;
        }
    }
}
