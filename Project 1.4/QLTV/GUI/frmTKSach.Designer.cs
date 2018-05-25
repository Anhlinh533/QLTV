namespace QLTV.GUI
{
    partial class frmTKSach
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
            this.item_TKSach = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.dgv_TKSach = new System.Windows.Forms.DataGridView();
            this.iDSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDauSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_TKSach = new DevExpress.XtraEditors.SimpleButton();
            this.tb_GiaTien = new System.Windows.Forms.TextBox();
            this.tb_SoLuongTon = new System.Windows.Forms.TextBox();
            this.tb_NamXuatBan = new System.Windows.Forms.TextBox();
            this.tb_NhaXuatBan = new System.Windows.Forms.TextBox();
            this.tb_IDDauSach = new System.Windows.Forms.TextBox();
            this.tb_IDSach = new System.Windows.Forms.TextBox();
            this.rdb_GiaTien = new System.Windows.Forms.RadioButton();
            this.rdb_SoLuongTon = new System.Windows.Forms.RadioButton();
            this.rdb_NamXuatBan = new System.Windows.Forms.RadioButton();
            this.rdb_NhaXuatBan = new System.Windows.Forms.RadioButton();
            this.rdb_IDDauSach = new System.Windows.Forms.RadioButton();
            this.rdb_IDSach = new System.Windows.Forms.RadioButton();
            this.item_CuonSach = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.dgv_TKCuonSach = new System.Windows.Forms.DataGridView();
            this.iDCuonSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSachDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_TKCuonSach = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.tb_IDSachCS = new System.Windows.Forms.TextBox();
            this.tb_IDCuonSach = new System.Windows.Forms.TextBox();
            this.rdb_TinhTrang = new System.Windows.Forms.RadioButton();
            this.rdb_IDSachCS = new System.Windows.Forms.RadioButton();
            this.rdb_IDCuonSach = new System.Windows.Forms.RadioButton();
            this.sACHTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.SACHTableAdapter();
            this.cUONSACHTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CUONSACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.item_TKSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.item_CuonSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKCuonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.item_TKSach);
            this.navigationPane1.Controls.Add(this.item_CuonSach);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.item_TKSach,
            this.item_CuonSach});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1628, 1097);
            this.navigationPane1.SelectedPage = this.item_TKSach;
            this.navigationPane1.Size = new System.Drawing.Size(1628, 1097);
            this.navigationPane1.TabIndex = 1;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // item_TKSach
            // 
            this.item_TKSach.Caption = "Tìm kiếm thông tin sách";
            this.item_TKSach.Controls.Add(this.groupControl4);
            this.item_TKSach.Controls.Add(this.groupControl3);
            this.item_TKSach.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_book_shelf_48;
            this.item_TKSach.Name = "item_TKSach";
            this.item_TKSach.Size = new System.Drawing.Size(1530, 1017);
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
            this.groupControl4.Controls.Add(this.dgv_TKSach);
            this.groupControl4.Location = new System.Drawing.Point(480, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1051, 1016);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Dữ liệu thông tin sách";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.btn_Luu,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.btn_Sua,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.btn_Xoa,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.btn_Reset,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.btn_Exit});
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 45);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1047, 31);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(41, 28);
            this.toolStripLabel5.Text = "Lưu";
            // 
            // btn_Luu
            // 
            this.btn_Luu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Luu.Image = global::QLTV.Properties.Resources.diskette;
            this.btn_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(28, 28);
            this.btn_Luu.Text = "Lưu";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 28);
            this.toolStripLabel1.Text = "Sửa";
            // 
            // btn_Sua
            // 
            this.btn_Sua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Sua.Image = global::QLTV.Properties.Resources.icons8_pencil_80;
            this.btn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(28, 28);
            this.btn_Sua.Text = "Sửa thông tin";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 28);
            this.toolStripLabel2.Text = "Xóa";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Xoa.Image = global::QLTV.Properties.Resources.icons8_cancel_80;
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(28, 28);
            this.btn_Xoa.Text = "Xóa";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(113, 28);
            this.toolStripLabel3.Text = "Reset dữ liệu";
            // 
            // btn_Reset
            // 
            this.btn_Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Reset.Image = global::QLTV.Properties.Resources.icons8_available_updates_40;
            this.btn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(28, 28);
            this.btn_Reset.Text = "Reset dữ liệu";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(57, 28);
            this.toolStripLabel4.Text = "Thoát";
            // 
            // btn_Exit
            // 
            this.btn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Exit.Image = global::QLTV.Properties.Resources.icons8_shutdown_80;
            this.btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(28, 28);
            this.btn_Exit.Text = "toolStripButton1";
            // 
            // dgv_TKSach
            // 
            this.dgv_TKSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TKSach.AutoGenerateColumns = false;
            this.dgv_TKSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSachDataGridViewTextBoxColumn,
            this.iDDauSachDataGridViewTextBoxColumn,
            this.nhaXBDataGridViewTextBoxColumn,
            this.namXBDataGridViewTextBoxColumn,
            this.soLuongTonDataGridViewTextBoxColumn,
            this.giaTienDataGridViewTextBoxColumn});
            this.dgv_TKSach.DataSource = this.sACHBindingSource;
            this.dgv_TKSach.Location = new System.Drawing.Point(2, 95);
            this.dgv_TKSach.Name = "dgv_TKSach";
            this.dgv_TKSach.RowTemplate.Height = 28;
            this.dgv_TKSach.Size = new System.Drawing.Size(1047, 919);
            this.dgv_TKSach.TabIndex = 0;
            // 
            // iDSachDataGridViewTextBoxColumn
            // 
            this.iDSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDSachDataGridViewTextBoxColumn.DataPropertyName = "IDSach";
            this.iDSachDataGridViewTextBoxColumn.HeaderText = "ID sách";
            this.iDSachDataGridViewTextBoxColumn.Name = "iDSachDataGridViewTextBoxColumn";
            this.iDSachDataGridViewTextBoxColumn.Width = 151;
            // 
            // iDDauSachDataGridViewTextBoxColumn
            // 
            this.iDDauSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDDauSachDataGridViewTextBoxColumn.DataPropertyName = "IDDauSach";
            this.iDDauSachDataGridViewTextBoxColumn.HeaderText = "ID đầu sách";
            this.iDDauSachDataGridViewTextBoxColumn.Name = "iDDauSachDataGridViewTextBoxColumn";
            this.iDDauSachDataGridViewTextBoxColumn.Width = 210;
            // 
            // nhaXBDataGridViewTextBoxColumn
            // 
            this.nhaXBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nhaXBDataGridViewTextBoxColumn.DataPropertyName = "NhaXB";
            this.nhaXBDataGridViewTextBoxColumn.HeaderText = "Nhà xuất bản";
            this.nhaXBDataGridViewTextBoxColumn.Name = "nhaXBDataGridViewTextBoxColumn";
            this.nhaXBDataGridViewTextBoxColumn.Width = 230;
            // 
            // namXBDataGridViewTextBoxColumn
            // 
            this.namXBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.namXBDataGridViewTextBoxColumn.DataPropertyName = "NamXB";
            this.namXBDataGridViewTextBoxColumn.HeaderText = "Năm xuất bản";
            this.namXBDataGridViewTextBoxColumn.Name = "namXBDataGridViewTextBoxColumn";
            this.namXBDataGridViewTextBoxColumn.Width = 238;
            // 
            // soLuongTonDataGridViewTextBoxColumn
            // 
            this.soLuongTonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.soLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.HeaderText = "Số lượng tồn";
            this.soLuongTonDataGridViewTextBoxColumn.Name = "soLuongTonDataGridViewTextBoxColumn";
            this.soLuongTonDataGridViewTextBoxColumn.Width = 221;
            // 
            // giaTienDataGridViewTextBoxColumn
            // 
            this.giaTienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.giaTienDataGridViewTextBoxColumn.DataPropertyName = "GiaTien";
            this.giaTienDataGridViewTextBoxColumn.HeaderText = "Giá tiền";
            this.giaTienDataGridViewTextBoxColumn.Name = "giaTienDataGridViewTextBoxColumn";
            this.giaTienDataGridViewTextBoxColumn.Width = 153;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.quanLyThuVienDataSet;
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
            this.groupControl3.Controls.Add(this.btn_TKSach);
            this.groupControl3.Controls.Add(this.tb_GiaTien);
            this.groupControl3.Controls.Add(this.tb_SoLuongTon);
            this.groupControl3.Controls.Add(this.tb_NamXuatBan);
            this.groupControl3.Controls.Add(this.tb_NhaXuatBan);
            this.groupControl3.Controls.Add(this.tb_IDDauSach);
            this.groupControl3.Controls.Add(this.tb_IDSach);
            this.groupControl3.Controls.Add(this.rdb_GiaTien);
            this.groupControl3.Controls.Add(this.rdb_SoLuongTon);
            this.groupControl3.Controls.Add(this.rdb_NamXuatBan);
            this.groupControl3.Controls.Add(this.rdb_NhaXuatBan);
            this.groupControl3.Controls.Add(this.rdb_IDDauSach);
            this.groupControl3.Controls.Add(this.rdb_IDSach);
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(474, 1016);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Tìm kiếm sách theo";
            // 
            // btn_TKSach
            // 
            this.btn_TKSach.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_TKSach.Appearance.Options.UseFont = true;
            this.btn_TKSach.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKSach.Location = new System.Drawing.Point(136, 460);
            this.btn_TKSach.Name = "btn_TKSach";
            this.btn_TKSach.Size = new System.Drawing.Size(202, 80);
            this.btn_TKSach.TabIndex = 19;
            this.btn_TKSach.Text = "Tìm kiếm";
            this.btn_TKSach.Click += new System.EventHandler(this.btn_TKSach_Click);
            // 
            // tb_GiaTien
            // 
            this.tb_GiaTien.Location = new System.Drawing.Point(254, 373);
            this.tb_GiaTien.Name = "tb_GiaTien";
            this.tb_GiaTien.Size = new System.Drawing.Size(214, 44);
            this.tb_GiaTien.TabIndex = 6;
            this.tb_GiaTien.Click += new System.EventHandler(this.tb_GiaTien_Click);
            this.tb_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_SoLuongTon
            // 
            this.tb_SoLuongTon.Location = new System.Drawing.Point(254, 313);
            this.tb_SoLuongTon.Name = "tb_SoLuongTon";
            this.tb_SoLuongTon.Size = new System.Drawing.Size(214, 44);
            this.tb_SoLuongTon.TabIndex = 5;
            this.tb_SoLuongTon.Click += new System.EventHandler(this.tb_SoLuongTon_Click);
            this.tb_SoLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_NamXuatBan
            // 
            this.tb_NamXuatBan.Location = new System.Drawing.Point(254, 253);
            this.tb_NamXuatBan.Name = "tb_NamXuatBan";
            this.tb_NamXuatBan.Size = new System.Drawing.Size(214, 44);
            this.tb_NamXuatBan.TabIndex = 4;
            this.tb_NamXuatBan.Click += new System.EventHandler(this.tb_NamXuatBan_Click);
            this.tb_NamXuatBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_NhaXuatBan
            // 
            this.tb_NhaXuatBan.Location = new System.Drawing.Point(254, 193);
            this.tb_NhaXuatBan.Name = "tb_NhaXuatBan";
            this.tb_NhaXuatBan.Size = new System.Drawing.Size(214, 44);
            this.tb_NhaXuatBan.TabIndex = 3;
            this.tb_NhaXuatBan.Click += new System.EventHandler(this.tb_NhaXuatBan_Click);
            this.tb_NhaXuatBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chu_KeyPress);
            // 
            // tb_IDDauSach
            // 
            this.tb_IDDauSach.Location = new System.Drawing.Point(254, 133);
            this.tb_IDDauSach.Name = "tb_IDDauSach";
            this.tb_IDDauSach.Size = new System.Drawing.Size(214, 44);
            this.tb_IDDauSach.TabIndex = 2;
            this.tb_IDDauSach.Click += new System.EventHandler(this.tb_IDDauSach_Click);
            this.tb_IDDauSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_IDSach
            // 
            this.tb_IDSach.Location = new System.Drawing.Point(254, 73);
            this.tb_IDSach.Name = "tb_IDSach";
            this.tb_IDSach.Size = new System.Drawing.Size(214, 44);
            this.tb_IDSach.TabIndex = 1;
            this.tb_IDSach.Click += new System.EventHandler(this.tb_IDSach_Click);
            this.tb_IDSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // rdb_GiaTien
            // 
            this.rdb_GiaTien.AutoSize = true;
            this.rdb_GiaTien.ForeColor = System.Drawing.Color.Red;
            this.rdb_GiaTien.Location = new System.Drawing.Point(6, 374);
            this.rdb_GiaTien.Name = "rdb_GiaTien";
            this.rdb_GiaTien.Size = new System.Drawing.Size(142, 40);
            this.rdb_GiaTien.TabIndex = 5;
            this.rdb_GiaTien.Text = "Giá tiền";
            this.rdb_GiaTien.UseVisualStyleBackColor = true;
            // 
            // rdb_SoLuongTon
            // 
            this.rdb_SoLuongTon.AutoSize = true;
            this.rdb_SoLuongTon.ForeColor = System.Drawing.Color.Red;
            this.rdb_SoLuongTon.Location = new System.Drawing.Point(6, 314);
            this.rdb_SoLuongTon.Name = "rdb_SoLuongTon";
            this.rdb_SoLuongTon.Size = new System.Drawing.Size(210, 40);
            this.rdb_SoLuongTon.TabIndex = 4;
            this.rdb_SoLuongTon.Text = "Số lượng tồn";
            this.rdb_SoLuongTon.UseVisualStyleBackColor = true;
            // 
            // rdb_NamXuatBan
            // 
            this.rdb_NamXuatBan.AutoSize = true;
            this.rdb_NamXuatBan.ForeColor = System.Drawing.Color.Red;
            this.rdb_NamXuatBan.Location = new System.Drawing.Point(6, 254);
            this.rdb_NamXuatBan.Name = "rdb_NamXuatBan";
            this.rdb_NamXuatBan.Size = new System.Drawing.Size(227, 40);
            this.rdb_NamXuatBan.TabIndex = 3;
            this.rdb_NamXuatBan.Text = "Năm xuất bản";
            this.rdb_NamXuatBan.UseVisualStyleBackColor = true;
            // 
            // rdb_NhaXuatBan
            // 
            this.rdb_NhaXuatBan.AutoSize = true;
            this.rdb_NhaXuatBan.ForeColor = System.Drawing.Color.Red;
            this.rdb_NhaXuatBan.Location = new System.Drawing.Point(6, 194);
            this.rdb_NhaXuatBan.Name = "rdb_NhaXuatBan";
            this.rdb_NhaXuatBan.Size = new System.Drawing.Size(219, 40);
            this.rdb_NhaXuatBan.TabIndex = 2;
            this.rdb_NhaXuatBan.Text = "Nhà xuất bản";
            this.rdb_NhaXuatBan.UseVisualStyleBackColor = true;
            // 
            // rdb_IDDauSach
            // 
            this.rdb_IDDauSach.AutoSize = true;
            this.rdb_IDDauSach.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDDauSach.Location = new System.Drawing.Point(6, 134);
            this.rdb_IDDauSach.Name = "rdb_IDDauSach";
            this.rdb_IDDauSach.Size = new System.Drawing.Size(199, 40);
            this.rdb_IDDauSach.TabIndex = 1;
            this.rdb_IDDauSach.Text = "ID đầu sách";
            this.rdb_IDDauSach.UseVisualStyleBackColor = true;
            // 
            // rdb_IDSach
            // 
            this.rdb_IDSach.AutoSize = true;
            this.rdb_IDSach.Checked = true;
            this.rdb_IDSach.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDSach.Location = new System.Drawing.Point(6, 74);
            this.rdb_IDSach.Name = "rdb_IDSach";
            this.rdb_IDSach.Size = new System.Drawing.Size(140, 40);
            this.rdb_IDSach.TabIndex = 0;
            this.rdb_IDSach.TabStop = true;
            this.rdb_IDSach.Text = "ID sách";
            this.rdb_IDSach.UseVisualStyleBackColor = true;
            // 
            // item_CuonSach
            // 
            this.item_CuonSach.Caption = "Tìm kiếm thông tin cuốn sách";
            this.item_CuonSach.Controls.Add(this.groupControl2);
            this.item_CuonSach.Controls.Add(this.groupControl1);
            this.item_CuonSach.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_book_40;
            this.item_CuonSach.Name = "item_CuonSach";
            this.item_CuonSach.Size = new System.Drawing.Size(1530, 1017);
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
            this.groupControl2.Controls.Add(this.dgv_TKCuonSach);
            this.groupControl2.Location = new System.Drawing.Point(450, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1081, 1017);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu thông tin cuốn sách";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel6,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.toolStripLabel7,
            this.toolStripButton2,
            this.toolStripSeparator6,
            this.toolStripLabel8,
            this.toolStripButton3,
            this.toolStripSeparator7,
            this.toolStripLabel9,
            this.toolStripButton4,
            this.toolStripSeparator8,
            this.toolStripLabel10,
            this.toolStripButton5});
            this.bindingNavigator2.Location = new System.Drawing.Point(2, 45);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(1077, 31);
            this.bindingNavigator2.TabIndex = 10;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(41, 28);
            this.toolStripLabel6.Text = "Lưu";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::QLTV.Properties.Resources.diskette;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "Lưu";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(42, 28);
            this.toolStripLabel7.Text = "Sửa";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::QLTV.Properties.Resources.icons8_pencil_80;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "Sửa thông tin";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(43, 28);
            this.toolStripLabel8.Text = "Xóa";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::QLTV.Properties.Resources.icons8_cancel_80;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "Xóa";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(113, 28);
            this.toolStripLabel9.Text = "Reset dữ liệu";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::QLTV.Properties.Resources.icons8_available_updates_40;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton4.Text = "Reset dữ liệu";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(57, 28);
            this.toolStripLabel10.Text = "Thoát";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::QLTV.Properties.Resources.icons8_shutdown_80;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton5.Text = "toolStripButton1";
            // 
            // dgv_TKCuonSach
            // 
            this.dgv_TKCuonSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TKCuonSach.AutoGenerateColumns = false;
            this.dgv_TKCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKCuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCuonSachDataGridViewTextBoxColumn,
            this.iDSachDataGridViewTextBoxColumn1,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dgv_TKCuonSach.DataSource = this.cUONSACHBindingSource;
            this.dgv_TKCuonSach.Location = new System.Drawing.Point(2, 91);
            this.dgv_TKCuonSach.Name = "dgv_TKCuonSach";
            this.dgv_TKCuonSach.RowTemplate.Height = 28;
            this.dgv_TKCuonSach.Size = new System.Drawing.Size(1077, 924);
            this.dgv_TKCuonSach.TabIndex = 0;
            // 
            // iDCuonSachDataGridViewTextBoxColumn
            // 
            this.iDCuonSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDCuonSachDataGridViewTextBoxColumn.DataPropertyName = "IDCuonSach";
            this.iDCuonSachDataGridViewTextBoxColumn.HeaderText = "ID cuốn sách";
            this.iDCuonSachDataGridViewTextBoxColumn.Name = "iDCuonSachDataGridViewTextBoxColumn";
            this.iDCuonSachDataGridViewTextBoxColumn.Width = 224;
            // 
            // iDSachDataGridViewTextBoxColumn1
            // 
            this.iDSachDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDSachDataGridViewTextBoxColumn1.DataPropertyName = "IDSach";
            this.iDSachDataGridViewTextBoxColumn1.HeaderText = "ID sách";
            this.iDSachDataGridViewTextBoxColumn1.Name = "iDSachDataGridViewTextBoxColumn1";
            this.iDSachDataGridViewTextBoxColumn1.Width = 151;
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.Width = 190;
            // 
            // cUONSACHBindingSource
            // 
            this.cUONSACHBindingSource.DataMember = "CUONSACH";
            this.cUONSACHBindingSource.DataSource = this.quanLyThuVienDataSet;
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
            this.groupControl1.Controls.Add(this.btn_TKCuonSach);
            this.groupControl1.Controls.Add(this.cbb_TinhTrang);
            this.groupControl1.Controls.Add(this.tb_IDSachCS);
            this.groupControl1.Controls.Add(this.tb_IDCuonSach);
            this.groupControl1.Controls.Add(this.rdb_TinhTrang);
            this.groupControl1.Controls.Add(this.rdb_IDSachCS);
            this.groupControl1.Controls.Add(this.rdb_IDCuonSach);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(444, 1017);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm thông tin cuốn sách theo";
            // 
            // btn_TKCuonSach
            // 
            this.btn_TKCuonSach.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_TKCuonSach.Appearance.Options.UseFont = true;
            this.btn_TKCuonSach.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKCuonSach.Location = new System.Drawing.Point(118, 295);
            this.btn_TKCuonSach.Name = "btn_TKCuonSach";
            this.btn_TKCuonSach.Size = new System.Drawing.Size(198, 80);
            this.btn_TKCuonSach.TabIndex = 19;
            this.btn_TKCuonSach.Text = "Tìm kiếm";
            this.btn_TKCuonSach.Click += new System.EventHandler(this.btn_TKCuonSach_Click);
            // 
            // cbb_TinhTrang
            // 
            this.cbb_TinhTrang.FormattingEnabled = true;
            this.cbb_TinhTrang.Items.AddRange(new object[] {
            "Chưa cho mượn.",
            "Đã cho mượn."});
            this.cbb_TinhTrang.Location = new System.Drawing.Point(225, 182);
            this.cbb_TinhTrang.Name = "cbb_TinhTrang";
            this.cbb_TinhTrang.Size = new System.Drawing.Size(213, 44);
            this.cbb_TinhTrang.TabIndex = 3;
            this.cbb_TinhTrang.Click += new System.EventHandler(this.cbb_TinhTrang_Click);
            // 
            // tb_IDSachCS
            // 
            this.tb_IDSachCS.Location = new System.Drawing.Point(225, 122);
            this.tb_IDSachCS.Name = "tb_IDSachCS";
            this.tb_IDSachCS.Size = new System.Drawing.Size(213, 44);
            this.tb_IDSachCS.TabIndex = 2;
            this.tb_IDSachCS.Click += new System.EventHandler(this.tb_IDSachCS_Click);
            this.tb_IDSachCS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_IDCuonSach
            // 
            this.tb_IDCuonSach.Location = new System.Drawing.Point(225, 62);
            this.tb_IDCuonSach.Name = "tb_IDCuonSach";
            this.tb_IDCuonSach.Size = new System.Drawing.Size(213, 44);
            this.tb_IDCuonSach.TabIndex = 1;
            this.tb_IDCuonSach.Click += new System.EventHandler(this.tb_IDCuonSach_Click);
            this.tb_IDCuonSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // rdb_TinhTrang
            // 
            this.rdb_TinhTrang.AutoSize = true;
            this.rdb_TinhTrang.ForeColor = System.Drawing.Color.Red;
            this.rdb_TinhTrang.Location = new System.Drawing.Point(6, 183);
            this.rdb_TinhTrang.Name = "rdb_TinhTrang";
            this.rdb_TinhTrang.Size = new System.Drawing.Size(179, 40);
            this.rdb_TinhTrang.TabIndex = 2;
            this.rdb_TinhTrang.Text = "Tình trạng";
            this.rdb_TinhTrang.UseVisualStyleBackColor = true;
            // 
            // rdb_IDSachCS
            // 
            this.rdb_IDSachCS.AutoSize = true;
            this.rdb_IDSachCS.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDSachCS.Location = new System.Drawing.Point(6, 123);
            this.rdb_IDSachCS.Name = "rdb_IDSachCS";
            this.rdb_IDSachCS.Size = new System.Drawing.Size(140, 40);
            this.rdb_IDSachCS.TabIndex = 1;
            this.rdb_IDSachCS.Text = "ID sách";
            this.rdb_IDSachCS.UseVisualStyleBackColor = true;
            // 
            // rdb_IDCuonSach
            // 
            this.rdb_IDCuonSach.AutoSize = true;
            this.rdb_IDCuonSach.Checked = true;
            this.rdb_IDCuonSach.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDCuonSach.Location = new System.Drawing.Point(6, 63);
            this.rdb_IDCuonSach.Name = "rdb_IDCuonSach";
            this.rdb_IDCuonSach.Size = new System.Drawing.Size(213, 40);
            this.rdb_IDCuonSach.TabIndex = 0;
            this.rdb_IDCuonSach.TabStop = true;
            this.rdb_IDCuonSach.Text = "ID cuốn sách";
            this.rdb_IDCuonSach.UseVisualStyleBackColor = true;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // cUONSACHTableAdapter
            // 
            this.cUONSACHTableAdapter.ClearBeforeFill = true;
            // 
            // frmTKSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 1097);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmTKSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTKSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.item_TKSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.item_CuonSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKCuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_TKSach;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraBars.Navigation.NavigationPage item_CuonSach;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgv_TKSach;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDauSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tb_GiaTien;
        private System.Windows.Forms.TextBox tb_SoLuongTon;
        private System.Windows.Forms.TextBox tb_NamXuatBan;
        private System.Windows.Forms.TextBox tb_NhaXuatBan;
        private System.Windows.Forms.TextBox tb_IDDauSach;
        private System.Windows.Forms.TextBox tb_IDSach;
        private System.Windows.Forms.RadioButton rdb_GiaTien;
        private System.Windows.Forms.RadioButton rdb_SoLuongTon;
        private System.Windows.Forms.RadioButton rdb_NamXuatBan;
        private System.Windows.Forms.RadioButton rdb_NhaXuatBan;
        private System.Windows.Forms.RadioButton rdb_IDDauSach;
        private System.Windows.Forms.RadioButton rdb_IDSach;
        private System.Windows.Forms.DataGridView dgv_TKCuonSach;
        private System.Windows.Forms.BindingSource cUONSACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.CUONSACHTableAdapter cUONSACHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCuonSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSachDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton rdb_TinhTrang;
        private System.Windows.Forms.RadioButton rdb_IDSachCS;
        private System.Windows.Forms.RadioButton rdb_IDCuonSach;
        private System.Windows.Forms.ComboBox cbb_TinhTrang;
        private System.Windows.Forms.TextBox tb_IDSachCS;
        private System.Windows.Forms.TextBox tb_IDCuonSach;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btn_Luu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_Sua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btn_Reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btn_Exit;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private DevExpress.XtraEditors.SimpleButton btn_TKSach;
        private DevExpress.XtraEditors.SimpleButton btn_TKCuonSach;
    }
}