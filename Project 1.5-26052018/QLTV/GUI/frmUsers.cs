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
        public frmUsers()
        {
            InitializeComponent();
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
        }

        private void btn_Them_Click(object sender, EventArgs e)
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

        private void btn_Sua_Click(object sender, EventArgs e)
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_UserName.Text != "")
            {
                ADO.adoUsers.Instance.Xoa(tb_UserName.Text);
                this.uSERSTableAdapter.Fill(quanLyThuVienDataSet.USERS);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
            ResetForm();
        }


        #region Form
        private void dgv_Them_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tb_UserName.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            tb_Password.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
            cbb_IDDocGia.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
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

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string username = dgv_Them.CurrentRow.Cells[0].Value.ToString();
            string password = dgv_Them.CurrentRow.Cells[1].Value.ToString();
            string iddg = dgv_Them.CurrentRow.Cells[2].Value.ToString();

            ADO.adoUsers.Instance.Sua(username, password, iddg);
            dgv_Them.DataSource = quanLyThuVienDataSet.USERS;
        }
    }
}