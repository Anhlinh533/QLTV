using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatPhieuNhapSach
    {
        private static formatPhieuNhapSach instance;

        internal static formatPhieuNhapSach Instance
        {
            get
            {
                if (instance == null) instance = new formatPhieuNhapSach(); return SCRIPT.formatPhieuNhapSach.instance;
            }

            private set
            {
                SCRIPT.formatPhieuNhapSach.instance = value;
            }
        }
        public string returnIDPhieuNhapSach(string id)
        {
            string IDDocGia;
            IDDocGia = "INS" + id;
            return IDDocGia;
        }
    }
}
