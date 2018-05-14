namespace QLTV.GUI
{
    partial class frmTKTacGia
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
            this.dgv_TKTacGia = new System.Windows.Forms.DataGridView();
            this.iDTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tACGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_TKTacGia = new Bunifu.Framework.UI.BunifuTileButton();
            this.tb_TenTacGia = new System.Windows.Forms.TextBox();
            this.tb_IDTacGia = new System.Windows.Forms.TextBox();
            this.rdb_NgaySinh = new System.Windows.Forms.RadioButton();
            this.rdb_TenTacGia = new System.Windows.Forms.RadioButton();
            this.rdb_IDTacGia = new System.Windows.Forms.RadioButton();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_TKCTTacGia = new System.Windows.Forms.DataGridView();
            this.iDCTTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDauSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTacGiaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTTACGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tb_IDTacGiaCT = new System.Windows.Forms.TextBox();
            this.tb_IDDauSach = new System.Windows.Forms.TextBox();
            this.tb_IDCTTacGia = new System.Windows.Forms.TextBox();
            this.btn_TKCTTacGia = new Bunifu.Framework.UI.BunifuTileButton();
            this.rdb_IDTacGiaCT = new System.Windows.Forms.RadioButton();
            this.rdb_IDDauSach = new System.Windows.Forms.RadioButton();
            this.rdb_IDCTTacGia = new System.Windows.Forms.RadioButton();
            this.tACGIATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.TACGIATableAdapter();
            this.cT_TACGIATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CT_TACGIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKCTTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTTACGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSetBindingSource)).BeginInit();
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
            this.navigationPane1.RegularSize = new System.Drawing.Size(1586, 1098);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(1586, 1098);
            this.navigationPane1.TabIndex = 1;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Tìm kiếm thông tin tác giả theo";
            this.navigationPage1.Controls.Add(this.groupControl4);
            this.navigationPage1.Controls.Add(this.groupControl3);
            this.navigationPage1.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_user_48;
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1456, 1017);
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
            this.groupControl4.Controls.Add(this.dgv_TKTacGia);
            this.groupControl4.Location = new System.Drawing.Point(479, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(978, 1017);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Dữ liệu thông tin tác giả";
            // 
            // dgv_TKTacGia
            // 
            this.dgv_TKTacGia.AutoGenerateColumns = false;
            this.dgv_TKTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTacGiaDataGridViewTextBoxColumn,
            this.tenTacGiaDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn});
            this.dgv_TKTacGia.DataSource = this.tACGIABindingSource;
            this.dgv_TKTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TKTacGia.Location = new System.Drawing.Point(3, 47);
            this.dgv_TKTacGia.Name = "dgv_TKTacGia";
            this.dgv_TKTacGia.RowTemplate.Height = 28;
            this.dgv_TKTacGia.Size = new System.Drawing.Size(972, 967);
            this.dgv_TKTacGia.TabIndex = 0;
            // 
            // iDTacGiaDataGridViewTextBoxColumn
            // 
            this.iDTacGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDTacGiaDataGridViewTextBoxColumn.DataPropertyName = "IDTacGia";
            this.iDTacGiaDataGridViewTextBoxColumn.HeaderText = "ID tác giả";
            this.iDTacGiaDataGridViewTextBoxColumn.Name = "iDTacGiaDataGridViewTextBoxColumn";
            this.iDTacGiaDataGridViewTextBoxColumn.Width = 180;
            // 
            // tenTacGiaDataGridViewTextBoxColumn
            // 
            this.tenTacGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenTacGiaDataGridViewTextBoxColumn.DataPropertyName = "TenTacGia";
            this.tenTacGiaDataGridViewTextBoxColumn.HeaderText = "Tên tác giả";
            this.tenTacGiaDataGridViewTextBoxColumn.Name = "tenTacGiaDataGridViewTextBoxColumn";
            this.tenTacGiaDataGridViewTextBoxColumn.Width = 200;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 182;
            // 
            // tACGIABindingSource
            // 
            this.tACGIABindingSource.DataMember = "TACGIA";
            this.tACGIABindingSource.DataSource = this.quanLyThuVienDataSet;
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
            this.groupControl3.Controls.Add(this.dtp_NgaySinh);
            this.groupControl3.Controls.Add(this.btn_TKTacGia);
            this.groupControl3.Controls.Add(this.tb_TenTacGia);
            this.groupControl3.Controls.Add(this.tb_IDTacGia);
            this.groupControl3.Controls.Add(this.rdb_NgaySinh);
            this.groupControl3.Controls.Add(this.rdb_TenTacGia);
            this.groupControl3.Controls.Add(this.rdb_IDTacGia);
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(635, 1017);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Tìm kiếm theo";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(232, 195);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(235, 44);
            this.dtp_NgaySinh.TabIndex = 3;
            // 
            // btn_TKTacGia
            // 
            this.btn_TKTacGia.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_TKTacGia.color = System.Drawing.Color.SeaGreen;
            this.btn_TKTacGia.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_TKTacGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TKTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_TKTacGia.ForeColor = System.Drawing.Color.White;
            this.btn_TKTacGia.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKTacGia.ImagePosition = 20;
            this.btn_TKTacGia.ImageZoom = 50;
            this.btn_TKTacGia.LabelPosition = 41;
            this.btn_TKTacGia.LabelText = "Tìm kiếm";
            this.btn_TKTacGia.Location = new System.Drawing.Point(144, 265);
            this.btn_TKTacGia.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TKTacGia.Name = "btn_TKTacGia";
            this.btn_TKTacGia.Size = new System.Drawing.Size(155, 162);
            this.btn_TKTacGia.TabIndex = 17;
            this.btn_TKTacGia.Click += new System.EventHandler(this.btn_TKTacGia_Click);
            // 
            // tb_TenTacGia
            // 
            this.tb_TenTacGia.Location = new System.Drawing.Point(232, 138);
            this.tb_TenTacGia.Name = "tb_TenTacGia";
            this.tb_TenTacGia.Size = new System.Drawing.Size(235, 44);
            this.tb_TenTacGia.TabIndex = 2;
            // 
            // tb_IDTacGia
            // 
            this.tb_IDTacGia.Location = new System.Drawing.Point(232, 78);
            this.tb_IDTacGia.Name = "tb_IDTacGia";
            this.tb_IDTacGia.Size = new System.Drawing.Size(235, 44);
            this.tb_IDTacGia.TabIndex = 1;
            // 
            // rdb_NgaySinh
            // 
            this.rdb_NgaySinh.AutoSize = true;
            this.rdb_NgaySinh.ForeColor = System.Drawing.Color.Red;
            this.rdb_NgaySinh.Location = new System.Drawing.Point(6, 199);
            this.rdb_NgaySinh.Name = "rdb_NgaySinh";
            this.rdb_NgaySinh.Size = new System.Drawing.Size(171, 40);
            this.rdb_NgaySinh.TabIndex = 2;
            this.rdb_NgaySinh.Text = "Ngày sinh";
            this.rdb_NgaySinh.UseVisualStyleBackColor = true;
            // 
            // rdb_TenTacGia
            // 
            this.rdb_TenTacGia.AutoSize = true;
            this.rdb_TenTacGia.ForeColor = System.Drawing.Color.Red;
            this.rdb_TenTacGia.Location = new System.Drawing.Point(6, 139);
            this.rdb_TenTacGia.Name = "rdb_TenTacGia";
            this.rdb_TenTacGia.Size = new System.Drawing.Size(189, 40);
            this.rdb_TenTacGia.TabIndex = 1;
            this.rdb_TenTacGia.Text = "Tên tác giả";
            this.rdb_TenTacGia.UseVisualStyleBackColor = true;
            // 
            // rdb_IDTacGia
            // 
            this.rdb_IDTacGia.AutoSize = true;
            this.rdb_IDTacGia.Checked = true;
            this.rdb_IDTacGia.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDTacGia.Location = new System.Drawing.Point(6, 79);
            this.rdb_IDTacGia.Name = "rdb_IDTacGia";
            this.rdb_IDTacGia.Size = new System.Drawing.Size(169, 40);
            this.rdb_IDTacGia.TabIndex = 0;
            this.rdb_IDTacGia.TabStop = true;
            this.rdb_IDTacGia.Text = "ID tác giả";
            this.rdb_IDTacGia.UseVisualStyleBackColor = true;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Tìm kiếm thông tin chi tiết tác giả";
            this.navigationPage2.Controls.Add(this.groupControl2);
            this.navigationPage2.Controls.Add(this.groupControl1);
            this.navigationPage2.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_administrator_male_80;
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1456, 1017);
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dgv_TKCTTacGia);
            this.groupControl2.Location = new System.Drawing.Point(507, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(950, 1017);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu chi tiết tác giả";
            // 
            // dgv_TKCTTacGia
            // 
            this.dgv_TKCTTacGia.AutoGenerateColumns = false;
            this.dgv_TKCTTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKCTTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCTTacGiaDataGridViewTextBoxColumn,
            this.iDDauSachDataGridViewTextBoxColumn,
            this.iDTacGiaDataGridViewTextBoxColumn1});
            this.dgv_TKCTTacGia.DataSource = this.cTTACGIABindingSource;
            this.dgv_TKCTTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TKCTTacGia.Location = new System.Drawing.Point(3, 47);
            this.dgv_TKCTTacGia.Name = "dgv_TKCTTacGia";
            this.dgv_TKCTTacGia.RowTemplate.Height = 28;
            this.dgv_TKCTTacGia.Size = new System.Drawing.Size(944, 967);
            this.dgv_TKCTTacGia.TabIndex = 0;
            // 
            // iDCTTacGiaDataGridViewTextBoxColumn
            // 
            this.iDCTTacGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDCTTacGiaDataGridViewTextBoxColumn.DataPropertyName = "IDCTTacGia";
            this.iDCTTacGiaDataGridViewTextBoxColumn.HeaderText = "ID chi tiết tác giả";
            this.iDCTTacGiaDataGridViewTextBoxColumn.Name = "iDCTTacGiaDataGridViewTextBoxColumn";
            this.iDCTTacGiaDataGridViewTextBoxColumn.Width = 218;
            // 
            // iDDauSachDataGridViewTextBoxColumn
            // 
            this.iDDauSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDauSachDataGridViewTextBoxColumn.DataPropertyName = "IDDauSach";
            this.iDDauSachDataGridViewTextBoxColumn.HeaderText = "ID đầu sách";
            this.iDDauSachDataGridViewTextBoxColumn.Name = "iDDauSachDataGridViewTextBoxColumn";
            this.iDDauSachDataGridViewTextBoxColumn.Width = 192;
            // 
            // iDTacGiaDataGridViewTextBoxColumn1
            // 
            this.iDTacGiaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDTacGiaDataGridViewTextBoxColumn1.DataPropertyName = "IDTacGia";
            this.iDTacGiaDataGridViewTextBoxColumn1.HeaderText = "ID tác giả";
            this.iDTacGiaDataGridViewTextBoxColumn1.Name = "iDTacGiaDataGridViewTextBoxColumn1";
            this.iDTacGiaDataGridViewTextBoxColumn1.Width = 165;
            // 
            // cTTACGIABindingSource
            // 
            this.cTTACGIABindingSource.DataMember = "CT_TACGIA";
            this.cTTACGIABindingSource.DataSource = this.quanLyThuVienDataSetBindingSource;
            // 
            // quanLyThuVienDataSetBindingSource
            // 
            this.quanLyThuVienDataSetBindingSource.DataSource = this.quanLyThuVienDataSet;
            this.quanLyThuVienDataSetBindingSource.Position = 0;
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
            this.groupControl1.Controls.Add(this.tb_IDTacGiaCT);
            this.groupControl1.Controls.Add(this.tb_IDDauSach);
            this.groupControl1.Controls.Add(this.tb_IDCTTacGia);
            this.groupControl1.Controls.Add(this.btn_TKCTTacGia);
            this.groupControl1.Controls.Add(this.rdb_IDTacGiaCT);
            this.groupControl1.Controls.Add(this.rdb_IDDauSach);
            this.groupControl1.Controls.Add(this.rdb_IDCTTacGia);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(501, 1017);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm theo";
            // 
            // tb_IDTacGiaCT
            // 
            this.tb_IDTacGiaCT.Location = new System.Drawing.Point(280, 192);
            this.tb_IDTacGiaCT.Name = "tb_IDTacGiaCT";
            this.tb_IDTacGiaCT.Size = new System.Drawing.Size(215, 44);
            this.tb_IDTacGiaCT.TabIndex = 3;
            // 
            // tb_IDDauSach
            // 
            this.tb_IDDauSach.Location = new System.Drawing.Point(280, 132);
            this.tb_IDDauSach.Name = "tb_IDDauSach";
            this.tb_IDDauSach.Size = new System.Drawing.Size(215, 44);
            this.tb_IDDauSach.TabIndex = 2;
            // 
            // tb_IDCTTacGia
            // 
            this.tb_IDCTTacGia.Location = new System.Drawing.Point(280, 73);
            this.tb_IDCTTacGia.Name = "tb_IDCTTacGia";
            this.tb_IDCTTacGia.Size = new System.Drawing.Size(215, 44);
            this.tb_IDCTTacGia.TabIndex = 1;
            // 
            // btn_TKCTTacGia
            // 
            this.btn_TKCTTacGia.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_TKCTTacGia.color = System.Drawing.Color.SeaGreen;
            this.btn_TKCTTacGia.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_TKCTTacGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TKCTTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_TKCTTacGia.ForeColor = System.Drawing.Color.White;
            this.btn_TKCTTacGia.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKCTTacGia.ImagePosition = 20;
            this.btn_TKCTTacGia.ImageZoom = 50;
            this.btn_TKCTTacGia.LabelPosition = 41;
            this.btn_TKCTTacGia.LabelText = "Tìm kiếm";
            this.btn_TKCTTacGia.Location = new System.Drawing.Point(149, 265);
            this.btn_TKCTTacGia.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TKCTTacGia.Name = "btn_TKCTTacGia";
            this.btn_TKCTTacGia.Size = new System.Drawing.Size(155, 162);
            this.btn_TKCTTacGia.TabIndex = 18;
            this.btn_TKCTTacGia.Click += new System.EventHandler(this.btn_TKCTTacGia_Click);
            // 
            // rdb_IDTacGiaCT
            // 
            this.rdb_IDTacGiaCT.AutoSize = true;
            this.rdb_IDTacGiaCT.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDTacGiaCT.Location = new System.Drawing.Point(6, 193);
            this.rdb_IDTacGiaCT.Name = "rdb_IDTacGiaCT";
            this.rdb_IDTacGiaCT.Size = new System.Drawing.Size(169, 40);
            this.rdb_IDTacGiaCT.TabIndex = 2;
            this.rdb_IDTacGiaCT.Text = "ID tác giả";
            this.rdb_IDTacGiaCT.UseVisualStyleBackColor = true;
            // 
            // rdb_IDDauSach
            // 
            this.rdb_IDDauSach.AutoSize = true;
            this.rdb_IDDauSach.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDDauSach.Location = new System.Drawing.Point(6, 133);
            this.rdb_IDDauSach.Name = "rdb_IDDauSach";
            this.rdb_IDDauSach.Size = new System.Drawing.Size(199, 40);
            this.rdb_IDDauSach.TabIndex = 1;
            this.rdb_IDDauSach.Text = "ID đầu sách";
            this.rdb_IDDauSach.UseVisualStyleBackColor = true;
            // 
            // rdb_IDCTTacGia
            // 
            this.rdb_IDCTTacGia.AutoSize = true;
            this.rdb_IDCTTacGia.Checked = true;
            this.rdb_IDCTTacGia.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDCTTacGia.Location = new System.Drawing.Point(6, 73);
            this.rdb_IDCTTacGia.Name = "rdb_IDCTTacGia";
            this.rdb_IDCTTacGia.Size = new System.Drawing.Size(268, 40);
            this.rdb_IDCTTacGia.TabIndex = 0;
            this.rdb_IDCTTacGia.TabStop = true;
            this.rdb_IDCTTacGia.Text = "ID chi tiết tác giả";
            this.rdb_IDCTTacGia.UseVisualStyleBackColor = true;
            // 
            // tACGIATableAdapter
            // 
            this.tACGIATableAdapter.ClearBeforeFill = true;
            // 
            // cT_TACGIATableAdapter
            // 
            this.cT_TACGIATableAdapter.ClearBeforeFill = true;
            // 
            // frmTKTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 1098);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmTKTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm tác giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTKTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKCTTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTTACGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_TKTacGia;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource tACGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.TACGIATableAdapter tACGIATableAdapter;
        private System.Windows.Forms.TextBox tb_TenTacGia;
        private System.Windows.Forms.TextBox tb_IDTacGia;
        private System.Windows.Forms.RadioButton rdb_NgaySinh;
        private System.Windows.Forms.RadioButton rdb_TenTacGia;
        private System.Windows.Forms.RadioButton rdb_IDTacGia;
        private Bunifu.Framework.UI.BunifuTileButton btn_TKTacGia;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgv_TKCTTacGia;
        private System.Windows.Forms.BindingSource quanLyThuVienDataSetBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource cTTACGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.CT_TACGIATableAdapter cT_TACGIATableAdapter;
        private System.Windows.Forms.TextBox tb_IDCTTacGia;
        private Bunifu.Framework.UI.BunifuTileButton btn_TKCTTacGia;
        private System.Windows.Forms.RadioButton rdb_IDTacGiaCT;
        private System.Windows.Forms.RadioButton rdb_IDDauSach;
        private System.Windows.Forms.RadioButton rdb_IDCTTacGia;
        private System.Windows.Forms.TextBox tb_IDTacGiaCT;
        private System.Windows.Forms.TextBox tb_IDDauSach;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCTTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDauSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTacGiaDataGridViewTextBoxColumn1;
    }
}