using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatCTAdmin
    {
        private static formatCTAdmin instance;

        internal static formatCTAdmin Instance
        {
            get
            {
                if (instance == null) instance = new formatCTAdmin(); return SCRIPT.formatCTAdmin.instance;
            }

            private set
            {
                SCRIPT.formatCTAdmin.instance = value;
            }
        }

        public void returnIDCTAdmin(ref string id)
        {
            id = "CAD" + id;
        }

    }
}
