using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatSach
    {
        private static formatSach instance;

        internal static formatSach Instance
        {
            get
            {
                if (instance == null) instance = new formatSach(); return SCRIPT.formatSach.instance;
            }

            private set
            {
                SCRIPT.formatSach.instance = value;
            }
        }
        public string returnIDSach(string id)
        {
            string IDDocGia;
            IDDocGia = "ISA" + id;
            return IDDocGia;
        }

    }
}
