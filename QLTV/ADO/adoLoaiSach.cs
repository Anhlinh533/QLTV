using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoLoaiSach
    {
        private static adoLoaiSach instance;

        internal static adoLoaiSach Instance
        {
            get
            {
                if (instance == null) instance = new adoLoaiSach(); return ADO.adoLoaiSach.instance;
            }

            private set
            {
                ADO.adoLoaiSach.instance = value;
            }
        }


    }
}
