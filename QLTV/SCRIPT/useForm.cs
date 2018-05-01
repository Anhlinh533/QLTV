using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class useForm
    {
        private static useForm instance;

        internal static useForm Instance
        {
            get
            {
                if (instance == null) instance = new useForm(); return SCRIPT.useForm.instance;
            }

            private set
            {
                SCRIPT.useForm.instance = value;
            }
        }
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        // Tránh việc gõ chữ vào text box ID
        public void messageShow(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Show message box cho form
        private void Close()
        {
            throw new NotImplementedException();
        }
    }
}
