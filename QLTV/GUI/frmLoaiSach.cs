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
        public frmLoaiSach()
        {
            InitializeComponent();
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LOAISACH' table. You can move, or remove it, as needed.
            this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatLoaiSach.Instance.checkLoaiSach(tb_IDLoaiSach.Text, tb_TenLoaiSach.Text);
            if (tb_IDLoaiSach.Text != "" && tb_TenLoaiSach.Text != "")
            {
                ADO.adoLoaiSach.Instance.Them(tb_IDLoaiSach.Text, tb_TenLoaiSach.Text);
                this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

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

        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {
            if (cbb_IDDelete.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cbb_IDDelete.Text != "")
            {
                ADO.adoLoaiSach.Instance.Xoa(cbb_IDDelete.Text);
                this.lOAISACHTableAdapter.Fill(quanLyThuVienDataSet.LOAISACH);
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
            tb_IDLoaiSach.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            tb_TenLoaiSach.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
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