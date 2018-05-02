using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoUsers
    {
        private static adoUsers instance;

        internal static adoUsers Instance
        {
            get
            {
                if (instance == null) instance = new adoUsers(); return ADO.adoUsers.instance;
            }

            private set
            {
                ADO.adoUsers.instance = value;
            }
        }


    }
}
