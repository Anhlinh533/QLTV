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
            //if (ExistForm(f)) return;
            //f.MdiParent = this;
            f.Show();
        }

        private void btn_HanThe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHanThe f = new frmHanThe();
            //if (ExistForm(f)) return;
            //f.MdiParent = this;
            f.Show();
        }

        private void btn_KhoangCachNamXuatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoangCachXuatBan f = new frmKhoangCachXuatBan();
            //if (ExistForm(f)) return;
            //f.MdiParent = this;
            f.Show();
        }

        private void btn_SoNgayMuonMax_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSoNgayMuonMax f = new frmSoNgayMuonMax();
            //if (ExistForm(f)) return;
            //f.MdiParent = this;
            f.Show();
        }

        private void btn_SoSachMuonMax_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSoSachMuonMax f = new frmSoSachMuonMax();
            //if (ExistForm(f)) return;
            //f.MdiParent = this;
            f.Show();
        }

        private void btn_TienPhatMoiNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTienPhatMoiNgay f = new frmTienPhatMoiNgay();
            //if (ExistForm(f)) return;
            //f.MdiParent = this;
            f.Show();
        }

        private void btn_TKDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTKDocGia f = new frmTKDocGia();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_TKSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTKSach f = new frmTKSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_TKTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTKTacGia f = new frmTKTacGia();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_TKMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTKMuonSach f = new frmTKMuonSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_TKTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTKTraSach f = new frmTKTraSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_rpSachTraTre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReportSachTraTre f = new frmReportSachTraTre();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReportTinhHinhMuonSach f = new frmReportTinhHinhMuonSach();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btn_MatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau dlg2 = new frmDoiMatKhau(UserName, Password);
            dlg2.ShowDialog();
        }
        private void btn_ThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinUser dlg2 = new frmThongTinUser(UserName, Password);
            dlg2.ShowDialog();
        }

        private void btn_ThongTinAdmin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinAdmin dlg2 = new frmThongTinAdmin(UserName, Password);
            dlg2.ShowDialog();
        }

        private void btn_ThongTinPM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinPhanMem dlg2 = new frmThongTinPhanMem();
            dlg2.ShowDialog();
        }

        private void btn_ChuyenServer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmConnection dlg2 = new frmConnection();
            dlg2.ShowDialog();
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
            rib_User.Text = "Tài khoản: " + UserName;
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
                //btn_CTMuonSach.Enabled = false;
            }
            if(ADO.adoLogin.Instance.checkAdmin(UserName,Password)==true)
            {
                btn_ThongTin.Enabled = false;
            }
        }


        private void btn_DangXuat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }


    }
}
