using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoCTTraSach
    {
        private static adoCTTraSach instance;

        internal static adoCTTraSach Instance
        {
            get
            {
                if (instance == null) instance = new adoCTTraSach(); return ADO.adoCTTraSach.instance;
            }

            private set
            {
                ADO.adoCTTraSach.instance = value;
            }
        }


    }
}
