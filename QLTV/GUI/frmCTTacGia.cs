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
    public partial class frmCTTacGia : DevExpress.XtraEditors.XtraForm
    {
        public frmCTTacGia()
        {
            InitializeComponent();
        }

        private void frmCTTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DAUSACH' table. You can move, or remove it, as needed.
            this.dAUSACHTableAdapter.Fill(this.quanLyThuVienDataSet.DAUSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_TACGIA' table. You can move, or remove it, as needed.
            this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTTacGia.Instance.checkCTTacGia(tb_IDCTTacGia.Text, cbb_IDDauSach.Text, cbb_IDTacGia.Text);
            if (tb_IDCTTacGia.Text != "" && cbb_IDDauSach.Text != "" && cbb_IDTacGia.Text != "")
            {
                ADO.adoCTTacGia.Instance.Them(tb_IDCTTacGia.Text, cbb_IDDauSach.Text, cbb_IDTacGia.Text);
                this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTTacGia.Instance.checkCTTacGia(tb_IDCTTacGia.Text, cbb_IDDauSach.Text, cbb_IDTacGia.Text);
            if (tb_IDCTTacGia.Text != "" && cbb_IDDauSach.Text != "" && cbb_IDTacGia.Text != "")
            {
                ADO.adoCTTacGia.Instance.Sua(tb_IDCTTacGia.Text, cbb_IDDauSach.Text, cbb_IDTacGia.Text);
                this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
                ResetForm();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDCTTacGia.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDCTTacGia.Text != "")
            {
                ADO.adoCTTacGia.Instance.Xoa(tb_IDCTTacGia.Text);
                this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
                ResetForm();
            }
        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {
            if (cbb_Delete.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cbb_Delete.Text != "")
            {
                ADO.adoCTTacGia.Instance.Xoa(cbb_Delete.Text);
                this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
                ResetForm();
            }
        }
        
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.cT_TACGIATableAdapter.Fill(quanLyThuVienDataSet.CT_TACGIA);
            ResetForm();
        }

        #region Form
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tb_IDCTTacGia.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            cbb_IDDauSach.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            cbb_IDTacGia.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
        }

        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl2);
            SCRIPT.useForm.ResetAllControls(groupControl3);
            SCRIPT.useForm.ResetAllControls(groupControl4);
        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}