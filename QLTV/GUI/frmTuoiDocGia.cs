using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLTV.GUI
{
    public partial class frmTuoiDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTuoiDocGia()
        {
            InitializeComponent();
        }

        private void frmTuoiDocGia_Load(object sender, EventArgs e)
        {
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);

        }

        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}