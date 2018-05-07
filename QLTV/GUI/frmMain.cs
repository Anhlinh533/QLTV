using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.GUI;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.DragEngine;

namespace QLTV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region Event
        private void btn_TheDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTheDocGia DG = new frmTheDocGia();
            if (ExistForm(DG)) return;
            DG.MdiParent = this;
            DG.Show();
        }
        private void btn_Users_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUsers f = new frmUsers();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btn_Sach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSach f = new frmSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_DauSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDauSach f = new frmDauSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_CuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCuonSach f = new frmCuonSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_LoaiSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoaiSach f = new frmLoaiSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_CTPhieuNhapSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCTPhieuNhapSach f = new frmCTPhieuNhapSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_TacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTacGia f = new frmTacGia();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_CTTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCTTacGia f = new frmCTTacGia();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_PhieuNhapSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhieuNhapSach f = new frmPhieuNhapSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        private void btn_Muon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMuonSach f = new frmMuonSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_CTMuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCTMuonSach f = new frmCTMuonSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_Tra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTraSach f = new frmTraSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_CTTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCTTraSach f = new frmCTTraSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_TuoiDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTuoiDocGia f = new frmTuoiDocGia();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_HanThe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHanThe f = new frmHanThe();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void ribtab_KhoangCachNamXuatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoangCachXuatBan f = new frmKhoangCachXuatBan();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_SoNgayMuonMax_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSoNgayMuonMax f = new frmSoNgayMuonMax();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_SoSachMuonMax_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSoSachMuonMax f = new frmSoSachMuonMax();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_TienPhatMoiNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTienPhatMoiNgay f = new frmTienPhatMoiNgay();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        #endregion


        #region Function
        private bool ExistForm(Form  form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }








        #endregion


    }
}
