using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoTheDocGia
    {
        private static adoTheDocGia instance;

        internal static adoTheDocGia Instance
        {
            get
            {
                if (instance == null) instance = new adoTheDocGia(); return ADO.adoTheDocGia.instance;
            }

            private set
            {
                ADO.adoTheDocGia.instance = value;
            }
        }


    }
}
