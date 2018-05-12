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
    public partial class frmTKDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTKDocGia()
        {
            InitializeComponent();
        }

        private void frmTKDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LOAIDOCGIA' table. You can move, or remove it, as needed.
            this.lOAIDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.LOAIDOCGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);

        }

        private void btn_TKDocGia_Click(object sender, EventArgs e)
        {
            if (rdb_IDDocGia.Checked == true && tb_IDDocGia.Text!="")
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKIDDocGia(tb_IDDocGia.Text.Trim()));
                ResetForm();
            }
            else if (rdb_DiaChi.Checked == true && tb_DiaChi.Text!="")
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKDiaChiDG(tb_DiaChi.Text.Trim()));
                ResetForm();
            }
            else if(rdb_Email.Checked==true && tb_Email.Text!="")
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKEmailDG(tb_Email.Text.Trim()));
                ResetForm();
            }
            else if(rdb_HoTen.Checked==true && tb_HoTen.Text!="")
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKHoTenDG(tb_HoTen.Text.Trim()));
                ResetForm();
            }
            else if(rdb_LoaiDocGia.Checked==true && cbb_LoaiDocGia.Text!="")
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKIDLoaiDG(cbb_LoaiDocGia.Text.Trim()));
                ResetForm();
            }
            else if(rdb_NgayLapThe.Checked==true && dtp_NgayLapThe.Text!="")
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKNgayLapThe(dtp_NgayLapThe.Text.Trim()));
                ResetForm();
            }
            else if(rdb_NgaySinh.Checked==true && dtp_NgaySinh.Text!="")
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKNgaySinhDG(dtp_NgaySinh.Text.Trim()));
                ResetForm();
            }

        }

        private void btn_TKUser_Click(object sender, EventArgs e)
        {
            if (rdb_User.Checked == true && tb_TenUser.Text!="")
            {
                dgv_TKUser.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoUsers.Instance.TKUser(tb_TenUser.Text.Trim()));
                ResetForm();
            }
            else if(rdb_UserIDDocGia.Checked==true && tb_IDUser.Text!="")
            {
                dgv_TKUser.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoUsers.Instance.TKUser(tb_IDUser.Text.Trim()));
                ResetForm();
            }
        }

        #region Form
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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