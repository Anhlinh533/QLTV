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
    public partial class frmTKTacGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTKTacGia()
        {
            InitializeComponent();
        }

        private void frmTKTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_TACGIA' table. You can move, or remove it, as needed.
            this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);

        }
    }
}