
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
        private DataGridView dgv = new DataGridView();

        public frmCTTraSach()
        {
            InitializeComponent();
            this.Controls.Add(this.dgv);
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

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("IDCTPhieuTra", "ID chi tiết phiếu trả");
            dgv.Columns[0].DataPropertyName = "IDCTPhieuTra";
            dgv.Columns.Add("IDPhieuTra", "ID phiếu trả");
            dgv.Columns[1].DataPropertyName = "IDPhieuTra";
            dgv.Columns.Add("IDCuonSach", "ID cuốn sách");
            dgv.Columns[2].DataPropertyName = "IDCuonSach";
            dgv.Columns.Add("TenDauSach", "Tên cuốn sách");
            dgv.Columns[3].DataPropertyName = "TenDauSach";
            dgv.Columns.Add("IDPhieuMuon", "ID phiếu mượn");
            dgv.Columns[4].DataPropertyName = "IDPhieuMuon";
            dgv.Columns.Add("SoNgayMuon", "Số ngày mượn");
            dgv.Columns[5].DataPropertyName = "SoNgayMuon";
            dgv.Columns.Add("TienPhat", "Tiền phạt");
            dgv.Columns[6].DataPropertyName = "TienPhat";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatCTTraSach.Instance.checkCTTraSach(tb_IDCTPhieuTra.Text, cbb_IDPhieuTra.Text, cbb_IDCuonSach.Text, tb_TenTacGia.Text);
                SCRIPT.formatCTTraSach.Instance.checkNull(tb_IDCTPhieuTra, cbb_IDPhieuTra, cbb_IDCuonSach, tb_TenTacGia);
                if (tb_IDCTPhieuTra.Text != "" && cbb_IDPhieuTra.Text != "" && cbb_IDCuonSach.Text != "")
                {
                    string IDCuonSach = "";
                    for (int j = 0; j < lb.Items.Count; j++)
                    {
                        IDCuonSach = lb.Items[j].ToString().Substring(lb.Items[j].ToString().Length - 8, 6);
                        ADO.adoCTTraSach.Instance.Them(tb_IDCTPhieuTra.Text, cbb_IDPhieuTra.Text, IDCuonSach);
                    }
                    if (IDCuonSach == "") ADO.adoCTTraSach.Instance.Them(tb_IDCTPhieuTra.Text, cbb_IDPhieuTra.Text, cbb_IDCuonSach.SelectedValue.ToString());

                    this.cT_PHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUTRA);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatCTTraSach.Instance.checkCTTraSach(tb_IDCTPhieuTra.Text, cbb_IDPhieuTra.Text, cbb_IDCuonSach.Text, tb_TenTacGia.Text);
                SCRIPT.formatCTTraSach.Instance.checkNull(tb_IDCTPhieuTra, cbb_IDPhieuTra, cbb_IDCuonSach, tb_TenTacGia);

                if (tb_IDCTPhieuTra.Text != "" && cbb_IDPhieuTra.Text != "" && cbb_IDCuonSach.Text != "")
                {
                    ADO.adoCTTraSach.Instance.Sua(tb_IDCTPhieuTra.Text, cbb_IDPhieuTra.Text, cbb_IDCuonSach.SelectedValue.ToString());
                    this.cT_PHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUTRA);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_IDCTPhieuTra.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb_IDCTPhieuTra.Text != "")
                {
                    ADO.adoCTTraSach.Instance.Xoa(tb_IDCTPhieuTra.Text, dgv_Them.CurrentRow.Cells[2].Value.ToString());
                    this.cT_PHIEUTRATableAdapter.Fill(quanLyThuVienDataSet.CT_PHIEUTRA);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                this.cT_PHIEUTRATableAdapter.Fill(quanLyThuVienDataSet.CT_PHIEUTRA);
                ResetForm();
            }
            catch { }
        }

        #region Form
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgv_Them_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                tb_IDCTPhieuTra.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
                cbb_IDPhieuTra.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();

                //cbb_IDPhieuTra.TextChanged -= cbb_IDPhieuTra_TextChanged;
                string idcs = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
                cbb_IDCuonSach.Text = ADO.adoCTTraSach.Instance.AutoFill(idcs, "cbb_IDCuonSach");
                tb_TenTacGia.Text = ADO.adoCTTraSach.Instance.AutoFill(idcs, "tb_TenTacGia");
            }
            catch { }
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
            try
            {
                SCRIPT.useForm.Instance.checkID(ADO.adoCTTraSach.Instance.checkID(tb_IDCTPhieuTra.Text.Trim()), label4, tb_IDCTPhieuTra, pic_Warning, pic_Ss);
            }
            catch { }
        }        

        private void btn_ThemSach_Click(object sender, EventArgs e)
        {
            try
            {
                lb.DisplayMember = "Text";
                lb.ValueMember = "Value";
                lb.Items.Add(new { Text = cbb_IDCuonSach.Text, Value = cbb_IDCuonSach.SelectedValue.ToString() });                
            }
            catch { }
        }

        private void lb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                lb.Items.Remove(lb.SelectedItem);
            }
            catch { }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string idctpt = dgv_Them.Rows[t].Cells[0].Value.ToString();
                string idpt = dgv_Them.Rows[t].Cells[1].Value.ToString();
                string idcs = dgv_Them.Rows[t].Cells[2].Value.ToString();

                ADO.adoCTTraSach.Instance.Sua(idctpt, idpt, idcs);
                dgv_Them.DataSource = quanLyThuVienDataSet.CT_PHIEUTRA;
                this.cT_PHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUTRA);
            }
            catch { }
        }                 

        private void cbb_IDPhieuTra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbb_IDCuonSach.DataSource = null;

                if (cbb_IDPhieuTra.Text.Length == 6)
                {
                    cbb_IDCuonSach.DataSource = null;
                    ADO.adoCTTraSach.Instance.AutoCbb1(cbb_IDCuonSach, cbb_IDPhieuTra.Text);
                }
            }
            catch { }
        }

        private void cbb_IDCuonSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tb_TenTacGia.Text = ADO.adoCTTraSach.Instance.HienTG(cbb_IDCuonSach.SelectedValue.ToString());
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

                    string sql = ADO.adoCTTraSach.Instance.GetQueryFillDgv();
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