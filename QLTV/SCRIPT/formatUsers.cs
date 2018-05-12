using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatUsers
    {
        private static formatUsers instance;

        internal static formatUsers Instance
        {
            get
            {
                if (instance == null) instance = new formatUsers(); return SCRIPT.formatUsers.instance;
            }

            private set
            {
                SCRIPT.formatUsers.instance = value;
            }
        }

        public void checkUsers(string UserName,string Password,string IDDocGia)
        {
            if (UserName == "") MessageBox.Show("Không được để trống User Name.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Password == "") MessageBox.Show("Không được để trống Password.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDDocGia == "") MessageBox.Show("Không được để trống ID độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
