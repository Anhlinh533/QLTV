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
using QLTV.ADO;
using DevComponents.DotNetBar;

namespace QLTV.GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(ADO.adoLogin.Instance.checkDocGia(tb_UserName.Text.Trim(), tb_MatKhau.Text.Trim())==true||ADO.adoLogin.Instance.checkAdmin(tb_UserName.Text.Trim(), tb_MatKhau.Text.Trim())==true)
            {
                MessageBox.Show("Đăng nhập thành công","Đăng nhập!!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                frmMain dlg2 = new frmMain(tb_UserName.Text.Trim(), tb_MatKhau.Text.Trim());
                this.Hide();
                dlg2.ShowDialog();
                this.Close();
            }

            if (ADO.adoLogin.Instance.checkDocGia(tb_UserName.Text.Trim(), tb_MatKhau.Text.Trim()) == false && ADO.adoLogin.Instance.checkAdmin(tb_UserName.Text.Trim(), tb_MatKhau.Text.Trim()) == false)
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập và mật khẩu!!","Cảnh báo!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(ADO.ConnectionSQL.OpenConnection()==false)
            {
                    ReConnection();           
            }

        }

        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            frmDangKi frm = new frmDangKi();
            frm.ShowDialog();
        }

        private void tb_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ADO.adoLogin.Instance.checkDocGia(tb_UserName.Text.Trim(), tb_MatKhau.Text.Trim()) == true || ADO.adoLogin.Instance.checkAdmin(tb_UserName.Text.Trim(), tb_MatKhau.Text.Trim()) == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Đăng nhập!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    frmMain dlg2 = new frmMain(tb_UserName.Text.Trim(), tb_MatKhau.Text.Trim());
                    this.Hide();
                    dlg2.ShowDialog();
                    this.Close();
                }

                if (ADO.adoLogin.Instance.checkDocGia(tb_UserName.Text.Trim(), tb_MatKhau.Text.Trim()) == false && ADO.adoLogin.Instance.checkAdmin(tb_UserName.Text.Trim(), tb_MatKhau.Text.Trim()) == false)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập và mật khẩu!!", "Cảnh báo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region frmConnection
        frmConnection m_Connection = null;
        //frmLogin m_FrmLogin = null;
        public void ReConnection()
        {
            MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            //m_Connection = new frmConnection();
            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new frmConnection();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
                return;
        }
        #endregion
    }
}