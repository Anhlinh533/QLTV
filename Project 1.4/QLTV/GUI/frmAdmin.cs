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

        }

        private void btn_ThemAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}