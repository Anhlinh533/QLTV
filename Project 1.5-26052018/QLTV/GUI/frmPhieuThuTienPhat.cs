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
    public partial class frmPhieuThuTienPhat : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuThuTienPhat()
        {
            InitializeComponent();
        }

        private void frmPhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUTHUTIENPHAT' table. You can move, or remove it, as needed.
            this.pHIEUTHUTIENPHATTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTHUTIENPHAT);

        }
    }
}