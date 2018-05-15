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
        public frmTheDocGia()
        {
            InitializeComponent();
        }

        private void frmTheDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LOAIDOCGIA' table. You can move, or remove it, as needed.
            this.lOAIDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.LOAIDOCGIA);

        }
        #region Event

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatTheDocGia.Instance.checkTheDocGia(tb_IDDocGia.Text, tb_HoTenDocGia.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text, cbb_LoaiDocGia.Text, dtp_NgayLapThe.Text);
            if (tb_IDDocGia.Text != "" && tb_HoTenDocGia.Text != "" && dtp_NgaySinh.Text != "" && tb_DiaChi.Text != "" && tb_Email.Text != "" && cbb_LoaiDocGia.Text != "" && dtp_NgayLapThe.Text != "")
            {
                ADO.adoTheDocGia.Instance.Them(tb_IDDocGia.Text, tb_HoTenDocGia.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text, cbb_LoaiDocGia.Text, dtp_NgayLapThe.Text);
                this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
                SCRIPT.useForm.ResetAllControls(groupControl1);
                SCRIPT.useForm.ResetAllControls(groupControl2);
                SCRIPT.useForm.ResetAllControls(groupControl3);
                SCRIPT.useForm.ResetAllControls(groupControl4);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatTheDocGia.Instance.checkTheDocGia(tb_IDDocGia.Text, tb_HoTenDocGia.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text, cbb_LoaiDocGia.Text, dtp_NgayLapThe.Text);
            if (tb_IDDocGia.Text != "" && tb_HoTenDocGia.Text != "" && dtp_NgaySinh.Text != "" && tb_DiaChi.Text != "" && tb_Email.Text != "" && cbb_LoaiDocGia.Text != "" && dtp_NgayLapThe.Text != "")
            {
                ADO.adoTheDocGia.Instance.Sua(tb_IDDocGia.Text, tb_HoTenDocGia.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text, cbb_LoaiDocGia.Text, dtp_NgayLapThe.Text);
                this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDDocGia.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDDocGia.Text != "")
            {
                ADO.adoTheDocGia.Instance.Xoa(cbb_IDDelete.Text);
                this.tHEDOCGIATableAdapter.Fill(quanLyThuVienDataSet.THEDOCGIA);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
            ResetForm();
        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {
            if (cbb_IDDelete.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cbb_IDDelete.Text != "")
            {
                ADO.adoTheDocGia.Instance.Xoa(cbb_IDDelete.Text);
                this.tHEDOCGIATableAdapter.Fill(quanLyThuVienDataSet.THEDOCGIA);
                ResetForm();
            }
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


        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl2);
            SCRIPT.useForm.ResetAllControls(groupControl3);
            SCRIPT.useForm.ResetAllControls(groupControl4);
        }

        private void chu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}