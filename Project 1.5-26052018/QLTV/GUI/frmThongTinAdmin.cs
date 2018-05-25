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
    public partial class frmThongTinAdmin : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinAdmin()
        {
            InitializeComponent();
        }

        private void frmThongTinAdmin_Load(object sender, EventArgs e)
        {
            tb_UserNameAdmin.Text = UserName;
            tb_IDAdmin.Text = ADO.ConnectionSQL.Instance.readData("SELECT IDAdmin FROM USERADMIN where UserNameAdmin = '" + UserName + "'", tb_IDAdmin.Text.Trim(), "IDAdmin");
            tb_HoTen.Text = ADO.ConnectionSQL.Instance.readData("SELECT HoTenAdmin FROM CT_USERADMIN where IDAdmin = '" + tb_IDAdmin.Text.Trim() + "'", tb_HoTen.Text.Trim(), "HoTenAdmin");
            dtp_NgaySinh.Text = ADO.ConnectionSQL.Instance.readData("SELECT NgaySinhAdmin FROM CT_USERADMIN where IDAdmin = '" + tb_IDAdmin.Text.Trim() + "'", dtp_NgaySinh.Text.Trim(), "NgaySinhAdmin");
            tb_DiaChi.Text = ADO.ConnectionSQL.Instance.readData("SELECT DiaChiAdmin FROM CT_USERADMIN where IDAdmin = '" + tb_IDAdmin.Text.Trim() + "'", tb_DiaChi.Text.Trim(), "DiaChiAdmin");
            tb_Email.Text = ADO.ConnectionSQL.Instance.readData("SELECT EmailAdmin FROM CT_USERADMIN where IDAdmin = '" + tb_IDAdmin.Text.Trim() + "'", tb_Email.Text.Trim(), "EmailAdmin");

        }
        private string UserName;
        private string Password;
        public frmThongTinAdmin(string userName, string password) : this()
        {
            UserName = userName;
            Password = password;
        }

    }
}