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
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
        }        

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatUsers.Instance.checkUsers(tb_UserName.Text, tb_Password.Text, cbb_IDDocGia.Text);
            SCRIPT.formatUsers.Instance.checkNull(tb_UserName, tb_Password, cbb_IDDocGia);
            if (tb_UserName.Text != "" && tb_Password.Text != "" && cbb_IDDocGia.Text != "")
            {
                //Hàm thêm

                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatUsers.Instance.checkUsers(tb_UserName.Text, tb_Password.Text, cbb_IDDocGia.Text);
            SCRIPT.formatUsers.Instance.checkNull(tb_UserName, tb_Password, cbb_IDDocGia);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //if (tb_UserName.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //if (tb_UserName.Text != "")
            //{
            //    ADO.adoUsers.Instance.Xoa(tb_UserName.Text);
            //    this.uSERSTableAdapter.Fill(quanLyThuVienDataSet.USERS);
            //    ResetForm();
            //}
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
            ResetForm();
        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {
            //if (cbb_IDDelete.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //if (cbb_IDDelete.Text != "")
            //{
            //    ADO.adoUsers.Instance.Xoa(cbb_IDDelete.Text);
            //    this.uSERSTableAdapter.Fill(quanLyThuVienDataSet.USERS);
            //    ResetForm();
            //}
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
            SCRIPT.useForm.ResetAllControls(groupControl3);
            SCRIPT.useForm.ResetAllControls(groupControl4);
        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}