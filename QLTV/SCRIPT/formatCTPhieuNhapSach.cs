using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.SCRIPT
{
    class formatCTPhieuNhapSach
    {
        private static formatCTPhieuNhapSach instance;

        internal static formatCTPhieuNhapSach Instance
        {
            get
            {
                if (instance == null) instance = new formatCTPhieuNhapSach(); return SCRIPT.formatCTPhieuNhapSach.instance;
            }

            private set
            {
                SCRIPT.formatCTPhieuNhapSach.instance = value;
            }
        }
        public string returnCTPhieuNhapSach(string id)
        {
            string IDDocGia;
            IDDocGia = "CNS" + id;
            return IDDocGia;
        }
    }
}
