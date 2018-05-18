using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoLogin
    {
        private static adoLogin instance;

        internal static adoLogin Instance
        {
            get
            {
                if (instance == null) instance = new adoLogin(); return ADO.adoLogin.instance;
            }

            private set
            {
                ADO.adoLogin.instance = value;
            }
        }

        public bool checkDocGia(string UserName, string Password)
        {
            //con = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            //try
            //{
            //    con.Open();
            //    string tk = tb_UserName.text;
            //    string pwd = tb_Pwd.Text;
            //    string sql = "Select *from USERS where UserName='" + tk + "' and Pwd='" + pwd + "'";
            //    SqlCommand cmd = new SqlCommand(sql, con);
            //    SqlDataReader dta = cmd.ExecuteReader();
            //    if (dta.Read() == true)
            //    {
            //MessageBox.Show("Đăng nhập thành công");
            //frmMain dlg2 = new frmMain();
            //dlg2.ShowDialog();
            //this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Đăng nhập thất bại, vui lòng đăng nhập lại.", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi kết nối.", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            con.Open();

            string sql = "Select *from USERS where UserName='" + UserName + "' and Pwd='" + Password + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dta = cmd.ExecuteReader();

            if (dta.Read()==true)
            {
                return true;
            }

            return false;
        }

        public bool checkAdmin(string UserName, string Password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            con.Open();

            string sql = "Select *from USERADMIN where UserNameAdmin='" + UserName + "' and PasswordAdmin='" + Password + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dta = cmd.ExecuteReader();

            if (dta.Read() == true)
            {
                return true;
            }

            return false;
        }
    }
}
