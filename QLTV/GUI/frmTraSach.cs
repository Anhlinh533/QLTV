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
    public partial class frmTraSach : DevExpress.XtraEditors.XtraForm
    {
        public frmTraSach()
        {
            InitializeComponent();
        }

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUTRA' table. You can move, or remove it, as needed.
            this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatTraSach.Instance.checkTraSach(tb_IDPhieuTra.Text, cbb_IDDocGia.Text, dtp_NgayTra.Text, tb_SoTienTra.Text);
            if (tb_IDPhieuTra.Text != "" && cbb_IDDocGia.Text != "" && dtp_NgayTra.Text != ""  && tb_SoTienTra.Text != "" )
            {
                ADO.adoTraSach.Instance.Them(tb_IDPhieuTra.Text, cbb_IDDocGia.Text, dtp_NgayTra.Text, tb_SoTienTra.Text);
                this.pHIEUTRATableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTRA);
            }
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

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {

        }

        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}