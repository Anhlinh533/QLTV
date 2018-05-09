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
    public partial class frmSoSachMuonMax : DevExpress.XtraEditors.XtraForm
    {
        public frmSoSachMuonMax()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);

        }
    }
}