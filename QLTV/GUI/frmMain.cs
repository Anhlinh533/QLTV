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
            frmUser f = new frmUser();
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
