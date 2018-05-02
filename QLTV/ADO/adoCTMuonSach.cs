using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoCTMuonSach
    {
        private static adoCTMuonSach instance;

        internal static adoCTMuonSach Instance
        {
            get
            {
                if (instance == null) instance = new adoCTMuonSach(); return ADO.adoCTMuonSach.instance;
            }

            private set
            {
                ADO.adoCTMuonSach.instance = value;
            }
        }


    }
}
