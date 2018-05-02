using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoSach
    {
        private static adoSach instance;

        internal static adoSach Instance
        {
            get
            {
                if (instance == null) instance = new adoSach(); return ADO.adoSach.instance;
            }

            private set
            {
                ADO.adoSach.instance = value;
            }
        }


    }
}
