using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoCuonSach
    {
        private static adoCuonSach instance;

        internal static adoCuonSach Instance
        {
            get
            {
                if (instance == null) instance = new adoCuonSach(); return ADO.adoCuonSach.instance;
            }

            private set
            {
                ADO.adoCuonSach.instance = value;
            }
        }


    }
}
