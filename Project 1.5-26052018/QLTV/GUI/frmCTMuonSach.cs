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
            SCRIPT.formatCTMuonSach.Instance.checkNull(tb_IDCTPhieuMuon, cbb_IDPhieuMuon, cbb_IDCuonSach);

            //if (tb_IDCTPhieuMuon.Text != "" && cbb_IDCuonSach.Text != "" && cbb_IDPhieuMuon.Text != "")
            //{
            //    ADO.adoCTMuonSach.Instance.Them(tb_IDCTPhieuMuon.Text, cbb_IDPhieuMuon.Text, cbb_IDCuonSach.Text);
            //    this.cT_PHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUMUON);
            //    ResetForm();
            //}

            if (tb_IDCTPhieuMuon.Text != "" && cbb_IDCuonSach.Text != "" && cbb_IDPhieuMuon.Text != "")
            {
                string s = "";                         

                for (int j = 0; j < lv_CuonSach.Items.Count; j++)
                {
                    string TenSach = "", TenTG = "";
                    int t = 0;

                    for (int i = 0; i < lv_CuonSach.Items[j].ToString().Length; i++)
                    {
                        if (lv_CuonSach.Items[j].ToString()[i] == '-')
                        {
                            t = i;
                            break;
                        }
                    }

                    if (t == 0) TenSach = lv_CuonSach.Items[j].ToString();
                    else
                    {
                        TenSach = lv_CuonSach.Items[j].ToString().Substring(0, t - 1);
                        TenTG = lv_CuonSach.Items[j].ToString().Substring(t + 2, lv_CuonSach.Items[j].ToString().Length - t - 2);
                    }

                        s = ADO.adoCTMuonSach.Instance.GetIDCuonSach(TenSach, TenTG);
                    if (s == null)
                        MessageBox.Show("Đã hết sách " + lv_CuonSach.Items[j].ToString());
                    else
                        ADO.adoCTMuonSach.Instance.Them(tb_IDCTPhieuMuon.Text, cbb_IDPhieuMuon.Text, s);
                }

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
                ADO.adoCTMuonSach.Instance.Xoa(tb_IDCTPhieuMuon.Text, cbb_IDCuonSach.Text);
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
            string idctpm = dgv_Them.CurrentRow.Cells[0].Value.ToString();
            string idpm = dgv_Them.CurrentRow.Cells[1].Value.ToString();
            string idcs = dgv_Them.CurrentRow.Cells[2].Value.ToString();

            ADO.adoCTMuonSach.Instance.Sua(idctpm, idpm, idcs);
            dgv_Them.DataSource = quanLyThuVienDataSet.CT_PHIEUMUON;
        }

        private void cbb_IDCuonSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (cbb_TenTacGia.Text == "")
                    lv_CuonSach.Items.Add(cbb_IDCuonSach.Text);
                else lv_CuonSach.Items.Add(cbb_IDCuonSach.Text + " - " + cbb_TenTacGia.Text);
            }
        }

        private void lv_CuonSach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lv_CuonSach.Items.Remove(lv_CuonSach.SelectedItem);
        }

        private void cbb_IDCuonSach_TextChanged(object sender, EventArgs e)
        {
            cbb_TenTacGia.Text = "";
            ADO.ConnectionSQL.Instance.FillCbb(cbb_TenTacGia, "SELECT TenTacGia FROM CT_TACGIA A, DAUSACH B, TACGIA C WHERE A.IDDauSach = B.IDDauSach AND A.IDTacGia = C.IDTacGia AND TenDauSach = N'" + cbb_IDCuonSach.Text + "'");
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {

        }
    }
}