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
    public partial class frmReportSachTraTre : DevExpress.XtraEditors.XtraForm
    {
        public frmReportSachTraTre()
        {
            InitializeComponent();
        }

        private void frmReportSachTraTre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.BCSACHTRATRE' table. You can move, or remove it, as needed.
            this.bCSACHTRATRETableAdapter.Fill(this.quanLyThuVienDataSet.BCSACHTRATRE);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.BCSACHTRATRE' table. You can move, or remove it, as needed.
            this.bCSACHTRATRETableAdapter.Fill(this.quanLyThuVienDataSet.BCSACHTRATRE);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}