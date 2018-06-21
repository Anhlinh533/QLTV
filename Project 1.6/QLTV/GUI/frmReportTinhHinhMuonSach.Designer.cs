﻿namespace QLTV.GUI
{
    partial class frmReportTinhHinhMuonSach
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
            this.LOAISACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.CT_BCTINHHINHMUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCTINHHINHMUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpv_TinhHinhMuonSach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDBCMuonSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoLuotMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TaoBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Nam = new System.Windows.Forms.TextBox();
            this.tb_Thang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.designRepositoryItemComboBox1 = new DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox();
            this.recentlyUsedItemsComboBox1 = new DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox();
            this.bCTINHHINHMUONSACHTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.BCTINHHINHMUONSACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LOAISACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_BCTINHHINHMUONSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCTINHHINHMUONSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LOAISACHBindingSource
            // 
            this.LOAISACHBindingSource.DataMember = "LOAISACH";
            this.LOAISACHBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CT_BCTINHHINHMUONSACHBindingSource
            // 
            this.CT_BCTINHHINHMUONSACHBindingSource.DataMember = "CT_BCTINHHINHMUONSACH";
            this.CT_BCTINHHINHMUONSACHBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // bCTINHHINHMUONSACHBindingSource
            // 
            this.bCTINHHINHMUONSACHBindingSource.DataMember = "BCTINHHINHMUONSACH";
            this.bCTINHHINHMUONSACHBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // rpv_TinhHinhMuonSach
            // 
            this.rpv_TinhHinhMuonSach.AutoSize = true;
            this.rpv_TinhHinhMuonSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_TinhHinhMuonSach.DocumentMapWidth = 44;
            reportDataSource1.Name = "rpLoaiSach";
            reportDataSource1.Value = this.LOAISACHBindingSource;
            reportDataSource2.Name = "rpCTTinhHinhMuonSach";
            reportDataSource2.Value = this.CT_BCTINHHINHMUONSACHBindingSource;
            reportDataSource3.Name = "rpTinhHinhSach";
            reportDataSource3.Value = this.bCTINHHINHMUONSACHBindingSource;
            this.rpv_TinhHinhMuonSach.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_TinhHinhMuonSach.LocalReport.DataSources.Add(reportDataSource2);
            this.rpv_TinhHinhMuonSach.LocalReport.DataSources.Add(reportDataSource3);
            this.rpv_TinhHinhMuonSach.LocalReport.ReportEmbeddedResource = "QLTV.REPORT.rpTinhHinhMuonSach.rdlc";
            this.rpv_TinhHinhMuonSach.Location = new System.Drawing.Point(2, 27);
            this.rpv_TinhHinhMuonSach.Margin = new System.Windows.Forms.Padding(2);
            this.rpv_TinhHinhMuonSach.Name = "rpv_TinhHinhMuonSach";
            this.rpv_TinhHinhMuonSach.ServerReport.BearerToken = null;
            this.rpv_TinhHinhMuonSach.Size = new System.Drawing.Size(610, 363);
            this.rpv_TinhHinhMuonSach.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBCMuonSachDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.tongSoLuotMuonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bCTINHHINHMUONSACHBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(649, 540);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDBCMuonSachDataGridViewTextBoxColumn
            // 
            this.iDBCMuonSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDBCMuonSachDataGridViewTextBoxColumn.DataPropertyName = "IDBCMuonSach";
            this.iDBCMuonSachDataGridViewTextBoxColumn.HeaderText = "ID báo cáo mượn sách";
            this.iDBCMuonSachDataGridViewTextBoxColumn.Name = "iDBCMuonSachDataGridViewTextBoxColumn";
            this.iDBCMuonSachDataGridViewTextBoxColumn.Width = 177;
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "Thang";
            this.thangDataGridViewTextBoxColumn.HeaderText = "Tháng";
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            this.thangDataGridViewTextBoxColumn.Width = 91;
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Năm";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            this.namDataGridViewTextBoxColumn.Width = 76;
            // 
            // tongSoLuotMuonDataGridViewTextBoxColumn
            // 
            this.tongSoLuotMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tongSoLuotMuonDataGridViewTextBoxColumn.DataPropertyName = "TongSoLuotMuon";
            this.tongSoLuotMuonDataGridViewTextBoxColumn.HeaderText = "Tổng số lượt mượn";
            this.tongSoLuotMuonDataGridViewTextBoxColumn.Name = "tongSoLuotMuonDataGridViewTextBoxColumn";
            this.tongSoLuotMuonDataGridViewTextBoxColumn.Width = 140;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rpv_TinhHinhMuonSach);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(665, 79);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(614, 392);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xem trước báo cáo thống kê tình hình mượn sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(8, 182);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(653, 569);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu thống kê được";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TaoBaoCao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_Nam);
            this.groupBox1.Controls.Add(this.tb_Thang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(589, 99);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê tình hình mượn sách";
            // 
            // btn_TaoBaoCao
            // 
            this.btn_TaoBaoCao.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_TaoBaoCao.Appearance.Options.UseFont = true;
            this.btn_TaoBaoCao.Location = new System.Drawing.Point(443, 46);
            this.btn_TaoBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TaoBaoCao.Name = "btn_TaoBaoCao";
            this.btn_TaoBaoCao.Size = new System.Drawing.Size(93, 30);
            this.btn_TaoBaoCao.TabIndex = 6;
            this.btn_TaoBaoCao.Text = "Tạo báo cáo";
            this.btn_TaoBaoCao.Click += new System.EventHandler(this.btn_TaoBaoCao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Năm:";
            // 
            // tb_Nam
            // 
            this.tb_Nam.Location = new System.Drawing.Point(283, 46);
            this.tb_Nam.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Nam.Name = "tb_Nam";
            this.tb_Nam.Size = new System.Drawing.Size(105, 32);
            this.tb_Nam.TabIndex = 4;
            // 
            // tb_Thang
            // 
            this.tb_Thang.Location = new System.Drawing.Point(82, 46);
            this.tb_Thang.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Thang.Name = "tb_Thang";
            this.tb_Thang.Size = new System.Drawing.Size(105, 32);
            this.tb_Thang.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(405, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Báo cáo thống kê tình hình mượn sách";
            // 
            // designRepositoryItemComboBox1
            // 
            this.designRepositoryItemComboBox1.AutoHeight = false;
            this.designRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.designRepositoryItemComboBox1.Name = "designRepositoryItemComboBox1";
            // 
            // recentlyUsedItemsComboBox1
            // 
            this.recentlyUsedItemsComboBox1.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.recentlyUsedItemsComboBox1.AppearanceDropDown.Options.UseFont = true;
            this.recentlyUsedItemsComboBox1.AutoHeight = false;
            this.recentlyUsedItemsComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.recentlyUsedItemsComboBox1.DropDownRows = 12;
            this.recentlyUsedItemsComboBox1.Name = "recentlyUsedItemsComboBox1";
            // 
            // bCTINHHINHMUONSACHTableAdapter
            // 
            this.bCTINHHINHMUONSACHTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportTinhHinhMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 482);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReportTinhHinhMuonSach";
            this.Text = "frmReportTinhHinhMuonSach";
            this.Load += new System.EventHandler(this.frmReportTinhHinhMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LOAISACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_BCTINHHINHMUONSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCTINHHINHMUONSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_TinhHinhMuonSach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox designRepositoryItemComboBox1;
        private DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox recentlyUsedItemsComboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Nam;
        private System.Windows.Forms.TextBox tb_Thang;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource bCTINHHINHMUONSACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.BCTINHHINHMUONSACHTableAdapter bCTINHHINHMUONSACHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBCMuonSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoLuotMuonDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.SimpleButton btn_TaoBaoCao;
        private System.Windows.Forms.BindingSource LOAISACHBindingSource;
        private System.Windows.Forms.BindingSource CT_BCTINHHINHMUONSACHBindingSource;
    }
}