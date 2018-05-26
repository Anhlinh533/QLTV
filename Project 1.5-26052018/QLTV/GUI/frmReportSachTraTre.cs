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
using QLTV.SCRIPT;
using QLTV.ADO;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QLTV.GUI
{
    public partial class frmReportSachTraTre : DevExpress.XtraEditors.XtraForm
    {
        public frmReportSachTraTre()
        {
            InitializeComponent();
        }

        private void frmReportSachTraTre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.BCSACHTRATRE' table. You can move, or remove it, as needed.
            this.bCSACHTRATRETableAdapter.Fill(this.quanLyThuVienDataSet.BCSACHTRATRE);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.BCSACHTRATRE' table. You can move, or remove it, as needed.
            this.bCSACHTRATRETableAdapter.Fill(this.quanLyThuVienDataSet.BCSACHTRATRE);

            //this.rpv_SachTraTre.RefreshReport();
            //this.rpv_SachTraTre.RefreshReport();
        }

        private void btn_TaoBaoCao_Click(object sender, EventArgs e)
        {
            DataSet dss = new DataSet();
            DataSet dsm = new DataSet();
            DataSet dsr = new DataSet();

            ADO.adoRPSachTraTre.Instance.Chons(dtp_NgayThangNam.Text).Fill(dss);
            ADO.adoRPSachTraTre.Instance.Chonm(dtp_NgayThangNam.Text).Fill(dsm);
            ADO.adoRPSachTraTre.Instance.Chonr(dtp_NgayThangNam.Text).Fill(dsr);

            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            rpv_SachTraTre.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            rpv_SachTraTre.LocalReport.ReportPath = "REPORT/rpSachTraTre.rdlc";

            if (dsr.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                ReportDataSource rdm = new ReportDataSource();
                ReportDataSource rdr = new ReportDataSource();

                rds.Name = "rpDauSach";
                rdm.Name = "rpPhieuMuon";
                rdr.Name = "rpSachTraTre";

                rds.Value = dss.Tables[0];
                rdm.Value = dsm.Tables[0];
                rdr.Value = dsr.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rpv_SachTraTre.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpv_SachTraTre.LocalReport.DataSources.Add(rds);
                rpv_SachTraTre.LocalReport.DataSources.Add(rdm);
                rpv_SachTraTre.LocalReport.DataSources.Add(rdr);
                //Refresh lại báo cáo
                rpv_SachTraTre.RefreshReport();
            }            
    }
}