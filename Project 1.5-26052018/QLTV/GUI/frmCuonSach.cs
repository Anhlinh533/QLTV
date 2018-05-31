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
        public frmCuonSach()
        {
            InitializeComponent();
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
        }

        private void btn_Them_Click(object sender, EventArgs e)
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

        private void btn_Sua_Click(object sender, EventArgs e)
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDCuonSach.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDCuonSach.Text != "")
            {
                ADO.adoCuonSach.Instance.Xoa(tb_IDCuonSach.Text);
                this.cUONSACHTableAdapter.Fill(quanLyThuVienDataSet.CUONSACH);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.cUONSACHTableAdapter.Fill(quanLyThuVienDataSet.CUONSACH);
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
            tb_IDCuonSach.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            cbb_IDSach.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
            //cbb_TinhTrang.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
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
            SCRIPT.useForm.Instance.checkID(ADO.adoCuonSach.Instance.checkID(tb_IDCuonSach.Text.Trim()), label3, tb_IDCuonSach, pic_Warning, pic_Ss);

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

        }
    }
}