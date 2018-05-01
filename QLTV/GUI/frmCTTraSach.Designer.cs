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
            this.dgv_Them = new System.Windows.Forms.DataGridView();
            this.iDCTPhieuTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienPhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPHIEUTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Reset = new System.Windows.Forms.ToolStripButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Them = new Bunifu.Framework.UI.BunifuTileButton();
            this.cbb_IDPhieuMuon = new System.Windows.Forms.ComboBox();
            this.cbb_IDPhieuTra = new System.Windows.Forms.ComboBox();
            this.tb_SoNgayMuon = new System.Windows.Forms.TextBox();
            this.tb_TienPhat = new System.Windows.Forms.TextBox();
            this.tb_IDCTPhieuTra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.item_Xoa = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Delete = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btn_IDDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.cbb_Delete = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cT_PHIEUTRATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CT_PHIEUTRATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.item_Them.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUTRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.item_Xoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete)).BeginInit();
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
            this.item_Them.Size = new System.Drawing.Size(1733, 957);
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
            this.groupControl2.Controls.Add(this.dgv_Them);
            this.groupControl2.Controls.Add(this.bindingNavigator1);
            this.groupControl2.Location = new System.Drawing.Point(552, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1181, 957);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu chi tiết phiếu trả sách";
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
            this.iDPhieuMuonDataGridViewTextBoxColumn,
            this.soNgayMuonDataGridViewTextBoxColumn,
            this.tienPhatDataGridViewTextBoxColumn});
            this.dgv_Them.DataSource = this.cTPHIEUTRABindingSource;
            this.dgv_Them.Location = new System.Drawing.Point(6, 81);
            this.dgv_Them.Name = "dgv_Them";
            this.dgv_Them.RowTemplate.Height = 28;
            this.dgv_Them.Size = new System.Drawing.Size(1169, 870);
            this.dgv_Them.TabIndex = 2;
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
            this.tienPhatDataGridViewTextBoxColumn.HeaderText = "Tiền phạt";
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
            this.btn_Reset});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 47);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1175, 31);
            this.bindingNavigator1.TabIndex = 1;
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
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_Them);
            this.groupControl1.Controls.Add(this.cbb_IDPhieuMuon);
            this.groupControl1.Controls.Add(this.cbb_IDPhieuTra);
            this.groupControl1.Controls.Add(this.tb_SoNgayMuon);
            this.groupControl1.Controls.Add(this.tb_TienPhat);
            this.groupControl1.Controls.Add(this.tb_IDCTPhieuTra);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(546, 957);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin chi tiết phiếu trả sách";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Them.color = System.Drawing.Color.SeaGreen;
            this.btn_Them.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = global::QLTV.Properties.Resources.icons8_next_page_96;
            this.btn_Them.ImagePosition = 20;
            this.btn_Them.ImageZoom = 50;
            this.btn_Them.LabelPosition = 41;
            this.btn_Them.LabelText = "Thêm";
            this.btn_Them.Location = new System.Drawing.Point(196, 385);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(128, 147);
            this.btn_Them.TabIndex = 15;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cbb_IDPhieuMuon
            // 
            this.cbb_IDPhieuMuon.FormattingEnabled = true;
            this.cbb_IDPhieuMuon.Location = new System.Drawing.Point(297, 198);
            this.cbb_IDPhieuMuon.Name = "cbb_IDPhieuMuon";
            this.cbb_IDPhieuMuon.Size = new System.Drawing.Size(243, 44);
            this.cbb_IDPhieuMuon.TabIndex = 9;
            // 
            // cbb_IDPhieuTra
            // 
            this.cbb_IDPhieuTra.FormattingEnabled = true;
            this.cbb_IDPhieuTra.Location = new System.Drawing.Point(297, 138);
            this.cbb_IDPhieuTra.Name = "cbb_IDPhieuTra";
            this.cbb_IDPhieuTra.Size = new System.Drawing.Size(243, 44);
            this.cbb_IDPhieuTra.TabIndex = 8;
            // 
            // tb_SoNgayMuon
            // 
            this.tb_SoNgayMuon.Location = new System.Drawing.Point(297, 258);
            this.tb_SoNgayMuon.Name = "tb_SoNgayMuon";
            this.tb_SoNgayMuon.Size = new System.Drawing.Size(243, 44);
            this.tb_SoNgayMuon.TabIndex = 7;
            // 
            // tb_TienPhat
            // 
            this.tb_TienPhat.Location = new System.Drawing.Point(297, 318);
            this.tb_TienPhat.Name = "tb_TienPhat";
            this.tb_TienPhat.Size = new System.Drawing.Size(243, 44);
            this.tb_TienPhat.TabIndex = 6;
            // 
            // tb_IDCTPhieuTra
            // 
            this.tb_IDCTPhieuTra.Location = new System.Drawing.Point(297, 78);
            this.tb_IDCTPhieuTra.MaxLength = 3;
            this.tb_IDCTPhieuTra.Name = "tb_IDCTPhieuTra";
            this.tb_IDCTPhieuTra.Size = new System.Drawing.Size(243, 44);
            this.tb_IDCTPhieuTra.TabIndex = 5;
            this.tb_IDCTPhieuTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền phạt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số ngày mượn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID phiếu mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 141);
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
            // item_Xoa
            // 
            this.item_Xoa.Caption = "Xóa theo ID";
            this.item_Xoa.Controls.Add(this.groupControl3);
            this.item_Xoa.Controls.Add(this.groupControl4);
            this.item_Xoa.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.item_Xoa.Name = "item_Xoa";
            this.item_Xoa.Size = new System.Drawing.Size(1733, 957);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.dgv_Delete);
            this.groupControl3.Location = new System.Drawing.Point(454, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1279, 957);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Dữ liệu chi tiết phiếu trả sách";
            // 
            // dgv_Delete
            // 
            this.dgv_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Delete.AutoGenerateColumns = false;
            this.dgv_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Delete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_Delete.DataSource = this.cTPHIEUTRABindingSource;
            this.dgv_Delete.Location = new System.Drawing.Point(3, 47);
            this.dgv_Delete.Name = "dgv_Delete";
            this.dgv_Delete.RowTemplate.Height = 28;
            this.dgv_Delete.Size = new System.Drawing.Size(1273, 907);
            this.dgv_Delete.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDCTPhieuTra";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID chi tiết phiếu trả";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 249;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDPhieuTra";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID phiếu trả";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 193;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDPhieuMuon";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID phiếu mượn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 229;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoNgayMuon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số ngày mượn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 223;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TienPhat";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tiền phạt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 163;
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
            this.groupControl4.Controls.Add(this.cbb_Delete);
            this.groupControl4.Controls.Add(this.label6);
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(448, 957);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Thông tin xóa";
            // 
            // btn_IDDelete
            // 
            this.btn_IDDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_IDDelete.color = System.Drawing.Color.SeaGreen;
            this.btn_IDDelete.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_IDDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IDDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_IDDelete.ForeColor = System.Drawing.Color.White;
            this.btn_IDDelete.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.btn_IDDelete.ImagePosition = 20;
            this.btn_IDDelete.ImageZoom = 50;
            this.btn_IDDelete.LabelPosition = 41;
            this.btn_IDDelete.LabelText = "Xóa";
            this.btn_IDDelete.Location = new System.Drawing.Point(134, 193);
            this.btn_IDDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_IDDelete.Name = "btn_IDDelete";
            this.btn_IDDelete.Size = new System.Drawing.Size(128, 146);
            this.btn_IDDelete.TabIndex = 3;
            this.btn_IDDelete.Click += new System.EventHandler(this.btn_IDDelete_Click);
            // 
            // cbb_Delete
            // 
            this.cbb_Delete.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cTPHIEUTRABindingSource, "IDCTPhieuTra", true));
            this.cbb_Delete.DataSource = this.cTPHIEUTRABindingSource;
            this.cbb_Delete.DisplayMember = "IDCTPhieuTra";
            this.cbb_Delete.FormattingEnabled = true;
            this.cbb_Delete.Location = new System.Drawing.Point(9, 123);
            this.cbb_Delete.Name = "cbb_Delete";
            this.cbb_Delete.Size = new System.Drawing.Size(222, 44);
            this.cbb_Delete.TabIndex = 1;
            this.cbb_Delete.ValueMember = "IDCTPhieuTra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID chi tiết phiếu trả cần xóa:";
            // 
            // cT_PHIEUTRATableAdapter
            // 
            this.cT_PHIEUTRATableAdapter.ClearBeforeFill = true;
            // 
            // frmCTTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1823, 1038);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmCTTraSach";
            this.Text = "frmCTTraSach";
            this.Load += new System.EventHandler(this.frmCTTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.item_Them.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUTRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.item_Xoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_Them;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_Xoa;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.DataGridView dgv_Them;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_Sua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btn_Reset;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource cTPHIEUTRABindingSource;
        private QuanLyThuVienDataSetTableAdapters.CT_PHIEUTRATableAdapter cT_PHIEUTRATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCTPhieuTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienPhatDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbb_IDPhieuMuon;
        private System.Windows.Forms.ComboBox cbb_IDPhieuTra;
        private System.Windows.Forms.TextBox tb_SoNgayMuon;
        private System.Windows.Forms.TextBox tb_TienPhat;
        private System.Windows.Forms.TextBox tb_IDCTPhieuTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btn_Them;
        private System.Windows.Forms.DataGridView dgv_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox cbb_Delete;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuTileButton btn_IDDelete;
    }
}