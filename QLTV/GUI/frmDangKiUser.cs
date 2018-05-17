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
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}