namespace QLTV.GUI
{
    partial class frmTKDocGia
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
            this.item_TKDocGia = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_TKDocGia = new System.Windows.Forms.DataGridView();
            this.iDDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLoaiDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapTheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHEDOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtp_NgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_TKDocGia = new Bunifu.Framework.UI.BunifuTileButton();
            this.tb_IDDocGia = new System.Windows.Forms.TextBox();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.cbb_LoaiDocGia = new System.Windows.Forms.ComboBox();
            this.lOAIDOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdb_NgayLapThe = new System.Windows.Forms.RadioButton();
            this.rdb_LoaiDocGia = new System.Windows.Forms.RadioButton();
            this.rdb_Email = new System.Windows.Forms.RadioButton();
            this.rdb_DiaChi = new System.Windows.Forms.RadioButton();
            this.rdb_NgaySinh = new System.Windows.Forms.RadioButton();
            this.rdb_HoTen = new System.Windows.Forms.RadioButton();
            this.rdb_IDDocGia = new System.Windows.Forms.RadioButton();
            this.item_TKUsers = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_TKUser = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocGiaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_TKUser = new Bunifu.Framework.UI.BunifuTileButton();
            this.tb_TenUser = new System.Windows.Forms.TextBox();
            this.tb_IDUser = new System.Windows.Forms.TextBox();
            this.rdb_UserIDDocGia = new System.Windows.Forms.RadioButton();
            this.rdb_User = new System.Windows.Forms.RadioButton();
            this.tHEDOCGIATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.THEDOCGIATableAdapter();
            this.lOAIDOCGIATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.LOAIDOCGIATableAdapter();
            this.uSERSTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.USERSTableAdapter();
            this.btn_ResetDG = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.item_TKDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOCGIABindingSource)).BeginInit();
            this.item_TKUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.item_TKDocGia);
            this.navigationPane1.Controls.Add(this.item_TKUsers);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.item_TKDocGia,
            this.item_TKUsers});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1814, 1045);
            this.navigationPane1.SelectedPage = this.item_TKDocGia;
            this.navigationPane1.Size = new System.Drawing.Size(1814, 1045);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // item_TKDocGia
            // 
            this.item_TKDocGia.Caption = "Tìm kiếm độc giả";
            this.item_TKDocGia.Controls.Add(this.groupControl2);
            this.item_TKDocGia.Controls.Add(this.groupControl1);
            this.item_TKDocGia.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_user_48;
            this.item_TKDocGia.Name = "item_TKDocGia";
            this.item_TKDocGia.Size = new System.Drawing.Size(1716, 965);
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
            this.groupControl2.Controls.Add(this.dgv_TKDocGia);
            this.groupControl2.Location = new System.Drawing.Point(488, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1229, 964);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu độc giả";
            // 
            // dgv_TKDocGia
            // 
            this.dgv_TKDocGia.AutoGenerateColumns = false;
            this.dgv_TKDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDocGiaDataGridViewTextBoxColumn,
            this.hoTenDGDataGridViewTextBoxColumn,
            this.ngaySinhDGDataGridViewTextBoxColumn,
            this.diaChiDGDataGridViewTextBoxColumn,
            this.emailDGDataGridViewTextBoxColumn,
            this.iDLoaiDGDataGridViewTextBoxColumn,
            this.ngayLapTheDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.tongNoDataGridViewTextBoxColumn});
            this.dgv_TKDocGia.DataSource = this.tHEDOCGIABindingSource;
            this.dgv_TKDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TKDocGia.Location = new System.Drawing.Point(2, 45);
            this.dgv_TKDocGia.Name = "dgv_TKDocGia";
            this.dgv_TKDocGia.RowTemplate.Height = 28;
            this.dgv_TKDocGia.Size = new System.Drawing.Size(1225, 917);
            this.dgv_TKDocGia.TabIndex = 0;
            // 
            // iDDocGiaDataGridViewTextBoxColumn
            // 
            this.iDDocGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDocGiaDataGridViewTextBoxColumn.DataPropertyName = "IDDocGia";
            this.iDDocGiaDataGridViewTextBoxColumn.HeaderText = "ID độc giả";
            this.iDDocGiaDataGridViewTextBoxColumn.Name = "iDDocGiaDataGridViewTextBoxColumn";
            this.iDDocGiaDataGridViewTextBoxColumn.Width = 187;
            // 
            // hoTenDGDataGridViewTextBoxColumn
            // 
            this.hoTenDGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hoTenDGDataGridViewTextBoxColumn.DataPropertyName = "HoTenDG";
            this.hoTenDGDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hoTenDGDataGridViewTextBoxColumn.Name = "hoTenDGDataGridViewTextBoxColumn";
            this.hoTenDGDataGridViewTextBoxColumn.Width = 139;
            // 
            // ngaySinhDGDataGridViewTextBoxColumn
            // 
            this.ngaySinhDGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngaySinhDGDataGridViewTextBoxColumn.DataPropertyName = "NgaySinhDG";
            this.ngaySinhDGDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDGDataGridViewTextBoxColumn.Name = "ngaySinhDGDataGridViewTextBoxColumn";
            this.ngaySinhDGDataGridViewTextBoxColumn.Width = 182;
            // 
            // diaChiDGDataGridViewTextBoxColumn
            // 
            this.diaChiDGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.diaChiDGDataGridViewTextBoxColumn.DataPropertyName = "DiaChiDG";
            this.diaChiDGDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDGDataGridViewTextBoxColumn.Name = "diaChiDGDataGridViewTextBoxColumn";
            this.diaChiDGDataGridViewTextBoxColumn.Width = 142;
            // 
            // emailDGDataGridViewTextBoxColumn
            // 
            this.emailDGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDGDataGridViewTextBoxColumn.DataPropertyName = "EmailDG";
            this.emailDGDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDGDataGridViewTextBoxColumn.Name = "emailDGDataGridViewTextBoxColumn";
            this.emailDGDataGridViewTextBoxColumn.Width = 123;
            // 
            // iDLoaiDGDataGridViewTextBoxColumn
            // 
            this.iDLoaiDGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDLoaiDGDataGridViewTextBoxColumn.DataPropertyName = "IDLoaiDG";
            this.iDLoaiDGDataGridViewTextBoxColumn.HeaderText = "Loại độc giả";
            this.iDLoaiDGDataGridViewTextBoxColumn.Name = "iDLoaiDGDataGridViewTextBoxColumn";
            this.iDLoaiDGDataGridViewTextBoxColumn.Width = 210;
            // 
            // ngayLapTheDataGridViewTextBoxColumn
            // 
            this.ngayLapTheDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngayLapTheDataGridViewTextBoxColumn.DataPropertyName = "NgayLapThe";
            this.ngayLapTheDataGridViewTextBoxColumn.HeaderText = "Ngày lập thẻ";
            this.ngayLapTheDataGridViewTextBoxColumn.Name = "ngayLapTheDataGridViewTextBoxColumn";
            this.ngayLapTheDataGridViewTextBoxColumn.Width = 220;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "Ngày hết hạn";
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.Width = 230;
            // 
            // tongNoDataGridViewTextBoxColumn
            // 
            this.tongNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tongNoDataGridViewTextBoxColumn.DataPropertyName = "TongNo";
            this.tongNoDataGridViewTextBoxColumn.HeaderText = "Tổng nợ";
            this.tongNoDataGridViewTextBoxColumn.Name = "tongNoDataGridViewTextBoxColumn";
            this.tongNoDataGridViewTextBoxColumn.Width = 162;
            // 
            // tHEDOCGIABindingSource
            // 
            this.tHEDOCGIABindingSource.DataMember = "THEDOCGIA";
            this.tHEDOCGIABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.groupControl1.Controls.Add(this.btn_ResetDG);
            this.groupControl1.Controls.Add(this.dtp_NgayLapThe);
            this.groupControl1.Controls.Add(this.dtp_NgaySinh);
            this.groupControl1.Controls.Add(this.btn_TKDocGia);
            this.groupControl1.Controls.Add(this.tb_IDDocGia);
            this.groupControl1.Controls.Add(this.tb_HoTen);
            this.groupControl1.Controls.Add(this.tb_DiaChi);
            this.groupControl1.Controls.Add(this.tb_Email);
            this.groupControl1.Controls.Add(this.cbb_LoaiDocGia);
            this.groupControl1.Controls.Add(this.rdb_NgayLapThe);
            this.groupControl1.Controls.Add(this.rdb_LoaiDocGia);
            this.groupControl1.Controls.Add(this.rdb_Email);
            this.groupControl1.Controls.Add(this.rdb_DiaChi);
            this.groupControl1.Controls.Add(this.rdb_NgaySinh);
            this.groupControl1.Controls.Add(this.rdb_HoTen);
            this.groupControl1.Controls.Add(this.rdb_IDDocGia);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(482, 964);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm theo";
            // 
            // dtp_NgayLapThe
            // 
            this.dtp_NgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLapThe.Location = new System.Drawing.Point(232, 425);
            this.dtp_NgayLapThe.Name = "dtp_NgayLapThe";
            this.dtp_NgayLapThe.Size = new System.Drawing.Size(230, 44);
            this.dtp_NgayLapThe.TabIndex = 7;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(232, 185);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(230, 44);
            this.dtp_NgaySinh.TabIndex = 3;
            // 
            // btn_TKDocGia
            // 
            this.btn_TKDocGia.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_TKDocGia.color = System.Drawing.Color.SeaGreen;
            this.btn_TKDocGia.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_TKDocGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TKDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_TKDocGia.ForeColor = System.Drawing.Color.White;
            this.btn_TKDocGia.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKDocGia.ImagePosition = 20;
            this.btn_TKDocGia.ImageZoom = 50;
            this.btn_TKDocGia.LabelPosition = 41;
            this.btn_TKDocGia.LabelText = "Tìm kiếm";
            this.btn_TKDocGia.Location = new System.Drawing.Point(71, 509);
            this.btn_TKDocGia.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TKDocGia.Name = "btn_TKDocGia";
            this.btn_TKDocGia.Size = new System.Drawing.Size(155, 162);
            this.btn_TKDocGia.TabIndex = 15;
            this.btn_TKDocGia.Click += new System.EventHandler(this.btn_TKDocGia_Click);
            // 
            // tb_IDDocGia
            // 
            this.tb_IDDocGia.Location = new System.Drawing.Point(232, 68);
            this.tb_IDDocGia.MaxLength = 3;
            this.tb_IDDocGia.Name = "tb_IDDocGia";
            this.tb_IDDocGia.Size = new System.Drawing.Size(230, 44);
            this.tb_IDDocGia.TabIndex = 1;
            this.tb_IDDocGia.Click += new System.EventHandler(this.tb_IDDocGia_Click);
            this.tb_IDDocGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Location = new System.Drawing.Point(232, 128);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(230, 44);
            this.tb_HoTen.TabIndex = 2;
            this.tb_HoTen.Click += new System.EventHandler(this.tb_HoTen_Click);
            this.tb_HoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chu_KeyPress);
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(232, 248);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(230, 44);
            this.tb_DiaChi.TabIndex = 4;
            this.tb_DiaChi.Click += new System.EventHandler(this.tb_DiaChi_Click);
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(232, 308);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(230, 44);
            this.tb_Email.TabIndex = 5;
            this.tb_Email.Click += new System.EventHandler(this.tb_Email_Click);
            // 
            // cbb_LoaiDocGia
            // 
            this.cbb_LoaiDocGia.DataSource = this.lOAIDOCGIABindingSource;
            this.cbb_LoaiDocGia.DisplayMember = "IDLoaiDG";
            this.cbb_LoaiDocGia.FormattingEnabled = true;
            this.cbb_LoaiDocGia.Location = new System.Drawing.Point(232, 368);
            this.cbb_LoaiDocGia.Name = "cbb_LoaiDocGia";
            this.cbb_LoaiDocGia.Size = new System.Drawing.Size(230, 44);
            this.cbb_LoaiDocGia.TabIndex = 6;
            this.cbb_LoaiDocGia.ValueMember = "IDLoaiDG";
            this.cbb_LoaiDocGia.Click += new System.EventHandler(this.cbb_LoaiDocGia_Click);
            // 
            // lOAIDOCGIABindingSource
            // 
            this.lOAIDOCGIABindingSource.DataMember = "LOAIDOCGIA";
            this.lOAIDOCGIABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // rdb_NgayLapThe
            // 
            this.rdb_NgayLapThe.AutoSize = true;
            this.rdb_NgayLapThe.ForeColor = System.Drawing.Color.Red;
            this.rdb_NgayLapThe.Location = new System.Drawing.Point(6, 429);
            this.rdb_NgayLapThe.Name = "rdb_NgayLapThe";
            this.rdb_NgayLapThe.Size = new System.Drawing.Size(220, 40);
            this.rdb_NgayLapThe.TabIndex = 6;
            this.rdb_NgayLapThe.Text = "Ngày lập thẻ:";
            this.rdb_NgayLapThe.UseVisualStyleBackColor = true;
            // 
            // rdb_LoaiDocGia
            // 
            this.rdb_LoaiDocGia.AutoSize = true;
            this.rdb_LoaiDocGia.ForeColor = System.Drawing.Color.Red;
            this.rdb_LoaiDocGia.Location = new System.Drawing.Point(6, 369);
            this.rdb_LoaiDocGia.Name = "rdb_LoaiDocGia";
            this.rdb_LoaiDocGia.Size = new System.Drawing.Size(210, 40);
            this.rdb_LoaiDocGia.TabIndex = 5;
            this.rdb_LoaiDocGia.Text = "Loại độc giả:";
            this.rdb_LoaiDocGia.UseVisualStyleBackColor = true;
            // 
            // rdb_Email
            // 
            this.rdb_Email.AutoSize = true;
            this.rdb_Email.ForeColor = System.Drawing.Color.Red;
            this.rdb_Email.Location = new System.Drawing.Point(6, 309);
            this.rdb_Email.Name = "rdb_Email";
            this.rdb_Email.Size = new System.Drawing.Size(123, 40);
            this.rdb_Email.TabIndex = 4;
            this.rdb_Email.Text = "Email:";
            this.rdb_Email.UseVisualStyleBackColor = true;
            // 
            // rdb_DiaChi
            // 
            this.rdb_DiaChi.AutoSize = true;
            this.rdb_DiaChi.ForeColor = System.Drawing.Color.Red;
            this.rdb_DiaChi.Location = new System.Drawing.Point(6, 249);
            this.rdb_DiaChi.Name = "rdb_DiaChi";
            this.rdb_DiaChi.Size = new System.Drawing.Size(142, 40);
            this.rdb_DiaChi.TabIndex = 3;
            this.rdb_DiaChi.Text = "Địa chỉ:";
            this.rdb_DiaChi.UseVisualStyleBackColor = true;
            // 
            // rdb_NgaySinh
            // 
            this.rdb_NgaySinh.AutoSize = true;
            this.rdb_NgaySinh.ForeColor = System.Drawing.Color.Red;
            this.rdb_NgaySinh.Location = new System.Drawing.Point(6, 189);
            this.rdb_NgaySinh.Name = "rdb_NgaySinh";
            this.rdb_NgaySinh.Size = new System.Drawing.Size(182, 40);
            this.rdb_NgaySinh.TabIndex = 2;
            this.rdb_NgaySinh.Text = "Ngày sinh:";
            this.rdb_NgaySinh.UseVisualStyleBackColor = true;
            // 
            // rdb_HoTen
            // 
            this.rdb_HoTen.AutoSize = true;
            this.rdb_HoTen.ForeColor = System.Drawing.Color.Red;
            this.rdb_HoTen.Location = new System.Drawing.Point(6, 129);
            this.rdb_HoTen.Name = "rdb_HoTen";
            this.rdb_HoTen.Size = new System.Drawing.Size(139, 40);
            this.rdb_HoTen.TabIndex = 1;
            this.rdb_HoTen.Text = "Họ tên:";
            this.rdb_HoTen.UseVisualStyleBackColor = true;
            // 
            // rdb_IDDocGia
            // 
            this.rdb_IDDocGia.AutoSize = true;
            this.rdb_IDDocGia.Checked = true;
            this.rdb_IDDocGia.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDDocGia.Location = new System.Drawing.Point(6, 69);
            this.rdb_IDDocGia.Name = "rdb_IDDocGia";
            this.rdb_IDDocGia.Size = new System.Drawing.Size(187, 40);
            this.rdb_IDDocGia.TabIndex = 0;
            this.rdb_IDDocGia.TabStop = true;
            this.rdb_IDDocGia.Text = "ID độc giả:";
            this.rdb_IDDocGia.UseVisualStyleBackColor = true;
            // 
            // item_TKUsers
            // 
            this.item_TKUsers.Caption = "Tìm kiếm Users";
            this.item_TKUsers.Controls.Add(this.groupControl4);
            this.item_TKUsers.Controls.Add(this.groupControl3);
            this.item_TKUsers.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_administrator_male_48;
            this.item_TKUsers.Name = "item_TKUsers";
            this.item_TKUsers.Size = new System.Drawing.Size(1716, 965);
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
            this.groupControl4.Controls.Add(this.dgv_TKUser);
            this.groupControl4.Location = new System.Drawing.Point(466, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1250, 962);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Dữ liệu User";
            // 
            // dgv_TKUser
            // 
            this.dgv_TKUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TKUser.AutoGenerateColumns = false;
            this.dgv_TKUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.iDDocGiaDataGridViewTextBoxColumn1});
            this.dgv_TKUser.DataSource = this.uSERSBindingSource;
            this.dgv_TKUser.Location = new System.Drawing.Point(6, 50);
            this.dgv_TKUser.Name = "dgv_TKUser";
            this.dgv_TKUser.RowTemplate.Height = 28;
            this.dgv_TKUser.Size = new System.Drawing.Size(1238, 906);
            this.dgv_TKUser.TabIndex = 0;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Tên User";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 171;
            // 
            // iDDocGiaDataGridViewTextBoxColumn1
            // 
            this.iDDocGiaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDocGiaDataGridViewTextBoxColumn1.DataPropertyName = "IDDocGia";
            this.iDDocGiaDataGridViewTextBoxColumn1.HeaderText = "ID độc giả";
            this.iDDocGiaDataGridViewTextBoxColumn1.Name = "iDDocGiaDataGridViewTextBoxColumn1";
            this.iDDocGiaDataGridViewTextBoxColumn1.Width = 187;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.quanLyThuVienDataSet;
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
            this.groupControl3.Controls.Add(this.btn_TKUser);
            this.groupControl3.Controls.Add(this.tb_TenUser);
            this.groupControl3.Controls.Add(this.tb_IDUser);
            this.groupControl3.Controls.Add(this.rdb_UserIDDocGia);
            this.groupControl3.Controls.Add(this.rdb_User);
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(460, 965);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Tìm kiếm User theo";
            // 
            // btn_TKUser
            // 
            this.btn_TKUser.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_TKUser.color = System.Drawing.Color.SeaGreen;
            this.btn_TKUser.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_TKUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TKUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_TKUser.ForeColor = System.Drawing.Color.White;
            this.btn_TKUser.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKUser.ImagePosition = 20;
            this.btn_TKUser.ImageZoom = 50;
            this.btn_TKUser.LabelPosition = 41;
            this.btn_TKUser.LabelText = "Tìm kiếm";
            this.btn_TKUser.Location = new System.Drawing.Point(50, 205);
            this.btn_TKUser.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TKUser.Name = "btn_TKUser";
            this.btn_TKUser.Size = new System.Drawing.Size(155, 162);
            this.btn_TKUser.TabIndex = 16;
            this.btn_TKUser.Click += new System.EventHandler(this.btn_TKUser_Click);
            // 
            // tb_TenUser
            // 
            this.tb_TenUser.Location = new System.Drawing.Point(199, 65);
            this.tb_TenUser.Name = "tb_TenUser";
            this.tb_TenUser.Size = new System.Drawing.Size(255, 44);
            this.tb_TenUser.TabIndex = 1;
            this.tb_TenUser.Click += new System.EventHandler(this.tb_TenUser_Click);
            // 
            // tb_IDUser
            // 
            this.tb_IDUser.Location = new System.Drawing.Point(199, 125);
            this.tb_IDUser.MaxLength = 3;
            this.tb_IDUser.Name = "tb_IDUser";
            this.tb_IDUser.Size = new System.Drawing.Size(255, 44);
            this.tb_IDUser.TabIndex = 2;
            this.tb_IDUser.Click += new System.EventHandler(this.tb_IDUser_Click);
            this.tb_IDUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // rdb_UserIDDocGia
            // 
            this.rdb_UserIDDocGia.AutoSize = true;
            this.rdb_UserIDDocGia.ForeColor = System.Drawing.Color.Red;
            this.rdb_UserIDDocGia.Location = new System.Drawing.Point(6, 126);
            this.rdb_UserIDDocGia.Name = "rdb_UserIDDocGia";
            this.rdb_UserIDDocGia.Size = new System.Drawing.Size(187, 40);
            this.rdb_UserIDDocGia.TabIndex = 1;
            this.rdb_UserIDDocGia.Text = "ID độc giả:";
            this.rdb_UserIDDocGia.UseVisualStyleBackColor = true;
            // 
            // rdb_User
            // 
            this.rdb_User.AutoSize = true;
            this.rdb_User.Checked = true;
            this.rdb_User.ForeColor = System.Drawing.Color.Red;
            this.rdb_User.Location = new System.Drawing.Point(6, 66);
            this.rdb_User.Name = "rdb_User";
            this.rdb_User.Size = new System.Drawing.Size(171, 40);
            this.rdb_User.TabIndex = 0;
            this.rdb_User.TabStop = true;
            this.rdb_User.Text = "Tên User:";
            this.rdb_User.UseVisualStyleBackColor = true;
            // 
            // tHEDOCGIATableAdapter
            // 
            this.tHEDOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // lOAIDOCGIATableAdapter
            // 
            this.lOAIDOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // btn_ResetDG
            // 
            this.btn_ResetDG.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ResetDG.color = System.Drawing.Color.SeaGreen;
            this.btn_ResetDG.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_ResetDG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResetDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_ResetDG.ForeColor = System.Drawing.Color.White;
            this.btn_ResetDG.Image = global::QLTV.Properties.Resources.icons8_available_updates_40;
            this.btn_ResetDG.ImagePosition = 20;
            this.btn_ResetDG.ImageZoom = 50;
            this.btn_ResetDG.LabelPosition = 41;
            this.btn_ResetDG.LabelText = "Reset";
            this.btn_ResetDG.Location = new System.Drawing.Point(280, 509);
            this.btn_ResetDG.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ResetDG.Name = "btn_ResetDG";
            this.btn_ResetDG.Size = new System.Drawing.Size(155, 162);
            this.btn_ResetDG.TabIndex = 16;
            this.btn_ResetDG.Click += new System.EventHandler(this.btn_ResetDG_Click);
            // 
            // frmTKDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 1045);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmTKDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm độc giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTKDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.item_TKDocGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOCGIABindingSource)).EndInit();
            this.item_TKUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_TKDocGia;
        private DevExpress.XtraBars.Navigation.NavigationPage item_TKUsers;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdb_IDDocGia;
        private System.Windows.Forms.RadioButton rdb_LoaiDocGia;
        private System.Windows.Forms.RadioButton rdb_Email;
        private System.Windows.Forms.RadioButton rdb_DiaChi;
        private System.Windows.Forms.RadioButton rdb_NgaySinh;
        private System.Windows.Forms.RadioButton rdb_HoTen;
        private System.Windows.Forms.RadioButton rdb_NgayLapThe;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource tHEDOCGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.THEDOCGIATableAdapter tHEDOCGIATableAdapter;
        private System.Windows.Forms.ComboBox cbb_LoaiDocGia;
        private System.Windows.Forms.BindingSource lOAIDOCGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.LOAIDOCGIATableAdapter lOAIDOCGIATableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgv_TKDocGia;
        private System.Windows.Forms.TextBox tb_IDDocGia;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_Email;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgv_TKUser;
        private System.Windows.Forms.RadioButton rdb_UserIDDocGia;
        private System.Windows.Forms.RadioButton rdb_User;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private QuanLyThuVienDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private Bunifu.Framework.UI.BunifuTileButton btn_TKDocGia;
        private System.Windows.Forms.TextBox tb_TenUser;
        private System.Windows.Forms.TextBox tb_IDUser;
        private Bunifu.Framework.UI.BunifuTileButton btn_TKUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocGiaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLoaiDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapTheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapThe;
        private Bunifu.Framework.UI.BunifuTileButton btn_ResetDG;
    }
}