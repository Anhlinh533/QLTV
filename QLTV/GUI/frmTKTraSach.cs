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
    public partial class frmTKTraSach : DevExpress.XtraEditors.XtraForm
    {
        public frmTKTraSach()
        {
            InitializeComponent();
        }

        private void frmTKTraSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_PHIEUTRA' table. You can move, or remove it, as needed.
            this.cT_PHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUTRA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUTRA' table. You can move, or remove it, as needed.
            this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);

        }

        private void btn_TKCTPhieuTraSach_Click(object sender, EventArgs e)
        {
            if(rdb_CuonSach.Checked==true && tb_CuonSach.Text!="")
            {
                dgv_TKCTPhieuTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTraSach.Instance.TKIDCuonSach(tb_CuonSach.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDCTPhieuTra.Checked==true && tb_IDCTPhieuTra.Text!="")
            {
                dgv_TKCTPhieuTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTraSach.Instance.TKIDCTPhieuTra(tb_IDCTPhieuTra.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDPhieuMuon.Checked==true && tb_IDCTPhieuMuon.Text!="")
            {
                dgv_TKCTPhieuTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTraSach.Instance.TKIDCTPhieuMuon(tb_IDCTPhieuMuon.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDPhieuTraCT.Checked==true && tb_IDPhieuTraCT.Text!="")
            {
                dgv_TKCTPhieuTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTraSach.Instance.TKIDPhieuTra(tb_IDPhieuTraCT.Text.Trim()));
                ResetForm();
            }
            else if(rdb_SoNgayMuon.Checked==true && tb_SoNgayMuon.Text!="")
            {
                dgv_TKCTPhieuTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTraSach.Instance.TKSoNgayMuon(tb_SoNgayMuon.Text.Trim()));
                ResetForm();
            }
            else if(rdb_TienPhat.Checked==true && tb_TienPhat.Text!="")
            {
                dgv_TKCTPhieuTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTraSach.Instance.TKTienPhat(tb_TienPhat.Text.Trim()));
                ResetForm();
            }
        }

        private void btn_TKPhieuTraSach_Click(object sender, EventArgs e)
        {
            if(rdb_IDDocGia.Checked==true && tb_IDDocGia.Text!="")
            {
                dgv_TKTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTraSach.Instance.TKIDDocGia(tb_IDDocGia.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDPhieuTra.Checked==true && tb_IDPhieuTra.Text!="")
            {
                dgv_TKTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTraSach.Instance.TKIDPhieuTra(tb_IDPhieuTra.Text.Trim()));
                ResetForm();
            }
            else if(rdb_NgayTra.Checked==true && dtp_NgayTra.Text!="")
            {
                dgv_TKTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTraSach.Instance.TKNgayTra(dtp_NgayTra.Text.Trim()));
                ResetForm();
            }
            else if(rdb_TienNoKiNay.Checked==true && tb_TienNoKiNay.Text!="")
            {
                dgv_TKTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTraSach.Instance.TKTienNoKyNay(tb_TienNoKiNay.Text.Trim()));
                ResetForm();
            }
            else if(rdb_SoTienTra.Checked==true && tb_SoTienTra.Text!="")
            {
                dgv_TKTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTraSach.Instance.TKSoTienTra(tb_SoTienTra.Text.Trim()));
                ResetForm();
            }
            else if(rdb_TienPhatKiNay.Checked==true && tb_TienPhatKiNay.Text!="")
            {
                dgv_TKTraSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTraSach.Instance.TKTienPhatKyNay(tb_TienPhatKiNay.Text.Trim()));
                ResetForm();
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
        #endregion
    }
}