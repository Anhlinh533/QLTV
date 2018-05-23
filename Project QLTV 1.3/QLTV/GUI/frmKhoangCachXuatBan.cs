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
    public partial class frmKhoangCachXuatBan : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoangCachXuatBan()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //SCRIPT.useForm.ResetAllControls(groupControl1);
            ADO.adoKhoangCachXuatBan.Instance.Sua(tb_KhoangCach.Text);
        }

        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}