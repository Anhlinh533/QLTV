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
using DevComponents.DotNetBar;

namespace QLTV.GUI
{
    public partial class frmSoSachMuonMax : DevExpress.XtraEditors.XtraForm
    {
        public frmSoSachMuonMax()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_SoSachMuonMax.Text == "") MessageBoxEx.Show("Không được để trống số sách mượn tối đa!!");
            else
                //SCRIPT.useForm.ResetAllControls(groupControl1);
                ADO.adoSoSachMuonMax.Instance.Sua(tb_SoSachMuonMax.Text);
        }
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}