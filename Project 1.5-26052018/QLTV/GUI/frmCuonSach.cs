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
    public partial class frmCuonSach : DevExpress.XtraEditors.XtraForm
    {
        private DataGridView dgv = new DataGridView();

        public frmCuonSach()
        {
            InitializeComponent();
            this.Controls.Add(this.dgv);
        }

        private void frmCuonSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CUONSACH' table. You can move, or remove it, as needed.
            this.cUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CUONSACH);
            label3.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("IDCuonSach", "ID cuốn sách");
            dgv.Columns[0].DataPropertyName = "IDCuonSach";
            dgv.Columns.Add("IDSach", "ID sách");
            dgv.Columns[1].DataPropertyName = "IDSach";
            dgv.Columns.Add("TenDauSach", "Tên cuốn sách");
            dgv.Columns[2].DataPropertyName = "TenDauSach";
            dgv.Columns.Add("TinhTrang", "Tình trạng");
            dgv.Columns[3].DataPropertyName = "TinhTrang";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatCuonSach.Instance.checkCuonSach(tb_IDCuonSach.Text, cbb_IDSach.Text);
                SCRIPT.formatCuonSach.Instance.checkNull(tb_IDCuonSach, cbb_IDSach);
                if (tb_IDCuonSach.Text != "" && cbb_IDSach.Text != "")
                {
                    ADO.adoCuonSach.Instance.Them(tb_IDCuonSach.Text, cbb_IDSach.Text);
                    this.cUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CUONSACH);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatCuonSach.Instance.checkCuonSach(tb_IDCuonSach.Text, cbb_IDSach.Text);
                SCRIPT.formatCuonSach.Instance.checkNull(tb_IDCuonSach, cbb_IDSach);

                if (tb_IDCuonSach.Text != "" && cbb_IDSach.Text != "")
                {
                    ADO.adoCuonSach.Instance.Sua(tb_IDCuonSach.Text, cbb_IDSach.Text);
                    this.cUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CUONSACH);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_IDCuonSach.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb_IDCuonSach.Text != "")
                {
                    ADO.adoCuonSach.Instance.Xoa(tb_IDCuonSach.Text);
                    this.cUONSACHTableAdapter.Fill(quanLyThuVienDataSet.CUONSACH);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                this.cUONSACHTableAdapter.Fill(quanLyThuVienDataSet.CUONSACH);
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
                tb_IDCuonSach.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
                cbb_IDSach.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
                //cbb_TinhTrang.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
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

        private void tb_IDCuonSach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.useForm.Instance.checkID(ADO.adoCuonSach.Instance.checkID(tb_IDCuonSach.Text.Trim()), label3, tb_IDCuonSach, pic_Warning, pic_Ss);
            }
            catch { }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string idcs = dgv_Them.Rows[t].Cells[0].Value.ToString();
                string ids = dgv_Them.Rows[t].Cells[1].Value.ToString();

                ADO.adoCuonSach.Instance.Sua(idcs, ids);
                dgv_Them.DataSource = quanLyThuVienDataSet.CUONSACH;
                this.cUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CUONSACH);
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

                    string sql = ADO.adoCuonSach.Instance.GetQueryFillDgv();
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