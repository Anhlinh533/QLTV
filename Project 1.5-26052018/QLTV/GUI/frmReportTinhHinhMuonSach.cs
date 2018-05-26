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
    public partial class frmReportTinhHinhMuonSach : DevExpress.XtraEditors.XtraForm
    {
        public frmReportTinhHinhMuonSach()
        {
            InitializeComponent();
        }

        private void frmReportTinhHinhMuonSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.BCTINHHINHMUONSACH' table. You can move, or remove it, as needed.
            this.bCTINHHINHMUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.BCTINHHINHMUONSACH);


        }

        private void btn_TaoBaoCao_Click(object sender, EventArgs e)
        {
            int i = ADO.adoRPTinhHinhMuonSach.Instance.IDReport();
            i++;

            string str = "00" + i.ToString();
            if (i >= 10 && i < 100) str = "0" + i.ToString();
            else if (i >= 100 && i < 1000) str = i.ToString();

            ADO.adoRPTinhHinhMuonSach.Instance.Them(str, tb_Thang.Text, tb_Nam.Text);
            this.bCTINHHINHMUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.BCTINHHINHMUONSACH);           

            DataSet dss = new DataSet();
            DataSet dsr = new DataSet();
            DataSet dsrc = new DataSet();

            ADO.adoRPTinhHinhMuonSach.Instance.Chons(str).Fill(dss);
            ADO.adoRPTinhHinhMuonSach.Instance.Chonr(str).Fill(dsr);
            ADO.adoRPTinhHinhMuonSach.Instance.Chonrc(str).Fill(dsrc);

            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            rpv_TinhHinhMuonSach.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            rpv_TinhHinhMuonSach.LocalReport.ReportPath = "REPORT/rpTinhHinhMuonSach.rdlc";

            if (dsrc.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                ReportDataSource rdr = new ReportDataSource();
                ReportDataSource rdrc = new ReportDataSource();

                rds.Name = "rpLoaiSach";
                rdr.Name = "rpTinhHinhMuonSach";
                rdrc.Name = "rpCTTinhHinhMuonSach";

                rds.Value = dss.Tables[0];
                rdr.Value = dsr.Tables[0];
                rdrc.Value = dsrc.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rpv_TinhHinhMuonSach.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpv_TinhHinhMuonSach.LocalReport.DataSources.Add(rds);
                rpv_TinhHinhMuonSach.LocalReport.DataSources.Add(rdr);
                rpv_TinhHinhMuonSach.LocalReport.DataSources.Add(rdrc);
                //Refresh lại báo cáo
                rpv_TinhHinhMuonSach.RefreshReport();
            }
        }
    }
}