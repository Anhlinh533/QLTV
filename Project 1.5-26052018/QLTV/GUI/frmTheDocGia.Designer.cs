namespace QLTV.GUI
{
    partial class frmTheDocGia
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
            this.item_Them = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.dgv_ThemDG = new System.Windows.Forms.DataGridView();
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
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.pic_Ss = new System.Windows.Forms.PictureBox();
            this.pic_Warning = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_NgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_LoaiDocGia = new System.Windows.Forms.ComboBox();
            this.lOAIDOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_HoTenDocGia = new System.Windows.Forms.TextBox();
            this.tb_IDDocGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lOAIDOCGIATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.LOAIDOCGIATableAdapter();
            this.tHEDOCGIATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.THEDOCGIATableAdapter();
            this.btn_Xuat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.item_Them.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThemDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOCGIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.item_Them);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.item_Them});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1497, 848);
            this.navigationPane1.SelectedPage = this.item_Them;
            this.navigationPane1.Size = new System.Drawing.Size(1497, 848);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // item_Them
            // 
            this.item_Them.Caption = "Thêm độc giả";
            this.item_Them.Controls.Add(this.groupControl2);
            this.item_Them.Controls.Add(this.groupControl1);
            this.item_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_plus_40;
            this.item_Them.Name = "item_Them";
            this.item_Them.Size = new System.Drawing.Size(1407, 768);
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
            this.groupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl2.Controls.Add(this.bindingNavigator1);
            this.groupControl2.Controls.Add(this.dgv_ThemDG);
            this.groupControl2.Location = new System.Drawing.Point(556, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(859, 777);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu độc giả";
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
            this.btn_Sua,
            this.toolStripSeparator1,
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
            this.bindingNavigator1.Size = new System.Drawing.Size(855, 35);
            this.bindingNavigator1.TabIndex = 17;
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
            // btn_Sua
            // 
            this.btn_Sua.ForeColor = System.Drawing.Color.Red;
            this.btn_Sua.Image = global::QLTV.Properties.Resources.icons8_pencil_80;
            this.btn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(159, 32);
            this.btn_Sua.Text = "Sửa thông tin";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
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
            // dgv_ThemDG
            // 
            this.dgv_ThemDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ThemDG.AutoGenerateColumns = false;
            this.dgv_ThemDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThemDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDocGiaDataGridViewTextBoxColumn,
            this.hoTenDGDataGridViewTextBoxColumn,
            this.ngaySinhDGDataGridViewTextBoxColumn,
            this.diaChiDGDataGridViewTextBoxColumn,
            this.emailDGDataGridViewTextBoxColumn,
            this.iDLoaiDGDataGridViewTextBoxColumn,
            this.ngayLapTheDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.tongNoDataGridViewTextBoxColumn});
            this.dgv_ThemDG.DataSource = this.tHEDOCGIABindingSource;
            this.dgv_ThemDG.Location = new System.Drawing.Point(3, 98);
            this.dgv_ThemDG.Name = "dgv_ThemDG";
            this.dgv_ThemDG.RowTemplate.Height = 28;
            this.dgv_ThemDG.Size = new System.Drawing.Size(853, 676);
            this.dgv_ThemDG.TabIndex = 1;
            this.dgv_ThemDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThemDG_CellClick);
            // 
            // iDDocGiaDataGridViewTextBoxColumn
            // 
            this.iDDocGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDocGiaDataGridViewTextBoxColumn.DataPropertyName = "IDDocGia";
            this.iDDocGiaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDocGiaDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.iDDocGiaDataGridViewTextBoxColumn.Name = "iDDocGiaDataGridViewTextBoxColumn";
            this.iDDocGiaDataGridViewTextBoxColumn.Width = 82;
            // 
            // hoTenDGDataGridViewTextBoxColumn
            // 
            this.hoTenDGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hoTenDGDataGridViewTextBoxColumn.DataPropertyName = "HoTenDG";
            this.hoTenDGDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.hoTenDGDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.hoTenDGDataGridViewTextBoxColumn.Name = "hoTenDGDataGridViewTextBoxColumn";
            this.hoTenDGDataGridViewTextBoxColumn.Width = 179;
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
            this.diaChiDGDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.diaChiDGDataGridViewTextBoxColumn.Name = "diaChiDGDataGridViewTextBoxColumn";
            this.diaChiDGDataGridViewTextBoxColumn.Width = 142;
            // 
            // emailDGDataGridViewTextBoxColumn
            // 
            this.emailDGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDGDataGridViewTextBoxColumn.DataPropertyName = "EmailDG";
            this.emailDGDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDGDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.emailDGDataGridViewTextBoxColumn.Name = "emailDGDataGridViewTextBoxColumn";
            this.emailDGDataGridViewTextBoxColumn.Width = 123;
            // 
            // iDLoaiDGDataGridViewTextBoxColumn
            // 
            this.iDLoaiDGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDLoaiDGDataGridViewTextBoxColumn.DataPropertyName = "IDLoaiDG";
            this.iDLoaiDGDataGridViewTextBoxColumn.HeaderText = "Loại độc giả";
            this.iDLoaiDGDataGridViewTextBoxColumn.MaxInputLength = 6;
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
            this.ngayHetHanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.btn_Them);
            this.groupControl1.Controls.Add(this.pic_Ss);
            this.groupControl1.Controls.Add(this.pic_Warning);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.dtp_NgayLapThe);
            this.groupControl1.Controls.Add(this.dtp_NgaySinh);
            this.groupControl1.Controls.Add(this.cbb_LoaiDocGia);
            this.groupControl1.Controls.Add(this.tb_Email);
            this.groupControl1.Controls.Add(this.tb_DiaChi);
            this.groupControl1.Controls.Add(this.tb_HoTenDocGia);
            this.groupControl1.Controls.Add(this.tb_IDDocGia);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(550, 841);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin độc giả";
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.btn_Them.Location = new System.Drawing.Point(207, 558);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(158, 75);
            this.btn_Them.TabIndex = 39;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // pic_Ss
            // 
            this.pic_Ss.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.pic_Ss.Location = new System.Drawing.Point(488, 79);
            this.pic_Ss.Name = "pic_Ss";
            this.pic_Ss.Size = new System.Drawing.Size(38, 39);
            this.pic_Ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ss.TabIndex = 17;
            this.pic_Ss.TabStop = false;
            // 
            // pic_Warning
            // 
            this.pic_Warning.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.pic_Warning.Location = new System.Drawing.Point(488, 79);
            this.pic_Warning.Name = "pic_Warning";
            this.pic_Warning.Size = new System.Drawing.Size(38, 39);
            this.pic_Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Warning.TabIndex = 16;
            this.pic_Warning.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(202, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            // 
            // dtp_NgayLapThe
            // 
            this.dtp_NgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLapThe.Location = new System.Drawing.Point(207, 471);
            this.dtp_NgayLapThe.Name = "dtp_NgayLapThe";
            this.dtp_NgayLapThe.Size = new System.Drawing.Size(276, 44);
            this.dtp_NgayLapThe.TabIndex = 7;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(207, 229);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(276, 44);
            this.dtp_NgaySinh.TabIndex = 3;
            // 
            // cbb_LoaiDocGia
            // 
            this.cbb_LoaiDocGia.DataSource = this.lOAIDOCGIABindingSource;
            this.cbb_LoaiDocGia.DisplayMember = "IDLoaiDG";
            this.cbb_LoaiDocGia.FormattingEnabled = true;
            this.cbb_LoaiDocGia.Location = new System.Drawing.Point(207, 414);
            this.cbb_LoaiDocGia.Name = "cbb_LoaiDocGia";
            this.cbb_LoaiDocGia.Size = new System.Drawing.Size(276, 44);
            this.cbb_LoaiDocGia.TabIndex = 6;
            this.cbb_LoaiDocGia.ValueMember = "IDLoaiDG";
            // 
            // lOAIDOCGIABindingSource
            // 
            this.lOAIDOCGIABindingSource.DataMember = "LOAIDOCGIA";
            this.lOAIDOCGIABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(207, 354);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(276, 44);
            this.tb_Email.TabIndex = 5;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_DiaChi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_DiaChi.Location = new System.Drawing.Point(207, 292);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(276, 44);
            this.tb_DiaChi.TabIndex = 4;
            // 
            // tb_HoTenDocGia
            // 
            this.tb_HoTenDocGia.Location = new System.Drawing.Point(207, 172);
            this.tb_HoTenDocGia.Name = "tb_HoTenDocGia";
            this.tb_HoTenDocGia.Size = new System.Drawing.Size(276, 44);
            this.tb_HoTenDocGia.TabIndex = 2;
            // 
            // tb_IDDocGia
            // 
            this.tb_IDDocGia.Location = new System.Drawing.Point(207, 79);
            this.tb_IDDocGia.MaxLength = 3;
            this.tb_IDDocGia.Name = "tb_IDDocGia";
            this.tb_IDDocGia.Size = new System.Drawing.Size(276, 44);
            this.tb_IDDocGia.TabIndex = 1;
            this.tb_IDDocGia.TextChanged += new System.EventHandler(this.tb_IDDocGia_TextChanged);
            this.tb_IDDocGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(6, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày lập thẻ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(6, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loại độc giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID độc giả:";
            // 
            // lOAIDOCGIATableAdapter
            // 
            this.lOAIDOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // tHEDOCGIATableAdapter
            // 
            this.tHEDOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.ForeColor = System.Drawing.Color.Red;
            this.btn_Xuat.Image = global::QLTV.Properties.Resources.icons8_export_csv_40;
            this.btn_Xuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(120, 32);
            this.btn_Xuat.Text = "Xuất CSV";
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 35);
            // 
            // frmTheDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 848);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmTheDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thẻ độc giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTheDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.item_Them.ResumeLayout(false);
            this.item_Them.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThemDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOCGIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_Them;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbb_LoaiDocGia;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_HoTenDocGia;
        private System.Windows.Forms.TextBox tb_IDDocGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource lOAIDOCGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.LOAIDOCGIATableAdapter lOAIDOCGIATableAdapter;
        private System.Windows.Forms.DataGridView dgv_ThemDG;
        private System.Windows.Forms.BindingSource tHEDOCGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.THEDOCGIATableAdapter tHEDOCGIATableAdapter;
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
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.PictureBox pic_Ss;
        private System.Windows.Forms.PictureBox pic_Warning;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btn_Luu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_Sua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btn_Xuat;
    }
}