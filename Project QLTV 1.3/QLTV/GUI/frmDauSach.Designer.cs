namespace QLTV.GUI
{
    partial class frmDauSach
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
            this.dgv_ThemDauSach = new System.Windows.Forms.DataGridView();
            this.iDDauSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDauSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLoaiSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAUSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.pic_Ss = new System.Windows.Forms.PictureBox();
            this.pic_Warning = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_TenDauSach = new System.Windows.Forms.TextBox();
            this.cbb_IDTheLoaiSach = new System.Windows.Forms.ComboBox();
            this.lOAISACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_IDDauSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.item_Xoa = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btn_IDDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_IDDelete = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dAUSACHTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.DAUSACHTableAdapter();
            this.lOAISACHTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.LOAISACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.item_Them.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThemDauSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISACHBindingSource)).BeginInit();
            this.item_Xoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.item_Them);
            this.navigationPane1.Controls.Add(this.item_Xoa);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.item_Them,
            this.item_Xoa});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1749, 1018);
            this.navigationPane1.SelectedPage = this.item_Them;
            this.navigationPane1.Size = new System.Drawing.Size(1749, 1018);
            this.navigationPane1.TabIndex = 2;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // item_Them
            // 
            this.item_Them.Caption = "Thêm đầu sách";
            this.item_Them.Controls.Add(this.groupControl2);
            this.item_Them.Controls.Add(this.groupControl1);
            this.item_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_plus_40;
            this.item_Them.Name = "item_Them";
            this.item_Them.Size = new System.Drawing.Size(1659, 938);
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
            this.groupControl2.Controls.Add(this.dgv_ThemDauSach);
            this.groupControl2.Location = new System.Drawing.Point(596, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1064, 934);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu đầu sách";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1060, 31);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // dgv_ThemDauSach
            // 
            this.dgv_ThemDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ThemDauSach.AutoGenerateColumns = false;
            this.dgv_ThemDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThemDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDauSachDataGridViewTextBoxColumn,
            this.tenDauSachDataGridViewTextBoxColumn,
            this.iDLoaiSachDataGridViewTextBoxColumn});
            this.dgv_ThemDauSach.DataSource = this.dAUSACHBindingSource;
            this.dgv_ThemDauSach.Location = new System.Drawing.Point(6, 97);
            this.dgv_ThemDauSach.Name = "dgv_ThemDauSach";
            this.dgv_ThemDauSach.RowTemplate.Height = 28;
            this.dgv_ThemDauSach.Size = new System.Drawing.Size(1052, 831);
            this.dgv_ThemDauSach.TabIndex = 2;
            this.dgv_ThemDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThemDauSach_CellClick);
            // 
            // iDDauSachDataGridViewTextBoxColumn
            // 
            this.iDDauSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDauSachDataGridViewTextBoxColumn.DataPropertyName = "IDDauSach";
            this.iDDauSachDataGridViewTextBoxColumn.HeaderText = "ID đầu sách";
            this.iDDauSachDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.iDDauSachDataGridViewTextBoxColumn.Name = "iDDauSachDataGridViewTextBoxColumn";
            this.iDDauSachDataGridViewTextBoxColumn.Width = 192;
            // 
            // tenDauSachDataGridViewTextBoxColumn
            // 
            this.tenDauSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenDauSachDataGridViewTextBoxColumn.DataPropertyName = "TenDauSach";
            this.tenDauSachDataGridViewTextBoxColumn.HeaderText = "Tên đầu sách";
            this.tenDauSachDataGridViewTextBoxColumn.MaxInputLength = 200;
            this.tenDauSachDataGridViewTextBoxColumn.Name = "tenDauSachDataGridViewTextBoxColumn";
            this.tenDauSachDataGridViewTextBoxColumn.Width = 210;
            // 
            // iDLoaiSachDataGridViewTextBoxColumn
            // 
            this.iDLoaiSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDLoaiSachDataGridViewTextBoxColumn.DataPropertyName = "IDLoaiSach";
            this.iDLoaiSachDataGridViewTextBoxColumn.HeaderText = "ID thể loại sách";
            this.iDLoaiSachDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.iDLoaiSachDataGridViewTextBoxColumn.Name = "iDLoaiSachDataGridViewTextBoxColumn";
            this.iDLoaiSachDataGridViewTextBoxColumn.Width = 181;
            // 
            // dAUSACHBindingSource
            // 
            this.dAUSACHBindingSource.DataMember = "DAUSACH";
            this.dAUSACHBindingSource.DataSource = this.quanLyThuVienDataSet;
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
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.tb_TenDauSach);
            this.groupControl1.Controls.Add(this.cbb_IDTheLoaiSach);
            this.groupControl1.Controls.Add(this.tb_IDDauSach);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(590, 937);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin đầu sách";
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.btn_Them.Location = new System.Drawing.Point(197, 295);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(157, 75);
            this.btn_Them.TabIndex = 35;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // pic_Ss
            // 
            this.pic_Ss.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.pic_Ss.Location = new System.Drawing.Point(529, 66);
            this.pic_Ss.Name = "pic_Ss";
            this.pic_Ss.Size = new System.Drawing.Size(37, 39);
            this.pic_Ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ss.TabIndex = 18;
            this.pic_Ss.TabStop = false;
            // 
            // pic_Warning
            // 
            this.pic_Warning.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.pic_Warning.Location = new System.Drawing.Point(529, 66);
            this.pic_Warning.Name = "pic_Warning";
            this.pic_Warning.Size = new System.Drawing.Size(37, 39);
            this.pic_Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Warning.TabIndex = 17;
            this.pic_Warning.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(240, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // tb_TenDauSach
            // 
            this.tb_TenDauSach.Location = new System.Drawing.Point(244, 161);
            this.tb_TenDauSach.MaxLength = 200;
            this.tb_TenDauSach.Name = "tb_TenDauSach";
            this.tb_TenDauSach.Size = new System.Drawing.Size(279, 44);
            this.tb_TenDauSach.TabIndex = 2;
            this.tb_TenDauSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chu_KeyPress);
            // 
            // cbb_IDTheLoaiSach
            // 
            this.cbb_IDTheLoaiSach.DataSource = this.lOAISACHBindingSource;
            this.cbb_IDTheLoaiSach.DisplayMember = "IDLoaiSach";
            this.cbb_IDTheLoaiSach.FormattingEnabled = true;
            this.cbb_IDTheLoaiSach.Location = new System.Drawing.Point(244, 219);
            this.cbb_IDTheLoaiSach.Name = "cbb_IDTheLoaiSach";
            this.cbb_IDTheLoaiSach.Size = new System.Drawing.Size(279, 44);
            this.cbb_IDTheLoaiSach.TabIndex = 3;
            this.cbb_IDTheLoaiSach.ValueMember = "IDLoaiSach";
            // 
            // lOAISACHBindingSource
            // 
            this.lOAISACHBindingSource.DataMember = "LOAISACH";
            this.lOAISACHBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // tb_IDDauSach
            // 
            this.tb_IDDauSach.Location = new System.Drawing.Point(244, 66);
            this.tb_IDDauSach.MaxLength = 3;
            this.tb_IDDauSach.Name = "tb_IDDauSach";
            this.tb_IDDauSach.Size = new System.Drawing.Size(279, 44);
            this.tb_IDDauSach.TabIndex = 1;
            this.tb_IDDauSach.TextChanged += new System.EventHandler(this.tb_IDDauSach_TextChanged);
            this.tb_IDDauSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID thể loại sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đầu sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID đầu sách:";
            // 
            // item_Xoa
            // 
            this.item_Xoa.Caption = "Xóa theo ID";
            this.item_Xoa.Controls.Add(this.groupControl3);
            this.item_Xoa.Controls.Add(this.groupControl4);
            this.item_Xoa.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.item_Xoa.Name = "item_Xoa";
            this.item_Xoa.Size = new System.Drawing.Size(1659, 938);
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
            this.groupControl3.Controls.Add(this.dataGridView1);
            this.groupControl3.Location = new System.Drawing.Point(388, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1284, 950);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Dữ liệu đầu sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.dAUSACHBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 903);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDDauSach";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID đầu sách";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 192;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenDauSach";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên đầu sách";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 210;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDLoaiSach";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID thể loại sách";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 181;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl4.Appearance.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.btn_IDDelete);
            this.groupControl4.Controls.Add(this.cbb_IDDelete);
            this.groupControl4.Controls.Add(this.label4);
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(382, 938);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Thông tin xóa";
            // 
            // btn_IDDelete
            // 
            this.btn_IDDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_IDDelete.Appearance.Options.UseFont = true;
            this.btn_IDDelete.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.btn_IDDelete.Location = new System.Drawing.Point(116, 218);
            this.btn_IDDelete.Name = "btn_IDDelete";
            this.btn_IDDelete.Size = new System.Drawing.Size(157, 75);
            this.btn_IDDelete.TabIndex = 35;
            this.btn_IDDelete.Text = "Xóa";
            this.btn_IDDelete.Click += new System.EventHandler(this.btn_IDDelete_Click);
            // 
            // cbb_IDDelete
            // 
            this.cbb_IDDelete.DataSource = this.dAUSACHBindingSource;
            this.cbb_IDDelete.DisplayMember = "IDDauSach";
            this.cbb_IDDelete.FormattingEnabled = true;
            this.cbb_IDDelete.Location = new System.Drawing.Point(12, 133);
            this.cbb_IDDelete.Name = "cbb_IDDelete";
            this.cbb_IDDelete.Size = new System.Drawing.Size(206, 44);
            this.cbb_IDDelete.TabIndex = 1;
            this.cbb_IDDelete.ValueMember = "IDDauSach";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID đầu sách cần xóa:";
            // 
            // dAUSACHTableAdapter
            // 
            this.dAUSACHTableAdapter.ClearBeforeFill = true;
            // 
            // lOAISACHTableAdapter
            // 
            this.lOAISACHTableAdapter.ClearBeforeFill = true;
            // 
            // frmDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 1018);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmDauSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đầu sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDauSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.item_Them.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThemDauSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISACHBindingSource)).EndInit();
            this.item_Xoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_Them;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_Xoa;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgv_ThemDauSach;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource dAUSACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.DAUSACHTableAdapter dAUSACHTableAdapter;
        private System.Windows.Forms.TextBox tb_TenDauSach;
        private System.Windows.Forms.ComboBox cbb_IDTheLoaiSach;
        private System.Windows.Forms.TextBox tb_IDDauSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource lOAISACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.LOAISACHTableAdapter lOAISACHTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb_IDDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDauSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDauSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLoaiSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.PictureBox pic_Ss;
        private System.Windows.Forms.PictureBox pic_Warning;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_IDDelete;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
    }
}