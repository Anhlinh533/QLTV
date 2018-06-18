using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.SCRIPT
{
    class formatRPTinhHinhMuonSach
    {
        private static formatRPTinhHinhMuonSach instance;

        internal static formatRPTinhHinhMuonSach Instance
        {
            get
            {
                if (instance == null) instance = new formatRPTinhHinhMuonSach(); return SCRIPT.formatRPTinhHinhMuonSach.instance;
            }

            private set
            {
                SCRIPT.formatRPTinhHinhMuonSach.instance = value;
            }
        }

        public void returnIDBCMuonSach(ref string id)
        {
            id = "IMS" + id;
        }
    }
}
