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
    public partial class frmTacGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatTacGia.Instance.checkTacGia(tb_IDTacGia.Text, tb_TenTacGia.Text, dtp_NgaySinh.Text);
            if (tb_IDTacGia.Text != "" && tb_TenTacGia.Text != "" && dtp_NgaySinh.Text != "")
            {
                ADO.adoTacGia.Instance.Them(tb_IDTacGia.Text, tb_TenTacGia.Text, dtp_NgaySinh.Text);
                this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDTacGia.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDTacGia.Text != "")
            {
                ADO.adoTacGia.Instance.Xoa(tb_IDTacGia.Text);
                this.tACGIATableAdapter.Fill(quanLyThuVienDataSet.TACGIA);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
            ResetForm();
        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {
            if (cbb_IDDelete.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cbb_IDDelete.Text != "")
            {
                ADO.adoTacGia.Instance.Xoa(cbb_IDDelete.Text);
                this.tACGIATableAdapter.Fill(quanLyThuVienDataSet.TACGIA);
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
            tb_IDTacGia.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            tb_TenTacGia.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
            dtp_NgaySinh.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
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