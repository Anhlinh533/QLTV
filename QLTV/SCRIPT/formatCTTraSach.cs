using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLTV.SCRIPT
{
    class formatCTTraSach
    {
        private static formatCTTraSach instance;

        internal static formatCTTraSach Instance
        {
            get
            {
                if (instance == null) instance = new formatCTTraSach(); return SCRIPT.formatCTTraSach.instance;
            }

            private set
            {
                SCRIPT.formatCTTraSach.instance = value;
            }
        }
        public string returnIDCTTraSach(string id)
        {
            string IDDocGia;
            IDDocGia = "CPT" + id;
            return IDDocGia;
        }
    }
}
