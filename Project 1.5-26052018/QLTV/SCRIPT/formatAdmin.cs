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

        public void checkAdmin(string UserName, string Password, string IDAdmin)
        {
            if (UserName == "") MessageBox.Show("Không được để trống User name.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Password == "") MessageBox.Show("Không được để trống Password.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDAdmin == "") MessageBox.Show("Không được để trống ID admin.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
        }

        public void checkNull(Control UserName, Control Password, Control IDAdmin)
        {
            if (useForm.Instance.checkNull(UserName) == true) useForm.Instance.Focus(UserName);
            else if (useForm.Instance.checkNull(Password) == true) useForm.Instance.Focus(Password);
            else if (useForm.Instance.checkNull(IDAdmin) == true) useForm.Instance.Focus(IDAdmin);            
        }
    }
}
