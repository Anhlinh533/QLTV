namespace QLTV.GUI
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TaoBaoCao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.designRepositoryItemComboBox1 = new DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox();
            this.recentlyUsedItemsComboBox1 = new DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox();
            this.tb_Thang = new System.Windows.Forms.TextBox();
            this.tb_Nam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.bCTINHHINHMUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCTINHHINHMUONSACHTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.BCTINHHINHMUONSACHTableAdapter();
            this.iDBCMuonSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoLuotMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCTINHHINHMUONSACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1053, 986);
            this.reportViewer1.TabIndex = 0;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(828, 832);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportViewer1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(852, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1059, 1029);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xem trước báo cáo thống kê tình hình mượn sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 875);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu thống kê được";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_Nam);
            this.groupBox1.Controls.Add(this.tb_Thang);
            this.groupBox1.Controls.Add(this.btn_TaoBaoCao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(18, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 145);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê tình hình mượn sách";
            // 
            // btn_TaoBaoCao
            // 
            this.btn_TaoBaoCao.Location = new System.Drawing.Point(618, 64);
            this.btn_TaoBaoCao.Name = "btn_TaoBaoCao";
            this.btn_TaoBaoCao.Size = new System.Drawing.Size(197, 44);
            this.btn_TaoBaoCao.TabIndex = 2;
            this.btn_TaoBaoCao.Text = "Tạo báo cáo";
            this.btn_TaoBaoCao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(499, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(880, 60);
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
            // tb_Thang
            // 
            this.tb_Thang.Location = new System.Drawing.Point(123, 67);
            this.tb_Thang.Name = "tb_Thang";
            this.tb_Thang.Size = new System.Drawing.Size(156, 44);
            this.tb_Thang.TabIndex = 3;
            // 
            // tb_Nam
            // 
            this.tb_Nam.Location = new System.Drawing.Point(425, 67);
            this.tb_Nam.Name = "tb_Nam";
            this.tb_Nam.Size = new System.Drawing.Size(155, 44);
            this.tb_Nam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Năm:";
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bCTINHHINHMUONSACHBindingSource
            // 
            this.bCTINHHINHMUONSACHBindingSource.DataMember = "BCTINHHINHMUONSACH";
            this.bCTINHHINHMUONSACHBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // bCTINHHINHMUONSACHTableAdapter
            // 
            this.bCTINHHINHMUONSACHTableAdapter.ClearBeforeFill = true;
            // 
            // iDBCMuonSachDataGridViewTextBoxColumn
            // 
            this.iDBCMuonSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDBCMuonSachDataGridViewTextBoxColumn.DataPropertyName = "IDBCMuonSach";
            this.iDBCMuonSachDataGridViewTextBoxColumn.HeaderText = "ID báo cáo mượn sách";
            this.iDBCMuonSachDataGridViewTextBoxColumn.Name = "iDBCMuonSachDataGridViewTextBoxColumn";
            this.iDBCMuonSachDataGridViewTextBoxColumn.Width = 264;
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "Thang";
            this.thangDataGridViewTextBoxColumn.HeaderText = "Tháng";
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            this.thangDataGridViewTextBoxColumn.Width = 136;
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Năm";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            this.namDataGridViewTextBoxColumn.Width = 112;
            // 
            // tongSoLuotMuonDataGridViewTextBoxColumn
            // 
            this.tongSoLuotMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tongSoLuotMuonDataGridViewTextBoxColumn.DataPropertyName = "TongSoLuotMuon";
            this.tongSoLuotMuonDataGridViewTextBoxColumn.HeaderText = "Tổng số lượt mượn";
            this.tongSoLuotMuonDataGridViewTextBoxColumn.Name = "tongSoLuotMuonDataGridViewTextBoxColumn";
            this.tongSoLuotMuonDataGridViewTextBoxColumn.Width = 207;
            // 
            // frmReportTinhHinhMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1153);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmReportTinhHinhMuonSach";
            this.Text = "frmReportTinhHinhMuonSach";
            this.Load += new System.EventHandler(this.frmReportTinhHinhMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCTINHHINHMUONSACHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TaoBaoCao;
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
    }
}