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
        private DataGridView dgv = new DataGridView();

        public frmTheDocGia()
        {
            InitializeComponent();
            this.Controls.Add(this.dgv);
        }

        private void frmTheDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LOAIDOCGIA' table. You can move, or remove it, as needed.
            this.lOAIDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.LOAIDOCGIA);
            label9.Hide();
            pic_Warning.Hide();
            pic_Ss.Hide();

            //dtp_NgayLapThe.Format = DateTimePickerFormat.Custom;
            //dtp_NgayLapThe.CustomFormat = "dd/MM/yyyy";
            //dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            //dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            ADO.ConnectionSQL.autoSach(tb_DiaChi, "select DiaChiDG from THEDOCGIA");

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("IDDocGia", "ID độc giả");
            dgv.Columns[0].DataPropertyName = "IDDocGia";
            dgv.Columns.Add("HoTenDG", "Họ tên độc giả");
            dgv.Columns[1].DataPropertyName = "HoTenDG";
            dgv.Columns.Add("NgaySinhDG", "Ngày sinh");
            dgv.Columns[2].DataPropertyName = "NgaySinhDG";
            dgv.Columns.Add("DiaChiDG", "Địa chỉ");
            dgv.Columns[3].DataPropertyName = "DiaChiDG";
            dgv.Columns.Add("EmailDG", "Email");
            dgv.Columns[4].DataPropertyName = "EmailDG";
            dgv.Columns.Add("IDLoaiDG", "ID loại độc giả");
            dgv.Columns[5].DataPropertyName = "IDLoaiDG";
            dgv.Columns.Add("TenLoaiDG", "Tên loại độc giả");
            dgv.Columns[6].DataPropertyName = "TenLoaiDG";
            dgv.Columns.Add("NgayLapThe", "Ngày lập thẻ");
            dgv.Columns[7].DataPropertyName = "NgayLapThe";
            dgv.Columns.Add("NgayHetHan", "Ngày hết hạn");
            dgv.Columns[8].DataPropertyName = "NgayHetHan";
            dgv.Columns.Add("TongNo", "Tổng nợ");
            dgv.Columns[9].DataPropertyName = "TongNo";
        }

        #region Event
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatTheDocGia.Instance.checkTheDocGia(tb_IDDocGia.Text, tb_HoTenDocGia.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text, cbb_LoaiDocGia.Text, dtp_NgayLapThe.Text);
                SCRIPT.formatTheDocGia.Instance.checkNull(tb_IDDocGia, tb_HoTenDocGia, tb_DiaChi, tb_Email, cbb_LoaiDocGia);
                if (tb_IDDocGia.Text != "" && tb_HoTenDocGia.Text != "" && dtp_NgaySinh.Text != "" && tb_DiaChi.Text != "" && tb_Email.Text != "" && cbb_LoaiDocGia.Text != "" && dtp_NgayLapThe.Text != "")
                {
                    ADO.adoTheDocGia.Instance.Them(tb_IDDocGia.Text, tb_HoTenDocGia.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text, cbb_LoaiDocGia.Text, dtp_NgayLapThe.Text);
                    this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatTheDocGia.Instance.checkTheDocGia(tb_IDDocGia.Text, tb_HoTenDocGia.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text, cbb_LoaiDocGia.Text, dtp_NgayLapThe.Text);
                SCRIPT.formatTheDocGia.Instance.checkNull(tb_IDDocGia, tb_HoTenDocGia, tb_DiaChi, tb_Email, cbb_LoaiDocGia);
                if (tb_IDDocGia.Text != "" && tb_HoTenDocGia.Text != "" && dtp_NgaySinh.Text != "" && tb_DiaChi.Text != "" && tb_Email.Text != "" && cbb_LoaiDocGia.Text != "" && dtp_NgayLapThe.Text != "")
                {
                    ADO.adoTheDocGia.Instance.Sua(tb_IDDocGia.Text, tb_HoTenDocGia.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text, cbb_LoaiDocGia.Text, dtp_NgayLapThe.Text);
                    this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_IDDocGia.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb_IDDocGia.Text != "")
                {
                    ADO.adoTheDocGia.Instance.Xoa(tb_IDDocGia.Text);
                    this.tHEDOCGIATableAdapter.Fill(quanLyThuVienDataSet.THEDOCGIA);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
                ResetForm();
            }
            catch { }
        }
        #endregion

        #region Form
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgv_ThemDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                tb_IDDocGia.Text = dgv_ThemDG.Rows[numrow].Cells[0].Value.ToString();
                tb_HoTenDocGia.Text = dgv_ThemDG.Rows[numrow].Cells[1].Value.ToString();
                dtp_NgaySinh.Text = dgv_ThemDG.Rows[numrow].Cells[2].Value.ToString();
                tb_DiaChi.Text = dgv_ThemDG.Rows[numrow].Cells[3].Value.ToString();
                tb_Email.Text = dgv_ThemDG.Rows[numrow].Cells[4].Value.ToString();
                cbb_LoaiDocGia.Text = dgv_ThemDG.Rows[numrow].Cells[5].Value.ToString();
                dtp_NgayLapThe.Text = dgv_ThemDG.Rows[numrow].Cells[6].Value.ToString();
            }
            catch { }
        }

        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl2);
        }

        private void chu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_IDDocGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.useForm.Instance.checkID(ADO.adoTheDocGia.Instance.checkID(tb_IDDocGia.Text.Trim()), label9, tb_IDDocGia, pic_Warning, pic_Ss);
            }
            catch { }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string iddg = dgv_ThemDG.Rows[t].Cells[0].Value.ToString();
                string hoten = dgv_ThemDG.Rows[t].Cells[1].Value.ToString();
                string ngaysinh = dgv_ThemDG.Rows[t].Cells[2].Value.ToString();
                string diachi = dgv_ThemDG.Rows[t].Cells[3].Value.ToString();
                string email = dgv_ThemDG.Rows[t].Cells[4].Value.ToString();
                string loaidg = dgv_ThemDG.Rows[t].Cells[5].Value.ToString();
                string ngaylapthe = dgv_ThemDG.Rows[t].Cells[6].Value.ToString();

                ADO.adoTheDocGia.Instance.Sua(iddg, hoten, ngaysinh, diachi, email, loaidg, ngaylapthe);
                dgv_ThemDG.DataSource = quanLyThuVienDataSet.THEDOCGIA;
                this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
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

                    string sql = ADO.adoTheDocGia.Instance.GetQueryFillDgv();
                    ADO.adoAdmin.Instance.XuatExcel(ref dgv, sql, DuongDan);
                }
            }
            catch { }
        }

        int t = 0;

        private void dgv_ThemDG_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_ThemDG.CurrentCell != null)
                    t = dgv_ThemDG.CurrentCell.RowIndex;
            }
            catch { }
        }
    }
}