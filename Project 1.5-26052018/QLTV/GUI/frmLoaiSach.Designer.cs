namespace QLTV.GUI
{
    partial class frmLoaiSach
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
            this.iDLoaiSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAISACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.pic_Ss = new System.Windows.Forms.PictureBox();
            this.pic_Warning = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_IDLoaiSach = new System.Windows.Forms.TextBox();
            this.tb_TenLoaiSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lOAISACHTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.LOAISACHTableAdapter();
            this.btn_Xuat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.item_Them.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).BeginInit();
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
            this.navigationPane1.RegularSize = new System.Drawing.Size(1662, 1065);
            this.navigationPane1.SelectedPage = this.item_Them;
            this.navigationPane1.Size = new System.Drawing.Size(1662, 1065);
            this.navigationPane1.TabIndex = 3;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // item_Them
            // 
            this.item_Them.Caption = "Thêm loại sách";
            this.item_Them.Controls.Add(this.groupControl2);
            this.item_Them.Controls.Add(this.groupControl1);
            this.item_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_plus_40;
            this.item_Them.Name = "item_Them";
            this.item_Them.Size = new System.Drawing.Size(1572, 985);
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
            this.groupControl2.Location = new System.Drawing.Point(500, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1072, 984);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu loại sách";
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
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1068, 35);
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
            // dgv_Them
            // 
            this.dgv_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Them.AutoGenerateColumns = false;
            this.dgv_Them.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Them.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDLoaiSachDataGridViewTextBoxColumn,
            this.tenLoaiSachDataGridViewTextBoxColumn});
            this.dgv_Them.DataSource = this.lOAISACHBindingSource;
            this.dgv_Them.Location = new System.Drawing.Point(6, 96);
            this.dgv_Them.Name = "dgv_Them";
            this.dgv_Them.RowTemplate.Height = 28;
            this.dgv_Them.Size = new System.Drawing.Size(1060, 882);
            this.dgv_Them.TabIndex = 2;
            this.dgv_Them.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Them_CellClick);
            // 
            // iDLoaiSachDataGridViewTextBoxColumn
            // 
            this.iDLoaiSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDLoaiSachDataGridViewTextBoxColumn.DataPropertyName = "IDLoaiSach";
            this.iDLoaiSachDataGridViewTextBoxColumn.HeaderText = "ID loại sách";
            this.iDLoaiSachDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.iDLoaiSachDataGridViewTextBoxColumn.Name = "iDLoaiSachDataGridViewTextBoxColumn";
            this.iDLoaiSachDataGridViewTextBoxColumn.Width = 206;
            // 
            // tenLoaiSachDataGridViewTextBoxColumn
            // 
            this.tenLoaiSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenLoaiSachDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiSach";
            this.tenLoaiSachDataGridViewTextBoxColumn.HeaderText = "Tên loại sách";
            this.tenLoaiSachDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.tenLoaiSachDataGridViewTextBoxColumn.Name = "tenLoaiSachDataGridViewTextBoxColumn";
            this.tenLoaiSachDataGridViewTextBoxColumn.Width = 226;
            // 
            // lOAISACHBindingSource
            // 
            this.lOAISACHBindingSource.DataMember = "LOAISACH";
            this.lOAISACHBindingSource.DataSource = this.quanLyThuVienDataSet;
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
            this.groupControl1.Controls.Add(this.tb_IDLoaiSach);
            this.groupControl1.Controls.Add(this.tb_TenLoaiSach);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(494, 984);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin loại sách";
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.btn_Them.Location = new System.Drawing.Point(181, 258);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(157, 75);
            this.btn_Them.TabIndex = 36;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // pic_Ss
            // 
            this.pic_Ss.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.pic_Ss.Location = new System.Drawing.Point(440, 78);
            this.pic_Ss.Name = "pic_Ss";
            this.pic_Ss.Size = new System.Drawing.Size(37, 39);
            this.pic_Ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ss.TabIndex = 18;
            this.pic_Ss.TabStop = false;
            // 
            // pic_Warning
            // 
            this.pic_Warning.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.pic_Warning.Location = new System.Drawing.Point(440, 78);
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
            this.label4.Location = new System.Drawing.Point(209, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // tb_IDLoaiSach
            // 
            this.tb_IDLoaiSach.Location = new System.Drawing.Point(213, 78);
            this.tb_IDLoaiSach.MaxLength = 3;
            this.tb_IDLoaiSach.Name = "tb_IDLoaiSach";
            this.tb_IDLoaiSach.Size = new System.Drawing.Size(221, 44);
            this.tb_IDLoaiSach.TabIndex = 1;
            this.tb_IDLoaiSach.TextChanged += new System.EventHandler(this.tb_IDLoaiSach_TextChanged);
            this.tb_IDLoaiSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // tb_TenLoaiSach
            // 
            this.tb_TenLoaiSach.Location = new System.Drawing.Point(213, 180);
            this.tb_TenLoaiSach.MaxLength = 50;
            this.tb_TenLoaiSach.Name = "tb_TenLoaiSach";
            this.tb_TenLoaiSach.Size = new System.Drawing.Size(221, 44);
            this.tb_TenLoaiSach.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID loại sách:";
            // 
            // lOAISACHTableAdapter
            // 
            this.lOAISACHTableAdapter.ClearBeforeFill = true;
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
            // frmLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1065);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoaiSach_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.lOAISACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage item_Them;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource lOAISACHBindingSource;
        private QuanLyThuVienDataSetTableAdapters.LOAISACHTableAdapter lOAISACHTableAdapter;
        private System.Windows.Forms.TextBox tb_IDLoaiSach;
        private System.Windows.Forms.TextBox tb_TenLoaiSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgv_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLoaiSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pic_Ss;
        private System.Windows.Forms.PictureBox pic_Warning;
        private System.Windows.Forms.Label label4;
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