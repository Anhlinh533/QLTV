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
    public partial class frmPhieuNhapSach : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuNhapSach()
        {
            InitializeComponent();
        }

        private void frmPhieuNhapSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUNHAPSACH' table. You can move, or remove it, as needed.
            this.pHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUNHAPSACH);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatPhieuNhapSach.Instance.checkPhieuNhapSach(tb_IDPhieuNhap.Text, dtp_NgayNhap.Text);
            if (tb_IDPhieuNhap.Text != "" && dtp_NgayNhap.Text != "" )
            {
                ADO.adoPhieuNhapSach.Instance.Them(tb_IDPhieuNhap.Text, dtp_NgayNhap.Text);
                this.pHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUNHAPSACH);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDPhieuNhap.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDPhieuNhap.Text != "")
            {
                ADO.adoPhieuNhapSach.Instance.Xoa(tb_IDPhieuNhap.Text);
                this.pHIEUNHAPSACHTableAdapter.Fill(quanLyThuVienDataSet.PHIEUNHAPSACH);
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
                ADO.adoPhieuNhapSach.Instance.Xoa(cbb_IDDelete.Text);
                this.pHIEUNHAPSACHTableAdapter.Fill(quanLyThuVienDataSet.PHIEUNHAPSACH);
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
            tb_IDPhieuNhap.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            dtp_NgayNhap.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();

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