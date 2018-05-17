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
using QLTV.SCRIPT;
using QLTV.ADO;
using System.Data.SqlClient;

namespace QLTV.GUI
{
    public partial class frmDangKi : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKi()
        {
            InitializeComponent();
        }

        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LOAIDOCGIA' table. You can move, or remove it, as needed.
            this.lOAIDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.LOAIDOCGIA);

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatTheDocGia.Instance.checkTheDocGia(tb_IDDocGia.Text, tb_HoTenDocGia.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text, cbb_LoaiDocGia.Text, dtp_NgayLapThe.Text);
            SCRIPT.formatTheDocGia.Instance.checkNull(tb_IDDocGia, tb_HoTenDocGia, tb_DiaChi, tb_Email, cbb_LoaiDocGia);
            if (tb_IDDocGia.Text != "" && tb_HoTenDocGia.Text != "" && dtp_NgaySinh.Text != "" && tb_DiaChi.Text != "" && tb_Email.Text != "" && cbb_LoaiDocGia.Text != "" && dtp_NgayLapThe.Text != "")
            {
                ADO.adoTheDocGia.Instance.Them(tb_IDDocGia.Text, tb_HoTenDocGia.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text, cbb_LoaiDocGia.Text, dtp_NgayLapThe.Text);
                this.Close();
            }
        }
    }
}