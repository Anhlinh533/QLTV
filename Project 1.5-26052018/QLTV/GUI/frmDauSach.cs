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
    public partial class frmDauSach : DevExpress.XtraEditors.XtraForm
    {
        private DataGridView dgv = new DataGridView();

        public frmDauSach()
        {
            InitializeComponent();
            this.Controls.Add(this.dgv);
        }

        private void frmDauSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LOAISACH' table. You can move, or remove it, as needed.
            this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DAUSACH' table. You can move, or remove it, as needed.
            this.dAUSACHTableAdapter.Fill(this.quanLyThuVienDataSet.DAUSACH);
            label5.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();

            ADO.ConnectionSQL.autoSach(cbb_IDTheLoaiSach, "select TenLoaiSach from LOAISACH");

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("IDDauSach", "ID đầu sách");
            dgv.Columns[0].DataPropertyName = "IDDauSach";
            dgv.Columns.Add("TenDauSach", "Tên đầu sách");
            dgv.Columns[1].DataPropertyName = "TenDauSach";
            dgv.Columns.Add("IDLoaiSach", "ID loại sách");
            dgv.Columns[2].DataPropertyName = "IDLoaiSach";
            dgv.Columns.Add("TenLoaiSach", "Tên loại sách");
            dgv.Columns[3].DataPropertyName = "TenLoaiSach";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatDauSach.Instance.checkDauSach(tb_IDDauSach.Text, tb_TenDauSach.Text, cbb_IDTheLoaiSach.Text);
                SCRIPT.formatDauSach.Instance.checkNull(tb_IDDauSach, tb_TenDauSach, cbb_IDTheLoaiSach);
                if (tb_IDDauSach.Text != "" && tb_TenDauSach.Text != "" && cbb_IDTheLoaiSach.Text != "")
                {
                    ADO.adoDauSach.Instance.Them(tb_IDDauSach.Text, tb_TenDauSach.Text, cbb_IDTheLoaiSach.Text);
                    this.dAUSACHTableAdapter.Fill(this.quanLyThuVienDataSet.DAUSACH);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatDauSach.Instance.checkDauSach(tb_IDDauSach.Text, tb_TenDauSach.Text, cbb_IDTheLoaiSach.Text);
                SCRIPT.formatDauSach.Instance.checkNull(tb_IDDauSach, tb_TenDauSach, cbb_IDTheLoaiSach);

                if (tb_IDDauSach.Text != "" && tb_TenDauSach.Text != "" && cbb_IDTheLoaiSach.Text != "")
                {
                    ADO.adoDauSach.Instance.Sua(tb_IDDauSach.Text, tb_TenDauSach.Text, cbb_IDTheLoaiSach.Text);
                    this.dAUSACHTableAdapter.Fill(this.quanLyThuVienDataSet.DAUSACH);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_IDDauSach.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb_IDDauSach.Text != "")
                {
                    ADO.adoDauSach.Instance.Xoa(tb_IDDauSach.Text);
                    this.dAUSACHTableAdapter.Fill(quanLyThuVienDataSet.DAUSACH);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                this.dAUSACHTableAdapter.Fill(quanLyThuVienDataSet.DAUSACH);
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

        private void dgv_ThemDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                tb_IDDauSach.Text = dgv_ThemDauSach.Rows[numrow].Cells[0].Value.ToString();
                tb_TenDauSach.Text = dgv_ThemDauSach.Rows[numrow].Cells[1].Value.ToString();

                string idls = dgv_ThemDauSach.Rows[numrow].Cells[2].Value.ToString();
                cbb_IDTheLoaiSach.Text = ADO.adoDauSach.Instance.AutoFill(idls, "cbb_IDTheLoaiSach");
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

        private void tb_IDDauSach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.useForm.Instance.checkID(ADO.adoDauSach.Instance.checkID(tb_IDDauSach.Text.Trim()), label5, tb_IDDauSach, pic_Warning, pic_Ss);
            }
            catch { }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string idds = dgv_ThemDauSach.Rows[t].Cells[0].Value.ToString();
                string tends = dgv_ThemDauSach.Rows[t].Cells[1].Value.ToString();
                string idls = dgv_ThemDauSach.Rows[t].Cells[2].Value.ToString();

                ADO.adoDauSach.Instance.SuaLuu(idds, tends, idls);
                dgv_ThemDauSach.DataSource = quanLyThuVienDataSet.DAUSACH;
                this.dAUSACHTableAdapter.Fill(this.quanLyThuVienDataSet.DAUSACH);
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

                    string sql = ADO.adoDauSach.Instance.GetQueryFillDgv();
                    ADO.adoAdmin.Instance.XuatExcel(ref dgv, sql, DuongDan);
                }
            }
            catch { }
        }

        int t = 0;

        private void dgv_ThemDauSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_ThemDauSach.CurrentCell != null)
                    t = dgv_ThemDauSach.CurrentCell.RowIndex;
            }
            catch { }
        }
    }
}