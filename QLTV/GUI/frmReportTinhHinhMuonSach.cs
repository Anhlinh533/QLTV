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
    public partial class frmReportTinhHinhMuonSach : DevExpress.XtraEditors.XtraForm
    {
        public frmReportTinhHinhMuonSach()
        {
            InitializeComponent();
        }

        private void frmReportTinhHinhMuonSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.BCTINHHINHMUONSACH' table. You can move, or remove it, as needed.
            this.bCTINHHINHMUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.BCTINHHINHMUONSACH);


        }
    }
}