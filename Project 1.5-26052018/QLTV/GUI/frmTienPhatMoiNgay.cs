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
    public partial class frmTienPhatMoiNgay : DevExpress.XtraEditors.XtraForm
    {
        public frmTienPhatMoiNgay()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_TienPhatMoiNgay.Text == "") MessageBoxEx.Show("Không được để trống tiền phạt mỗi ngày!!");
                else
                    //SCRIPT.useForm.ResetAllControls(groupControl1);
                    ADO.adoTienPhatMoiNgay.Instance.Sua(tb_TienPhatMoiNgay.Text);
            }
            catch { }
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