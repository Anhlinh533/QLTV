namespace QLTV.GUI
{
    partial class frmTraSach
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
            this.dgv_Them = new System.Windows.Forms.DataGridView();
            this.iDPhieuTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienPhatKyNayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienNoKyNayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.pic_Ss = new System.Windows.Forms.PictureBox();
            this.pic_Warning = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.cbb_IDDocGia = new System.Windows.Forms.ComboBox();
            this.tHEDOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_SoTienTra = new System.Windows.Forms.TextBox();
            this.tb_IDPhieuTra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pHIEUTRATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.PHIEUTRATableAdapter();
            this.tHEDOCGIATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.THEDOCGIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.item_Them.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDOCGIABindingSource)).BeginInit();
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
            this.navigationPane1.RegularSize = new System.Drawing.Size(1544, 1007);
            this.navigationPane1.SelectedPage = this.item_Them;
            this.navigationPane1.Size = new System.Drawing.Size(1544, 1007);
            this.navigationPane1.TabIndex = 2;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // item_Them
            // 
            this.item_Them.Caption = "Thêm phiếu trả sách";
            this.item_Them.Controls.Add(this.groupControl2);
            this.item_Them.Controls.Add(this.groupControl1);
            this.item_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_plus_40;
            this.item_Them.Name = "item_Them";
            this.item_Them.Size = new System.Drawing.Size(1454, 927);
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
            this.groupControl2.Controls.Add(this.bindingNavigator1);
            this.groupControl2.Controls.Add(this.dgv_Them);
            this.groupControl2.Location = new System.Drawing.Point(521, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(933, 926);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu phiếu trả sách";
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
            this.bindingNavigator1.Size = new System.Drawing.Size(929, 31);
            this.bindingNavigator1.TabIndex = 13;
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
            this.toolStripLabel1.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Sua.Image = global::QLTV.Properties.Resources.icons8_pencil_80;
            this.btn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(28, 28);
            this.btn_Sua.Text = "Sửa thông tin";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
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
            this.toolStripLabel2.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Xoa.Image = global::QLTV.Properties.Resources.icons8_cancel_80;
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(28, 28);
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.toolStripLabel3.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Reset.Image = global::QLTV.Properties.Resources.icons8_available_updates_40;
            this.btn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(28, 28);
            this.btn_Reset.Text = "Reset dữ liệu";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
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
            this.toolStripLabel4.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Exit.Image = global::QLTV.Properties.Resources.icons8_shutdown_80;
            this.btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(28, 28);
            this.btn_Exit.Text = "toolStripButton1";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dgv_Them
            // 
            this.dgv_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Them.AutoGenerateColumns = false;
            this.dgv_Them.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Them.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPhieuTraDataGridViewTextBoxColumn,
            this.iDDocGiaDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.tienPhatKyNayDataGridViewTextBoxColumn,
            this.soTienTraDataGridViewTextBoxColumn,
            this.tienNoKyNayDataGridViewTextBoxColumn});
            this.dgv_Them.DataSource = this.pHIEUTRABindingSource;
            this.dgv_Them.Location = new System.Drawing.Point(6, 99);
            this.dgv_Them.Name = "dgv_Them";
            this.dgv_Them.RowTemplate.Height = 28;
            this.dgv_Them.Size = new System.Drawing.Size(921, 824);
            this.dgv_Them.TabIndex = 2;
            this.dgv_Them.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Them_CellClick);
            // 
            // iDPhieuTraDataGridViewTextBoxColumn
            // 
            this.iDPhieuTraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDPhieuTraDataGridViewTextBoxColumn.DataPropertyName = "IDPhieuTra";
            this.iDPhieuTraDataGridViewTextBoxColumn.HeaderText = "ID phiếu trả";
            this.iDPhieuTraDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.iDPhieuTraDataGridViewTextBoxColumn.Name = "iDPhieuTraDataGridViewTextBoxColumn";
            this.iDPhieuTraDataGridViewTextBoxColumn.Width = 193;
            // 
            // iDDocGiaDataGridViewTextBoxColumn
            // 
            this.iDDocGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDocGiaDataGridViewTextBoxColumn.DataPropertyName = "IDDocGia";
            this.iDDocGiaDataGridViewTextBoxColumn.HeaderText = "ID độc giả";
            this.iDDocGiaDataGridViewTextBoxColumn.MaxInputLength = 6;
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
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_Them);
            this.groupControl1.Controls.Add(this.pic_Ss);
            this.groupControl1.Controls.Add(this.pic_Warning);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.dtp_NgayTra);
            this.groupControl1.Controls.Add(this.cbb_IDDocGia);
            this.groupControl1.Controls.Add(this.tb_SoTienTra);
            this.groupControl1.Controls.Add(this.tb_IDPhieuTra);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(515, 926);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin phiếu trả sách";
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.btn_Them.Location = new System.Drawing.Point(204, 371);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(157, 75);
            this.btn_Them.TabIndex = 39;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // pic_Ss
            // 
            this.pic_Ss.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.pic_Ss.Location = new System.Drawing.Point(462, 78);
            this.pic_Ss.Name = "pic_Ss";
            this.pic_Ss.Size = new System.Drawing.Size(37, 39);
            this.pic_Ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ss.TabIndex = 18;
            this.pic_Ss.TabStop = false;
            // 
            // pic_Warning
            // 
            this.pic_Warning.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.pic_Warning.Location = new System.Drawing.Point(462, 78);
            this.pic_Warning.Name = "pic_Warning";
            this.pic_Warning.Size = new System.Drawing.Size(37, 39);
            this.pic_Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Warning.TabIndex = 17;
            this.pic_Warning.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(249, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTra.Location = new System.Drawing.Point(253, 225);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(203, 44);
            this.dtp_NgayTra.TabIndex = 3;
            // 
            // cbb_IDDocGia
            // 
            this.cbb_IDDocGia.DataSource = this.tHEDOCGIABindingSource;
            this.cbb_IDDocGia.DisplayMember = "IDDocGia";
            this.cbb_IDDocGia.FormattingEnabled = true;
            this.cbb_IDDocGia.Location = new System.Drawing.Point(253, 168);
            this.cbb_IDDocGia.Name = "cbb_IDDocGia";
            this.cbb_IDDocGia.Size = new System.Drawing.Size(203, 44);
            this.cbb_IDDocGia.TabIndex = 2;
            this.cbb_IDDocGia.ValueMember = "IDDocGia";
            this.cbb_IDDocGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tHEDOCGIABindingSource
            // 
            this.tHEDOCGIABindingSource.DataMember = "THEDOCGIA";
            this.tHEDOCGIABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // tb_SoTienTra
            // 
            this.tb_SoTienTra.Location = new System.Drawing.Point(253, 288);
            this.tb_SoTienTra.Name = "tb_SoTienTra";
            this.tb_SoTienTra.Size = new System.Drawing.Size(203, 44);
            this.tb_SoTienTra.TabIndex = 4;
            this.tb_SoTienTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_IDPhieuTra
            // 
            this.tb_IDPhieuTra.Location = new System.Drawing.Point(253, 78);
            this.tb_IDPhieuTra.MaxLength = 3;
            this.tb_IDPhieuTra.Name = "tb_IDPhieuTra";
            this.tb_IDPhieuTra.Size = new System.Drawing.Size(203, 44);
            this.tb_IDPhieuTra.TabIndex = 1;
            this.tb_IDPhieuTra.TextChanged += new System.EventHandler(this.tb_IDPhieuTra_TextChanged);
            this.tb_IDPhieuTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID phiếu trả:";
            // 
            // pHIEUTRATableAdapter
            // 
            this.pHIEUTRATableAdapter.ClearBeforeFill = true;
            // 
            // tHEDOCGIATableAdapter
            // 
            this.tHEDOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 1007);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu trả sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.item_Them.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDOCGIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_Them;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgv_Them;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource pHIEUTRABindingSource;
        private QuanLyThuVienDataSetTableAdapters.PHIEUTRATableAdapter pHIEUTRATableAdapter;
        private System.Windows.Forms.ComboBox cbb_IDDocGia;
        private System.Windows.Forms.TextBox tb_SoTienTra;
        private System.Windows.Forms.TextBox tb_IDPhieuTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienPhatKyNayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienNoKyNayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtp_NgayTra;
        private System.Windows.Forms.BindingSource tHEDOCGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.THEDOCGIATableAdapter tHEDOCGIATableAdapter;
        private System.Windows.Forms.PictureBox pic_Ss;
        private System.Windows.Forms.PictureBox pic_Warning;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
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
    }
}