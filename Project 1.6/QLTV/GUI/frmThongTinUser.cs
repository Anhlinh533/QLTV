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
    public partial class frmThongTinUser : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinUser()
        {
            InitializeComponent();
        }
        private string UserName;
        private string Password;
        public frmThongTinUser(string userName, string password) : this()
        {
            UserName = userName;
            Password = password;
        }
        private void frmThongTinUser_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'quanLyThuVienDataSet.USERS' table. You can move, or remove it, as needed.
            //this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
            //// TODO: This line of code loads data into the 'quanLyThuVienDataSet.USERS' table. You can move, or remove it, as needed.
            //this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
            //// TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            tb_UserName.Text = UserName;
            tb_IDDocGia.Text=ADO.ConnectionSQL.Instance.readData("SELECT IDDocGia FROM USERS where UserName = '" + UserName + "'", tb_IDDocGia.Text.Trim(),"IDDocGia");
            tb_HoTenDocGia.Text = ADO.ConnectionSQL.Instance.readData("SELECT HoTenDG FROM THEDOCGIA where IDDocGia = '" + tb_IDDocGia.Text.Trim() + "'", tb_HoTenDocGia.Text.Trim(), "HoTenDG");
            dtp_NgaySinh.Text = ADO.ConnectionSQL.Instance.readData("SELECT NgaySinhDG FROM THEDOCGIA where IDDocGia = '" + tb_IDDocGia.Text.Trim() + "'", dtp_NgaySinh.Text.Trim(), "NgaySinhDG");
            tb_DiaChi.Text = ADO.ConnectionSQL.Instance.readData("SELECT DiaChiDG FROM THEDOCGIA where IDDocGia = '" + tb_IDDocGia.Text.Trim() + "'", tb_DiaChi.Text.Trim(), "DiaChiDG");
            tb_Email.Text = ADO.ConnectionSQL.Instance.readData("SELECT EmailDG FROM THEDOCGIA where IDDocGia = '" + tb_IDDocGia.Text.Trim() + "'", tb_Email.Text.Trim(), "EmailDG");
            cbb_LoaiDocGia.Text = ADO.ConnectionSQL.Instance.readData("SELECT IDLoaiDG FROM THEDOCGIA where IDDocGia = '" + tb_IDDocGia.Text.Trim() + "'", cbb_LoaiDocGia.Text.Trim(), "IDLoaiDG");
            dtp_NgayLapThe.Text = ADO.ConnectionSQL.Instance.readData("SELECT NgayLapThe FROM THEDOCGIA where IDDocGia = '" + tb_IDDocGia.Text.Trim() + "'", dtp_NgayLapThe.Text.Trim(), "NgayLapThe");
            dtp_NgayHetHan.Text = ADO.ConnectionSQL.Instance.readData("SELECT NgayHetHan FROM THEDOCGIA where IDDocGia = '" + tb_IDDocGia.Text.Trim() + "'", dtp_NgayHetHan.Text.Trim(), "NgayHetHan");
            tb_TongNo.Text = ADO.ConnectionSQL.Instance.readData("SELECT TongNo FROM THEDOCGIA where IDDocGia = '" + tb_IDDocGia.Text.Trim() + "'",tb_TongNo.Text.Trim(), "TongNo");

            //dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            //dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            //dtp_NgayLapThe.Format = DateTimePickerFormat.Custom;
            //dtp_NgayLapThe.CustomFormat = "dd/MM/yyyy";
            //dtp_NgayHetHan.Format = DateTimePickerFormat.Custom;
            //dtp_NgayHetHan.CustomFormat = "dd/MM/yyyy";
        }

    }
}