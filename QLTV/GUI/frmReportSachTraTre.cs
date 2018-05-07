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

            this.reportViewer1.RefreshReport();
        }
    }
}