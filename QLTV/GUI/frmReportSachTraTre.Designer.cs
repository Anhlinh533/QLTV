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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportSachTraTre));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener1 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            this.xrDesignBarManager1 = new DevExpress.XtraReports.UserDesigner.XRDesignBarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.recentlyUsedItemsComboBox1 = new DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox();
            this.designRepositoryItemComboBox1 = new DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportDesigner1 = new DevExpress.XtraReports.UserDesigner.XRDesignMdiController(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.bCSACHTRATREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCSACHTRATRETableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.BCSACHTRATRETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCSACHTRATREBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xrDesignBarManager1
            // 
            this.xrDesignBarManager1.DockControls.Add(this.barDockControlTop);
            this.xrDesignBarManager1.DockControls.Add(this.barDockControlBottom);
            this.xrDesignBarManager1.DockControls.Add(this.barDockControlLeft);
            this.xrDesignBarManager1.DockControls.Add(this.barDockControlRight);
            this.xrDesignBarManager1.FontNameBox = this.recentlyUsedItemsComboBox1;
            this.xrDesignBarManager1.FontNameEdit = null;
            this.xrDesignBarManager1.FontSizeBox = this.designRepositoryItemComboBox1;
            this.xrDesignBarManager1.FontSizeEdit = null;
            this.xrDesignBarManager1.Form = this;
            this.xrDesignBarManager1.FormattingToolbar = null;
            this.xrDesignBarManager1.HintStaticItem = null;
            this.xrDesignBarManager1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("xrDesignBarManager1.ImageStream")));
            this.xrDesignBarManager1.LayoutToolbar = null;
            this.xrDesignBarManager1.MaxItemId = 76;
            this.xrDesignBarManager1.Toolbar = null;
            this.xrDesignBarManager1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            this.xrDesignBarManager1.Updates.AddRange(new string[] {
            "Toolbox"});
            this.xrDesignBarManager1.ZoomItem = null;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.xrDesignBarManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1925, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1086);
            this.barDockControlBottom.Manager = this.xrDesignBarManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1925, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.xrDesignBarManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1086);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1925, 0);
            this.barDockControlRight.Manager = this.xrDesignBarManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1086);
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Right;
            reportDataSource1.Name = "rpSACHTRATRE";
            reportDataSource1.Value = this.bCSACHTRATREBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLTV.REPORT.rpSachTraTre.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(342, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1583, 1086);
            this.reportViewer1.TabIndex = 1;
            // 
            // reportDesigner1
            // 
            this.reportDesigner1.ContainerControl = null;
            xrDesignPanelListener1.DesignControl = this.xrDesignBarManager1;
            this.reportDesigner1.DesignPanelListeners.AddRange(new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener[] {
            xrDesignPanelListener1});
            this.reportDesigner1.Form = this;
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
            // frmReportSachTraTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1925, 1086);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmReportSachTraTre";
            this.Text = "frmReportSachTraTre";
            this.Load += new System.EventHandler(this.frmReportSachTraTre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCSACHTRATREBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraReports.UserDesigner.XRDesignMdiController reportDesigner1;
        private DevExpress.XtraReports.UserDesigner.XRDesignBarManager xrDesignBarManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox recentlyUsedItemsComboBox1;
        private DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox designRepositoryItemComboBox1;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource bCSACHTRATREBindingSource;
        private QuanLyThuVienDataSetTableAdapters.BCSACHTRATRETableAdapter bCSACHTRATRETableAdapter;
    }
}