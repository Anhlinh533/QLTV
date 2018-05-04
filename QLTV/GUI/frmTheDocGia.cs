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
    public partial class frmTheDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTheDocGia()
        {
            InitializeComponent();
        }

        private void frmTheDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LOAIDOCGIA' table. You can move, or remove it, as needed.
            this.lOAIDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.LOAIDOCGIA);

        }
        #region Event

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {


        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatTheDocGia.Instance.checkTheDocGia(tb_IDDocGia.Text, tb_HoTenDocGia.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text, cbb_LoaiDocGia.Text, dtp_NgayLapThe.Text);

        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Function
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}