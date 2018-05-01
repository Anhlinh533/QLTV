using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatDauSach
    {
        private static formatDauSach instance;

        internal static formatDauSach Instance
        {
            get
            {
                if (instance == null) instance = new formatDauSach(); return SCRIPT.formatDauSach.instance;
            }

            private set
            {
                SCRIPT.formatDauSach.instance = value;
            }
        }
        public string returnIDDauSach(string id)
        {
            string IDDocGia;
            IDDocGia = "DSA" + id;
            return IDDocGia;
        }
    }
}
