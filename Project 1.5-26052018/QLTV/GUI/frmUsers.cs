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
    public partial class frmUsers : DevExpress.XtraEditors.XtraForm
    {
        private DataGridView dgv = new DataGridView();

        public frmUsers()
        {
            InitializeComponent();
            this.Controls.Add(this.dgv);
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_USERADMIN' table. You can move, or remove it, as needed.
            this.cT_USERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.CT_USERADMIN);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.USERADMIN' table. You can move, or remove it, as needed.
            this.uSERADMINTableAdapter.Fill(this.quanLyThuVienDataSet.USERADMIN);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
            label5.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("UserName", "User name");
            dgv.Columns[0].DataPropertyName = "UserName";
            dgv.Columns.Add("Pwd", "Password");
            dgv.Columns[1].DataPropertyName = "Pwd";
            dgv.Columns.Add("IDDocGia", "ID độc giả");
            dgv.Columns[2].DataPropertyName = "IDDocGia";
            dgv.Columns.Add("HoTenDG", "Tên độc giả");
            dgv.Columns[3].DataPropertyName = "HoTenDG";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatUsers.Instance.checkUsers(tb_UserName.Text, tb_Password.Text, cbb_IDDocGia.Text);
                SCRIPT.formatUsers.Instance.checkNull(tb_UserName, tb_Password, cbb_IDDocGia);
                if (tb_UserName.Text != "" && tb_Password.Text != "" && cbb_IDDocGia.Text != "")
                {
                    ADO.adoUsers.Instance.Them(tb_UserName.Text, tb_Password.Text, cbb_IDDocGia.Text);
                    this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatUsers.Instance.checkUsers(tb_UserName.Text, tb_Password.Text, cbb_IDDocGia.Text);
                SCRIPT.formatUsers.Instance.checkNull(tb_UserName, tb_Password, cbb_IDDocGia);
                if (tb_UserName.Text != "" && tb_Password.Text != "" && cbb_IDDocGia.Text != "")
                {
                    ADO.adoUsers.Instance.Sua(tb_UserName.Text, tb_Password.Text, cbb_IDDocGia.Text);
                    this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_UserName.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb_UserName.Text != "")
                {
                    ADO.adoUsers.Instance.Xoa(tb_UserName.Text);
                    this.uSERSTableAdapter.Fill(quanLyThuVienDataSet.USERS);
                    ResetForm();
                }
            }
            catch { }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
            ResetForm();
        }

        #region Form
        private void dgv_Them_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                tb_UserName.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
                tb_Password.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
                cbb_IDDocGia.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
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

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ADO.adoLogin.Instance.checkUserName(tb_UserName.Text.Trim()) == true)
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "UserName này đã tồn tại!!";
                    label5.Show();
                    pic_Warning.Show();
                    pic_Ss.Hide();
                }
                else
                {
                    label5.ForeColor = Color.Green;
                    label5.Text = "Username phù hợp!!";
                    label5.Show();
                    pic_Warning.Hide();
                    pic_Ss.Show();
                }
                if (tb_UserName.Text == "")
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Không được để trống ID";
                    label5.Show();
                    pic_Ss.Hide();
                    pic_Warning.Show();
                }
            }
            catch { }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string username = dgv_Them.Rows[t].Cells[0].Value.ToString();
                string password = dgv_Them.Rows[t].Cells[1].Value.ToString();
                string iddg = dgv_Them.Rows[t].Cells[2].Value.ToString();

                ADO.adoUsers.Instance.Sua(username, password, iddg);
                dgv_Them.DataSource = quanLyThuVienDataSet.USERS;
                this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
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

                    string sql = ADO.adoUsers.Instance.GetQueryFillDgv();
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