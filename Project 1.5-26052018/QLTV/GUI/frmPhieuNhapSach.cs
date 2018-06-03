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
            label3.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();

            //dtp_NgayNhap.Format = DateTimePickerFormat.Custom;
            //dtp_NgayNhap.CustomFormat = "dd/MM/yyyy";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatPhieuNhapSach.Instance.checkPhieuNhapSach(tb_IDPhieuNhap.Text, dtp_NgayNhap.Text);
            SCRIPT.formatPhieuNhapSach.Instance.checkNull(tb_IDPhieuNhap);
            if (tb_IDPhieuNhap.Text != "" && dtp_NgayNhap.Text != "")
            {
                ADO.adoPhieuNhapSach.Instance.Them(tb_IDPhieuNhap.Text, dtp_NgayNhap.Text);
                this.pHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUNHAPSACH);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatPhieuNhapSach.Instance.checkPhieuNhapSach(tb_IDPhieuNhap.Text, dtp_NgayNhap.Text);
            SCRIPT.formatPhieuNhapSach.Instance.checkNull(tb_IDPhieuNhap);

            if (tb_IDPhieuNhap.Text != "" && dtp_NgayNhap.Text != "")
            {
                ADO.adoPhieuNhapSach.Instance.Sua(tb_IDPhieuNhap.Text, dtp_NgayNhap.Text);
                this.pHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUNHAPSACH);
                ResetForm();
            }
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
            this.pHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUNHAPSACH);
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
            tb_IDPhieuNhap.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            dtp_NgayNhap.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
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

        private void tb_IDPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            SCRIPT.useForm.Instance.checkID(ADO.adoPhieuNhapSach.Instance.checkID(tb_IDPhieuNhap.Text.Trim()), label3, tb_IDPhieuNhap, pic_Warning, pic_Ss);

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string idpn = dgv_Them.CurrentRow.Cells[0].Value.ToString();
            string ngaynhap = dgv_Them.CurrentRow.Cells[1].Value.ToString();

            ADO.adoPhieuNhapSach.Instance.Sua(idpn, ngaynhap);
            dgv_Them.DataSource = quanLyThuVienDataSet.PHIEUNHAPSACH;
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {

        }
    }
}