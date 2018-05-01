using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatTacGia
    {
        private static formatTacGia instance;

        internal static formatTacGia Instance
        {
            get
            {
                if (instance == null) instance = new formatTacGia(); return SCRIPT.formatTacGia.instance;
            }

            private set
            {
                SCRIPT.formatTacGia.instance = value;
            }
        }

        public string returnIDTacGia(string id)
        {
            string IDDocGia;
            IDDocGia = "ITG" + id;
            return IDDocGia;
        }
    }
}
