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
    public partial class frmCTPhieuNhapSach : DevExpress.XtraEditors.XtraForm
    {
        private DataGridView dgv = new DataGridView();

        public frmCTPhieuNhapSach()
        {
            InitializeComponent();
            this.Controls.Add(this.dgv);
        }

        private void frmCTPhieuNhapSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUNHAPSACH' table. You can move, or remove it, as needed.
            this.pHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUNHAPSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_PHIEUNHAPSACH' table. You can move, or remove it, as needed.
            this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);
            label6.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();
            ADO.ConnectionSQL.autoSach(cbb_IDPhieuNhap, "select IDPhieuNhap from PHIEUNHAPSACH");//idphieunhap
            ADO.ConnectionSQL.autoSach(cbb_IDSach, "Select TenDauSach from DAUSACH");//idsach

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("IDCTPhieuMuon", "ID chi tiết phiếu nhập");
            dgv.Columns[0].DataPropertyName = "IDCTPhieuNhap";
            dgv.Columns.Add("IDPhieuMuon", "ID phiếu nhập");
            dgv.Columns[1].DataPropertyName = "IDPhieuNhap";
            dgv.Columns.Add("IDSach", "ID sách");
            dgv.Columns[2].DataPropertyName = "IDSach";
            dgv.Columns.Add("TenDauSach", "Tên cuốn sách");
            dgv.Columns[3].DataPropertyName = "TenDauSach";
            dgv.Columns.Add("SoLuong", "Số lượng");
            dgv.Columns[4].DataPropertyName = "SoLuong";
            dgv.Columns.Add("DonGia", "Đơn giá");
            dgv.Columns[5].DataPropertyName = "DonGia";
            dgv.Columns.Add("ThanhTien", "Thành tiền");
            dgv.Columns[6].DataPropertyName = "ThanhTien";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatCTPhieuNhapSach.Instance.checkCTPhieuNhapSach(tb_IDCTPhieuNhap.Text, cbb_IDPhieuNhap.Text, cbb_IDSach.Text, tb_SoLuong.Text, tb_DonGia.Text);
                SCRIPT.formatCTPhieuNhapSach.Instance.checkNull(tb_IDCTPhieuNhap, cbb_IDPhieuNhap, cbb_IDSach, tb_SoLuong, tb_DonGia);
                if (tb_DonGia.Text != "" && tb_IDCTPhieuNhap.Text != "" && tb_SoLuong.Text != "" && cbb_IDPhieuNhap.Text != "" && cbb_IDSach.Text != "")
                {
                    ADO.adoCTPhieuNhapSach.Instance.Them(tb_IDCTPhieuNhap.Text, cbb_IDPhieuNhap.Text, cbb_IDSach.Text, cbb_TacGia.Text, cbb_NamXB.Text, tb_SoLuong.Text, tb_DonGia.Text);
                    this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);
                }

            }
            catch { }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
           try
            {
                SCRIPT.formatCTPhieuNhapSach.Instance.checkCTPhieuNhapSach(tb_IDCTPhieuNhap.Text, cbb_IDPhieuNhap.Text, cbb_IDSach.Text, tb_SoLuong.Text, tb_DonGia.Text);
                SCRIPT.formatCTPhieuNhapSach.Instance.checkNull(tb_IDCTPhieuNhap, cbb_IDPhieuNhap, cbb_IDSach, tb_SoLuong, tb_DonGia);

                if (tb_DonGia.Text != "" && tb_IDCTPhieuNhap.Text != "" && tb_SoLuong.Text != "" && cbb_IDPhieuNhap.Text != "" && cbb_IDSach.Text != "")
                {
                    ADO.adoCTPhieuNhapSach.Instance.Sua(tb_IDCTPhieuNhap.Text, cbb_IDPhieuNhap.Text, cbb_IDSach.Text, tb_SoLuong.Text, tb_DonGia.Text);
                    this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);

                }
            }
            catch { }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_IDCTPhieuNhap.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb_IDCTPhieuNhap.Text != "")
                {
                    ADO.adoCTPhieuNhapSach.Instance.Xoa(tb_IDCTPhieuNhap.Text);
                    this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);
                ResetForm();
            }
            catch { }
        }


        #region Form
        private void dgv_Them_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                tb_IDCTPhieuNhap.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
                cbb_IDPhieuNhap.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
                tb_SoLuong.Text = dgv_Them.Rows[numrow].Cells[3].Value.ToString();
                tb_DonGia.Text = dgv_Them.Rows[numrow].Cells[4].Value.ToString();

                string ids = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
                cbb_IDSach.Text = ADO.adoCTPhieuNhapSach.Instance.AutoFill(ids, "cbb_IDSach");
                cbb_TacGia.Text = ADO.adoCTPhieuNhapSach.Instance.AutoFill(ids, "cbb_TacGia");
                cbb_NhaXB.Text = ADO.adoCTPhieuNhapSach.Instance.AutoFill(ids, "cbb_NhaXB");
                cbb_NamXB.Text = ADO.adoCTPhieuNhapSach.Instance.AutoFill(ids, "cbb_NamXB");
            }
            catch { }
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

        private void tb_IDCTPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.useForm.Instance.checkID(ADO.adoCTPhieuNhapSach.Instance.checkID(tb_IDCTPhieuNhap.Text.Trim()), label6, tb_IDCTPhieuNhap, pic_Warning, pic_Ss);
            }
            catch { }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string idctpn = dgv_Them.Rows[t].Cells[0].Value.ToString();
                string idpn = dgv_Them.Rows[t].Cells[1].Value.ToString();
                string ids = dgv_Them.Rows[t].Cells[2].Value.ToString();
                string soluong = dgv_Them.Rows[t].Cells[3].Value.ToString();
                string dongia = dgv_Them.Rows[t].Cells[4].Value.ToString();

                ADO.adoCTPhieuNhapSach.Instance.Sua(idctpn, idpn, ids, soluong, dongia);
                dgv_Them.DataSource = quanLyThuVienDataSet.CT_PHIEUNHAPSACH;
                this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);
            }
            catch { }
        }

        private void cbb_IDSach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbb_TacGia.Text = "";
                cbb_NhaXB.Text = "";
                cbb_NamXB.Text = "";
                ADO.adoCTPhieuNhapSach.Instance.AutoCbb(cbb_TacGia, cbb_IDSach.Text, null, null, "cbb_IDSach");
            }
            catch { }
        }

        private void cbb_TacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbb_NhaXB.Text = "";
                cbb_NamXB.Text = "";
                ADO.adoCTPhieuNhapSach.Instance.AutoCbb(cbb_NhaXB, null, cbb_IDSach.Text, cbb_TacGia.Text, "cbb_TacGia");
                //ADO.ConnectionSQL.Instance.FillCbb(cbb_NamXB, "SELECT NamXB FROM SACH A, DAUSACH B, TACGIA C, CT_TACGIA D WHERE A.IDDauSach = B.IDDauSach AND C.IDTacGia = D.IDTacGia AND A.IDDauSach = D.IDDauSach AND B.TenDauSach = N'" + cbb_IDSach.Text + "' AND C.TenTacGia = N'" + cbb_TacGia.Text + "'");
            }
            catch { }
        }

        private void cbb_NhaXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbb_NamXB.Text = "";
                ADO.adoCTPhieuNhapSach.Instance.AutoCbb(cbb_NamXB, cbb_NhaXB.Text, cbb_IDSach.Text, cbb_TacGia.Text, "cbb_NhaXB");
            }
            catch { }
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    sfd.Title = "Save an Excel File";
                    sfd.ShowDialog();

                    string DuongDan;
                    DuongDan = sfd.FileName;

                    string sql = ADO.adoCTPhieuNhapSach.Instance.GetQueryFillDgv();
                    ADO.adoAdmin.Instance.XuatExcel(ref dgv, sql, DuongDan);
                }
            }
            catch { }
        }

        int t = 0;

        private void dgv_Them_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_Them.CurrentCell != null)
                    t = dgv_Them.CurrentCell.RowIndex;
            }
            catch { }
        }
    }
}