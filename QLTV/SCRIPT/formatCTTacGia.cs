using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLTV.SCRIPT
{
    class formatCTTacGia
    {
        private static formatCTTacGia instance;

        internal static formatCTTacGia Instance
        {
            get
            {
                if (instance == null) instance = new formatCTTacGia(); return SCRIPT.formatCTTacGia.instance;
            }

            private set
            {
                SCRIPT.formatCTTacGia.instance = value;
            }
        }
        public string returnIDCTTacGia(string id)
        {
            string IDDocGia;
            IDDocGia = "CTG" + id;
            return IDDocGia;
        }
    }
}
