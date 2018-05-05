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
    public partial class frmCTMuonSach : DevExpress.XtraEditors.XtraForm
    {
        public frmCTMuonSach()
        {
            InitializeComponent();
        }

        private void frmCTMuonSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CUONSACH' table. You can move, or remove it, as needed.
            this.cUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CUONSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUMUON' table. You can move, or remove it, as needed.
            this.pHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUMUON);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_PHIEUMUON' table. You can move, or remove it, as needed.
            this.cT_PHIEUMUONTableAdapter.Fill(this.quanLyThuVienDataSet.CT_PHIEUMUON);

        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTMuonSach.Instance.checkCTMuonSach(tb_IDCTPhieuMuon.Text, cbb_IDPhieuMuon.Text, cbb_IDCuonSach.Text);
            if(tb_IDCTPhieuMuon.Text!="" && cbb_IDCuonSach.Text!="" && cbb_IDPhieuMuon.Text!="")
            {
                //Hàm thêm

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

        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}