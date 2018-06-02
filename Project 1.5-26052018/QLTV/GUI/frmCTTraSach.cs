
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
    public partial class frmCTTraSach : DevExpress.XtraEditors.XtraForm
    {
        public frmCTTraSach()
        {
            InitializeComponent();
        }

        private void frmCTTraSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUTRA' table. You can move, or remove it, as needed.
            this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CUONSACH' table. You can move, or remove it, as needed.
            this.cUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CUONSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_PHIEUTRA' table. You can move, or remove it, as needed.
            this.cT_PHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUTRA);
            label4.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();

            //idphieutra
            ADO.ConnectionSQL.autoSach(cbb_IDPhieuTra, "select IDPhieuTra from PHIEUTRA");

            //idcuonsach->tencuonsach. chuyển về id
            //ADO.ConnectionSQL.autoSach(cbb_IDCuonSach, "select TenDauSach from DAUSACH");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTTraSach.Instance.checkCTTraSach(tb_IDCTPhieuTra.Text, cbb_IDPhieuTra.Text, cbb_IDCuonSach.Text);
            SCRIPT.formatCTTraSach.Instance.checkNull(tb_IDCTPhieuTra, cbb_IDPhieuTra, cbb_IDCuonSach);
            if (tb_IDCTPhieuTra.Text != "" && cbb_IDPhieuTra.Text != "" && cbb_IDCuonSach.Text != "")
            {
                ADO.adoCTTraSach.Instance.Them(tb_IDCTPhieuTra.Text, cbb_IDPhieuTra.Text, cbb_IDCuonSach.Text);
                this.cT_PHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUTRA);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTTraSach.Instance.checkCTTraSach(tb_IDCTPhieuTra.Text, cbb_IDPhieuTra.Text, cbb_IDCuonSach.Text);
            SCRIPT.formatCTTraSach.Instance.checkNull(tb_IDCTPhieuTra, cbb_IDPhieuTra, cbb_IDCuonSach);

            if (tb_IDCTPhieuTra.Text != "" && cbb_IDPhieuTra.Text != "" && cbb_IDCuonSach.Text != "")
            {
                ADO.adoCTTraSach.Instance.Sua(tb_IDCTPhieuTra.Text, cbb_IDPhieuTra.Text, cbb_IDCuonSach.Text);
                this.cT_PHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUTRA);
                ResetForm();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDCTPhieuTra.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDCTPhieuTra.Text != "")
            {
                ADO.adoCTTraSach.Instance.Xoa(tb_IDCTPhieuTra.Text);
                this.cT_PHIEUTRATableAdapter.Fill(quanLyThuVienDataSet.CT_PHIEUTRA);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.cT_PHIEUTRATableAdapter.Fill(quanLyThuVienDataSet.CT_PHIEUTRA);
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
            tb_IDCTPhieuTra.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            cbb_IDPhieuTra.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
            cbb_IDCuonSach.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
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

        private void tb_IDCTPhieuTra_TextChanged(object sender, EventArgs e)
        {
            SCRIPT.useForm.Instance.checkID(ADO.adoCTTraSach.Instance.checkID(tb_IDCTPhieuTra.Text.Trim()), label4, tb_IDCTPhieuTra, pic_Warning, pic_Ss);

        }

        private void cbb_IDCuonSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                lb.Items.Add(cbb_IDCuonSach.Text);
            }
        }

        private void lb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lb.Items.Remove(lb.SelectedItem);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string idctpt = dgv_Them.CurrentRow.Cells[0].Value.ToString();
            string idpt = dgv_Them.CurrentRow.Cells[1].Value.ToString();
            string idcs = dgv_Them.CurrentRow.Cells[2].Value.ToString();

            ADO.adoCTTraSach.Instance.Sua(idctpt, idpt, idcs);
            dgv_Them.DataSource = quanLyThuVienDataSet.CT_PHIEUTRA;
        }
    }
}