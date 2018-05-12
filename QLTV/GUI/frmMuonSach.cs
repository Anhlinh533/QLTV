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
    public partial class frmMuonSach : DevExpress.XtraEditors.XtraForm
    {
        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUMUON' table. You can move, or remove it, as needed.
            this.pHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUMUON);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatMuonSach.Instance.checkPhieuMuonSach(tb_IDPhieuMuon.Text, cbb_IDDocGia.Text, dtp_NgayMuon.Text);
            if (tb_IDPhieuMuon.Text != "" && cbb_IDDocGia.Text != "" && dtp_NgayMuon.Text != "")
            {
                ADO.adoMuonSach.Instance.Them(tb_IDPhieuMuon.Text, cbb_IDDocGia.Text, dtp_NgayMuon.Text);
                this.pHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUMUON);
                ResetForm();
            }
        }       

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDPhieuMuon.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDPhieuMuon.Text != "")
            {
                ADO.adoMuonSach.Instance.Xoa(tb_IDPhieuMuon.Text);
                this.pHIEUMUONTableAdapter.Fill(quanLyThuVienDataSet.PHIEUMUON);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.pHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUMUON);
            ResetForm();
        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {
            if (cbb_IDDelete.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cbb_IDDelete.Text != "")
            {
                ADO.adoMuonSach.Instance.Xoa(cbb_IDDelete.Text);
                this.pHIEUMUONTableAdapter.Fill(quanLyThuVienDataSet.PHIEUMUON);
                ResetForm();
            }
        }
        #region Form
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgv_Them_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tb_IDPhieuMuon.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            cbb_IDDocGia.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
            dtp_NgayMuon.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
        }
        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl2);
            SCRIPT.useForm.ResetAllControls(groupControl3);
            SCRIPT.useForm.ResetAllControls(groupControl4);
        }
        #endregion
    }
}