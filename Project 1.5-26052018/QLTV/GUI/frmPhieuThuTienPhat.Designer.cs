namespace QLTV.GUI
{
    partial class frmPhieuThuTienPhat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TenDG = new System.Windows.Forms.TextBox();
            this.tb_SoTienThu = new System.Windows.Forms.TextBox();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.btn_TaoPhieuThu = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.pHIEUTHUTIENPHATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUTIENPHATTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.PHIEUTHUTIENPHATTableAdapter();
            this.iDPhieuThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conLaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rpv_PhieuThuTienPhat = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUTIENPHATBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(624, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu thu tiền phạt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TaoPhieuThu);
            this.groupBox1.Controls.Add(this.dtp_NgayLap);
            this.groupBox1.Controls.Add(this.tb_SoTienThu);
            this.groupBox1.Controls.Add(this.tb_TenDG);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(107, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên độc giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(107, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày lập phiếu thu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(107, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số tiền thu:";
            // 
            // tb_TenDG
            // 
            this.tb_TenDG.Location = new System.Drawing.Point(392, 49);
            this.tb_TenDG.Name = "tb_TenDG";
            this.tb_TenDG.Size = new System.Drawing.Size(375, 44);
            this.tb_TenDG.TabIndex = 3;
            // 
            // tb_SoTienThu
            // 
            this.tb_SoTienThu.Location = new System.Drawing.Point(392, 172);
            this.tb_SoTienThu.Name = "tb_SoTienThu";
            this.tb_SoTienThu.Size = new System.Drawing.Size(375, 44);
            this.tb_SoTienThu.TabIndex = 4;
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLap.Location = new System.Drawing.Point(392, 108);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(375, 44);
            this.dtp_NgayLap.TabIndex = 5;
            // 
            // btn_TaoPhieuThu
            // 
            this.btn_TaoPhieuThu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_TaoPhieuThu.Appearance.Options.UseFont = true;
            this.btn_TaoPhieuThu.Location = new System.Drawing.Point(392, 241);
            this.btn_TaoPhieuThu.Name = "btn_TaoPhieuThu";
            this.btn_TaoPhieuThu.Size = new System.Drawing.Size(167, 42);
            this.btn_TaoPhieuThu.TabIndex = 6;
            this.btn_TaoPhieuThu.Text = "Tạo phiếu thu";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 560);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu phiếu thu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPhieuThuDataGridViewTextBoxColumn,
            this.iDDocGiaDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.soTienThuDataGridViewTextBoxColumn,
            this.conLaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pHIEUTHUTIENPHATBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(958, 517);
            this.dataGridView1.TabIndex = 0;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUTHUTIENPHATBindingSource
            // 
            this.pHIEUTHUTIENPHATBindingSource.DataMember = "PHIEUTHUTIENPHAT";
            this.pHIEUTHUTIENPHATBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // pHIEUTHUTIENPHATTableAdapter
            // 
            this.pHIEUTHUTIENPHATTableAdapter.ClearBeforeFill = true;
            // 
            // iDPhieuThuDataGridViewTextBoxColumn
            // 
            this.iDPhieuThuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDPhieuThuDataGridViewTextBoxColumn.DataPropertyName = "IDPhieuThu";
            this.iDPhieuThuDataGridViewTextBoxColumn.HeaderText = "ID phiếu thu";
            this.iDPhieuThuDataGridViewTextBoxColumn.Name = "iDPhieuThuDataGridViewTextBoxColumn";
            this.iDPhieuThuDataGridViewTextBoxColumn.Width = 218;
            // 
            // iDDocGiaDataGridViewTextBoxColumn
            // 
            this.iDDocGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDocGiaDataGridViewTextBoxColumn.DataPropertyName = "IDDocGia";
            this.iDDocGiaDataGridViewTextBoxColumn.HeaderText = "ID độc giả";
            this.iDDocGiaDataGridViewTextBoxColumn.Name = "iDDocGiaDataGridViewTextBoxColumn";
            this.iDDocGiaDataGridViewTextBoxColumn.Width = 187;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.Width = 168;
            // 
            // soTienThuDataGridViewTextBoxColumn
            // 
            this.soTienThuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soTienThuDataGridViewTextBoxColumn.DataPropertyName = "SoTienThu";
            this.soTienThuDataGridViewTextBoxColumn.HeaderText = "Số tiền thu";
            this.soTienThuDataGridViewTextBoxColumn.Name = "soTienThuDataGridViewTextBoxColumn";
            this.soTienThuDataGridViewTextBoxColumn.Width = 196;
            // 
            // conLaiDataGridViewTextBoxColumn
            // 
            this.conLaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.conLaiDataGridViewTextBoxColumn.DataPropertyName = "ConLai";
            this.conLaiDataGridViewTextBoxColumn.HeaderText = "Còn lại";
            this.conLaiDataGridViewTextBoxColumn.Name = "conLaiDataGridViewTextBoxColumn";
            this.conLaiDataGridViewTextBoxColumn.Width = 141;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rpv_PhieuThuTienPhat);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(979, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1095, 864);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xem trước phiếu thu tiền phạt";
            // 
            // rpv_PhieuThuTienPhat
            // 
            this.rpv_PhieuThuTienPhat.AutoSize = true;
            this.rpv_PhieuThuTienPhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_PhieuThuTienPhat.DocumentMapWidth = 44;
            reportDataSource1.Name = "rpLoaiSach";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "rpCTTinhHinhMuonSach";
            reportDataSource2.Value = null;
            reportDataSource3.Name = "rpTinhHinhSach";
            reportDataSource3.Value = null;
            this.rpv_PhieuThuTienPhat.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_PhieuThuTienPhat.LocalReport.DataSources.Add(reportDataSource2);
            this.rpv_PhieuThuTienPhat.LocalReport.DataSources.Add(reportDataSource3);
            this.rpv_PhieuThuTienPhat.LocalReport.ReportEmbeddedResource = "QLTV.REPORT.rpTinhHinhMuonSach.rdlc";
            this.rpv_PhieuThuTienPhat.Location = new System.Drawing.Point(3, 40);
            this.rpv_PhieuThuTienPhat.Name = "rpv_PhieuThuTienPhat";
            this.rpv_PhieuThuTienPhat.Size = new System.Drawing.Size(1089, 821);
            this.rpv_PhieuThuTienPhat.TabIndex = 0;
            // 
            // frmPhieuThuTienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2086, 1037);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuThuTienPhat";
            this.Text = "Phiếu thu tiền phạt";
            this.Load += new System.EventHandler(this.frmPhieuThuTienPhat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUTIENPHATBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_TaoPhieuThu;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.TextBox tb_SoTienThu;
        private System.Windows.Forms.TextBox tb_TenDG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource pHIEUTHUTIENPHATBindingSource;
        private QuanLyThuVienDataSetTableAdapters.PHIEUTHUTIENPHATTableAdapter pHIEUTHUTIENPHATTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conLaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_PhieuThuTienPhat;
    }
}