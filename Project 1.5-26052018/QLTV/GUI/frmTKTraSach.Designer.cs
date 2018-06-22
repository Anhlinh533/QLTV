namespace QLTV.GUI
{
    partial class frmTKTraSach
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
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Xuat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.dgv_TKTraSach = new System.Windows.Forms.DataGridView();
            this.iDPhieuTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienPhatKyNayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienNoKyNayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_PhieuTraSach = new DevExpress.XtraEditors.SimpleButton();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.tb_TienNoKiNay = new System.Windows.Forms.TextBox();
            this.tb_SoTienTra = new System.Windows.Forms.TextBox();
            this.tb_IDPhieuTra = new System.Windows.Forms.TextBox();
            this.tb_IDDocGia = new System.Windows.Forms.TextBox();
            this.tb_TienPhatKiNay = new System.Windows.Forms.TextBox();
            this.rdb_TienNoKiNay = new System.Windows.Forms.RadioButton();
            this.rdb_SoTienTra = new System.Windows.Forms.RadioButton();
            this.rdb_TienPhatKiNay = new System.Windows.Forms.RadioButton();
            this.rdb_NgayTra = new System.Windows.Forms.RadioButton();
            this.rdb_IDDocGia = new System.Windows.Forms.RadioButton();
            this.rdb_IDPhieuTra = new System.Windows.Forms.RadioButton();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_LuuCTPT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_XoaCTPT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_XuatCTTraSach = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ResetCTPT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.dgv_TKCTPhieuTraSach = new System.Windows.Forms.DataGridView();
            this.iDCTPhieuTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuTraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienPhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPHIEUTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_TKCTPhieuTraSach = new DevExpress.XtraEditors.SimpleButton();
            this.tb_TienPhat = new System.Windows.Forms.TextBox();
            this.tb_SoNgayMuon = new System.Windows.Forms.TextBox();
            this.tb_IDCTPhieuMuon = new System.Windows.Forms.TextBox();
            this.tb_IDPhieuTraCT = new System.Windows.Forms.TextBox();
            this.tb_IDCTPhieuTra = new System.Windows.Forms.TextBox();
            this.rdb_TienPhat = new System.Windows.Forms.RadioButton();
            this.rdb_SoNgayMuon = new System.Windows.Forms.RadioButton();
            this.rdb_IDPhieuMuon = new System.Windows.Forms.RadioButton();
            this.rdb_IDPhieuTraCT = new System.Windows.Forms.RadioButton();
            this.rdb_IDCTPhieuTra = new System.Windows.Forms.RadioButton();
            this.pHIEUTRATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.PHIEUTRATableAdapter();
            this.cT_PHIEUTRATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CT_PHIEUTRATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKTraSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKCTPhieuTraSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUTRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1370, 748);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(1370, 748);
            this.navigationPane1.TabIndex = 1;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Tìm kiếm thông tin trả sách";
            this.navigationPage1.Controls.Add(this.groupControl4);
            this.navigationPage1.Controls.Add(this.groupControl3);
            this.navigationPage1.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_book_64;
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1256, 668);
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
            this.groupControl4.Controls.Add(this.bindingNavigator1);
            this.groupControl4.Controls.Add(this.dgv_TKTraSach);
            this.groupControl4.Location = new System.Drawing.Point(520, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(763, 696);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Dữ liệu thông tin mượn sách";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Luu,
            this.toolStripSeparator4,
            this.btn_Xoa,
            this.toolStripSeparator9,
            this.btn_Xuat,
            this.toolStripSeparator2,
            this.btn_Reset,
            this.toolStripSeparator3,
            this.btn_Exit});
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 45);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(759, 35);
            this.bindingNavigator1.TabIndex = 14;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Luu.ForeColor = System.Drawing.Color.Red;
            this.btn_Luu.Image = global::QLTV.Properties.Resources.diskette;
            this.btn_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(72, 32);
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Image = global::QLTV.Properties.Resources.icons8_cancel_80;
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(74, 32);
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.ForeColor = System.Drawing.Color.Red;
            this.btn_Xuat.Image = global::QLTV.Properties.Resources.icons8_export_csv_40;
            this.btn_Xuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(120, 32);
            this.btn_Xuat.Text = "Xuất CSV";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_Reset
            // 
            this.btn_Reset.ForeColor = System.Drawing.Color.Red;
            this.btn_Reset.Image = global::QLTV.Properties.Resources.icons8_available_updates_40;
            this.btn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(151, 32);
            this.btn_Reset.Text = "Reset dữ liệu";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Image = global::QLTV.Properties.Resources.icons8_shutdown_80;
            this.btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(90, 32);
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dgv_TKTraSach
            // 
            this.dgv_TKTraSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TKTraSach.AutoGenerateColumns = false;
            this.dgv_TKTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKTraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPhieuTraDataGridViewTextBoxColumn,
            this.iDDocGiaDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.tienPhatKyNayDataGridViewTextBoxColumn,
            this.soTienTraDataGridViewTextBoxColumn,
            this.tienNoKyNayDataGridViewTextBoxColumn});
            this.dgv_TKTraSach.DataSource = this.pHIEUTRABindingSource;
            this.dgv_TKTraSach.Location = new System.Drawing.Point(2, 92);
            this.dgv_TKTraSach.Name = "dgv_TKTraSach";
            this.dgv_TKTraSach.RowTemplate.Height = 28;
            this.dgv_TKTraSach.Size = new System.Drawing.Size(758, 603);
            this.dgv_TKTraSach.TabIndex = 0;
            this.dgv_TKTraSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TKTraSach_CellValueChanged);
            // 
            // iDPhieuTraDataGridViewTextBoxColumn
            // 
            this.iDPhieuTraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDPhieuTraDataGridViewTextBoxColumn.DataPropertyName = "IDPhieuTra";
            this.iDPhieuTraDataGridViewTextBoxColumn.HeaderText = "ID phiếu trả";
            this.iDPhieuTraDataGridViewTextBoxColumn.Name = "iDPhieuTraDataGridViewTextBoxColumn";
            this.iDPhieuTraDataGridViewTextBoxColumn.Width = 193;
            // 
            // iDDocGiaDataGridViewTextBoxColumn
            // 
            this.iDDocGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDocGiaDataGridViewTextBoxColumn.DataPropertyName = "IDDocGia";
            this.iDDocGiaDataGridViewTextBoxColumn.HeaderText = "ID độc giả";
            this.iDDocGiaDataGridViewTextBoxColumn.Name = "iDDocGiaDataGridViewTextBoxColumn";
            this.iDDocGiaDataGridViewTextBoxColumn.Width = 171;
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "Ngày trả";
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            this.ngayTraDataGridViewTextBoxColumn.Width = 152;
            // 
            // tienPhatKyNayDataGridViewTextBoxColumn
            // 
            this.tienPhatKyNayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tienPhatKyNayDataGridViewTextBoxColumn.DataPropertyName = "TienPhatKyNay";
            this.tienPhatKyNayDataGridViewTextBoxColumn.HeaderText = "Tiền phạt kì này";
            this.tienPhatKyNayDataGridViewTextBoxColumn.Name = "tienPhatKyNayDataGridViewTextBoxColumn";
            this.tienPhatKyNayDataGridViewTextBoxColumn.Width = 199;
            // 
            // soTienTraDataGridViewTextBoxColumn
            // 
            this.soTienTraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soTienTraDataGridViewTextBoxColumn.DataPropertyName = "SoTienTra";
            this.soTienTraDataGridViewTextBoxColumn.HeaderText = "Số tiền trả";
            this.soTienTraDataGridViewTextBoxColumn.Name = "soTienTraDataGridViewTextBoxColumn";
            this.soTienTraDataGridViewTextBoxColumn.Width = 173;
            // 
            // tienNoKyNayDataGridViewTextBoxColumn
            // 
            this.tienNoKyNayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tienNoKyNayDataGridViewTextBoxColumn.DataPropertyName = "TienNoKyNay";
            this.tienNoKyNayDataGridViewTextBoxColumn.HeaderText = "Tiền nợ kì này";
            this.tienNoKyNayDataGridViewTextBoxColumn.Name = "tienNoKyNayDataGridViewTextBoxColumn";
            this.tienNoKyNayDataGridViewTextBoxColumn.Width = 176;
            // 
            // pHIEUTRABindingSource
            // 
            this.pHIEUTRABindingSource.DataMember = "PHIEUTRA";
            this.pHIEUTRABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.btn_PhieuTraSach);
            this.groupControl3.Controls.Add(this.dtp_NgayTra);
            this.groupControl3.Controls.Add(this.tb_TienNoKiNay);
            this.groupControl3.Controls.Add(this.tb_SoTienTra);
            this.groupControl3.Controls.Add(this.tb_IDPhieuTra);
            this.groupControl3.Controls.Add(this.tb_IDDocGia);
            this.groupControl3.Controls.Add(this.tb_TienPhatKiNay);
            this.groupControl3.Controls.Add(this.rdb_TienNoKiNay);
            this.groupControl3.Controls.Add(this.rdb_SoTienTra);
            this.groupControl3.Controls.Add(this.rdb_TienPhatKiNay);
            this.groupControl3.Controls.Add(this.rdb_NgayTra);
            this.groupControl3.Controls.Add(this.rdb_IDDocGia);
            this.groupControl3.Controls.Add(this.rdb_IDPhieuTra);
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(514, 696);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Tìm kiếm theo";
            // 
            // btn_PhieuTraSach
            // 
            this.btn_PhieuTraSach.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_PhieuTraSach.Appearance.Options.UseFont = true;
            this.btn_PhieuTraSach.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_PhieuTraSach.Location = new System.Drawing.Point(156, 455);
            this.btn_PhieuTraSach.Name = "btn_PhieuTraSach";
            this.btn_PhieuTraSach.Size = new System.Drawing.Size(196, 80);
            this.btn_PhieuTraSach.TabIndex = 20;
            this.btn_PhieuTraSach.Text = "Tìm kiếm";
            this.btn_PhieuTraSach.Click += new System.EventHandler(this.btn_TKPhieuTraSach_Click);
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTra.Location = new System.Drawing.Point(267, 190);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(202, 44);
            this.dtp_NgayTra.TabIndex = 3;
            // 
            // tb_TienNoKiNay
            // 
            this.tb_TienNoKiNay.Location = new System.Drawing.Point(267, 373);
            this.tb_TienNoKiNay.Name = "tb_TienNoKiNay";
            this.tb_TienNoKiNay.Size = new System.Drawing.Size(202, 44);
            this.tb_TienNoKiNay.TabIndex = 6;
            this.tb_TienNoKiNay.Click += new System.EventHandler(this.tb_TienNoKiNay_Click);
            this.tb_TienNoKiNay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_SoTienTra
            // 
            this.tb_SoTienTra.Location = new System.Drawing.Point(267, 313);
            this.tb_SoTienTra.Name = "tb_SoTienTra";
            this.tb_SoTienTra.Size = new System.Drawing.Size(202, 44);
            this.tb_SoTienTra.TabIndex = 5;
            this.tb_SoTienTra.Click += new System.EventHandler(this.tb_SoTienTra_Click);
            this.tb_SoTienTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_IDPhieuTra
            // 
            this.tb_IDPhieuTra.Location = new System.Drawing.Point(267, 73);
            this.tb_IDPhieuTra.Name = "tb_IDPhieuTra";
            this.tb_IDPhieuTra.Size = new System.Drawing.Size(202, 44);
            this.tb_IDPhieuTra.TabIndex = 1;
            this.tb_IDPhieuTra.Click += new System.EventHandler(this.tb_IDPhieuTra_Click);
            this.tb_IDPhieuTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_IDDocGia
            // 
            this.tb_IDDocGia.Location = new System.Drawing.Point(267, 133);
            this.tb_IDDocGia.Name = "tb_IDDocGia";
            this.tb_IDDocGia.Size = new System.Drawing.Size(202, 44);
            this.tb_IDDocGia.TabIndex = 2;
            this.tb_IDDocGia.Click += new System.EventHandler(this.tb_IDDocGia_Click);
            this.tb_IDDocGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_TienPhatKiNay
            // 
            this.tb_TienPhatKiNay.Location = new System.Drawing.Point(267, 253);
            this.tb_TienPhatKiNay.Name = "tb_TienPhatKiNay";
            this.tb_TienPhatKiNay.Size = new System.Drawing.Size(202, 44);
            this.tb_TienPhatKiNay.TabIndex = 4;
            this.tb_TienPhatKiNay.Click += new System.EventHandler(this.tb_TienPhatKiNay_Click);
            this.tb_TienPhatKiNay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // rdb_TienNoKiNay
            // 
            this.rdb_TienNoKiNay.AutoSize = true;
            this.rdb_TienNoKiNay.ForeColor = System.Drawing.Color.Red;
            this.rdb_TienNoKiNay.Location = new System.Drawing.Point(6, 374);
            this.rdb_TienNoKiNay.Name = "rdb_TienNoKiNay";
            this.rdb_TienNoKiNay.Size = new System.Drawing.Size(229, 40);
            this.rdb_TienNoKiNay.TabIndex = 5;
            this.rdb_TienNoKiNay.TabStop = true;
            this.rdb_TienNoKiNay.Text = "Tiền nợ kì này";
            this.rdb_TienNoKiNay.UseVisualStyleBackColor = true;
            // 
            // rdb_SoTienTra
            // 
            this.rdb_SoTienTra.AutoSize = true;
            this.rdb_SoTienTra.ForeColor = System.Drawing.Color.Red;
            this.rdb_SoTienTra.Location = new System.Drawing.Point(6, 314);
            this.rdb_SoTienTra.Name = "rdb_SoTienTra";
            this.rdb_SoTienTra.Size = new System.Drawing.Size(178, 40);
            this.rdb_SoTienTra.TabIndex = 4;
            this.rdb_SoTienTra.TabStop = true;
            this.rdb_SoTienTra.Text = "Số tiền trả";
            this.rdb_SoTienTra.UseVisualStyleBackColor = true;
            // 
            // rdb_TienPhatKiNay
            // 
            this.rdb_TienPhatKiNay.AutoSize = true;
            this.rdb_TienPhatKiNay.ForeColor = System.Drawing.Color.Red;
            this.rdb_TienPhatKiNay.Location = new System.Drawing.Point(6, 254);
            this.rdb_TienPhatKiNay.Name = "rdb_TienPhatKiNay";
            this.rdb_TienPhatKiNay.Size = new System.Drawing.Size(255, 40);
            this.rdb_TienPhatKiNay.TabIndex = 3;
            this.rdb_TienPhatKiNay.TabStop = true;
            this.rdb_TienPhatKiNay.Text = "Tiền phạt kì này";
            this.rdb_TienPhatKiNay.UseVisualStyleBackColor = true;
            // 
            // rdb_NgayTra
            // 
            this.rdb_NgayTra.AutoSize = true;
            this.rdb_NgayTra.ForeColor = System.Drawing.Color.Red;
            this.rdb_NgayTra.Location = new System.Drawing.Point(6, 194);
            this.rdb_NgayTra.Name = "rdb_NgayTra";
            this.rdb_NgayTra.Size = new System.Drawing.Size(154, 40);
            this.rdb_NgayTra.TabIndex = 2;
            this.rdb_NgayTra.TabStop = true;
            this.rdb_NgayTra.Text = "Ngày trả";
            this.rdb_NgayTra.UseVisualStyleBackColor = true;
            // 
            // rdb_IDDocGia
            // 
            this.rdb_IDDocGia.AutoSize = true;
            this.rdb_IDDocGia.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDDocGia.Location = new System.Drawing.Point(6, 134);
            this.rdb_IDDocGia.Name = "rdb_IDDocGia";
            this.rdb_IDDocGia.Size = new System.Drawing.Size(176, 40);
            this.rdb_IDDocGia.TabIndex = 1;
            this.rdb_IDDocGia.TabStop = true;
            this.rdb_IDDocGia.Text = "ID độc giả";
            this.rdb_IDDocGia.UseVisualStyleBackColor = true;
            // 
            // rdb_IDPhieuTra
            // 
            this.rdb_IDPhieuTra.AutoSize = true;
            this.rdb_IDPhieuTra.Checked = true;
            this.rdb_IDPhieuTra.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDPhieuTra.Location = new System.Drawing.Point(6, 75);
            this.rdb_IDPhieuTra.Name = "rdb_IDPhieuTra";
            this.rdb_IDPhieuTra.Size = new System.Drawing.Size(200, 40);
            this.rdb_IDPhieuTra.TabIndex = 0;
            this.rdb_IDPhieuTra.TabStop = true;
            this.rdb_IDPhieuTra.Text = "ID phiếu trả";
            this.rdb_IDPhieuTra.UseVisualStyleBackColor = true;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Tìm kiếm thông tin chi tiết phiếu trả sách";
            this.navigationPage2.Controls.Add(this.groupControl2);
            this.navigationPage2.Controls.Add(this.groupControl1);
            this.navigationPage2.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_book_40;
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1256, 668);
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
            this.groupControl2.Controls.Add(this.bindingNavigator2);
            this.groupControl2.Controls.Add(this.dgv_TKCTPhieuTraSach);
            this.groupControl2.Location = new System.Drawing.Point(578, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(680, 668);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu thông tin chi tiết phiếu trả sách";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_LuuCTPT,
            this.toolStripSeparator5,
            this.btn_XoaCTPT,
            this.toolStripSeparator1,
            this.btn_XuatCTTraSach,
            this.toolStripSeparator7,
            this.btn_ResetCTPT,
            this.toolStripSeparator8,
            this.toolStripButton5});
            this.bindingNavigator2.Location = new System.Drawing.Point(2, 45);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(676, 35);
            this.bindingNavigator2.TabIndex = 14;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // btn_LuuCTPT
            // 
            this.btn_LuuCTPT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_LuuCTPT.ForeColor = System.Drawing.Color.Red;
            this.btn_LuuCTPT.Image = global::QLTV.Properties.Resources.diskette;
            this.btn_LuuCTPT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_LuuCTPT.Name = "btn_LuuCTPT";
            this.btn_LuuCTPT.Size = new System.Drawing.Size(72, 32);
            this.btn_LuuCTPT.Text = "Lưu";
            this.btn_LuuCTPT.Click += new System.EventHandler(this.btn_LuuCTPT_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_XoaCTPT
            // 
            this.btn_XoaCTPT.ForeColor = System.Drawing.Color.Red;
            this.btn_XoaCTPT.Image = global::QLTV.Properties.Resources.icons8_cancel_80;
            this.btn_XoaCTPT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XoaCTPT.Name = "btn_XoaCTPT";
            this.btn_XoaCTPT.Size = new System.Drawing.Size(74, 32);
            this.btn_XoaCTPT.Text = "Xóa";
            this.btn_XoaCTPT.Click += new System.EventHandler(this.btn_XoaCTPT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_XuatCTTraSach
            // 
            this.btn_XuatCTTraSach.ForeColor = System.Drawing.Color.Red;
            this.btn_XuatCTTraSach.Image = global::QLTV.Properties.Resources.icons8_export_csv_40;
            this.btn_XuatCTTraSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XuatCTTraSach.Name = "btn_XuatCTTraSach";
            this.btn_XuatCTTraSach.Size = new System.Drawing.Size(120, 32);
            this.btn_XuatCTTraSach.Text = "Xuất CSV";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_ResetCTPT
            // 
            this.btn_ResetCTPT.ForeColor = System.Drawing.Color.Red;
            this.btn_ResetCTPT.Image = global::QLTV.Properties.Resources.icons8_available_updates_40;
            this.btn_ResetCTPT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ResetCTPT.Name = "btn_ResetCTPT";
            this.btn_ResetCTPT.Size = new System.Drawing.Size(151, 32);
            this.btn_ResetCTPT.Text = "Reset dữ liệu";
            this.btn_ResetCTPT.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ForeColor = System.Drawing.Color.Red;
            this.toolStripButton5.Image = global::QLTV.Properties.Resources.icons8_shutdown_80;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(90, 32);
            this.toolStripButton5.Text = "Thoát";
            this.toolStripButton5.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dgv_TKCTPhieuTraSach
            // 
            this.dgv_TKCTPhieuTraSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TKCTPhieuTraSach.AutoGenerateColumns = false;
            this.dgv_TKCTPhieuTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKCTPhieuTraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCTPhieuTraDataGridViewTextBoxColumn,
            this.iDPhieuTraDataGridViewTextBoxColumn1,
            this.IDCuonSach,
            this.iDPhieuMuonDataGridViewTextBoxColumn,
            this.soNgayMuonDataGridViewTextBoxColumn,
            this.tienPhatDataGridViewTextBoxColumn});
            this.dgv_TKCTPhieuTraSach.DataSource = this.cTPHIEUTRABindingSource;
            this.dgv_TKCTPhieuTraSach.Location = new System.Drawing.Point(2, 94);
            this.dgv_TKCTPhieuTraSach.Name = "dgv_TKCTPhieuTraSach";
            this.dgv_TKCTPhieuTraSach.RowTemplate.Height = 28;
            this.dgv_TKCTPhieuTraSach.Size = new System.Drawing.Size(674, 570);
            this.dgv_TKCTPhieuTraSach.TabIndex = 0;
            this.dgv_TKCTPhieuTraSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TKCTPhieuTraSach_CellValueChanged);
            // 
            // iDCTPhieuTraDataGridViewTextBoxColumn
            // 
            this.iDCTPhieuTraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDCTPhieuTraDataGridViewTextBoxColumn.DataPropertyName = "IDCTPhieuTra";
            this.iDCTPhieuTraDataGridViewTextBoxColumn.HeaderText = "ID chi tiết phiếu trả";
            this.iDCTPhieuTraDataGridViewTextBoxColumn.Name = "iDCTPhieuTraDataGridViewTextBoxColumn";
            this.iDCTPhieuTraDataGridViewTextBoxColumn.Width = 249;
            // 
            // iDPhieuTraDataGridViewTextBoxColumn1
            // 
            this.iDPhieuTraDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDPhieuTraDataGridViewTextBoxColumn1.DataPropertyName = "IDPhieuTra";
            this.iDPhieuTraDataGridViewTextBoxColumn1.HeaderText = "ID phiếu trả";
            this.iDPhieuTraDataGridViewTextBoxColumn1.Name = "iDPhieuTraDataGridViewTextBoxColumn1";
            this.iDPhieuTraDataGridViewTextBoxColumn1.Width = 193;
            // 
            // IDCuonSach
            // 
            this.IDCuonSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDCuonSach.DataPropertyName = "IDCuonSach";
            this.IDCuonSach.HeaderText = "ID cuốn sách";
            this.IDCuonSach.Name = "IDCuonSach";
            this.IDCuonSach.Width = 205;
            // 
            // iDPhieuMuonDataGridViewTextBoxColumn
            // 
            this.iDPhieuMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDPhieuMuonDataGridViewTextBoxColumn.DataPropertyName = "IDPhieuMuon";
            this.iDPhieuMuonDataGridViewTextBoxColumn.HeaderText = "ID phiếu mượn";
            this.iDPhieuMuonDataGridViewTextBoxColumn.Name = "iDPhieuMuonDataGridViewTextBoxColumn";
            this.iDPhieuMuonDataGridViewTextBoxColumn.Width = 229;
            // 
            // soNgayMuonDataGridViewTextBoxColumn
            // 
            this.soNgayMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soNgayMuonDataGridViewTextBoxColumn.DataPropertyName = "SoNgayMuon";
            this.soNgayMuonDataGridViewTextBoxColumn.HeaderText = "Số ngày mượn";
            this.soNgayMuonDataGridViewTextBoxColumn.Name = "soNgayMuonDataGridViewTextBoxColumn";
            this.soNgayMuonDataGridViewTextBoxColumn.Width = 223;
            // 
            // tienPhatDataGridViewTextBoxColumn
            // 
            this.tienPhatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tienPhatDataGridViewTextBoxColumn.DataPropertyName = "TienPhat";
            this.tienPhatDataGridViewTextBoxColumn.HeaderText = "Tiền phạt";
            this.tienPhatDataGridViewTextBoxColumn.Name = "tienPhatDataGridViewTextBoxColumn";
            this.tienPhatDataGridViewTextBoxColumn.Width = 163;
            // 
            // cTPHIEUTRABindingSource
            // 
            this.cTPHIEUTRABindingSource.DataMember = "CT_PHIEUTRA";
            this.cTPHIEUTRABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_TKCTPhieuTraSach);
            this.groupControl1.Controls.Add(this.tb_TienPhat);
            this.groupControl1.Controls.Add(this.tb_SoNgayMuon);
            this.groupControl1.Controls.Add(this.tb_IDCTPhieuMuon);
            this.groupControl1.Controls.Add(this.tb_IDPhieuTraCT);
            this.groupControl1.Controls.Add(this.tb_IDCTPhieuTra);
            this.groupControl1.Controls.Add(this.rdb_TienPhat);
            this.groupControl1.Controls.Add(this.rdb_SoNgayMuon);
            this.groupControl1.Controls.Add(this.rdb_IDPhieuMuon);
            this.groupControl1.Controls.Add(this.rdb_IDPhieuTraCT);
            this.groupControl1.Controls.Add(this.rdb_IDCTPhieuTra);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(572, 668);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm theo";
            // 
            // btn_TKCTPhieuTraSach
            // 
            this.btn_TKCTPhieuTraSach.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_TKCTPhieuTraSach.Appearance.Options.UseFont = true;
            this.btn_TKCTPhieuTraSach.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKCTPhieuTraSach.Location = new System.Drawing.Point(172, 408);
            this.btn_TKCTPhieuTraSach.Name = "btn_TKCTPhieuTraSach";
            this.btn_TKCTPhieuTraSach.Size = new System.Drawing.Size(212, 80);
            this.btn_TKCTPhieuTraSach.TabIndex = 20;
            this.btn_TKCTPhieuTraSach.Text = "Tìm kiếm";
            this.btn_TKCTPhieuTraSach.Click += new System.EventHandler(this.btn_TKCTPhieuTraSach_Click);
            // 
            // tb_TienPhat
            // 
            this.tb_TienPhat.Location = new System.Drawing.Point(351, 320);
            this.tb_TienPhat.Name = "tb_TienPhat";
            this.tb_TienPhat.Size = new System.Drawing.Size(198, 44);
            this.tb_TienPhat.TabIndex = 6;
            this.tb_TienPhat.Click += new System.EventHandler(this.tb_TienPhat_Click);
            this.tb_TienPhat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_SoNgayMuon
            // 
            this.tb_SoNgayMuon.Location = new System.Drawing.Point(351, 260);
            this.tb_SoNgayMuon.Name = "tb_SoNgayMuon";
            this.tb_SoNgayMuon.Size = new System.Drawing.Size(198, 44);
            this.tb_SoNgayMuon.TabIndex = 5;
            this.tb_SoNgayMuon.Click += new System.EventHandler(this.tb_SoNgayMuon_Click);
            this.tb_SoNgayMuon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_IDCTPhieuMuon
            // 
            this.tb_IDCTPhieuMuon.Location = new System.Drawing.Point(351, 200);
            this.tb_IDCTPhieuMuon.Name = "tb_IDCTPhieuMuon";
            this.tb_IDCTPhieuMuon.Size = new System.Drawing.Size(198, 44);
            this.tb_IDCTPhieuMuon.TabIndex = 4;
            this.tb_IDCTPhieuMuon.Click += new System.EventHandler(this.tb_IDCTPhieuMuon_Click);
            this.tb_IDCTPhieuMuon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_IDPhieuTraCT
            // 
            this.tb_IDPhieuTraCT.Location = new System.Drawing.Point(351, 140);
            this.tb_IDPhieuTraCT.Name = "tb_IDPhieuTraCT";
            this.tb_IDPhieuTraCT.Size = new System.Drawing.Size(198, 44);
            this.tb_IDPhieuTraCT.TabIndex = 2;
            this.tb_IDPhieuTraCT.Click += new System.EventHandler(this.tb_IDPhieuTraCT_Click);
            this.tb_IDPhieuTraCT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_IDCTPhieuTra
            // 
            this.tb_IDCTPhieuTra.Location = new System.Drawing.Point(351, 80);
            this.tb_IDCTPhieuTra.Name = "tb_IDCTPhieuTra";
            this.tb_IDCTPhieuTra.Size = new System.Drawing.Size(198, 44);
            this.tb_IDCTPhieuTra.TabIndex = 1;
            this.tb_IDCTPhieuTra.Click += new System.EventHandler(this.tb_IDCTPhieuTra_Click);
            this.tb_IDCTPhieuTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // rdb_TienPhat
            // 
            this.rdb_TienPhat.AutoSize = true;
            this.rdb_TienPhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdb_TienPhat.ForeColor = System.Drawing.Color.Red;
            this.rdb_TienPhat.Location = new System.Drawing.Point(6, 322);
            this.rdb_TienPhat.Name = "rdb_TienPhat";
            this.rdb_TienPhat.Size = new System.Drawing.Size(167, 40);
            this.rdb_TienPhat.TabIndex = 4;
            this.rdb_TienPhat.Text = "Tiền phạt";
            this.rdb_TienPhat.UseVisualStyleBackColor = true;
            // 
            // rdb_SoNgayMuon
            // 
            this.rdb_SoNgayMuon.AutoSize = true;
            this.rdb_SoNgayMuon.ForeColor = System.Drawing.Color.Red;
            this.rdb_SoNgayMuon.Location = new System.Drawing.Point(6, 262);
            this.rdb_SoNgayMuon.Name = "rdb_SoNgayMuon";
            this.rdb_SoNgayMuon.Size = new System.Drawing.Size(233, 40);
            this.rdb_SoNgayMuon.TabIndex = 3;
            this.rdb_SoNgayMuon.Text = "Số ngày mượn";
            this.rdb_SoNgayMuon.UseVisualStyleBackColor = true;
            // 
            // rdb_IDPhieuMuon
            // 
            this.rdb_IDPhieuMuon.AutoSize = true;
            this.rdb_IDPhieuMuon.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDPhieuMuon.Location = new System.Drawing.Point(6, 202);
            this.rdb_IDPhieuMuon.Name = "rdb_IDPhieuMuon";
            this.rdb_IDPhieuMuon.Size = new System.Drawing.Size(339, 40);
            this.rdb_IDPhieuMuon.TabIndex = 2;
            this.rdb_IDPhieuMuon.Text = "ID chi tiết phiếu mượn";
            this.rdb_IDPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // rdb_IDPhieuTraCT
            // 
            this.rdb_IDPhieuTraCT.AutoSize = true;
            this.rdb_IDPhieuTraCT.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDPhieuTraCT.Location = new System.Drawing.Point(6, 140);
            this.rdb_IDPhieuTraCT.Name = "rdb_IDPhieuTraCT";
            this.rdb_IDPhieuTraCT.Size = new System.Drawing.Size(200, 40);
            this.rdb_IDPhieuTraCT.TabIndex = 1;
            this.rdb_IDPhieuTraCT.Text = "ID phiếu trả";
            this.rdb_IDPhieuTraCT.UseVisualStyleBackColor = true;
            // 
            // rdb_IDCTPhieuTra
            // 
            this.rdb_IDCTPhieuTra.AutoSize = true;
            this.rdb_IDCTPhieuTra.Checked = true;
            this.rdb_IDCTPhieuTra.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDCTPhieuTra.Location = new System.Drawing.Point(6, 80);
            this.rdb_IDCTPhieuTra.Name = "rdb_IDCTPhieuTra";
            this.rdb_IDCTPhieuTra.Size = new System.Drawing.Size(299, 40);
            this.rdb_IDCTPhieuTra.TabIndex = 0;
            this.rdb_IDCTPhieuTra.TabStop = true;
            this.rdb_IDCTPhieuTra.Text = "ID chi tiết phiếu trả";
            this.rdb_IDCTPhieuTra.UseVisualStyleBackColor = true;
            // 
            // pHIEUTRATableAdapter
            // 
            this.pHIEUTRATableAdapter.ClearBeforeFill = true;
            // 
            // cT_PHIEUTRATableAdapter
            // 
            this.cT_PHIEUTRATableAdapter.ClearBeforeFill = true;
            // 
            // frmTKTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmTKTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm phiếu trả sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTKTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKTraSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKCTPhieuTraSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUTRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgv_TKTraSach;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource pHIEUTRABindingSource;
        private QuanLyThuVienDataSetTableAdapters.PHIEUTRATableAdapter pHIEUTRATableAdapter;
        private System.Windows.Forms.TextBox tb_TienNoKiNay;
        private System.Windows.Forms.TextBox tb_SoTienTra;
        private System.Windows.Forms.TextBox tb_IDPhieuTra;
        private System.Windows.Forms.TextBox tb_IDDocGia;
        private System.Windows.Forms.TextBox tb_TienPhatKiNay;
        private System.Windows.Forms.RadioButton rdb_TienNoKiNay;
        private System.Windows.Forms.RadioButton rdb_SoTienTra;
        private System.Windows.Forms.RadioButton rdb_TienPhatKiNay;
        private System.Windows.Forms.RadioButton rdb_NgayTra;
        private System.Windows.Forms.RadioButton rdb_IDDocGia;
        private System.Windows.Forms.RadioButton rdb_IDPhieuTra;
        private System.Windows.Forms.DataGridView dgv_TKCTPhieuTraSach;
        private System.Windows.Forms.BindingSource cTPHIEUTRABindingSource;
        private QuanLyThuVienDataSetTableAdapters.CT_PHIEUTRATableAdapter cT_PHIEUTRATableAdapter;
        private System.Windows.Forms.TextBox tb_TienPhat;
        private System.Windows.Forms.TextBox tb_SoNgayMuon;
        private System.Windows.Forms.TextBox tb_IDCTPhieuMuon;
        private System.Windows.Forms.TextBox tb_IDPhieuTraCT;
        private System.Windows.Forms.TextBox tb_IDCTPhieuTra;
        private System.Windows.Forms.RadioButton rdb_TienPhat;
        private System.Windows.Forms.RadioButton rdb_SoNgayMuon;
        private System.Windows.Forms.RadioButton rdb_IDPhieuMuon;
        private System.Windows.Forms.RadioButton rdb_IDPhieuTraCT;
        private System.Windows.Forms.RadioButton rdb_IDCTPhieuTra;
        private System.Windows.Forms.DateTimePicker dtp_NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienPhatKyNayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienNoKyNayDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.SimpleButton btn_PhieuTraSach;
        private DevExpress.XtraEditors.SimpleButton btn_TKCTPhieuTraSach;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btn_Luu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Exit;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton btn_LuuCTPT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_XoaCTPT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btn_ResetCTPT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btn_Xuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_XuatCTTraSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCTPhieuTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuTraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienPhatDataGridViewTextBoxColumn;
    }
}