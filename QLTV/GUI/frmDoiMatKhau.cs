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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private string UserName;
        private string Password;
        public frmDoiMatKhau(string userName, string password):this()
        {
            UserName = userName;
            Password = password;
        }


        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            tb_UserName.Text = UserName;
            label5.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();
            pic_SsMK.Hide();
            pic_WarningMK.Hide();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if(tb_MKMoi.Text!=Password)
            {
                if(tb_MKCu.Text!=Password)
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Mật khẩu cũ không đúng!!";
                    label5.Show();
                    pic_Warning.Show();
                    pic_Ss.Hide();
                }
                if(tb_MKCu.Text==Password)
                {
                    label5.Hide();
                    pic_Ss.Show();
                    pic_Warning.Hide();
                }
            }
            if(ADO.adoLogin.Instance.checkDocGia(UserName,tb_MKCu.Text.Trim())==true)
                {
                    if (tb_MKMoi.Text != Password && tb_MKMoi.Text != "" && tb_MKCu.Text != "" && tb_MKCu.Text == Password)
                    {
                    ADO.adoLogin.Instance.DoiMatKhau(tb_UserName.Text.Trim(), tb_MKMoi.Text.Trim());
                    pic_SsMK.Show();
                    }
                //this.Close();
                }
            if (ADO.adoLogin.Instance.checkAdmin(UserName, tb_MKCu.Text.Trim()) == true)
            {
                if (tb_MKMoi.Text != Password && tb_MKMoi.Text != "" && tb_MKCu.Text != "" && tb_MKCu.Text == Password)
                {
                    ADO.adoLogin.Instance.DoiMatKhauAdmin(tb_UserName.Text.Trim(), tb_MKMoi.Text.Trim());
                    pic_SsMK.Show();
                }
                //this.Close();
            }


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}