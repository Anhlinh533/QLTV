using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoMuonSach
    {
        private static adoMuonSach instance;

        internal static adoMuonSach Instance
        {
            get
            {
                if (instance == null) instance = new adoMuonSach(); return ADO.adoMuonSach.instance;
            }

            private set
            {
                ADO.adoMuonSach.instance = value;
            }
        }


    }
}
