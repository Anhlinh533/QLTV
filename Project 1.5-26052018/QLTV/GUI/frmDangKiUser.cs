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
    public partial class frmDangKiUser : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKiUser()
        {
            InitializeComponent();
        }

        string IDDocGia;

        public frmDangKiUser(string sIDDocGia): this()
        {
            IDDocGia = sIDDocGia;
        }

        private void frmDangKiUser_Load(object sender, EventArgs e)
        {
            tb_IDDocGia.Text = "IDG" +IDDocGia;
            label5.Hide();
            pic_Warning.Hide();
            pic_Ss.Hide();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatUsers.Instance.checkUsers(tb_UserName.Text, tb_Password.Text, tb_IDDocGia.Text);
                SCRIPT.formatUsers.Instance.checkNull(tb_UserName, tb_Password, tb_IDDocGia);
                if (tb_UserName.Text != "" && tb_Password.Text != "" && tb_IDDocGia.Text != "")
                {
                    ADO.adoUsers.Instance.Them(tb_UserName.Text, tb_Password.Text, tb_IDDocGia.Text);
                }
                this.Close();
            }
            catch { } 
        }

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ADO.adoLogin.Instance.checkUserName(tb_UserName.Text.Trim()) == true)
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Username đã tồn tại!!";
                    label5.Show();
                    pic_Warning.Show();
                    pic_Ss.Hide();
                }
                else
                {
                    label5.ForeColor = Color.Green;
                    label5.Text = "Có thể đăng kí user!!";
                    label5.Show();
                    pic_Warning.Hide();
                    pic_Ss.Show();
                }
            }
            catch { }
        }
    }
}