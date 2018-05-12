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
            if (rdb_IDDocGia.Checked == true)
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(SCRIPT.formatTheDocGia.Instance.TKIDDocGia(tb_IDDocGia.Text.Trim()));
                ResetForm();
            }
            else if (rdb_DiaChi.Checked == true)
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(SCRIPT.formatTheDocGia.Instance.TKDiaChiDG(tb_DiaChi.Text.Trim()));
                ResetForm();
            }
            else if(rdb_Email.Checked==true)
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(SCRIPT.formatTheDocGia.Instance.TKEmailDG(tb_Email.Text.Trim()));
                ResetForm();
            }
            else if(rdb_HoTen.Checked==true)
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(SCRIPT.formatTheDocGia.Instance.TKHoTenDG(tb_HoTen.Text.Trim()));
                ResetForm();
            }
            else if(rdb_LoaiDocGia.Checked==true)
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(SCRIPT.formatTheDocGia.Instance.TKIDLoaiDG(cbb_LoaiDocGia.Text.Trim()));
                ResetForm();
            }
            else if(rdb_NgayLapThe.Checked==true)
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(SCRIPT.formatTheDocGia.Instance.TKNgayLapThe(dtp_NgayLapThe.Text.Trim()));
                ResetForm();
            }
            else if(rdb_NgaySinh.Checked==true)
            {
                dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(SCRIPT.formatTheDocGia.Instance.TKNgaySinhDG(dtp_NgaySinh.Text.Trim()));
                ResetForm();
            }

        }

        private void btn_TKUser_Click(object sender, EventArgs e)
        {
            ResetForm();
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