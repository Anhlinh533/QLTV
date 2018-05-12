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
            this.btn_TKSach = new Bunifu.Framework.UI.BunifuTileButton();
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
            this.dgv_TKCuonSach = new System.Windows.Forms.DataGridView();
            this.iDCuonSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSachDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_TKCuonSach = new Bunifu.Framework.UI.BunifuTileButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.item_CuonSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            this.item_TKSach.Size = new System.Drawing.Size(1530, 1016);
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
            this.groupControl4.Controls.Add(this.dgv_TKSach);
            this.groupControl4.Location = new System.Drawing.Point(480, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1051, 1016);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Dữ liệu thông tin sách";
            // 
            // dgv_TKSach
            // 
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
            this.dgv_TKSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TKSach.Location = new System.Drawing.Point(3, 47);
            this.dgv_TKSach.Name = "dgv_TKSach";
            this.dgv_TKSach.RowTemplate.Height = 28;
            this.dgv_TKSach.Size = new System.Drawing.Size(1045, 966);
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
            this.btn_TKSach.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_TKSach.color = System.Drawing.Color.SeaGreen;
            this.btn_TKSach.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_TKSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TKSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_TKSach.ForeColor = System.Drawing.Color.White;
            this.btn_TKSach.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKSach.ImagePosition = 20;
            this.btn_TKSach.ImageZoom = 50;
            this.btn_TKSach.LabelPosition = 41;
            this.btn_TKSach.LabelText = "Tìm kiếm";
            this.btn_TKSach.Location = new System.Drawing.Point(164, 445);
            this.btn_TKSach.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TKSach.Name = "btn_TKSach";
            this.btn_TKSach.Size = new System.Drawing.Size(155, 162);
            this.btn_TKSach.TabIndex = 16;
            this.btn_TKSach.Click += new System.EventHandler(this.btn_TKSach_Click);
            // 
            // tb_GiaTien
            // 
            this.tb_GiaTien.Location = new System.Drawing.Point(254, 373);
            this.tb_GiaTien.Name = "tb_GiaTien";
            this.tb_GiaTien.Size = new System.Drawing.Size(214, 44);
            this.tb_GiaTien.TabIndex = 6;
            // 
            // tb_SoLuongTon
            // 
            this.tb_SoLuongTon.Location = new System.Drawing.Point(254, 313);
            this.tb_SoLuongTon.Name = "tb_SoLuongTon";
            this.tb_SoLuongTon.Size = new System.Drawing.Size(214, 44);
            this.tb_SoLuongTon.TabIndex = 5;
            // 
            // tb_NamXuatBan
            // 
            this.tb_NamXuatBan.Location = new System.Drawing.Point(254, 253);
            this.tb_NamXuatBan.Name = "tb_NamXuatBan";
            this.tb_NamXuatBan.Size = new System.Drawing.Size(214, 44);
            this.tb_NamXuatBan.TabIndex = 4;
            // 
            // tb_NhaXuatBan
            // 
            this.tb_NhaXuatBan.Location = new System.Drawing.Point(254, 193);
            this.tb_NhaXuatBan.Name = "tb_NhaXuatBan";
            this.tb_NhaXuatBan.Size = new System.Drawing.Size(214, 44);
            this.tb_NhaXuatBan.TabIndex = 3;
            // 
            // tb_IDDauSach
            // 
            this.tb_IDDauSach.Location = new System.Drawing.Point(254, 133);
            this.tb_IDDauSach.Name = "tb_IDDauSach";
            this.tb_IDDauSach.Size = new System.Drawing.Size(214, 44);
            this.tb_IDDauSach.TabIndex = 2;
            // 
            // tb_IDSach
            // 
            this.tb_IDSach.Location = new System.Drawing.Point(254, 73);
            this.tb_IDSach.Name = "tb_IDSach";
            this.tb_IDSach.Size = new System.Drawing.Size(214, 44);
            this.tb_IDSach.TabIndex = 1;
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
            this.item_CuonSach.Size = new System.Drawing.Size(1530, 1016);
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
            this.groupControl2.Controls.Add(this.dgv_TKCuonSach);
            this.groupControl2.Location = new System.Drawing.Point(450, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1081, 1016);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu thông tin cuốn sách";
            // 
            // dgv_TKCuonSach
            // 
            this.dgv_TKCuonSach.AutoGenerateColumns = false;
            this.dgv_TKCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKCuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCuonSachDataGridViewTextBoxColumn,
            this.iDSachDataGridViewTextBoxColumn1,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dgv_TKCuonSach.DataSource = this.cUONSACHBindingSource;
            this.dgv_TKCuonSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TKCuonSach.Location = new System.Drawing.Point(3, 47);
            this.dgv_TKCuonSach.Name = "dgv_TKCuonSach";
            this.dgv_TKCuonSach.RowTemplate.Height = 28;
            this.dgv_TKCuonSach.Size = new System.Drawing.Size(1075, 966);
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
            this.groupControl1.Size = new System.Drawing.Size(444, 1016);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm thông tin cuốn sách theo";
            // 
            // btn_TKCuonSach
            // 
            this.btn_TKCuonSach.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_TKCuonSach.color = System.Drawing.Color.SeaGreen;
            this.btn_TKCuonSach.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_TKCuonSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TKCuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_TKCuonSach.ForeColor = System.Drawing.Color.White;
            this.btn_TKCuonSach.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKCuonSach.ImagePosition = 20;
            this.btn_TKCuonSach.ImageZoom = 50;
            this.btn_TKCuonSach.LabelPosition = 41;
            this.btn_TKCuonSach.LabelText = "Tìm kiếm";
            this.btn_TKCuonSach.Location = new System.Drawing.Point(138, 258);
            this.btn_TKCuonSach.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TKCuonSach.Name = "btn_TKCuonSach";
            this.btn_TKCuonSach.Size = new System.Drawing.Size(155, 162);
            this.btn_TKCuonSach.TabIndex = 16;
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
            // 
            // tb_IDSachCS
            // 
            this.tb_IDSachCS.Location = new System.Drawing.Point(225, 122);
            this.tb_IDSachCS.Name = "tb_IDSachCS";
            this.tb_IDSachCS.Size = new System.Drawing.Size(213, 44);
            this.tb_IDSachCS.TabIndex = 2;
            // 
            // tb_IDCuonSach
            // 
            this.tb_IDCuonSach.Location = new System.Drawing.Point(225, 62);
            this.tb_IDCuonSach.Name = "tb_IDCuonSach";
            this.tb_IDCuonSach.Size = new System.Drawing.Size(213, 44);
            this.tb_IDCuonSach.TabIndex = 1;
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
            this.Text = "frmTKSach";
            this.Load += new System.EventHandler(this.frmTKSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.item_TKSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.item_CuonSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
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
        private Bunifu.Framework.UI.BunifuTileButton btn_TKSach;
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
        private Bunifu.Framework.UI.BunifuTileButton btn_TKCuonSach;
    }
}