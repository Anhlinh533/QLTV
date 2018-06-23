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
    public partial class frmSach : DevExpress.XtraEditors.XtraForm
    {
        private DataGridView dgv = new DataGridView();

        public frmSach()
        {
            InitializeComponent();
            this.Controls.Add(this.dgv);
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_TACGIA' table. You can move, or remove it, as needed.
            this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DAUSACH' table. You can move, or remove it, as needed.
            this.dAUSACHTableAdapter.Fill(this.quanLyThuVienDataSet.DAUSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            label9.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();

            ADO.ConnectionSQL.autoSach(cbb_IDCTTacGia, "Select TenTacGia from TACGIA");
            ADO.ConnectionSQL.autoSach(cbb_IDDauSach, "select TenDauSach from DAUSACH");
            ADO.ConnectionSQL.autoSach(tb_NXB, "select NhaXB from SACH");

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("IDSach", "ID sách");
            dgv.Columns[0].DataPropertyName = "IDSach";
            dgv.Columns.Add("IDDauSach", "ID đầu sách");
            dgv.Columns[1].DataPropertyName = "IDDauSach";
            dgv.Columns.Add("TenDauSach", "Tên đầu sách");
            dgv.Columns[2].DataPropertyName = "TenDauSach";
            dgv.Columns.Add("IDCTTacGia", "ID chi tiết tác giả");
            dgv.Columns[3].DataPropertyName = "IDCTTacGia";
            dgv.Columns.Add("TenTacGia", "Tên tác giả");
            dgv.Columns[4].DataPropertyName = "TenTacGia";
            dgv.Columns.Add("NhaXB", "Nhà xuất bản");
            dgv.Columns[5].DataPropertyName = "NhaXB";
            dgv.Columns.Add("NamXB", "Năm xuất bản");
            dgv.Columns[6].DataPropertyName = "NamXB";
            dgv.Columns.Add("SoLuongTon", "Số lượng tồn");
            dgv.Columns[7].DataPropertyName = "SoLuongTon";
            dgv.Columns.Add("GiaTien", "Giá tiền");
            dgv.Columns[8].DataPropertyName = "GiaTien";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatSach.Instance.checkSach(tb_IDSach.Text, cbb_IDDauSach.Text, cbb_IDCTTacGia.Text, tb_NXB.Text, cbb_NXB.Text, tb_SoLuongTon.Text, tb_GiaTien.Text);
                SCRIPT.formatSach.Instance.checkNull(tb_IDSach, cbb_IDDauSach, cbb_IDCTTacGia, tb_NXB, cbb_NXB, tb_SoLuongTon, tb_GiaTien);
                if (tb_IDSach.Text != "" && cbb_IDDauSach.Text != "" && cbb_IDCTTacGia.Text != "" && tb_NXB.Text != "" && cbb_NXB.Text != "" && tb_SoLuongTon.Text != "" && tb_GiaTien.Text != "")
                {
                    ADO.adoSach.Instance.Them(tb_IDSach.Text, cbb_IDDauSach.Text, cbb_IDCTTacGia.Text, tb_NXB.Text, cbb_NXB.Text, tb_SoLuongTon.Text, tb_GiaTien.Text);
                    this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatSach.Instance.checkSach(tb_IDSach.Text, cbb_IDDauSach.Text, cbb_IDCTTacGia.Text, tb_NXB.Text, cbb_NXB.Text, tb_SoLuongTon.Text, tb_GiaTien.Text);
                SCRIPT.formatSach.Instance.checkNull(tb_IDSach, cbb_IDDauSach, cbb_IDCTTacGia, tb_NXB, cbb_NXB, tb_SoLuongTon, tb_GiaTien);

                if (tb_IDSach.Text != "" && cbb_IDDauSach.Text != "" && cbb_IDCTTacGia.Text != "" && tb_NXB.Text != "" && cbb_NXB.Text != "" && tb_SoLuongTon.Text != "" && tb_GiaTien.Text != "")
                {
                    ADO.adoSach.Instance.Sua(tb_IDSach.Text, cbb_IDDauSach.Text, cbb_IDCTTacGia.Text, tb_NXB.Text, cbb_NXB.Text, tb_SoLuongTon.Text, tb_GiaTien.Text);
                    this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_IDSach.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb_IDSach.Text != "")
                {
                    ADO.adoSach.Instance.Xoa(tb_IDSach.Text);
                    this.sACHTableAdapter.Fill(quanLyThuVienDataSet.SACH);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
                ResetForm();
            }
            catch { }
        }

        #region Form
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgv_Them_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                tb_IDSach.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
                tb_NXB.Text = dgv_Them.Rows[numrow].Cells[3].Value.ToString();
                cbb_NXB.Text = dgv_Them.Rows[numrow].Cells[4].Value.ToString();
                tb_SoLuongTon.Text = dgv_Them.Rows[numrow].Cells[5].Value.ToString();
                tb_GiaTien.Text = dgv_Them.Rows[numrow].Cells[6].Value.ToString();

                string idds = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
                string idctdg = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
                cbb_IDDauSach.Text = ADO.adoSach.Instance.AutoFill(idds, "cbb_IDDauSach");
                cbb_IDCTTacGia.Text = ADO.adoSach.Instance.AutoFill(idctdg, "cbb_IDCTTacGia");
            }
            catch { }
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

        private void tb_IDSach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.useForm.Instance.checkID(ADO.adoCTPhieuNhapSach.Instance.checkID(tb_IDSach.Text.Trim()), label9, tb_IDSach, pic_Warning, pic_Ss);
            }
            catch { }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string ids = dgv_Them.Rows[t].Cells[0].Value.ToString();
                string idds = dgv_Them.Rows[t].Cells[1].Value.ToString();
                string idcttg = dgv_Them.Rows[t].Cells[2].Value.ToString();
                string nhaxb = dgv_Them.Rows[t].Cells[3].Value.ToString();
                string namxb = dgv_Them.Rows[t].Cells[4].Value.ToString();
                string soluongton = dgv_Them.Rows[t].Cells[5].Value.ToString();
                string giatien = dgv_Them.Rows[t].Cells[6].Value.ToString();

                ADO.adoSach.Instance.Sua(ids, idds, idcttg, nhaxb, namxb, soluongton, giatien);
                dgv_Them.DataSource = quanLyThuVienDataSet.SACH;
                this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            }
            catch { }
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    sfd.Title = "Save an Excel File";
                    sfd.ShowDialog();

                    string DuongDan;
                    DuongDan = sfd.FileName;

                    string sql = ADO.adoSach.Instance.GetQueryFillDgv();
                    ADO.adoAdmin.Instance.XuatExcel(ref dgv, sql, DuongDan);
                }
            }
            catch { }
        }

        int t = 0;

        private void dgv_Them_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_Them.CurrentCell != null)
                    t = dgv_Them.CurrentCell.RowIndex;
            }
            catch { }
        }
    }
}