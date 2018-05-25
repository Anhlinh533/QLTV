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
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.quanLyThuVienDataSet.USERS);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.quanLyThuVienDataSet.THEDOCGIA);

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {

        }
    }
}