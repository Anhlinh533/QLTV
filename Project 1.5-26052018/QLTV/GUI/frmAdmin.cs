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
    public partial class frmAdmin : DevExpress.XtraEditors.XtraForm
    {
        public frmAdmin()
        {
            InitializeComponent();
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
        }

        private void btn_ThemAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string ida = dgv_CTAdmin.CurrentRow.Cells[0].Value.ToString();
            string hoten = dgv_CTAdmin.CurrentRow.Cells[1].Value.ToString();
            string ngaysinh = dgv_CTAdmin.CurrentRow.Cells[2].Value.ToString();
            string diachi = dgv_CTAdmin.CurrentRow.Cells[3].Value.ToString();
            string email = dgv_CTAdmin.CurrentRow.Cells[4].Value.ToString();

            ADO.adoCTAdmin.Instance.Sua(ida, hoten, ngaysinh, diachi, email);
            dgv_CTAdmin.DataSource = quanLyThuVienDataSet.CT_USERADMIN;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string ida = dgv_CTAdmin.CurrentRow.Cells[0].Value.ToString();
            ADO.adoCTAdmin.Instance.Xoa(ida);
            dgv_CTAdmin.DataSource = quanLyThuVienDataSet.CT_USERADMIN;
        }

        //private void btn_LuuAdmin_Click(object sender, EventArgs e)
        //{
        //    string username = dgv_UserAdmin.CurrentRow.Cells[0].Value.ToString();
        //    string password = dgv_UserAdmin.CurrentRow.Cells[1].Value.ToString();
        //    string ida = dgv_UserAdmin.CurrentRow.Cells[2].Value.ToString();

        //    ADO.adoAdmin.Instance.Sua(username, password, ida);
        //    dgv_UserAdmin.DataSource = quanLyThuVienDataSet.USERADMIN;
        //}

        //private void btn_XoaAdmin_Click(object sender, EventArgs e)
        //{
        //    string username = dgv_UserAdmin.CurrentRow.Cells[0].Value.ToString();
        //    ADO.adoAdmin.Instance.Xoa(username);
        //    dgv_UserAdmin.DataSource = quanLyThuVienDataSet.USERADMIN;
        //}
    }
}