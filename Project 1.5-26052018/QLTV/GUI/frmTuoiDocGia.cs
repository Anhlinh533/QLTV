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
            if (tb_TuoiMin.Text == "") MessageBoxEx.Show("Không được để trống tuổi nhỏ nhất!!");
            else if (tb_TuoiMax.Text == "") MessageBoxEx.Show("Không được để trống tuổi lớn nhất!!");
            if (tb_TuoiMin.Text != "" && tb_TuoiMax.Text != "")
                //SCRIPT.useForm.ResetAllControls(groupControl1);
                ADO.adoTuoiDocGia.Instance.Sua(tb_TuoiMin.Text, tb_TuoiMax.Text);
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