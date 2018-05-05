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
    public partial class frmCTTacGia : DevExpress.XtraEditors.XtraForm
    {
        public frmCTTacGia()
        {
            InitializeComponent();
        }

        private void frmCTTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DAUSACH' table. You can move, or remove it, as needed.
            this.dAUSACHTableAdapter.Fill(this.quanLyThuVienDataSet.DAUSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_TACGIA' table. You can move, or remove it, as needed.
            this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTTacGia.Instance.checkCTTacGia(tb_IDCTTacGia.Text, cbb_IDDauSach.Text, cbb_IDTacGia.Text);
            if(tb_IDCTTacGia.Text != "" && cbb_IDDauSach.Text != "" && cbb_IDTacGia.Text != "" )
            {
                ADO.adoCTTacGia.Instance.Them(tb_IDCTTacGia.Text, cbb_IDDauSach.Text, cbb_IDTacGia.Text);
                this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}