using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoCTTacGia
    {
        private static adoCTTacGia instance;

        internal static adoCTTacGia Instance
        {
            get
            {
                if (instance == null) instance = new adoCTTacGia(); return ADO.adoCTTacGia.instance;
            }

            private set
            {
                ADO.adoCTTacGia.instance = value;
            }
        }


    }
}
