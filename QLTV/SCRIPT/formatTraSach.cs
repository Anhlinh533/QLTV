using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatTraSach
    {
        private static formatTraSach instance;

        internal static formatTraSach Instance
        {
            get
            {
                if (instance == null) instance = new formatTraSach(); return SCRIPT.formatTraSach.instance;
            }

            private set
            {
                SCRIPT.formatTraSach.instance = value;
            }
        }

        public string returnIDPhieuTra(string id)
        {
            string IDDocGia;
            IDDocGia = "IPT" + id;
            return IDDocGia;
        }
    }
}
