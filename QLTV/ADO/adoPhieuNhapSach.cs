using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.ADO
{
    class adoPhieuNhapSach
    {
        private static adoPhieuNhapSach instance;

        internal static adoPhieuNhapSach Instance
        {
            get
            {
                if (instance == null) instance = new adoPhieuNhapSach(); return ADO.adoPhieuNhapSach.instance;
            }

            private set
            {
                ADO.adoPhieuNhapSach.instance = value;
            }
        }


    }
}
