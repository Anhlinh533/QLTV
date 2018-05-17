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

        public void checkUsers(string UserName, string Password, string IDDocGia)
        {
            if (UserName == "") MessageBox.Show("Không được để trống User Name.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Password == "") MessageBox.Show("Không được để trống Password.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDDocGia == "") MessageBox.Show("Không được để trống ID độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void checkNull(Control UserName,Control Pass,Control IDDocGia)
        {
            if (useForm.Instance.checkNull(UserName) == true) useForm.Instance.Focus(UserName);
            else if (useForm.Instance.checkNull(Pass) == true) useForm.Instance.Focus(Pass);
            else if (useForm.Instance.checkNull(IDDocGia) == true) useForm.Instance.Focus(IDDocGia);
        }
    }
}
