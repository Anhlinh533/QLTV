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
    public partial class frmLoaiSach : DevExpress.XtraEditors.XtraForm
    {
        private DataGridView dgv = new DataGridView();

        public frmLoaiSach()
        {
            InitializeComponent();
            this.Controls.Add(this.dgv);
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LOAISACH' table. You can move, or remove it, as needed.
            this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
            label4.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("IDLoaiSach", "ID loại sách");
            dgv.Columns[0].DataPropertyName = "IDLoaiSach";
            dgv.Columns.Add("TenLoaiSach", "Tên loại sách");
            dgv.Columns[1].DataPropertyName = "TenLoaiSach";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatLoaiSach.Instance.checkLoaiSach(tb_IDLoaiSach.Text, tb_TenLoaiSach.Text);
            SCRIPT.formatLoaiSach.Instance.checkNull(tb_IDLoaiSach, tb_TenLoaiSach);
            if (tb_IDLoaiSach.Text != "" && tb_TenLoaiSach.Text != "")
            {
                ADO.adoLoaiSach.Instance.Them(tb_IDLoaiSach.Text, tb_TenLoaiSach.Text);
                this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatLoaiSach.Instance.checkLoaiSach(tb_IDLoaiSach.Text, tb_TenLoaiSach.Text);
            SCRIPT.formatLoaiSach.Instance.checkNull(tb_IDLoaiSach, tb_TenLoaiSach);

            if (tb_IDLoaiSach.Text != "" && tb_TenLoaiSach.Text != "")
            {
                ADO.adoLoaiSach.Instance.Sua(tb_IDLoaiSach.Text, tb_TenLoaiSach.Text);
                this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
                ResetForm();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDLoaiSach.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDLoaiSach.Text != "")
            {
                ADO.adoLoaiSach.Instance.Xoa(tb_IDLoaiSach.Text);
                this.lOAISACHTableAdapter.Fill(quanLyThuVienDataSet.LOAISACH);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
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
            tb_IDLoaiSach.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            tb_TenLoaiSach.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
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

        private void tb_IDLoaiSach_TextChanged(object sender, EventArgs e)
        {
            SCRIPT.useForm.Instance.checkID(ADO.adoLoaiSach.Instance.checkID(tb_IDLoaiSach.Text.Trim()), label4, tb_IDLoaiSach, pic_Warning, pic_Ss);

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string idls = dgv_Them.Rows[t].Cells[0].Value.ToString();
            string tenls = dgv_Them.Rows[t].Cells[1].Value.ToString();

            ADO.adoLoaiSach.Instance.Sua(idls, tenls);
            dgv_Them.DataSource = quanLyThuVienDataSet.LOAISACH;
            this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
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

                string sql = ADO.adoLoaiSach.Instance.GetQueryFillDgv();
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