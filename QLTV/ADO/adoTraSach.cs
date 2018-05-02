using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoTraSach
    {
        private static adoTraSach instance;

        internal static adoTraSach Instance
        {
            get
            {
                if (instance == null) instance = new adoTraSach(); return ADO.adoTraSach.instance;
            }

            private set
            {
                ADO.adoTraSach.instance = value;
            }
        }


    }
}
