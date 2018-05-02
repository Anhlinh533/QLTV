using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoTacGia
    {
        private static adoTacGia instance;

        internal static adoTacGia Instance
        {
            get
            {
                if (instance == null) instance = new adoTacGia(); return ADO.adoTacGia.instance;
            }

            private set
            {
                ADO.adoTacGia.instance = value;
            }
        }


    }
}
