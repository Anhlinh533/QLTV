using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using QLTV.GUI;
using System.Configuration;

namespace QLTV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Properties.Settings.Default["QuanLyThuVienConnectionString"] = ADO.ConnectionSQL.ConSTR();
            Properties.Settings.Default["ConnectionString"] = ADO.ConnectionSQL.ConSTR();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new frmLogin());
        }
    }
}
