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
            try
            {
                frmTheDocGia DG = new frmTheDocGia();
                if (ExistForm(DG)) return;
                DG.MdiParent = this;
                DG.Show();
            }
            catch { }
        }

        private void btn_Users_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmUsers f = new frmUsers();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_Sach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSach f = new frmSach();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_DauSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmDauSach f = new frmDauSach();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_CuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCuonSach f = new frmCuonSach();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_LoaiSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmLoaiSach f = new frmLoaiSach();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_CTPhieuNhapSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCTPhieuNhapSach f = new frmCTPhieuNhapSach();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_TacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmTacGia f = new frmTacGia();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_CTTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCTTacGia f = new frmCTTacGia();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_PhieuNhapSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmPhieuNhapSach f = new frmPhieuNhapSach();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_Muon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmMuonSach f = new frmMuonSach();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_CTMuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCTMuonSach f = new frmCTMuonSach();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_Tra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmTraSach f = new frmTraSach();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_PhieuThuTienPhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmPhieuThuTienPhat f = new frmPhieuThuTienPhat(UserName, Password);
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_CTTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCTTraSach f = new frmCTTraSach();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_TuoiDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmTuoiDocGia f = new frmTuoiDocGia();
                //if (ExistForm(f)) return;
                //f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_HanThe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmHanThe f = new frmHanThe();
                //if (ExistForm(f)) return;
                //f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_KhoangCachNamXuatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmKhoangCachXuatBan f = new frmKhoangCachXuatBan();
                //if (ExistForm(f)) return;
                //f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_SoNgayMuonMax_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSoNgayMuonMax f = new frmSoNgayMuonMax();
                //if (ExistForm(f)) return;
                //f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_SoSachMuonMax_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSoSachMuonMax f = new frmSoSachMuonMax();
                //if (ExistForm(f)) return;
                //f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_TienPhatMoiNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmTienPhatMoiNgay f = new frmTienPhatMoiNgay();
                //if (ExistForm(f)) return;
                //f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_TKDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmTKDocGia f = new frmTKDocGia(UserName, Password);
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_TKSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmTKSach f = new frmTKSach(UserName, Password);
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_TKTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmTKTacGia f = new frmTKTacGia(UserName, Password);
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_TKMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmTKMuonSach f = new frmTKMuonSach(UserName, Password);
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_TKTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmTKTraSach f = new frmTKTraSach(UserName, Password);
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_rpSachTraTre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmReportSachTraTre f = new frmReportSachTraTre(UserName, Password);
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmReportTinhHinhMuonSach f = new frmReportTinhHinhMuonSach(UserName, Password);
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
        }

        private void btn_MatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmDoiMatKhau dlg2 = new frmDoiMatKhau(UserName, Password);
                dlg2.ShowDialog();
            }
            catch { }
        }
        private void btn_ThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThongTinUser dlg2 = new frmThongTinUser(UserName, Password);
                dlg2.ShowDialog();
            }
            catch { }
        }

        private void btn_ThongTinAdmin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThongTinAdmin dlg2 = new frmThongTinAdmin(UserName, Password);
                dlg2.ShowDialog();
            }
            catch { }
        }

        private void btn_ThongTinPM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThongTinPhanMem dlg2 = new frmThongTinPhanMem();
                dlg2.ShowDialog();
            }
            catch { }
        }

        private void btn_ChuyenServer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmConnection dlg2 = new frmConnection();
                dlg2.ShowDialog();
            }
            catch { }
        }

        private void btn_DangXuat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch { }
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }

        private void btn_Admin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmAdmin f = new frmAdmin();
                if (ExistForm(f)) return;
                f.MdiParent = this;
                f.Show();
            }
            catch { }
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

        public string UserName;
        public string Password;

        public frmMain(string user, string pass) : this()
        {
            UserName = user;
            Password = pass;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (ADO.adoLogin.Instance.checkDocGia(UserName, Password) == true)
            {
                btn_CTMuonSach.Enabled = false;
                btn_CTPhieuNhapSach.Enabled = false;
                btn_CTTacGia.Enabled = false;
                btn_CTTraSach.Enabled = false;
                btn_CuonSach.Enabled = false;
                btn_DauSach.Enabled = false;
                btn_HanThe.Enabled = false;
                btn_LoaiSach.Enabled = false;
                btn_Muon.Enabled = false;
                btn_PhieuNhapSach.Enabled = false;
                btn_Sach.Enabled = false;
                btn_SoNgayMuonMax.Enabled = false;
                btn_SoSachMuonMax.Enabled = false;
                btn_TacGia.Enabled = false;
                btn_TheDocGia.Enabled = false;
                btn_TienPhatMoiNgay.Enabled = false;
                btn_Tra.Enabled = false;
                btn_TuoiDocGia.Enabled = false;
                btn_Users.Enabled = false;
                btn_KhoangCachNamXuatBan.Enabled = false;
                btn_ThongTinAdmin.Enabled = false;
                btn_Admin.Enabled = false;
                btn_CTPNSach.Enabled = false;
                btn_rpSachTraTre.Enabled = false;
                btn_rpTinhHinhMuonSach.Enabled = false;
                btn_Admin.Enabled = false;
                btn_PhieuThuTienPhat.Enabled = false;
            }

            if (ADO.adoLogin.Instance.checkAdmin(UserName,Password)==true && UserName!="root")
            {
                btn_ThongTin.Enabled = false;
                btn_Admin.Enabled = false;
            }           
        }
    }
}
