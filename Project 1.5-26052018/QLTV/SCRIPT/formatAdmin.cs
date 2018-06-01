using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatAdmin
    {
        private static formatAdmin instance;

        internal static formatAdmin Instance
        {
            get
            {
                if (instance == null) instance = new formatAdmin(); return SCRIPT.formatAdmin.instance;
            }

            private set
            {
                SCRIPT.formatAdmin.instance = value;
            }
        }
    }
}
