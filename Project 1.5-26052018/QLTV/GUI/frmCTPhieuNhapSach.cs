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
        public frmCTPhieuNhapSach()
        {
            InitializeComponent();
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
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTPhieuNhapSach.Instance.checkCTPhieuNhapSach(tb_IDCTPhieuNhap.Text, cbb_IDPhieuNhap.Text, cbb_IDSach.Text, tb_SoLuong.Text, tb_DonGia.Text);
            SCRIPT.formatCTPhieuNhapSach.Instance.checkNull(tb_IDCTPhieuNhap, cbb_IDPhieuNhap, cbb_IDSach, tb_SoLuong, tb_DonGia);
            if (tb_DonGia.Text != "" && tb_IDCTPhieuNhap.Text != "" && tb_SoLuong.Text != "" && cbb_IDPhieuNhap.Text != "" && cbb_IDSach.Text != "")
            {
                ADO.adoCTPhieuNhapSach.Instance.Them(tb_IDCTPhieuNhap.Text, cbb_IDPhieuNhap.Text, cbb_IDSach.Text, cbb_TacGia.Text,cbb_NamXB.Text, tb_SoLuong.Text, tb_DonGia.Text);
                this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTPhieuNhapSach.Instance.checkCTPhieuNhapSach(tb_IDCTPhieuNhap.Text, cbb_IDPhieuNhap.Text, cbb_IDSach.Text, tb_SoLuong.Text, tb_DonGia.Text);
            SCRIPT.formatCTPhieuNhapSach.Instance.checkNull(tb_IDCTPhieuNhap, cbb_IDPhieuNhap, cbb_IDSach, tb_SoLuong, tb_DonGia);

            if (tb_DonGia.Text != "" && tb_IDCTPhieuNhap.Text != "" && tb_SoLuong.Text != "" && cbb_IDPhieuNhap.Text != "" && cbb_IDSach.Text != "")
            {
                ADO.adoCTPhieuNhapSach.Instance.Sua(tb_IDCTPhieuNhap.Text, cbb_IDPhieuNhap.Text, cbb_IDSach.Text, tb_SoLuong.Text, tb_DonGia.Text);
                this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDCTPhieuNhap.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDCTPhieuNhap.Text != "")
            {
                ADO.adoCTPhieuNhapSach.Instance.Xoa(tb_IDCTPhieuNhap.Text);
                this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.cT_PHIEUNHAPSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUNHAPSACH);
            ResetForm();
        }


        #region Form
        private void dgv_Them_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tb_IDCTPhieuNhap.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            cbb_IDPhieuNhap.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
            cbb_IDSach.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
            tb_SoLuong.Text = dgv_Them.Rows[numrow].Cells[3].Value.ToString();
            tb_DonGia.Text = dgv_Them.Rows[numrow].Cells[4].Value.ToString();
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
            SCRIPT.useForm.Instance.checkID(ADO.adoCTPhieuNhapSach.Instance.checkID(tb_IDCTPhieuNhap.Text.Trim()), label6, tb_IDCTPhieuNhap, pic_Warning, pic_Ss);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string idctpn = dgv_Them.CurrentRow.Cells[0].Value.ToString();
            string idpn = dgv_Them.CurrentRow.Cells[1].Value.ToString();
            string ids = dgv_Them.CurrentRow.Cells[2].Value.ToString();
            string soluong = dgv_Them.CurrentRow.Cells[3].Value.ToString();
            string dongia = dgv_Them.CurrentRow.Cells[4].Value.ToString();

            ADO.adoCTPhieuNhapSach.Instance.Sua(idctpn, idpn, ids, soluong, dongia);
            dgv_Them.DataSource = quanLyThuVienDataSet.CT_PHIEUNHAPSACH;
        }

        private void cbb_IDSach_TextChanged(object sender, EventArgs e)
        {
            cbb_TacGia.Text = "";
            cbb_NhaXB.Text = "";
            cbb_NamXB.Text = "";
            ADO.ConnectionSQL.Instance.FillCbb(cbb_TacGia, "SELECT TenTacGia FROM TACGIA A, CT_TACGIA B, DAUSACH C WHERE A.IDTacGia = B.IDTacGia AND B.IDDauSach = C.IDDauSach AND C.TenDauSach = N'" + cbb_IDSach.Text + "'");
        }

        private void cbb_TacGia_SelectedIndexChanged(object sender, EventArgs e)
        {   
            string IDDauSach = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDDauSach FROM DAUSACH WHERE TenDauSach = N'" + cbb_IDSach.Text + "'");
            string IDCTTacGia = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDCTTacGia FROM CT_TACGIA A, TACGIA B WHERE A.IDTacGia = B.IDTacGia AND A.IDDauSach = '" + IDDauSach + "'AND B.TenTacGia = N'" + cbb_TacGia.Text + "'");

            cbb_NhaXB.Text = "";
            cbb_NamXB.Text = "";
            ADO.ConnectionSQL.Instance.FillCbb(cbb_NhaXB, "SELECT NhaXB FROM SACH WHERE IDDauSach = N'" + IDDauSach + "' AND IDCTTacGia = '" + IDCTTacGia + "'");
            //ADO.ConnectionSQL.Instance.FillCbb(cbb_NamXB, "SELECT NamXB FROM SACH A, DAUSACH B, TACGIA C, CT_TACGIA D WHERE A.IDDauSach = B.IDDauSach AND C.IDTacGia = D.IDTacGia AND A.IDDauSach = D.IDDauSach AND B.TenDauSach = N'" + cbb_IDSach.Text + "' AND C.TenTacGia = N'" + cbb_TacGia.Text + "'");
            
        }

        private void cbb_NhaXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IDDauSach = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDDauSach FROM DAUSACH WHERE TenDauSach = N'" + cbb_IDSach.Text + "'");
            string IDCTTacGia = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDCTTacGia FROM CT_TACGIA A, TACGIA B WHERE A.IDTacGia = B.IDTacGia AND A.IDDauSach = '" + IDDauSach + "'AND B.TenTacGia = N'" + cbb_TacGia.Text + "'");

            cbb_NamXB.Text = "";
            ADO.ConnectionSQL.Instance.FillCbb(cbb_NamXB, "SELECT NamXB FROM SACH WHERE IDDauSach = N'" + IDDauSach + "' AND IDCTTacGia = '" + IDCTTacGia + "' AND NhaXB = N'" + cbb_NhaXB.Text + "'");
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {

        }
    }
}