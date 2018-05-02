using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoCTPhieuNhapSach
    {
        private static adoCTPhieuNhapSach instance;

        internal static adoCTPhieuNhapSach Instance
        {
            get
            {
                if (instance == null) instance = new adoCTPhieuNhapSach(); return ADO.adoCTPhieuNhapSach.instance;
            }

            private set
            {
                ADO.adoCTPhieuNhapSach.instance = value;
            }
        }


    }
}
