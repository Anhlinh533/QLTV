﻿using System;
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
    public partial class frmTraSach : DevExpress.XtraEditors.XtraForm
    {
        private DataGridView dgv = new DataGridView();

        public frmTraSach()
        {
            InitializeComponent();
            this.Controls.Add(this.dgv);
        }

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUTRA' table. You can move, or remove it, as needed.
            this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);
            label4.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();

            //dtp_NgayTra.Format = DateTimePickerFormat.Custom;
            //dtp_NgayTra.CustomFormat = "dd/MM/yyyy";

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("IDPhieuTra", "ID phiếu trả");
            dgv.Columns[0].DataPropertyName = "IDPhieuTra";
            dgv.Columns.Add("IDDocGia", "ID độc giả");
            dgv.Columns[1].DataPropertyName = "IDDocGia";
            dgv.Columns.Add("HoTenDG", "Tên độc giả");
            dgv.Columns[2].DataPropertyName = "HoTenDG";
            dgv.Columns.Add("NgayTra", "Ngày trả");
            dgv.Columns[3].DataPropertyName = "NgayTra";
            dgv.Columns.Add("TienPhatKyNay", "Tiền phạt kỳ này");
            dgv.Columns[4].DataPropertyName = "TienPhatKyNay";
            dgv.Columns.Add("SoTienTra", "Số tiền trả");
            dgv.Columns[5].DataPropertyName = "SoTienTra";
            dgv.Columns.Add("TienNoKyNay", "Tiền nợ kỳ này");
            dgv.Columns[6].DataPropertyName = "TienNoKyNay";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatTraSach.Instance.checkTraSach(tb_IDPhieuTra.Text, cbb_IDDocGia.Text, dtp_NgayTra.Text, tb_SoTienTra.Text);
            SCRIPT.formatTraSach.Instance.checkNull(tb_IDPhieuTra, cbb_IDDocGia, tb_SoTienTra);
            if (tb_IDPhieuTra.Text != "" && cbb_IDDocGia.Text != "" && dtp_NgayTra.Text != "" && tb_SoTienTra.Text != "")
            {
                ADO.adoTraSach.Instance.Them(tb_IDPhieuTra.Text, cbb_IDDocGia.Text, dtp_NgayTra.Text, tb_SoTienTra.Text);
                this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatTraSach.Instance.checkTraSach(tb_IDPhieuTra.Text, cbb_IDDocGia.Text, dtp_NgayTra.Text, tb_SoTienTra.Text);
            SCRIPT.formatTraSach.Instance.checkNull(tb_IDPhieuTra, cbb_IDDocGia, tb_SoTienTra);
            if (tb_IDPhieuTra.Text != "" && cbb_IDDocGia.Text != "" && dtp_NgayTra.Text != "" && tb_SoTienTra.Text != "")
            {
                ADO.adoTraSach.Instance.Sua(tb_IDPhieuTra.Text, cbb_IDDocGia.Text, dtp_NgayTra.Text, tb_SoTienTra.Text);
                this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);
                ResetForm();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDPhieuTra.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDPhieuTra.Text != "")
            {
                ADO.adoTraSach.Instance.Xoa(tb_IDPhieuTra.Text);
                this.pHIEUTRATableAdapter.Fill(quanLyThuVienDataSet.PHIEUTRA);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);
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
            tb_IDPhieuTra.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            cbb_IDDocGia.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
            dtp_NgayTra.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
            tb_SoTienTra.Text = dgv_Them.Rows[numrow].Cells[4].Value.ToString();
        }

        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl2);

        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_IDPhieuTra_TextChanged(object sender, EventArgs e)
        {
            SCRIPT.useForm.Instance.checkID(ADO.adoTraSach.Instance.checkID(tb_IDPhieuTra.Text.Trim()), label4, tb_IDPhieuTra, pic_Warning, pic_Ss);

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string idpt = dgv_Them.Rows[t].Cells[0].Value.ToString();
            string iddg = dgv_Them.Rows[t].Cells[1].Value.ToString();
            string ngaytra = dgv_Them.Rows[t].Cells[2].Value.ToString();
            string sotientra = dgv_Them.Rows[t].Cells[4].Value.ToString();

            ADO.adoTraSach.Instance.Sua(idpt, iddg, ngaytra, sotientra);
            dgv_Them.DataSource = quanLyThuVienDataSet.PHIEUTRA;
            this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);
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

                string sql = ADO.adoTraSach.Instance.GetQueryFillDgv();
                ADO.adoAdmin.Instance.XuatExcel(ref dgv, sql, DuongDan);
            }
        }

        int t = 0;

        private void dgv_Them_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Them.CurrentCell != null)
                t = dgv_Them.CurrentCell.RowIndex;
        }
    }
}