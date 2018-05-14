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

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //SCRIPT.formatCuonSach.Instance.checkCuonSach(tb_IDCuonSach.Text, cbb_IDSach.Text, cbb_TinhTrang.Text);
            //if (tb_IDCuonSach.Text != "" && cbb_IDSach.Text != "" && cbb_TinhTrang.Text != "")
            //{
            //    ADO.adoCuonSach.Instance.Them(tb_IDCuonSach.Text, cbb_IDSach.Text, cbb_TinhTrang.Text);
            //    this.cUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CUONSACH);
            //    ResetForm();
            //}
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

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

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {
            if (cbb_IDDelete.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cbb_IDDelete.Text != "")
            {
                ADO.adoCuonSach.Instance.Xoa(cbb_IDDelete.Text);
                this.cUONSACHTableAdapter.Fill(quanLyThuVienDataSet.CUONSACH);
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
            tb_IDCuonSach.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            cbb_IDSach.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
            //cbb_TinhTrang.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
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