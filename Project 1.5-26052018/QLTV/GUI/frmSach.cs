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
        public frmSach()
        {
            InitializeComponent();
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
        }

        private void btn_Them_Click(object sender, EventArgs e)
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

        private void btn_Sua_Click(object sender, EventArgs e)
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDSach.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDSach.Text != "")
            {
                ADO.adoSach.Instance.Xoa(tb_IDSach.Text);
                this.sACHTableAdapter.Fill(quanLyThuVienDataSet.SACH);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
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
            tb_IDSach.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            cbb_IDDauSach.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
            tb_NXB.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
            cbb_NXB.Text = dgv_Them.Rows[numrow].Cells[3].Value.ToString();
            tb_SoLuongTon.Text = dgv_Them.Rows[numrow].Cells[4].Value.ToString();
            tb_GiaTien.Text = dgv_Them.Rows[numrow].Cells[5].Value.ToString();
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
            SCRIPT.useForm.Instance.checkID(ADO.adoCTPhieuNhapSach.Instance.checkID(tb_IDSach.Text.Trim()), label9, tb_IDSach, pic_Warning, pic_Ss);

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

        }
    }
}