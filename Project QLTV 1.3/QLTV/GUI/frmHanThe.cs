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
    public partial class frmHanThe : DevExpress.XtraEditors.XtraForm
    {
        public frmHanThe()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_HanThe.Text == "") MessageBoxEx.Show("Không được để trống hạn thẻ!!");
            else
                //SCRIPT.useForm.ResetAllControls(groupControl1);
                ADO.adoHanThe.Instance.Sua(tb_HanThe.Text);
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