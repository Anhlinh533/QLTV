﻿using System;
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

        private string UserName;
        private string Password;

        public frmTKDocGia(string userName, string password) : this()
        {
            UserName = userName;
            Password = password;
        }

        private void frmTKDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LOAIDOCGIA' table. You can move, or remove it, as needed.
            this.lOAIDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.LOAIDOCGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
            if (ADO.adoLogin.Instance.checkDocGia(UserName, Password) == true)
            {
                //btn_Luu.Enabled = false;
                //btn_Sua.Enabled = false;
                //toolStripLabel1.Enabled = false;
                //toolStripLabel5.Enabled = false;
                //toolStripLabel2.Enabled = false;
                //btn_Xoa.Enabled = false;
                //toolStripLabel6.Enabled = false;
                //toolStripLabel7.Enabled = false;
                //toolStripLabel8.Enabled = false;
                //toolStripButton1.Enabled = false;
                //toolStripButton2.Enabled = false;
                //toolStripButton3.Enabled = false;
            }

            //dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            //dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            //dtp_NgayLapThe.Format = DateTimePickerFormat.Custom;
            //dtp_NgayLapThe.CustomFormat = "dd/MM/yyyy";
        }

        private void btn_TKDocGia_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_IDDocGia.Checked == true && tb_IDDocGia.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKIDDocGia(tb_IDDocGia.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_DiaChi.Checked == true && tb_DiaChi.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKDiaChiDG(tb_DiaChi.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_Email.Checked == true && tb_Email.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKEmailDG(tb_Email.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_HoTen.Checked == true && tb_HoTen.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKHoTenDG(tb_HoTen.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_LoaiDocGia.Checked == true && cbb_LoaiDocGia.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKIDLoaiDG(cbb_LoaiDocGia.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_NgayLapThe.Checked == true && dtp_NgayLapThe.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKNgayLapThe(dtp_NgayLapThe.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_NgaySinh.Checked == true && dtp_NgaySinh.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKNgaySinhDG(dtp_NgaySinh.Text.Trim()));
                    //ResetForm();
                }
                else
                if (rdb_IDDocGia.Checked == true && tb_IDDocGia.Text == "")
                {
                    MessageBox.Show("Vui lòng điền ID độc giả cần tìm!!");
                    tb_IDDocGia.Focus();
                }
                else if (rdb_DiaChi.Checked == true && tb_DiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền địa chỉ cần tìm!!");
                    tb_DiaChi.Focus();
                }
                else if (rdb_Email.Checked == true && tb_Email.Text == "")
                {
                    MessageBox.Show("Vui lòng điền email cần tìm!!");
                    tb_Email.Focus();
                }
                else if (rdb_HoTen.Checked == true && tb_HoTen.Text == "")
                {
                    MessageBox.Show("Vui lòng điền tên độc giả cần tìm!!");
                    tb_HoTen.Focus();
                }
                else if (rdb_LoaiDocGia.Checked == true && cbb_LoaiDocGia.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn loại độc giả cần tìm!!");
                }
            }
            catch { }
        }

        private void btn_TKUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_User.Checked == true && tb_TenUser.Text != "")
                {
                    dgv_TKUser.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoUsers.Instance.TKUser(tb_TenUser.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_UserIDDocGia.Checked == true && tb_IDUser.Text != "")
                {
                    dgv_TKUser.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoUsers.Instance.TKUserIDDocGia(tb_IDUser.Text.Trim()));
                    //ResetForm();
                }
                else
                if (rdb_User.Checked == true && tb_TenUser.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Username cần tìm!!");
                    tb_TenUser.Focus();
                }
                else if (rdb_UserIDDocGia.Checked == true && tb_IDUser.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập ID độc giả cần tìm!!");
                    tb_IDUser.Focus();
                }
            }
            catch { }
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
            SCRIPT.useForm.ResetAllControls(groupControl3);

        }

        private void chu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }
        #endregion

        private void btn_ResetDG_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_TKDocGia.DataSource = quanLyThuVienDataSet.THEDOCGIA;
            }
            catch { }
        }

        #region Checked on click
        private void tb_IDDocGia_Click(object sender, EventArgs e)
        {
            rdb_IDDocGia.Checked = true;
        }

        private void tb_HoTen_Click(object sender, EventArgs e)
        {
            rdb_HoTen.Checked = true;
        }

        private void tb_DiaChi_Click(object sender, EventArgs e)
        {
            rdb_DiaChi.Checked = true;
        }

        private void tb_Email_Click(object sender, EventArgs e)
        {
            rdb_Email.Checked = true;
        }

        private void cbb_LoaiDocGia_Click(object sender, EventArgs e)
        {
            rdb_LoaiDocGia.Checked = true;
        }

        private void tb_TenUser_Click(object sender, EventArgs e)
        {
            rdb_User.Checked = true;
        }

        private void tb_IDUser_Click(object sender, EventArgs e)
        {
            rdb_UserIDDocGia.Checked = true;
        }
        #endregion

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string iddg = dgv_TKDocGia.Rows[t].Cells[0].Value.ToString();
                string hoten = dgv_TKDocGia.Rows[t].Cells[1].Value.ToString();
                string ngaysinh = dgv_TKDocGia.Rows[t].Cells[2].Value.ToString();
                string diachi = dgv_TKDocGia.Rows[t].Cells[3].Value.ToString();
                string email = dgv_TKDocGia.Rows[t].Cells[4].Value.ToString();
                string loaidg = dgv_TKDocGia.Rows[t].Cells[5].Value.ToString();
                string ngaylapthe = dgv_TKDocGia.Rows[t].Cells[6].Value.ToString();

                ADO.adoTheDocGia.Instance.Sua(iddg, hoten, ngaysinh, diachi, email, loaidg, ngaylapthe);

                dgv_TKDocGia.DataSource = quanLyThuVienDataSet.THEDOCGIA;
                this.tHEDOCGIATableAdapter.Fill(quanLyThuVienDataSet.THEDOCGIA);
                if (rdb_IDDocGia.Checked == true && tb_IDDocGia.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKIDDocGia(tb_IDDocGia.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_DiaChi.Checked == true && tb_DiaChi.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKDiaChiDG(tb_DiaChi.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_Email.Checked == true && tb_Email.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKEmailDG(tb_Email.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_HoTen.Checked == true && tb_HoTen.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKHoTenDG(tb_HoTen.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_LoaiDocGia.Checked == true && cbb_LoaiDocGia.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKIDLoaiDG(cbb_LoaiDocGia.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_NgayLapThe.Checked == true && dtp_NgayLapThe.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKNgayLapThe(dtp_NgayLapThe.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_NgaySinh.Checked == true && dtp_NgaySinh.Text != "")
                {
                    dgv_TKDocGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTheDocGia.Instance.TKNgaySinhDG(dtp_NgaySinh.Text.Trim()));
                    //ResetForm();
                }
            }
            catch { }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string iddg = dgv_TKDocGia.CurrentRow.Cells[0].Value.ToString();
                ADO.adoTheDocGia.Instance.Xoa(iddg);
                dgv_TKDocGia.DataSource = quanLyThuVienDataSet.THEDOCGIA;
            }
            catch { }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_TKDocGia.DataSource = quanLyThuVienDataSet.THEDOCGIA;
                dgv_TKUser.DataSource = quanLyThuVienDataSet.USERS;
                this.tHEDOCGIATableAdapter.Fill(quanLyThuVienDataSet.THEDOCGIA);
                this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
            }
            catch { }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int t = 0;

        private void dgv_TKDocGia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_TKDocGia.CurrentCell != null)
                    t = dgv_TKDocGia.CurrentCell.RowIndex;
            }
            catch { }
        }

        private void dgv_TKUser_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_TKUser.CurrentCell != null)
                    t = dgv_TKUser.CurrentCell.RowIndex;
            }
            catch { }
        }
    }
}