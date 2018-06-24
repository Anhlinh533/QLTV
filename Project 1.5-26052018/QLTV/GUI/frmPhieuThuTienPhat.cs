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
    public partial class frmPhieuThuTienPhat : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuThuTienPhat()
        {
            InitializeComponent();
        }

        private void frmPhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.PHIEUTHUTIENPHAT' table. You can move, or remove it, as needed.
            this.pHIEUTHUTIENPHATTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTHUTIENPHAT);            
        }

        public string UserName;
        public string Password;

        public frmPhieuThuTienPhat(string user, string pass) : this()
        {
            UserName = user;
            Password = pass;
        }

        private void btn_TaoPhieuThu_Click(object sender, EventArgs e)
        {
            try
            {
                SCRIPT.formatPhieuThuTienPhat.Instance.checkPhieuThuTienPhat(tb_IDDocGia.Text, dtp_NgayLap.Text, tb_SoTienThu.Text);
                SCRIPT.formatPhieuThuTienPhat.Instance.checkNull(tb_IDDocGia, dtp_NgayLap, tb_SoTienThu);
                if (tb_IDDocGia.Text != "" && dtp_NgayLap.Text != "" && tb_SoTienThu.Text != "")
                {
                    int i = ADO.adoPhieuThuTienPhat.Instance.IDCount();
                    i++;

                    string str = "00" + i.ToString();
                    if (i >= 10 && i < 100) str = "0" + i.ToString();
                    else if (i >= 100 && i < 1000) str = i.ToString();

                    ADO.adoPhieuThuTienPhat.Instance.Them(str, tb_IDDocGia.Text, dtp_NgayLap.Text, tb_SoTienThu.Text);
                    this.pHIEUTHUTIENPHATTableAdapter.Fill(this.quanLyThuVienDataSet.PHIEUTHUTIENPHAT);

                    DataSet dst = new DataSet();
                    DataSet dsp = new DataSet();
                    DataSet dsa = new DataSet();

                    ADO.adoPhieuThuTienPhat.Instance.Chont(str).Fill(dst);
                    ADO.adoPhieuThuTienPhat.Instance.Chonp(str).Fill(dsp);
                    ADO.adoPhieuThuTienPhat.Instance.Chona(UserName).Fill(dsa);

                    //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
                    rpv_PhieuThuTienPhat.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    //Đường dẫn báo cáo
                    rpv_PhieuThuTienPhat.LocalReport.ReportPath = "REPORT/rpPhieuThuTienPhat.rdlc";

                    if (dsp.Tables[0].Rows.Count > 0)
                    {
                        //Tạo nguồn dữ liệu cho báo cáo
                        ReportDataSource rdt = new ReportDataSource();
                        ReportDataSource rdp = new ReportDataSource();
                        ReportDataSource rda = new ReportDataSource();

                        rdt.Name = "rpTheDocGia";
                        rdp.Name = "rpPhieuThuTienPhat";
                        rda.Name = "rpAdmin";

                        rdt.Value = dst.Tables[0];
                        rdp.Value = dsp.Tables[0];
                        rda.Value = dsa.Tables[0];
                        //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                        rpv_PhieuThuTienPhat.LocalReport.DataSources.Clear();
                        //Add dữ liệu vào báo cáo
                        rpv_PhieuThuTienPhat.LocalReport.DataSources.Add(rdt);
                        rpv_PhieuThuTienPhat.LocalReport.DataSources.Add(rdp);
                        rpv_PhieuThuTienPhat.LocalReport.DataSources.Add(rda);
                        //Refresh lại báo cáo
                        rpv_PhieuThuTienPhat.RefreshReport();
                    }
                }
                
            }
            catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {               
                DataSet dst = new DataSet();
                DataSet dsp = new DataSet();
                DataSet dsa = new DataSet();

                ADO.adoPhieuThuTienPhat.Instance.Chont(dataGridView1.CurrentRow.Cells[0].Value.ToString().Substring(3)).Fill(dst);
                ADO.adoPhieuThuTienPhat.Instance.Chonp(dataGridView1.CurrentRow.Cells[0].Value.ToString().Substring(3)).Fill(dsp);
                ADO.adoPhieuThuTienPhat.Instance.Chona(UserName).Fill(dsa);

                //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
                rpv_PhieuThuTienPhat.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                //Đường dẫn báo cáo
                rpv_PhieuThuTienPhat.LocalReport.ReportPath = "REPORT/rpPhieuThuTienPhat.rdlc";

                if (dsp.Tables[0].Rows.Count > 0)
                {
                    //Tạo nguồn dữ liệu cho báo cáo
                    ReportDataSource rdt = new ReportDataSource();
                    ReportDataSource rdp = new ReportDataSource();
                    ReportDataSource rda = new ReportDataSource();

                    rdt.Name = "rpTheDocGia";
                    rdp.Name = "rpPhieuThuTienPhat";
                    rda.Name = "rpAdmin";

                    rdt.Value = dst.Tables[0];
                    rdp.Value = dsp.Tables[0];
                    rda.Value = dsa.Tables[0];
                    //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                    rpv_PhieuThuTienPhat.LocalReport.DataSources.Clear();
                    //Add dữ liệu vào báo cáo
                    rpv_PhieuThuTienPhat.LocalReport.DataSources.Add(rdt);
                    rpv_PhieuThuTienPhat.LocalReport.DataSources.Add(rdp);
                    rpv_PhieuThuTienPhat.LocalReport.DataSources.Add(rda);
                    //Refresh lại báo cáo
                    rpv_PhieuThuTienPhat.RefreshReport();
                }
            }
            catch { }
        }
    }
}