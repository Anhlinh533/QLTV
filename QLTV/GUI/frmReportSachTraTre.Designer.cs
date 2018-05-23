namespace QLTV.GUI
{
    partial class frmReportSachTraTre
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
            this.recentlyUsedItemsComboBox1 = new DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox();
            this.designRepositoryItemComboBox1 = new DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_NgayThangNam = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_TaoBaoCao = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.bCSACHTRATREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCSACHTRATRETableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.BCSACHTRATRETableAdapter();
            this.iDBCSachTreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThangNamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCuonSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayTraTreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCSACHTRATREBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // designRepositoryItemComboBox1
            // 
            this.designRepositoryItemComboBox1.AutoHeight = false;
            this.designRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.designRepositoryItemComboBox1.Name = "designRepositoryItemComboBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(550, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Báo cáo thống kê sách trả trễ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_TaoBaoCao);
            this.groupBox1.Controls.Add(this.dtp_NgayThangNam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê sách trả trễ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày tháng năm:";
            // 
            // dtp_NgayThangNam
            // 
            this.dtp_NgayThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayThangNam.Location = new System.Drawing.Point(336, 64);
            this.dtp_NgayThangNam.Name = "dtp_NgayThangNam";
            this.dtp_NgayThangNam.Size = new System.Drawing.Size(259, 44);
            this.dtp_NgayThangNam.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 795);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu thống kê được";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportViewer1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(854, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1059, 949);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xem trước báo cáo thống kê sách trả trễ";
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBCSachTreDataGridViewTextBoxColumn,
            this.ngayThangNamDataGridViewTextBoxColumn,
            this.iDCuonSachDataGridViewTextBoxColumn,
            this.iDPhieuMuonDataGridViewTextBoxColumn,
            this.soNgayTraTreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bCSACHTRATREBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(830, 752);
            this.dataGridView1.TabIndex = 0;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bCSACHTRATREBindingSource
            // 
            this.bCSACHTRATREBindingSource.DataMember = "BCSACHTRATRE";
            this.bCSACHTRATREBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // bCSACHTRATRETableAdapter
            // 
            this.bCSACHTRATRETableAdapter.ClearBeforeFill = true;
            // 
            // iDBCSachTreDataGridViewTextBoxColumn
            // 
            this.iDBCSachTreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDBCSachTreDataGridViewTextBoxColumn.DataPropertyName = "IDBCSachTre";
            this.iDBCSachTreDataGridViewTextBoxColumn.HeaderText = "IDBCSachTre";
            this.iDBCSachTreDataGridViewTextBoxColumn.Name = "iDBCSachTreDataGridViewTextBoxColumn";
            this.iDBCSachTreDataGridViewTextBoxColumn.Width = 227;
            // 
            // ngayThangNamDataGridViewTextBoxColumn
            // 
            this.ngayThangNamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ngayThangNamDataGridViewTextBoxColumn.DataPropertyName = "NgayThangNam";
            this.ngayThangNamDataGridViewTextBoxColumn.HeaderText = "Ngày tháng năm";
            this.ngayThangNamDataGridViewTextBoxColumn.Name = "ngayThangNamDataGridViewTextBoxColumn";
            this.ngayThangNamDataGridViewTextBoxColumn.Width = 196;
            // 
            // iDCuonSachDataGridViewTextBoxColumn
            // 
            this.iDCuonSachDataGridViewTextBoxColumn.DataPropertyName = "IDCuonSach";
            this.iDCuonSachDataGridViewTextBoxColumn.HeaderText = "ID cuốn sách";
            this.iDCuonSachDataGridViewTextBoxColumn.Name = "iDCuonSachDataGridViewTextBoxColumn";
            // 
            // iDPhieuMuonDataGridViewTextBoxColumn
            // 
            this.iDPhieuMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDPhieuMuonDataGridViewTextBoxColumn.DataPropertyName = "IDPhieuMuon";
            this.iDPhieuMuonDataGridViewTextBoxColumn.HeaderText = "ID phiếu mượn";
            this.iDPhieuMuonDataGridViewTextBoxColumn.Name = "iDPhieuMuonDataGridViewTextBoxColumn";
            this.iDPhieuMuonDataGridViewTextBoxColumn.Width = 160;
            // 
            // soNgayTraTreDataGridViewTextBoxColumn
            // 
            this.soNgayTraTreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.soNgayTraTreDataGridViewTextBoxColumn.DataPropertyName = "SoNgayTraTre";
            this.soNgayTraTreDataGridViewTextBoxColumn.HeaderText = "Số ngày trả trễ";
            this.soNgayTraTreDataGridViewTextBoxColumn.Name = "soNgayTraTreDataGridViewTextBoxColumn";
            this.soNgayTraTreDataGridViewTextBoxColumn.Width = 153;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1053, 906);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReportSachTraTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1925, 1086);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmReportSachTraTre";
            this.Text = "frmReportSachTraTre";
            this.Load += new System.EventHandler(this.frmReportSachTraTre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCSACHTRATREBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox recentlyUsedItemsComboBox1;
        private DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox designRepositoryItemComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TaoBaoCao;
        private System.Windows.Forms.DateTimePicker dtp_NgayThangNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource bCSACHTRATREBindingSource;
        private QuanLyThuVienDataSetTableAdapters.BCSACHTRATRETableAdapter bCSACHTRATRETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBCSachTreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThangNamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCuonSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayTraTreDataGridViewTextBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}