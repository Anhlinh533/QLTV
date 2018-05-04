namespace QLTV.GUI
{
    partial class frmTKMuonSach
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
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.item_TKPhieuMuonSach = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPhieuMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_TKPhieuMuonSach = new Bunifu.Framework.UI.BunifuTileButton();
            this.dtp_HanTra = new DevExpress.XtraEditors.DateEdit();
            this.dtp_NgayMuon = new DevExpress.XtraEditors.DateEdit();
            this.tb_IDDocGia = new System.Windows.Forms.TextBox();
            this.tb_IDPhieuMuon = new System.Windows.Forms.TextBox();
            this.rdb_HanTra = new System.Windows.Forms.RadioButton();
            this.rdb_IDNgayMuon = new System.Windows.Forms.RadioButton();
            this.rdb_IDDocGia = new System.Windows.Forms.RadioButton();
            this.rdb_IDPhieuMuon = new System.Windows.Forms.RadioButton();
            this.item_TKCTPhieuMuonSach = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_TKCTPhieuMuonSach = new System.Windows.Forms.DataGridView();
            this.iDCTPhieuMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuMuonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCuonSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_TKCTPhieuMuonSach = new Bunifu.Framework.UI.BunifuTileButton();
            this.tb_IDCuonSach = new System.Windows.Forms.TextBox();
            this.tb_IDPhieuMuonSach = new System.Windows.Forms.TextBox();
            this.tb_IDCTPhieuMuonSach = new System.Windows.Forms.TextBox();
            this.rdb_IDCuonSach = new System.Windows.Forms.RadioButton();
            this.rdb_IDPhieuMuonSach = new System.Windows.Forms.RadioButton();
            this.rdb_IDCTPhieuMuon = new System.Windows.Forms.RadioButton();
            this.pHIEUMUONTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.PHIEUMUONTableAdapter();
            this.cT_PHIEUMUONTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CT_PHIEUMUONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.item_TKPhieuMuonSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_HanTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_HanTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayMuon.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayMuon.Properties)).BeginInit();
            this.item_TKCTPhieuMuonSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKCTPhieuMuonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUMUONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.item_TKPhieuMuonSach);
            this.navigationPane1.Controls.Add(this.item_TKCTPhieuMuonSach);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.item_TKPhieuMuonSach,
            this.item_TKCTPhieuMuonSach});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1659, 1083);
            this.navigationPane1.SelectedPage = this.item_TKCTPhieuMuonSach;
            this.navigationPane1.Size = new System.Drawing.Size(1659, 1083);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "`````````````````````";
            // 
            // item_TKPhieuMuonSach
            // 
            this.item_TKPhieuMuonSach.Caption = "Tìm kiếm phiếu mượn sách";
            this.item_TKPhieuMuonSach.Controls.Add(this.groupControl4);
            this.item_TKPhieuMuonSach.Controls.Add(this.groupControl3);
            this.item_TKPhieuMuonSach.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_borow_book_80;
            this.item_TKPhieuMuonSach.Name = "item_TKPhieuMuonSach";
            this.item_TKPhieuMuonSach.Size = new System.Drawing.Size(1529, 1002);
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl4.Appearance.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.dataGridView1);
            this.groupControl4.Location = new System.Drawing.Point(480, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1050, 1002);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Dữ liệu phiếu mượn sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPhieuMuonDataGridViewTextBoxColumn,
            this.iDDocGiaDataGridViewTextBoxColumn,
            this.ngayMuonDataGridViewTextBoxColumn,
            this.hanTraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pHIEUMUONBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 952);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDPhieuMuonDataGridViewTextBoxColumn
            // 
            this.iDPhieuMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDPhieuMuonDataGridViewTextBoxColumn.DataPropertyName = "IDPhieuMuon";
            this.iDPhieuMuonDataGridViewTextBoxColumn.HeaderText = "ID phiếu mượn";
            this.iDPhieuMuonDataGridViewTextBoxColumn.Name = "iDPhieuMuonDataGridViewTextBoxColumn";
            this.iDPhieuMuonDataGridViewTextBoxColumn.Width = 251;
            // 
            // iDDocGiaDataGridViewTextBoxColumn
            // 
            this.iDDocGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDocGiaDataGridViewTextBoxColumn.DataPropertyName = "IDDocGia";
            this.iDDocGiaDataGridViewTextBoxColumn.HeaderText = "ID độc giả";
            this.iDDocGiaDataGridViewTextBoxColumn.Name = "iDDocGiaDataGridViewTextBoxColumn";
            this.iDDocGiaDataGridViewTextBoxColumn.Width = 187;
            // 
            // ngayMuonDataGridViewTextBoxColumn
            // 
            this.ngayMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngayMuonDataGridViewTextBoxColumn.DataPropertyName = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.HeaderText = "Ngày mượn";
            this.ngayMuonDataGridViewTextBoxColumn.Name = "ngayMuonDataGridViewTextBoxColumn";
            this.ngayMuonDataGridViewTextBoxColumn.Width = 205;
            // 
            // hanTraDataGridViewTextBoxColumn
            // 
            this.hanTraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hanTraDataGridViewTextBoxColumn.DataPropertyName = "HanTra";
            this.hanTraDataGridViewTextBoxColumn.HeaderText = "Hạn trả";
            this.hanTraDataGridViewTextBoxColumn.Name = "hanTraDataGridViewTextBoxColumn";
            this.hanTraDataGridViewTextBoxColumn.Width = 150;
            // 
            // pHIEUMUONBindingSource
            // 
            this.pHIEUMUONBindingSource.DataMember = "PHIEUMUON";
            this.pHIEUMUONBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.btn_TKPhieuMuonSach);
            this.groupControl3.Controls.Add(this.dtp_HanTra);
            this.groupControl3.Controls.Add(this.dtp_NgayMuon);
            this.groupControl3.Controls.Add(this.tb_IDDocGia);
            this.groupControl3.Controls.Add(this.tb_IDPhieuMuon);
            this.groupControl3.Controls.Add(this.rdb_HanTra);
            this.groupControl3.Controls.Add(this.rdb_IDNgayMuon);
            this.groupControl3.Controls.Add(this.rdb_IDDocGia);
            this.groupControl3.Controls.Add(this.rdb_IDPhieuMuon);
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(474, 1002);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Tìm kiếm theo";
            // 
            // btn_TKPhieuMuonSach
            // 
            this.btn_TKPhieuMuonSach.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_TKPhieuMuonSach.color = System.Drawing.Color.SeaGreen;
            this.btn_TKPhieuMuonSach.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_TKPhieuMuonSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TKPhieuMuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_TKPhieuMuonSach.ForeColor = System.Drawing.Color.White;
            this.btn_TKPhieuMuonSach.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKPhieuMuonSach.ImagePosition = 20;
            this.btn_TKPhieuMuonSach.ImageZoom = 50;
            this.btn_TKPhieuMuonSach.LabelPosition = 41;
            this.btn_TKPhieuMuonSach.LabelText = "Tìm kiếm";
            this.btn_TKPhieuMuonSach.Location = new System.Drawing.Point(167, 321);
            this.btn_TKPhieuMuonSach.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TKPhieuMuonSach.Name = "btn_TKPhieuMuonSach";
            this.btn_TKPhieuMuonSach.Size = new System.Drawing.Size(155, 162);
            this.btn_TKPhieuMuonSach.TabIndex = 16;
            // 
            // dtp_HanTra
            // 
            this.dtp_HanTra.EditValue = null;
            this.dtp_HanTra.Location = new System.Drawing.Point(263, 248);
            this.dtp_HanTra.Name = "dtp_HanTra";
            this.dtp_HanTra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.dtp_HanTra.Properties.Appearance.Options.UseFont = true;
            this.dtp_HanTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_HanTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_HanTra.Size = new System.Drawing.Size(205, 42);
            this.dtp_HanTra.TabIndex = 7;
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.EditValue = null;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(263, 188);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.dtp_NgayMuon.Properties.Appearance.Options.UseFont = true;
            this.dtp_NgayMuon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgayMuon.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgayMuon.Size = new System.Drawing.Size(205, 42);
            this.dtp_NgayMuon.TabIndex = 6;
            // 
            // tb_IDDocGia
            // 
            this.tb_IDDocGia.Location = new System.Drawing.Point(263, 128);
            this.tb_IDDocGia.Name = "tb_IDDocGia";
            this.tb_IDDocGia.Size = new System.Drawing.Size(205, 44);
            this.tb_IDDocGia.TabIndex = 5;
            // 
            // tb_IDPhieuMuon
            // 
            this.tb_IDPhieuMuon.Location = new System.Drawing.Point(263, 68);
            this.tb_IDPhieuMuon.Name = "tb_IDPhieuMuon";
            this.tb_IDPhieuMuon.Size = new System.Drawing.Size(205, 44);
            this.tb_IDPhieuMuon.TabIndex = 4;
            // 
            // rdb_HanTra
            // 
            this.rdb_HanTra.AutoSize = true;
            this.rdb_HanTra.ForeColor = System.Drawing.Color.Red;
            this.rdb_HanTra.Location = new System.Drawing.Point(6, 249);
            this.rdb_HanTra.Name = "rdb_HanTra";
            this.rdb_HanTra.Size = new System.Drawing.Size(150, 40);
            this.rdb_HanTra.TabIndex = 3;
            this.rdb_HanTra.Text = "Hạn trả:";
            this.rdb_HanTra.UseVisualStyleBackColor = true;
            // 
            // rdb_IDNgayMuon
            // 
            this.rdb_IDNgayMuon.AutoSize = true;
            this.rdb_IDNgayMuon.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDNgayMuon.Location = new System.Drawing.Point(6, 189);
            this.rdb_IDNgayMuon.Name = "rdb_IDNgayMuon";
            this.rdb_IDNgayMuon.Size = new System.Drawing.Size(205, 40);
            this.rdb_IDNgayMuon.TabIndex = 2;
            this.rdb_IDNgayMuon.Text = "Ngày mượn:";
            this.rdb_IDNgayMuon.UseVisualStyleBackColor = true;
            // 
            // rdb_IDDocGia
            // 
            this.rdb_IDDocGia.AutoSize = true;
            this.rdb_IDDocGia.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDDocGia.Location = new System.Drawing.Point(6, 129);
            this.rdb_IDDocGia.Name = "rdb_IDDocGia";
            this.rdb_IDDocGia.Size = new System.Drawing.Size(187, 40);
            this.rdb_IDDocGia.TabIndex = 1;
            this.rdb_IDDocGia.Text = "ID độc giả:";
            this.rdb_IDDocGia.UseVisualStyleBackColor = true;
            // 
            // rdb_IDPhieuMuon
            // 
            this.rdb_IDPhieuMuon.AutoSize = true;
            this.rdb_IDPhieuMuon.Checked = true;
            this.rdb_IDPhieuMuon.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDPhieuMuon.Location = new System.Drawing.Point(6, 69);
            this.rdb_IDPhieuMuon.Name = "rdb_IDPhieuMuon";
            this.rdb_IDPhieuMuon.Size = new System.Drawing.Size(251, 40);
            this.rdb_IDPhieuMuon.TabIndex = 0;
            this.rdb_IDPhieuMuon.TabStop = true;
            this.rdb_IDPhieuMuon.Text = "ID phiếu mượn:";
            this.rdb_IDPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // item_TKCTPhieuMuonSach
            // 
            this.item_TKCTPhieuMuonSach.Caption = "Tìm kiếm chi tiết phiếu mượn sách";
            this.item_TKCTPhieuMuonSach.Controls.Add(this.groupControl2);
            this.item_TKCTPhieuMuonSach.Controls.Add(this.groupControl1);
            this.item_TKCTPhieuMuonSach.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_more_details_40;
            this.item_TKCTPhieuMuonSach.Name = "item_TKCTPhieuMuonSach";
            this.item_TKCTPhieuMuonSach.PageText = "";
            this.item_TKCTPhieuMuonSach.Size = new System.Drawing.Size(1529, 1002);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dgv_TKCTPhieuMuonSach);
            this.groupControl2.Location = new System.Drawing.Point(521, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1009, 1002);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu chi tiết phiếu mượn sách";
            // 
            // dgv_TKCTPhieuMuonSach
            // 
            this.dgv_TKCTPhieuMuonSach.AutoGenerateColumns = false;
            this.dgv_TKCTPhieuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKCTPhieuMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCTPhieuMuonDataGridViewTextBoxColumn,
            this.iDPhieuMuonDataGridViewTextBoxColumn1,
            this.iDCuonSachDataGridViewTextBoxColumn});
            this.dgv_TKCTPhieuMuonSach.DataSource = this.cTPHIEUMUONBindingSource;
            this.dgv_TKCTPhieuMuonSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TKCTPhieuMuonSach.Location = new System.Drawing.Point(3, 47);
            this.dgv_TKCTPhieuMuonSach.Name = "dgv_TKCTPhieuMuonSach";
            this.dgv_TKCTPhieuMuonSach.RowTemplate.Height = 28;
            this.dgv_TKCTPhieuMuonSach.Size = new System.Drawing.Size(1003, 952);
            this.dgv_TKCTPhieuMuonSach.TabIndex = 0;
            // 
            // iDCTPhieuMuonDataGridViewTextBoxColumn
            // 
            this.iDCTPhieuMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDCTPhieuMuonDataGridViewTextBoxColumn.DataPropertyName = "IDCTPhieuMuon";
            this.iDCTPhieuMuonDataGridViewTextBoxColumn.HeaderText = "ID chi tiết phiếu mượn";
            this.iDCTPhieuMuonDataGridViewTextBoxColumn.Name = "iDCTPhieuMuonDataGridViewTextBoxColumn";
            this.iDCTPhieuMuonDataGridViewTextBoxColumn.Width = 249;
            // 
            // iDPhieuMuonDataGridViewTextBoxColumn1
            // 
            this.iDPhieuMuonDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDPhieuMuonDataGridViewTextBoxColumn1.DataPropertyName = "IDPhieuMuon";
            this.iDPhieuMuonDataGridViewTextBoxColumn1.HeaderText = "ID phiếu mượn";
            this.iDPhieuMuonDataGridViewTextBoxColumn1.Name = "iDPhieuMuonDataGridViewTextBoxColumn1";
            this.iDPhieuMuonDataGridViewTextBoxColumn1.Width = 229;
            // 
            // iDCuonSachDataGridViewTextBoxColumn
            // 
            this.iDCuonSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDCuonSachDataGridViewTextBoxColumn.DataPropertyName = "IDCuonSach";
            this.iDCuonSachDataGridViewTextBoxColumn.HeaderText = "ID cuốn sách";
            this.iDCuonSachDataGridViewTextBoxColumn.Name = "iDCuonSachDataGridViewTextBoxColumn";
            this.iDCuonSachDataGridViewTextBoxColumn.Width = 205;
            // 
            // cTPHIEUMUONBindingSource
            // 
            this.cTPHIEUMUONBindingSource.DataMember = "CT_PHIEUMUON";
            this.cTPHIEUMUONBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_TKCTPhieuMuonSach);
            this.groupControl1.Controls.Add(this.tb_IDCuonSach);
            this.groupControl1.Controls.Add(this.tb_IDPhieuMuonSach);
            this.groupControl1.Controls.Add(this.tb_IDCTPhieuMuonSach);
            this.groupControl1.Controls.Add(this.rdb_IDCuonSach);
            this.groupControl1.Controls.Add(this.rdb_IDPhieuMuonSach);
            this.groupControl1.Controls.Add(this.rdb_IDCTPhieuMuon);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(515, 1002);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm chi tiết phiếu mượn sách theo";
            // 
            // btn_TKCTPhieuMuonSach
            // 
            this.btn_TKCTPhieuMuonSach.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_TKCTPhieuMuonSach.color = System.Drawing.Color.SeaGreen;
            this.btn_TKCTPhieuMuonSach.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_TKCTPhieuMuonSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TKCTPhieuMuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_TKCTPhieuMuonSach.ForeColor = System.Drawing.Color.White;
            this.btn_TKCTPhieuMuonSach.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKCTPhieuMuonSach.ImagePosition = 20;
            this.btn_TKCTPhieuMuonSach.ImageZoom = 50;
            this.btn_TKCTPhieuMuonSach.LabelPosition = 41;
            this.btn_TKCTPhieuMuonSach.LabelText = "Tìm kiếm";
            this.btn_TKCTPhieuMuonSach.Location = new System.Drawing.Point(152, 278);
            this.btn_TKCTPhieuMuonSach.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TKCTPhieuMuonSach.Name = "btn_TKCTPhieuMuonSach";
            this.btn_TKCTPhieuMuonSach.Size = new System.Drawing.Size(155, 162);
            this.btn_TKCTPhieuMuonSach.TabIndex = 17;
            // 
            // tb_IDCuonSach
            // 
            this.tb_IDCuonSach.Location = new System.Drawing.Point(351, 199);
            this.tb_IDCuonSach.Name = "tb_IDCuonSach";
            this.tb_IDCuonSach.Size = new System.Drawing.Size(158, 44);
            this.tb_IDCuonSach.TabIndex = 5;
            // 
            // tb_IDPhieuMuonSach
            // 
            this.tb_IDPhieuMuonSach.Location = new System.Drawing.Point(351, 139);
            this.tb_IDPhieuMuonSach.Name = "tb_IDPhieuMuonSach";
            this.tb_IDPhieuMuonSach.Size = new System.Drawing.Size(158, 44);
            this.tb_IDPhieuMuonSach.TabIndex = 4;
            // 
            // tb_IDCTPhieuMuonSach
            // 
            this.tb_IDCTPhieuMuonSach.Location = new System.Drawing.Point(351, 79);
            this.tb_IDCTPhieuMuonSach.Name = "tb_IDCTPhieuMuonSach";
            this.tb_IDCTPhieuMuonSach.Size = new System.Drawing.Size(158, 44);
            this.tb_IDCTPhieuMuonSach.TabIndex = 3;
            // 
            // rdb_IDCuonSach
            // 
            this.rdb_IDCuonSach.AutoSize = true;
            this.rdb_IDCuonSach.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDCuonSach.Location = new System.Drawing.Point(6, 200);
            this.rdb_IDCuonSach.Name = "rdb_IDCuonSach";
            this.rdb_IDCuonSach.Size = new System.Drawing.Size(213, 40);
            this.rdb_IDCuonSach.TabIndex = 2;
            this.rdb_IDCuonSach.TabStop = true;
            this.rdb_IDCuonSach.Text = "ID cuốn sách";
            this.rdb_IDCuonSach.UseVisualStyleBackColor = true;
            // 
            // rdb_IDPhieuMuonSach
            // 
            this.rdb_IDPhieuMuonSach.AutoSize = true;
            this.rdb_IDPhieuMuonSach.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDPhieuMuonSach.Location = new System.Drawing.Point(6, 140);
            this.rdb_IDPhieuMuonSach.Name = "rdb_IDPhieuMuonSach";
            this.rdb_IDPhieuMuonSach.Size = new System.Drawing.Size(240, 40);
            this.rdb_IDPhieuMuonSach.TabIndex = 1;
            this.rdb_IDPhieuMuonSach.TabStop = true;
            this.rdb_IDPhieuMuonSach.Text = "ID phiếu mượn";
            this.rdb_IDPhieuMuonSach.UseVisualStyleBackColor = true;
            // 
            // rdb_IDCTPhieuMuon
            // 
            this.rdb_IDCTPhieuMuon.AutoSize = true;
            this.rdb_IDCTPhieuMuon.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDCTPhieuMuon.Location = new System.Drawing.Point(6, 80);
            this.rdb_IDCTPhieuMuon.Name = "rdb_IDCTPhieuMuon";
            this.rdb_IDCTPhieuMuon.Size = new System.Drawing.Size(339, 40);
            this.rdb_IDCTPhieuMuon.TabIndex = 0;
            this.rdb_IDCTPhieuMuon.TabStop = true;
            this.rdb_IDCTPhieuMuon.Text = "ID chi tiết phiếu mượn";
            this.rdb_IDCTPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // pHIEUMUONTableAdapter
            // 
            this.pHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // cT_PHIEUMUONTableAdapter
            // 
            this.cT_PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // frmTKMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 1083);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmTKMuonSach";
            this.Text = "frmTKMuonSach";
            this.Load += new System.EventHandler(this.frmTKMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.item_TKPhieuMuonSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_HanTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_HanTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayMuon.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayMuon.Properties)).EndInit();
            this.item_TKCTPhieuMuonSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKCTPhieuMuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUMUONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_TKPhieuMuonSach;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraBars.Navigation.NavigationPage item_TKCTPhieuMuonSach;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource pHIEUMUONBindingSource;
        private QuanLyThuVienDataSetTableAdapters.PHIEUMUONTableAdapter pHIEUMUONTableAdapter;
        private System.Windows.Forms.RadioButton rdb_HanTra;
        private System.Windows.Forms.RadioButton rdb_IDNgayMuon;
        private System.Windows.Forms.RadioButton rdb_IDDocGia;
        private System.Windows.Forms.RadioButton rdb_IDPhieuMuon;
        private DevExpress.XtraEditors.DateEdit dtp_HanTra;
        private DevExpress.XtraEditors.DateEdit dtp_NgayMuon;
        private System.Windows.Forms.TextBox tb_IDDocGia;
        private System.Windows.Forms.TextBox tb_IDPhieuMuon;
        private Bunifu.Framework.UI.BunifuTileButton btn_TKPhieuMuonSach;
        private System.Windows.Forms.DataGridView dgv_TKCTPhieuMuonSach;
        private System.Windows.Forms.BindingSource cTPHIEUMUONBindingSource;
        private QuanLyThuVienDataSetTableAdapters.CT_PHIEUMUONTableAdapter cT_PHIEUMUONTableAdapter;
        private System.Windows.Forms.RadioButton rdb_IDCTPhieuMuon;
        private System.Windows.Forms.RadioButton rdb_IDCuonSach;
        private System.Windows.Forms.RadioButton rdb_IDPhieuMuonSach;
        private Bunifu.Framework.UI.BunifuTileButton btn_TKCTPhieuMuonSach;
        private System.Windows.Forms.TextBox tb_IDCuonSach;
        private System.Windows.Forms.TextBox tb_IDPhieuMuonSach;
        private System.Windows.Forms.TextBox tb_IDCTPhieuMuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCTPhieuMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuMuonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCuonSachDataGridViewTextBoxColumn;
    }
}