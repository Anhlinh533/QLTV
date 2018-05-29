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
    public partial class frmCTMuonSach : DevExpress.XtraEditors.XtraForm
    {
        public frmCTMuonSach()
        {
            InitializeComponent();
        }

        private void frmCTMuonSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CUONSACH' table. You can move, or remove it, as needed.
            this.cUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CUONSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUMUON' table. You can move, or remove it, as needed.
            this.pHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUMUON);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_PHIEUMUON' table. You can move, or remove it, as needed.
            this.cT_PHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUMUON);
            label5.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();
            ADO.ConnectionSQL.autoSach(cbb_IDPhieuMuon, "select IDPhieuMuon from PHIEUMUON");
            ADO.ConnectionSQL.autoSach(cbb_IDCuonSach, "select TenDauSach from DAUSACH");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTMuonSach.Instance.checkCTMuonSach(tb_IDCTPhieuMuon.Text, cbb_IDPhieuMuon.Text, cbb_IDCuonSach.Text);
            SCRIPT.formatCTMuonSach.Instance.checkNull(tb_IDCTPhieuMuon,cbb_IDPhieuMuon,cbb_IDCuonSach);
            if (tb_IDCTPhieuMuon.Text != "" && cbb_IDCuonSach.Text != "" && cbb_IDPhieuMuon.Text != "")
            {
                ADO.adoCTMuonSach.Instance.Them(tb_IDCTPhieuMuon.Text, cbb_IDPhieuMuon.Text, cbb_IDCuonSach.Text);
                this.cT_PHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUMUON);
                ResetForm();
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTMuonSach.Instance.checkCTMuonSach(tb_IDCTPhieuMuon.Text, cbb_IDPhieuMuon.Text, cbb_IDCuonSach.Text);
            SCRIPT.formatCTMuonSach.Instance.checkNull(tb_IDCTPhieuMuon, cbb_IDPhieuMuon, cbb_IDCuonSach);

            if (tb_IDCTPhieuMuon.Text != "" && cbb_IDCuonSach.Text != "" && cbb_IDPhieuMuon.Text != "")
            {
                ADO.adoCTMuonSach.Instance.Sua(tb_IDCTPhieuMuon.Text, cbb_IDPhieuMuon.Text, cbb_IDCuonSach.Text);
                this.cT_PHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUMUON);
                ResetForm();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDCTPhieuMuon.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDCTPhieuMuon.Text != "")
            {
                ADO.adoCTMuonSach.Instance.Xoa(tb_IDCTPhieuMuon.Text);
                this.cT_PHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUMUON);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.cT_PHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUMUON);
            ResetForm();
        }

        #region Form
        private void dgv_Them_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tb_IDCTPhieuMuon.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            cbb_IDPhieuMuon.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
            cbb_IDCuonSach.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
        }

        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl2);

        }

        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_IDCTPhieuMuon_TextChanged(object sender, EventArgs e)
        {
            SCRIPT.useForm.Instance.checkID(ADO.adoCTMuonSach.Instance.checkID(tb_IDCTPhieuMuon.Text.Trim()), label5, tb_IDCTPhieuMuon, pic_Warning, pic_Ss);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

        }

        private void cbb_IDCuonSach_Click(object sender, EventArgs e)
        {
            lv_CuonSach.Items.Add(cbb_IDCuonSach.Text);
        }
    }
}