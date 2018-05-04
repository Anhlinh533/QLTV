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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPhieuTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienPhatKyNayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienNoKyNayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.btn_TKPhieuTraSach = new Bunifu.Framework.UI.BunifuTileButton();
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
            this.dgv_TKCTPhieuTraSach = new System.Windows.Forms.DataGridView();
            this.iDCTPhieuTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuTraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhieuMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienPhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPHIEUTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_TKCTPhieuTraSach = new Bunifu.Framework.UI.BunifuTileButton();
            this.tb_TienPhat = new System.Windows.Forms.TextBox();
            this.tb_SoNgayMuon = new System.Windows.Forms.TextBox();
            this.tb_IDPhieuMuon = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            this.navigationPane1.RegularSize = new System.Drawing.Size(1467, 1082);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(1467, 1082);
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
            this.navigationPage1.Size = new System.Drawing.Size(1353, 1001);
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
            this.groupControl4.Controls.Add(this.dataGridView1);
            this.groupControl4.Location = new System.Drawing.Point(430, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(924, 1001);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Dữ liệu thông tin mượn sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPhieuTraDataGridViewTextBoxColumn,
            this.iDDocGiaDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.tienPhatKyNayDataGridViewTextBoxColumn,
            this.soTienTraDataGridViewTextBoxColumn,
            this.tienNoKyNayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pHIEUTRABindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(918, 951);
            this.dataGridView1.TabIndex = 0;
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
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.dtp_NgayTra);
            this.groupControl3.Controls.Add(this.btn_TKPhieuTraSach);
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
            this.groupControl3.Size = new System.Drawing.Size(424, 1001);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Tìm kiếm theo";
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTra.Location = new System.Drawing.Point(267, 190);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(151, 44);
            this.dtp_NgayTra.TabIndex = 18;
            // 
            // btn_TKPhieuTraSach
            // 
            this.btn_TKPhieuTraSach.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_TKPhieuTraSach.color = System.Drawing.Color.SeaGreen;
            this.btn_TKPhieuTraSach.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_TKPhieuTraSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TKPhieuTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_TKPhieuTraSach.ForeColor = System.Drawing.Color.White;
            this.btn_TKPhieuTraSach.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKPhieuTraSach.ImagePosition = 20;
            this.btn_TKPhieuTraSach.ImageZoom = 50;
            this.btn_TKPhieuTraSach.LabelPosition = 41;
            this.btn_TKPhieuTraSach.LabelText = "Tìm kiếm";
            this.btn_TKPhieuTraSach.Location = new System.Drawing.Point(129, 426);
            this.btn_TKPhieuTraSach.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TKPhieuTraSach.Name = "btn_TKPhieuTraSach";
            this.btn_TKPhieuTraSach.Size = new System.Drawing.Size(155, 162);
            this.btn_TKPhieuTraSach.TabIndex = 17;
            // 
            // tb_TienNoKiNay
            // 
            this.tb_TienNoKiNay.Location = new System.Drawing.Point(267, 373);
            this.tb_TienNoKiNay.Name = "tb_TienNoKiNay";
            this.tb_TienNoKiNay.Size = new System.Drawing.Size(151, 44);
            this.tb_TienNoKiNay.TabIndex = 10;
            // 
            // tb_SoTienTra
            // 
            this.tb_SoTienTra.Location = new System.Drawing.Point(267, 313);
            this.tb_SoTienTra.Name = "tb_SoTienTra";
            this.tb_SoTienTra.Size = new System.Drawing.Size(151, 44);
            this.tb_SoTienTra.TabIndex = 9;
            // 
            // tb_IDPhieuTra
            // 
            this.tb_IDPhieuTra.Location = new System.Drawing.Point(267, 73);
            this.tb_IDPhieuTra.Name = "tb_IDPhieuTra";
            this.tb_IDPhieuTra.Size = new System.Drawing.Size(151, 44);
            this.tb_IDPhieuTra.TabIndex = 8;
            // 
            // tb_IDDocGia
            // 
            this.tb_IDDocGia.Location = new System.Drawing.Point(267, 133);
            this.tb_IDDocGia.Name = "tb_IDDocGia";
            this.tb_IDDocGia.Size = new System.Drawing.Size(151, 44);
            this.tb_IDDocGia.TabIndex = 7;
            // 
            // tb_TienPhatKiNay
            // 
            this.tb_TienPhatKiNay.Location = new System.Drawing.Point(267, 253);
            this.tb_TienPhatKiNay.Name = "tb_TienPhatKiNay";
            this.tb_TienPhatKiNay.Size = new System.Drawing.Size(151, 44);
            this.tb_TienPhatKiNay.TabIndex = 6;
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
            this.rdb_IDPhieuTra.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDPhieuTra.Location = new System.Drawing.Point(6, 74);
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
            this.navigationPage2.Size = new System.Drawing.Size(1353, 1001);
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
            this.groupControl2.Controls.Add(this.dgv_TKCTPhieuTraSach);
            this.groupControl2.Location = new System.Drawing.Point(478, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(876, 1001);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu thông tin chi tiết phiếu trả sách";
            // 
            // dgv_TKCTPhieuTraSach
            // 
            this.dgv_TKCTPhieuTraSach.AutoGenerateColumns = false;
            this.dgv_TKCTPhieuTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKCTPhieuTraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCTPhieuTraDataGridViewTextBoxColumn,
            this.iDPhieuTraDataGridViewTextBoxColumn1,
            this.iDPhieuMuonDataGridViewTextBoxColumn,
            this.soNgayMuonDataGridViewTextBoxColumn,
            this.tienPhatDataGridViewTextBoxColumn});
            this.dgv_TKCTPhieuTraSach.DataSource = this.cTPHIEUTRABindingSource;
            this.dgv_TKCTPhieuTraSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TKCTPhieuTraSach.Location = new System.Drawing.Point(3, 47);
            this.dgv_TKCTPhieuTraSach.Name = "dgv_TKCTPhieuTraSach";
            this.dgv_TKCTPhieuTraSach.RowTemplate.Height = 28;
            this.dgv_TKCTPhieuTraSach.Size = new System.Drawing.Size(870, 951);
            this.dgv_TKCTPhieuTraSach.TabIndex = 0;
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
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_TKCTPhieuTraSach);
            this.groupControl1.Controls.Add(this.tb_TienPhat);
            this.groupControl1.Controls.Add(this.tb_SoNgayMuon);
            this.groupControl1.Controls.Add(this.tb_IDPhieuMuon);
            this.groupControl1.Controls.Add(this.tb_IDPhieuTraCT);
            this.groupControl1.Controls.Add(this.tb_IDCTPhieuTra);
            this.groupControl1.Controls.Add(this.rdb_TienPhat);
            this.groupControl1.Controls.Add(this.rdb_SoNgayMuon);
            this.groupControl1.Controls.Add(this.rdb_IDPhieuMuon);
            this.groupControl1.Controls.Add(this.rdb_IDPhieuTraCT);
            this.groupControl1.Controls.Add(this.rdb_IDCTPhieuTra);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(472, 1001);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm theo";
            // 
            // btn_TKCTPhieuTraSach
            // 
            this.btn_TKCTPhieuTraSach.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_TKCTPhieuTraSach.color = System.Drawing.Color.SeaGreen;
            this.btn_TKCTPhieuTraSach.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_TKCTPhieuTraSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TKCTPhieuTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_TKCTPhieuTraSach.ForeColor = System.Drawing.Color.White;
            this.btn_TKCTPhieuTraSach.Image = global::QLTV.Properties.Resources.icons8_search_48;
            this.btn_TKCTPhieuTraSach.ImagePosition = 20;
            this.btn_TKCTPhieuTraSach.ImageZoom = 50;
            this.btn_TKCTPhieuTraSach.LabelPosition = 41;
            this.btn_TKCTPhieuTraSach.LabelText = "Tìm kiếm";
            this.btn_TKCTPhieuTraSach.Location = new System.Drawing.Point(161, 388);
            this.btn_TKCTPhieuTraSach.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TKCTPhieuTraSach.Name = "btn_TKCTPhieuTraSach";
            this.btn_TKCTPhieuTraSach.Size = new System.Drawing.Size(155, 162);
            this.btn_TKCTPhieuTraSach.TabIndex = 18;
            // 
            // tb_TienPhat
            // 
            this.tb_TienPhat.Location = new System.Drawing.Point(311, 320);
            this.tb_TienPhat.Name = "tb_TienPhat";
            this.tb_TienPhat.Size = new System.Drawing.Size(155, 44);
            this.tb_TienPhat.TabIndex = 9;
            // 
            // tb_SoNgayMuon
            // 
            this.tb_SoNgayMuon.Location = new System.Drawing.Point(311, 260);
            this.tb_SoNgayMuon.Name = "tb_SoNgayMuon";
            this.tb_SoNgayMuon.Size = new System.Drawing.Size(155, 44);
            this.tb_SoNgayMuon.TabIndex = 8;
            // 
            // tb_IDPhieuMuon
            // 
            this.tb_IDPhieuMuon.Location = new System.Drawing.Point(311, 200);
            this.tb_IDPhieuMuon.Name = "tb_IDPhieuMuon";
            this.tb_IDPhieuMuon.Size = new System.Drawing.Size(155, 44);
            this.tb_IDPhieuMuon.TabIndex = 7;
            // 
            // tb_IDPhieuTraCT
            // 
            this.tb_IDPhieuTraCT.Location = new System.Drawing.Point(311, 140);
            this.tb_IDPhieuTraCT.Name = "tb_IDPhieuTraCT";
            this.tb_IDPhieuTraCT.Size = new System.Drawing.Size(155, 44);
            this.tb_IDPhieuTraCT.TabIndex = 6;
            // 
            // tb_IDCTPhieuTra
            // 
            this.tb_IDCTPhieuTra.Location = new System.Drawing.Point(311, 80);
            this.tb_IDCTPhieuTra.Name = "tb_IDCTPhieuTra";
            this.tb_IDCTPhieuTra.Size = new System.Drawing.Size(155, 44);
            this.tb_IDCTPhieuTra.TabIndex = 5;
            // 
            // rdb_TienPhat
            // 
            this.rdb_TienPhat.AutoSize = true;
            this.rdb_TienPhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdb_TienPhat.ForeColor = System.Drawing.Color.Red;
            this.rdb_TienPhat.Location = new System.Drawing.Point(6, 321);
            this.rdb_TienPhat.Name = "rdb_TienPhat";
            this.rdb_TienPhat.Size = new System.Drawing.Size(167, 40);
            this.rdb_TienPhat.TabIndex = 4;
            this.rdb_TienPhat.TabStop = true;
            this.rdb_TienPhat.Text = "Tiền phạt";
            this.rdb_TienPhat.UseVisualStyleBackColor = true;
            // 
            // rdb_SoNgayMuon
            // 
            this.rdb_SoNgayMuon.AutoSize = true;
            this.rdb_SoNgayMuon.ForeColor = System.Drawing.Color.Red;
            this.rdb_SoNgayMuon.Location = new System.Drawing.Point(6, 261);
            this.rdb_SoNgayMuon.Name = "rdb_SoNgayMuon";
            this.rdb_SoNgayMuon.Size = new System.Drawing.Size(233, 40);
            this.rdb_SoNgayMuon.TabIndex = 3;
            this.rdb_SoNgayMuon.TabStop = true;
            this.rdb_SoNgayMuon.Text = "Số ngày mượn";
            this.rdb_SoNgayMuon.UseVisualStyleBackColor = true;
            // 
            // rdb_IDPhieuMuon
            // 
            this.rdb_IDPhieuMuon.AutoSize = true;
            this.rdb_IDPhieuMuon.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDPhieuMuon.Location = new System.Drawing.Point(6, 201);
            this.rdb_IDPhieuMuon.Name = "rdb_IDPhieuMuon";
            this.rdb_IDPhieuMuon.Size = new System.Drawing.Size(240, 40);
            this.rdb_IDPhieuMuon.TabIndex = 2;
            this.rdb_IDPhieuMuon.TabStop = true;
            this.rdb_IDPhieuMuon.Text = "ID phiếu mượn";
            this.rdb_IDPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // rdb_IDPhieuTraCT
            // 
            this.rdb_IDPhieuTraCT.AutoSize = true;
            this.rdb_IDPhieuTraCT.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDPhieuTraCT.Location = new System.Drawing.Point(6, 141);
            this.rdb_IDPhieuTraCT.Name = "rdb_IDPhieuTraCT";
            this.rdb_IDPhieuTraCT.Size = new System.Drawing.Size(200, 40);
            this.rdb_IDPhieuTraCT.TabIndex = 1;
            this.rdb_IDPhieuTraCT.TabStop = true;
            this.rdb_IDPhieuTraCT.Text = "ID phiếu trả";
            this.rdb_IDPhieuTraCT.UseVisualStyleBackColor = true;
            // 
            // rdb_IDCTPhieuTra
            // 
            this.rdb_IDCTPhieuTra.AutoSize = true;
            this.rdb_IDCTPhieuTra.ForeColor = System.Drawing.Color.Red;
            this.rdb_IDCTPhieuTra.Location = new System.Drawing.Point(6, 81);
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
            this.ClientSize = new System.Drawing.Size(1467, 1082);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmTKTraSach";
            this.Text = "frmTKTraSach";
            this.Load += new System.EventHandler(this.frmTKTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private Bunifu.Framework.UI.BunifuTileButton btn_TKPhieuTraSach;
        private System.Windows.Forms.DataGridView dgv_TKCTPhieuTraSach;
        private System.Windows.Forms.BindingSource cTPHIEUTRABindingSource;
        private QuanLyThuVienDataSetTableAdapters.CT_PHIEUTRATableAdapter cT_PHIEUTRATableAdapter;
        private Bunifu.Framework.UI.BunifuTileButton btn_TKCTPhieuTraSach;
        private System.Windows.Forms.TextBox tb_TienPhat;
        private System.Windows.Forms.TextBox tb_SoNgayMuon;
        private System.Windows.Forms.TextBox tb_IDPhieuMuon;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCTPhieuTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuTraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhieuMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienPhatDataGridViewTextBoxColumn;
    }
}