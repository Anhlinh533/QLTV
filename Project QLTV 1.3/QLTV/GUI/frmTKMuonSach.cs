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
    public partial class frmTKMuonSach : DevExpress.XtraEditors.XtraForm
    {
        public frmTKMuonSach()
        {
            InitializeComponent();
        }

        private void frmTKMuonSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_PHIEUMUON' table. You can move, or remove it, as needed.
            this.cT_PHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUMUON);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUMUON' table. You can move, or remove it, as needed.
            this.pHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUMUON);

        }

        private void btn_TKCTPhieuMuonSach_Click(object sender, EventArgs e)
        {
            if(rdb_IDCTPhieuMuon.Checked==true && tb_IDCTPhieuMuonSach.Text!="")
            {
                dgv_TKCTPhieuMuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTMuonSach.Instance.TKIDCTPhieuMuon(tb_IDCTPhieuMuonSach.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDCuonSach.Checked==true && tb_IDCuonSach.Text!="")
            {
                dgv_TKCTPhieuMuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTMuonSach.Instance.TKIDCuonSach(tb_IDCuonSach.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDPhieuMuonSach.Checked==true && tb_IDPhieuMuonSach.Text!="")
            {
                dgv_TKCTPhieuMuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTMuonSach.Instance.TKIDPhieuMuon(tb_IDPhieuMuonSach.Text.Trim()));
                ResetForm();
            }

            if (rdb_IDCTPhieuMuon.Checked == true && tb_IDCTPhieuMuonSach.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID chi tiết phiếu mượn cần tìm!!");
                tb_IDCTPhieuMuonSach.Focus();
            }
            else if (rdb_IDCuonSach.Checked == true && tb_IDCuonSach.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID cuốn sách cần tìm!!");
                tb_IDCuonSach.Focus();
            }
            else if (rdb_IDPhieuMuonSach.Checked == true && tb_IDPhieuMuonSach.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID phiếu mượn cần tìm!!");
                tb_IDPhieuMuonSach.Focus();
            }

        }

        private void btn_TKPhieuMuonSach_Click(object sender, EventArgs e)
        {
            if(rdb_HanTra.Checked==true && dtp_HanTra.Text!="")
            {
                dgv_TKMuonSach.DataSource= ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoMuonSach.Instance.TKHanTra(dtp_HanTra.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDDocGia.Checked==true && tb_IDDocGia.Text!="")
            {
                dgv_TKMuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoMuonSach.Instance.TKHanTra(tb_IDDocGia.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDPhieuMuon.Checked==true && tb_IDPhieuMuon.Text!="")
            {
                dgv_TKMuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoMuonSach.Instance.TKIDPhieuMuon(tb_IDPhieuMuon.Text.Trim()));
                ResetForm();
            }
            else if(rdb_NgayMuon.Checked==true && dtp_NgayMuon.Text!="")
            {
                dgv_TKMuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoMuonSach.Instance.TKNgayMuon(dtp_NgayMuon.Text.Trim()));
                ResetForm();
            }
            if (rdb_IDDocGia.Checked == true && tb_IDDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID độc giả cần tìm!!");
                tb_IDDocGia.Focus();
            }
            else if (rdb_IDPhieuMuon.Checked == true && tb_IDPhieuMuon.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID phiếu mượn cần tìm!!");
                tb_IDPhieuMuon.Focus();

            }
            
        }
        #region Form
        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl2);
            SCRIPT.useForm.ResetAllControls(groupControl3);
            SCRIPT.useForm.ResetAllControls(groupControl4);
        }
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
        #region Check on click
        private void tb_IDPhieuMuon_Click(object sender, EventArgs e)
        {
            rdb_IDPhieuMuon.Checked = true;
        }

        private void tb_IDDocGia_Click(object sender, EventArgs e)
        {
            rdb_IDDocGia.Checked = true;
        }

        private void tb_IDCTPhieuMuonSach_Click(object sender, EventArgs e)
        {
            rdb_IDCTPhieuMuon.Checked = true;
        }

        private void tb_IDPhieuMuonSach_Click(object sender, EventArgs e)
        {
            rdb_IDPhieuMuonSach.Checked = true;
        }

        private void tb_IDCuonSach_Click(object sender, EventArgs e)
        {
            rdb_IDCuonSach.Checked = true;
        }
        #endregion
    }
}