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
        private string UserName;
        private string Password;
        public frmTKTraSach(string userName, string password) : this()
        {
            UserName = userName;
            Password = password;
        }
        private void frmTKTraSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_PHIEUTRA' table. You can move, or remove it, as needed.
            this.cT_PHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUTRA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUTRA' table. You can move, or remove it, as needed.
            this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);
            if (ADO.adoLogin.Instance.checkDocGia(UserName, Password) == true)
            {
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = false;
                toolStripLabel1.Enabled = false;
                toolStripLabel5.Enabled = false;
                toolStripLabel2.Enabled = false;
                btn_Xoa.Enabled = false;
                toolStripLabel6.Enabled = false;
                toolStripLabel7.Enabled = false;
                toolStripLabel8.Enabled = false;
                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
            }
        }

        private void btn_TKCTPhieuTraSach_Click(object sender, EventArgs e)
        {
            if(rdb_IDCTPhieuTra.Checked==true && tb_IDCTPhieuTra.Text!="")
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

            if (rdb_IDCTPhieuTra.Checked == true && tb_IDCTPhieuTra.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID chi tiết phiếu trả cần tìm!!");
                tb_IDCTPhieuTra.Focus();
            }
            else if (rdb_IDPhieuMuon.Checked == true && tb_IDCTPhieuMuon.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID chi tiết phiếu mượn cần tìm!!");
                tb_IDCTPhieuMuon.Focus();
            }
            else if (rdb_IDPhieuTraCT.Checked == true && tb_IDPhieuTraCT.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID phiếu trả cần tìm!!");
                tb_IDPhieuTraCT.Focus();
            }
            else if (rdb_SoNgayMuon.Checked == true && tb_SoNgayMuon.Text == "")
            {
                MessageBox.Show("Vui lòng điền số ngày mượn cần tìm!!");
                tb_SoNgayMuon.Focus();
            }
            else if (rdb_TienPhat.Checked == true && tb_TienPhat.Text == "")
            {
                MessageBox.Show("Vui lòng điền tiền phạt cần tìm!!");
                tb_TienPhat.Focus();
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

            if (rdb_IDDocGia.Checked == true && tb_IDDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID độc giả cần tìm!!");
                tb_IDDocGia.Focus();
            }
            else if (rdb_IDPhieuTra.Checked == true && tb_IDPhieuTra.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID phiếu trả cần tìm!!");
                tb_IDPhieuTra.Focus();
            }
            else if (rdb_TienNoKiNay.Checked == true && tb_TienNoKiNay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tiền nợ cần tìm!!");
                tb_TienNoKiNay.Focus();
            }
            else if (rdb_SoTienTra.Checked == true && tb_SoTienTra.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền trả cần tìm!!");
                tb_SoTienTra.Focus();
            }
            else if (rdb_TienPhatKiNay.Checked == true && tb_TienPhatKiNay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tiền phạt cần tìm!!");
                tb_TienPhatKiNay.Focus();

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
        #region check on click

        private void tb_IDPhieuTra_Click(object sender, EventArgs e)
        {
            rdb_IDPhieuTra.Checked = true;
        }

        private void tb_IDDocGia_Click(object sender, EventArgs e)
        {
            rdb_IDDocGia.Checked = true;
        }

        private void tb_TienPhatKiNay_Click(object sender, EventArgs e)
        {
            rdb_TienPhatKiNay.Checked = true;
        }

        private void tb_SoTienTra_Click(object sender, EventArgs e)
        {
            rdb_SoTienTra.Checked = true;
        }

        private void tb_TienNoKiNay_Click(object sender, EventArgs e)
        {
            rdb_TienNoKiNay.Checked = true;
        }

        private void tb_IDCTPhieuTra_Click(object sender, EventArgs e)
        {
            rdb_IDCTPhieuTra.Checked = true;
        }

        private void tb_IDPhieuTraCT_Click(object sender, EventArgs e)
        {
            rdb_IDPhieuTraCT.Checked = true;
        }

        private void tb_IDCTPhieuMuon_Click(object sender, EventArgs e)
        {
            rdb_IDPhieuMuon.Checked = true;
        }

        private void tb_SoNgayMuon_Click(object sender, EventArgs e)
        {
            rdb_SoNgayMuon.Checked = true;
        }

        private void tb_TienPhat_Click(object sender, EventArgs e)
        {
            rdb_TienPhat.Checked = true;
        }
        #endregion
    }

}