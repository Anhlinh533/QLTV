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
        private DataGridView dgv = new DataGridView();

        public frmMuonSach()
        {
            InitializeComponent();
            this.Controls.Add(this.dgv);
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUMUON' table. You can move, or remove it, as needed.
            this.pHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUMUON);
            label4.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();

            //dtp_NgayMuon.Format = DateTimePickerFormat.Custom;
            //dtp_NgayMuon.CustomFormat = "dd/MM/yyyy";
            ADO.ConnectionSQL.autoSach(cbb_IDDocGia, "Select IDDocGia from THEDOCGIA");

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("IDPhieuMuon", "ID phiếu mượn");
            dgv.Columns[0].DataPropertyName = "IDPhieuMuon";
            dgv.Columns.Add("IDDocGia", "ID độc giả");
            dgv.Columns[1].DataPropertyName = "IDDocGia";
            dgv.Columns.Add("HoTenDG", "Tên độc giả");
            dgv.Columns[2].DataPropertyName = "HoTenDG";
            dgv.Columns.Add("NgayMuon", "Ngày mượn");
            dgv.Columns[3].DataPropertyName = "NgayMuon";
            dgv.Columns.Add("HanTra", "Hạn trả");
            dgv.Columns[4].DataPropertyName = "HanTra";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatMuonSach.Instance.checkPhieuMuonSach(tb_IDPhieuMuon.Text, cbb_IDDocGia.Text, dtp_NgayMuon.Text);
            SCRIPT.formatMuonSach.Instance.checkNull(tb_IDPhieuMuon, cbb_IDDocGia);
            if (tb_IDPhieuMuon.Text != "" && cbb_IDDocGia.Text != "" && dtp_NgayMuon.Text != "")
            {
                ADO.adoMuonSach.Instance.Them(tb_IDPhieuMuon.Text, cbb_IDDocGia.Text, dtp_NgayMuon.Text);
                this.pHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUMUON);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatMuonSach.Instance.checkPhieuMuonSach(tb_IDPhieuMuon.Text, cbb_IDDocGia.Text, dtp_NgayMuon.Text);
            SCRIPT.formatMuonSach.Instance.checkNull(tb_IDPhieuMuon, cbb_IDDocGia);

            if (tb_IDPhieuMuon.Text != "" && cbb_IDDocGia.Text != "" && dtp_NgayMuon.Text != "")
            {
                ADO.adoMuonSach.Instance.Sua(tb_IDPhieuMuon.Text, cbb_IDDocGia.Text, dtp_NgayMuon.Text);
                this.pHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUMUON);
                ResetForm();
            }
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

            SCRIPT.useForm.ResetAllControls(groupControl3);
            SCRIPT.useForm.ResetAllControls(groupControl4);
        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_IDPhieuMuon_TextChanged(object sender, EventArgs e)
        {
            SCRIPT.useForm.Instance.checkID(ADO.adoMuonSach.Instance.checkID(tb_IDPhieuMuon.Text.Trim()), label4, tb_IDPhieuMuon, pic_Warning, pic_Ss);

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string idpm = dgv_Them.CurrentRow.Cells[0].Value.ToString();
            string iddg = dgv_Them.CurrentRow.Cells[1].Value.ToString();
            string ngaymuon = dgv_Them.CurrentRow.Cells[2].Value.ToString();
            string hantra = dgv_Them.CurrentRow.Cells[3].Value.ToString();

            ADO.adoMuonSach.Instance.Sua(idpm, iddg, ngaymuon);
            dgv_Them.DataSource = quanLyThuVienDataSet.PHIEUMUON;
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                sfd.Title = "Save an Excel File";
                sfd.ShowDialog();

                string DuongDan;
                DuongDan = sfd.FileName;

                string sql = ADO.adoMuonSach.Instance.GetQueryFillDgv();
                ADO.adoAdmin.Instance.XuatExcel(ref dgv, sql, DuongDan);
            }
        }
    }
}