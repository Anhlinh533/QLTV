using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoDauSach
    {
        private static adoDauSach instance;

        internal static adoDauSach Instance
        {
            get
            {
                if (instance == null) instance = new adoDauSach(); return ADO.adoDauSach.instance;
            }

            private set
            {
                ADO.adoDauSach.instance = value;
            }
        }


    }
}
