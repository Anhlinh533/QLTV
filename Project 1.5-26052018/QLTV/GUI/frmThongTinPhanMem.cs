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
    public partial class frmThongTinPhanMem : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinPhanMem()
        {
            InitializeComponent();
        }

        private void frmThongTinPhanMem_Load(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}