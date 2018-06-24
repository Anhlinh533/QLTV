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
using QLTV.SCRIPT;
using QLTV.ADO;
using System.Data.SqlClient;

namespace QLTV.GUI
{
    public partial class frmAdmin : DevExpress.XtraEditors.XtraForm
    {
        private DataGridView dgvc = new DataGridView();
        private DataGridView dgv = new DataGridView();

        public frmAdmin()
        {
            InitializeComponent();
            this.Controls.Add(this.dgvc);
            this.Controls.Add(this.dgv);
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_USERADMIN' table. You can move, or remove it, as needed.
            this.cT_USERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.CT_USERADMIN);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.USERADMIN' table. You can move, or remove it, as needed.
            this.uSERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.USERADMIN);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.USERADMIN' table. You can move, or remove it, as needed.
            this.uSERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.USERADMIN);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_USERADMIN' table. You can move, or remove it, as needed.
            this.cT_USERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.CT_USERADMIN);

            //dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            //dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";

            this.dgvc.VirtualMode = true;
            dgvc.Columns.Add("IDAdmin", "ID Admin");
            dgvc.Columns[0].DataPropertyName = "IDAdmin";
            dgvc.Columns.Add("HoTenAdmin", "Họ tên Admin");
            dgvc.Columns[1].DataPropertyName = "HoTenAdmin";
            dgvc.Columns.Add("NgaySinhAdmin", "Ngày sinh");
            dgvc.Columns[2].DataPropertyName = "NgaySinhAdmin";
            dgvc.Columns.Add("DiaChiAdmin", "Địa chỉ");
            dgvc.Columns[3].DataPropertyName = "DiaChiAdmin";
            dgvc.Columns.Add("EmailAdmin", "Email");
            dgvc.Columns[4].DataPropertyName = "EmailAdmin";

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("UserNameAdmin", "User name admin");
            dgv.Columns[0].DataPropertyName = "UserNameAdmin";
            dgv.Columns.Add("PasswordAdmin", "Password");
            dgv.Columns[1].DataPropertyName = "PasswordAdmin";
            dgv.Columns.Add("IDAdmin", "ID admin");
            dgv.Columns[2].DataPropertyName = "IDAdmin";
            dgv.Columns.Add("HoTenAdmin", "Họ tên Admin");
            dgv.Columns[3].DataPropertyName = "HoTenAdmin";
            //pic_SsAdmin.Hide();
            //pic_SSCTAdmin.Hide();
            //pic_WarningAdmin.Hide();
            //pic_WarningCTAdmin.Hide();
            //label1.Hide();
            //label6.Hide();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatCTAdmin.Instance.checkCTAdmin(tb_IDAdmin.Text, tb_HoTen.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text);
                SCRIPT.formatCTAdmin.Instance.checkNull(tb_IDAdmin, tb_HoTen, tb_DiaChi, tb_Email);
                if (tb_UserAdmin.Text != "" && tb_PassAdmin.Text != "" && cbb_IDAdmin.Text != "")
                {
                    ADO.adoCTAdmin.Instance.Them(tb_IDAdmin.Text, tb_HoTen.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text);
                    this.cT_USERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.CT_USERADMIN);
                    //ResetForm();
                }
            }
            catch { }
        }        

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatCTAdmin.Instance.checkCTAdmin(tb_IDAdmin.Text, tb_HoTen.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text);
                SCRIPT.formatCTAdmin.Instance.checkNull(tb_IDAdmin, tb_HoTen, tb_DiaChi, tb_Email);
                if (tb_UserAdmin.Text != "" && tb_PassAdmin.Text != "" && cbb_IDAdmin.Text != "")
                {
                    ADO.adoCTAdmin.Instance.Sua(tb_IDAdmin.Text, tb_HoTen.Text, dtp_NgaySinh.Text, tb_DiaChi.Text, tb_Email.Text);
                    this.cT_USERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.CT_USERADMIN);
                    //ResetForm();
                }
            }
            catch { }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ida = dgv_CTAdmin.CurrentRow.Cells[0].Value.ToString();
                ADO.adoCTAdmin.Instance.Xoa(ida);
                dgv_CTAdmin.DataSource = quanLyThuVienDataSet.CT_USERADMIN;
            }
            catch { }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string ida = dgv_CTAdmin.Rows[t].Cells[0].Value.ToString();
                string hoten = dgv_CTAdmin.Rows[t].Cells[1].Value.ToString();
                string ngaysinh = dgv_CTAdmin.Rows[t].Cells[2].Value.ToString();
                string diachi = dgv_CTAdmin.Rows[t].Cells[3].Value.ToString();
                string email = dgv_CTAdmin.Rows[t].Cells[4].Value.ToString();

                ADO.adoCTAdmin.Instance.Sua(ida, hoten, ngaysinh, diachi, email);
                dgv_CTAdmin.DataSource = quanLyThuVienDataSet.CT_USERADMIN;
                this.cT_USERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.CT_USERADMIN);
            }
            catch { }
        }        

        private void btn_ThemAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatAdmin.Instance.checkAdmin(tb_UserAdmin.Text, tb_PassAdmin.Text, cbb_IDAdmin.Text);
                SCRIPT.formatAdmin.Instance.checkNull(tb_UserAdmin, tb_PassAdmin, cbb_IDAdmin);
                if (tb_UserAdmin.Text != "" && tb_PassAdmin.Text != "" && cbb_IDAdmin.Text != "")
                {
                    ADO.adoAdmin.Instance.Them(tb_UserAdmin.Text, tb_PassAdmin.Text, cbb_IDAdmin.Text);
                    this.uSERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.USERADMIN);
                    //ResetForm();
                }
            }
            catch { }
        }

        private void btn_SuaAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatAdmin.Instance.checkAdmin(tb_UserAdmin.Text, tb_PassAdmin.Text, cbb_IDAdmin.Text);
                SCRIPT.formatAdmin.Instance.checkNull(tb_UserAdmin, tb_PassAdmin, cbb_IDAdmin);
                if (tb_UserAdmin.Text != "" && tb_PassAdmin.Text != "" && cbb_IDAdmin.Text != "")
                {
                    ADO.adoAdmin.Instance.Sua(tb_UserAdmin.Text, tb_PassAdmin.Text, cbb_IDAdmin.Text);
                    this.uSERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.USERADMIN);
                    //ResetForm();
                }
            }
            catch { }
        }

        private void btn_XoaAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = dgv_UserAdmin.CurrentRow.Cells[0].Value.ToString();
                ADO.adoAdmin.Instance.Xoa(username);
                dgv_UserAdmin.DataSource = quanLyThuVienDataSet.USERADMIN;
            }
            catch { }
        }

        private void btn_LuuAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = dgv_UserAdmin.Rows[t].Cells[0].Value.ToString();
                string password = dgv_UserAdmin.Rows[t].Cells[1].Value.ToString();
                string ida = dgv_UserAdmin.Rows[t].Cells[2].Value.ToString();

                ADO.adoAdmin.Instance.Sua(username, password, ida);
                dgv_UserAdmin.DataSource = quanLyThuVienDataSet.USERADMIN;
                this.uSERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.USERADMIN);
            }
            catch { }
        }             

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_CTAdmin.DataSource = quanLyThuVienDataSet.CT_USERADMIN;
                dgv_UserAdmin.DataSource = quanLyThuVienDataSet.USERADMIN;
                SCRIPT.useForm.ResetAllControls(groupControl1);
                SCRIPT.useForm.ResetAllControls(groupControl2);
                SCRIPT.useForm.ResetAllControls(groupControl3);
                SCRIPT.useForm.ResetAllControls(groupControl4);
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

                    string sql = ADO.adoCTAdmin.Instance.GetQueryFillDgv();
                    ADO.adoAdmin.Instance.XuatExcel(ref dgvc, sql, DuongDan);
                }
            }
            catch { }        
        }

        private void btn_XuatUserAdmin_Click(object sender, EventArgs e)
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

                    string sql = ADO.adoAdmin.Instance.GetQueryFillDgv();
                    ADO.adoAdmin.Instance.XuatExcel(ref dgv, sql, DuongDan);
                }
            }
            catch { }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_IDAdmin_TextChanged(object sender, EventArgs e)
        {
            //if (ADO.adoAdmin.Instance.checkAdmin(tb_IDAdmin.Text.Trim()) == true)
            //{
            //    label1.ForeColor = Color.Red;
            //    label1.Text = "UserName này đã tồn tại!!";
            //    label1.Show();
            //    pic_WarningAdmin.Show();
            //    pic_SsAdmin.Hide();
            //}
            //else
            //{
            //    label1.ForeColor = Color.Green;
            //    label1.Text = "Username phù hợp!!";
            //    label1.Show();
            //    pic_WarningAdmin.Hide();
            //    pic_SsAdmin.Show();
            //}
            //if (tb_IDAdmin.Text == "")
            //{
            //    label1.ForeColor = Color.Red;
            //    label1.Text = "Không được để trống ID";
            //    label1.Show();
            //    pic_SsAdmin.Hide();
            //    pic_WarningAdmin.Show();
            //}

        }
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgv_CTAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                tb_IDAdmin.Text = dgv_CTAdmin.Rows[numrow].Cells[0].Value.ToString();
                tb_HoTen.Text = dgv_CTAdmin.Rows[numrow].Cells[1].Value.ToString();
                dtp_NgaySinh.Text = dgv_CTAdmin.Rows[numrow].Cells[2].Value.ToString();
                tb_DiaChi.Text = dgv_CTAdmin.Rows[numrow].Cells[3].Value.ToString();
                tb_Email.Text = dgv_CTAdmin.Rows[numrow].Cells[4].Value.ToString();
            }
            catch { }
        }

        private void dgv_UserAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                tb_UserAdmin.Text = dgv_UserAdmin.Rows[numrow].Cells[0].Value.ToString();
                tb_PassAdmin.Text = dgv_UserAdmin.Rows[numrow].Cells[1].Value.ToString();
                cbb_IDAdmin.Text = dgv_UserAdmin.Rows[numrow].Cells[2].Value.ToString();
            }
            catch { }
        }

        int t = 0;

        private void dgv_CTAdmin_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_CTAdmin.CurrentCell != null)
                    t = dgv_CTAdmin.CurrentCell.RowIndex;
            }
            catch { }
        }

        private void dgv_UserAdmin_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_UserAdmin.CurrentCell != null)
                    t = dgv_UserAdmin.CurrentCell.RowIndex;
            }
            catch { }
        }
    }
}