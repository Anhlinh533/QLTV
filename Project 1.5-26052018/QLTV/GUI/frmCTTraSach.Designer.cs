namespace QLTV.GUI
{
    partial class frmCTTraSach
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
            this.dgv_Them = new System.Windows.Forms.DataGridView();
            this.iDCTPhieuTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCuonSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienPhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPHIEUTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lb = new System.Windows.Forms.ListBox();
            this.cbb_IDPhieuTra = new System.Windows.Forms.TextBox();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.pic_Ss = new System.Windows.Forms.PictureBox();
            this.pic_Warning = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_IDCTPhieuTra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_PHIEUTRATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CT_PHIEUTRATableAdapter();
            this.cUONSACHTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CUONSACHTableAdapter();
            this.pHIEUTRATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.PHIEUTRATableAdapter();
            this.cbb_IDCuonSach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_TenTacGia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.item_Them.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUTRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRABindingSource)).BeginInit();
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
            this.navigationPane1.RegularSize = new System.Drawing.Size(1823, 1038);
            this.navigationPane1.SelectedPage = this.item_Them;
            this.navigationPane1.Size = new System.Drawing.Size(1823, 1038);
            this.navigationPane1.TabIndex = 3;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // item_Them
            // 
            this.item_Them.Caption = "Thêm chi tiết phiếu trả sách";
            this.item_Them.Controls.Add(this.groupControl2);
            this.item_Them.Controls.Add(this.groupControl1);
            this.item_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_plus_40;
            this.item_Them.Name = "item_Them";
            this.item_Them.Size = new System.Drawing.Size(1733, 958);
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
            this.groupControl2.Location = new System.Drawing.Point(606, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1127, 957);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu chi tiết phiếu trả sách";
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
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1123, 35);
            this.bindingNavigator1.TabIndex = 16;
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
            // dgv_Them
            // 
            this.dgv_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Them.AutoGenerateColumns = false;
            this.dgv_Them.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Them.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCTPhieuTraDataGridViewTextBoxColumn,
            this.iDPhieuTraDataGridViewTextBoxColumn,
            this.iDCuonSachDataGridViewTextBoxColumn,
            this.iDPhieuMuonDataGridViewTextBoxColumn,
            this.soNgayMuonDataGridViewTextBoxColumn,
            this.tienPhatDataGridViewTextBoxColumn});
            this.dgv_Them.DataSource = this.cTPHIEUTRABindingSource;
            this.dgv_Them.Location = new System.Drawing.Point(6, 97);
            this.dgv_Them.Name = "dgv_Them";
            this.dgv_Them.RowTemplate.Height = 28;
            this.dgv_Them.Size = new System.Drawing.Size(1115, 854);
            this.dgv_Them.TabIndex = 2;
            this.dgv_Them.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Them_CellClick);
            // 
            // iDCTPhieuTraDataGridViewTextBoxColumn
            // 
            this.iDCTPhieuTraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDCTPhieuTraDataGridViewTextBoxColumn.DataPropertyName = "IDCTPhieuTra";
            this.iDCTPhieuTraDataGridViewTextBoxColumn.HeaderText = "ID chi tiết phiếu trả";
            this.iDCTPhieuTraDataGridViewTextBoxColumn.Name = "iDCTPhieuTraDataGridViewTextBoxColumn";
            this.iDCTPhieuTraDataGridViewTextBoxColumn.Width = 249;
            // 
            // iDPhieuTraDataGridViewTextBoxColumn
            // 
            this.iDPhieuTraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDPhieuTraDataGridViewTextBoxColumn.DataPropertyName = "IDPhieuTra";
            this.iDPhieuTraDataGridViewTextBoxColumn.HeaderText = "ID phiếu trả";
            this.iDPhieuTraDataGridViewTextBoxColumn.Name = "iDPhieuTraDataGridViewTextBoxColumn";
            this.iDPhieuTraDataGridViewTextBoxColumn.Width = 193;
            // 
            // iDCuonSachDataGridViewTextBoxColumn
            // 
            this.iDCuonSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDCuonSachDataGridViewTextBoxColumn.DataPropertyName = "IDCuonSach";
            this.iDCuonSachDataGridViewTextBoxColumn.HeaderText = "ID cuốn sách";
            this.iDCuonSachDataGridViewTextBoxColumn.Name = "iDCuonSachDataGridViewTextBoxColumn";
            this.iDCuonSachDataGridViewTextBoxColumn.Width = 205;
            // 
            // iDPhieuMuonDataGridViewTextBoxColumn
            // 
            this.iDPhieuMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDPhieuMuonDataGridViewTextBoxColumn.DataPropertyName = "IDPhieuMuon";
            this.iDPhieuMuonDataGridViewTextBoxColumn.HeaderText = "ID phiếu mượn";
            this.iDPhieuMuonDataGridViewTextBoxColumn.Name = "iDPhieuMuonDataGridViewTextBoxColumn";
            this.iDPhieuMuonDataGridViewTextBoxColumn.Width = 229;
            // 
            // soNgayMuonDataGridViewTextBoxColumn
            // 
            this.soNgayMuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.soNgayMuonDataGridViewTextBoxColumn.DataPropertyName = "SoNgayMuon";
            this.soNgayMuonDataGridViewTextBoxColumn.HeaderText = "Số ngày mượn";
            this.soNgayMuonDataGridViewTextBoxColumn.Name = "soNgayMuonDataGridViewTextBoxColumn";
            this.soNgayMuonDataGridViewTextBoxColumn.Width = 223;
            // 
            // tienPhatDataGridViewTextBoxColumn
            // 
            this.tienPhatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tienPhatDataGridViewTextBoxColumn.DataPropertyName = "TienPhat";
            this.tienPhatDataGridViewTextBoxColumn.HeaderText = "Tiền Phạt";
            this.tienPhatDataGridViewTextBoxColumn.Name = "tienPhatDataGridViewTextBoxColumn";
            this.tienPhatDataGridViewTextBoxColumn.Width = 163;
            // 
            // cTPHIEUTRABindingSource
            // 
            this.cTPHIEUTRABindingSource.DataMember = "CT_PHIEUTRA";
            this.cTPHIEUTRABindingSource.DataSource = this.quanLyThuVienDataSet;
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
            this.groupControl1.Controls.Add(this.tb_TenTacGia);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cbb_IDCuonSach);
            this.groupControl1.Controls.Add(this.lb);
            this.groupControl1.Controls.Add(this.cbb_IDPhieuTra);
            this.groupControl1.Controls.Add(this.btn_Them);
            this.groupControl1.Controls.Add(this.pic_Ss);
            this.groupControl1.Controls.Add(this.pic_Warning);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.tb_IDCTPhieuTra);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(600, 957);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin chi tiết phiếu trả sách";
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 36;
            this.lb.Location = new System.Drawing.Point(12, 357);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(528, 220);
            this.lb.TabIndex = 36;
            this.lb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDoubleClick);
            // 
            // cbb_IDPhieuTra
            // 
            this.cbb_IDPhieuTra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_IDPhieuTra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbb_IDPhieuTra.Location = new System.Drawing.Point(297, 175);
            this.cbb_IDPhieuTra.Name = "cbb_IDPhieuTra";
            this.cbb_IDPhieuTra.Size = new System.Drawing.Size(243, 44);
            this.cbb_IDPhieuTra.TabIndex = 34;
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.btn_Them.Location = new System.Drawing.Point(190, 609);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(157, 75);
            this.btn_Them.TabIndex = 33;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // pic_Ss
            // 
            this.pic_Ss.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.pic_Ss.Location = new System.Drawing.Point(546, 78);
            this.pic_Ss.Name = "pic_Ss";
            this.pic_Ss.Size = new System.Drawing.Size(38, 39);
            this.pic_Ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ss.TabIndex = 19;
            this.pic_Ss.TabStop = false;
            // 
            // pic_Warning
            // 
            this.pic_Warning.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.pic_Warning.Location = new System.Drawing.Point(546, 78);
            this.pic_Warning.Name = "pic_Warning";
            this.pic_Warning.Size = new System.Drawing.Size(38, 39);
            this.pic_Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Warning.TabIndex = 18;
            this.pic_Warning.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(293, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên cuốn sách:";
            // 
            // tb_IDCTPhieuTra
            // 
            this.tb_IDCTPhieuTra.Location = new System.Drawing.Point(297, 78);
            this.tb_IDCTPhieuTra.MaxLength = 3;
            this.tb_IDCTPhieuTra.Name = "tb_IDCTPhieuTra";
            this.tb_IDCTPhieuTra.Size = new System.Drawing.Size(243, 44);
            this.tb_IDCTPhieuTra.TabIndex = 1;
            this.tb_IDCTPhieuTra.TextChanged += new System.EventHandler(this.tb_IDCTPhieuTra_TextChanged);
            this.tb_IDCTPhieuTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID phiếu trả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID chi tiết phiếu trả:";
            // 
            // cUONSACHBindingSource
            // 
            this.cUONSACHBindingSource.DataMember = "CUONSACH";
            this.cUONSACHBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // pHIEUTRABindingSource
            // 
            this.pHIEUTRABindingSource.DataMember = "PHIEUTRA";
            this.pHIEUTRABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // cT_PHIEUTRATableAdapter
            // 
            this.cT_PHIEUTRATableAdapter.ClearBeforeFill = true;
            // 
            // cUONSACHTableAdapter
            // 
            this.cUONSACHTableAdapter.ClearBeforeFill = true;
            // 
            // pHIEUTRATableAdapter
            // 
            this.pHIEUTRATableAdapter.ClearBeforeFill = true;
            // 
            // cbb_IDCuonSach
            // 
            this.cbb_IDCuonSach.FormattingEnabled = true;
            this.cbb_IDCuonSach.Location = new System.Drawing.Point(297, 235);
            this.cbb_IDCuonSach.Name = "cbb_IDCuonSach";
            this.cbb_IDCuonSach.Size = new System.Drawing.Size(243, 44);
            this.cbb_IDCuonSach.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 36);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tên tác giả:";
            // 
            // tb_TenTacGia
            // 
            this.tb_TenTacGia.Enabled = false;
            this.tb_TenTacGia.Location = new System.Drawing.Point(297, 293);
            this.tb_TenTacGia.Name = "tb_TenTacGia";
            this.tb_TenTacGia.Size = new System.Drawing.Size(243, 44);
            this.tb_TenTacGia.TabIndex = 39;
            // 
            // frmCTTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1823, 1038);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmCTTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu trả sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCTTraSach_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUTRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_Them;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgv_Them;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource cTPHIEUTRABindingSource;
        private QuanLyThuVienDataSetTableAdapters.CT_PHIEUTRATableAdapter cT_PHIEUTRATableAdapter;
        private System.Windows.Forms.TextBox tb_IDCTPhieuTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource cUONSACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.CUONSACHTableAdapter cUONSACHTableAdapter;
        private System.Windows.Forms.BindingSource pHIEUTRABindingSource;
        private QuanLyThuVienDataSetTableAdapters.PHIEUTRATableAdapter pHIEUTRATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCTPhieuTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCuonSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienPhatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_Ss;
        private System.Windows.Forms.PictureBox pic_Warning;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private System.Windows.Forms.TextBox cbb_IDPhieuTra;
        private System.Windows.Forms.ListBox lb;
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
        private System.Windows.Forms.TextBox tb_TenTacGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_IDCuonSach;
    }
}