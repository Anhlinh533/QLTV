namespace QLTV.GUI
{
    partial class frmAdmin
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
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_UserAdmin = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pic_SsAdmin = new System.Windows.Forms.PictureBox();
            this.pic_WarningAdmin = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ThemAdmin = new Bunifu.Framework.UI.BunifuTileButton();
            this.cbb_IDAdmin = new System.Windows.Forms.ComboBox();
            this.tb_PassAdmin = new System.Windows.Forms.TextBox();
            this.tb_UserAdmin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
            this.uSERADMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERADMINTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.USERADMINTableAdapter();
            this.userNameAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTUSERADMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_USERADMINTableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.CT_USERADMINTableAdapter();
            this.iDAdminDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WarningAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERADMINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTUSERADMINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
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
            this.navigationPane1.RegularSize = new System.Drawing.Size(1781, 1149);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(1781, 1149);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Thêm Admin";
            this.navigationPage1.Controls.Add(this.groupControl4);
            this.navigationPage1.Controls.Add(this.groupControl3);
            this.navigationPage1.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_administrator_male_48;
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1683, 1069);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Thêm Username Admin";
            this.navigationPage2.Controls.Add(this.groupControl1);
            this.navigationPage2.Controls.Add(this.groupControl2);
            this.navigationPage2.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_lock_40;
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1683, 1069);
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
            this.groupControl2.Controls.Add(this.dgv_UserAdmin);
            this.groupControl2.Location = new System.Drawing.Point(474, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1210, 1069);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Dữ liệu admin";
            // 
            // dgv_UserAdmin
            // 
            this.dgv_UserAdmin.AutoGenerateColumns = false;
            this.dgv_UserAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameAdminDataGridViewTextBoxColumn,
            this.passwordAdminDataGridViewTextBoxColumn,
            this.iDAdminDataGridViewTextBoxColumn});
            this.dgv_UserAdmin.DataSource = this.uSERADMINBindingSource;
            this.dgv_UserAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_UserAdmin.Location = new System.Drawing.Point(2, 45);
            this.dgv_UserAdmin.Name = "dgv_UserAdmin";
            this.dgv_UserAdmin.RowTemplate.Height = 28;
            this.dgv_UserAdmin.Size = new System.Drawing.Size(1206, 1022);
            this.dgv_UserAdmin.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.pic_SsAdmin);
            this.groupControl1.Controls.Add(this.pic_WarningAdmin);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.btn_ThemAdmin);
            this.groupControl1.Controls.Add(this.cbb_IDAdmin);
            this.groupControl1.Controls.Add(this.tb_PassAdmin);
            this.groupControl1.Controls.Add(this.tb_UserAdmin);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(468, 1069);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin admin";
            // 
            // pic_SsAdmin
            // 
            this.pic_SsAdmin.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.pic_SsAdmin.Location = new System.Drawing.Point(375, 84);
            this.pic_SsAdmin.Name = "pic_SsAdmin";
            this.pic_SsAdmin.Size = new System.Drawing.Size(42, 39);
            this.pic_SsAdmin.TabIndex = 28;
            this.pic_SsAdmin.TabStop = false;
            // 
            // pic_WarningAdmin
            // 
            this.pic_WarningAdmin.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.pic_WarningAdmin.Location = new System.Drawing.Point(375, 84);
            this.pic_WarningAdmin.Name = "pic_WarningAdmin";
            this.pic_WarningAdmin.Size = new System.Drawing.Size(42, 39);
            this.pic_WarningAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_WarningAdmin.TabIndex = 27;
            this.pic_WarningAdmin.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(176, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "label6";
            // 
            // btn_ThemAdmin
            // 
            this.btn_ThemAdmin.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemAdmin.color = System.Drawing.Color.SeaGreen;
            this.btn_ThemAdmin.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_ThemAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_ThemAdmin.ForeColor = System.Drawing.Color.White;
            this.btn_ThemAdmin.Image = global::QLTV.Properties.Resources.icons8_next_page_96;
            this.btn_ThemAdmin.ImagePosition = 20;
            this.btn_ThemAdmin.ImageZoom = 50;
            this.btn_ThemAdmin.LabelPosition = 41;
            this.btn_ThemAdmin.LabelText = "Thêm";
            this.btn_ThemAdmin.Location = new System.Drawing.Point(112, 316);
            this.btn_ThemAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ThemAdmin.Name = "btn_ThemAdmin";
            this.btn_ThemAdmin.Size = new System.Drawing.Size(128, 147);
            this.btn_ThemAdmin.TabIndex = 25;
            // 
            // cbb_IDAdmin
            // 
            this.cbb_IDAdmin.DisplayMember = "IDAdmin";
            this.cbb_IDAdmin.FormattingEnabled = true;
            this.cbb_IDAdmin.Location = new System.Drawing.Point(180, 240);
            this.cbb_IDAdmin.Name = "cbb_IDAdmin";
            this.cbb_IDAdmin.Size = new System.Drawing.Size(189, 44);
            this.cbb_IDAdmin.TabIndex = 24;
            this.cbb_IDAdmin.ValueMember = "IDAdmin";
            // 
            // tb_PassAdmin
            // 
            this.tb_PassAdmin.Location = new System.Drawing.Point(180, 180);
            this.tb_PassAdmin.Name = "tb_PassAdmin";
            this.tb_PassAdmin.Size = new System.Drawing.Size(189, 44);
            this.tb_PassAdmin.TabIndex = 22;
            // 
            // tb_UserAdmin
            // 
            this.tb_UserAdmin.Location = new System.Drawing.Point(180, 84);
            this.tb_UserAdmin.MaxLength = 50;
            this.tb_UserAdmin.Name = "tb_UserAdmin";
            this.tb_UserAdmin.Size = new System.Drawing.Size(189, 44);
            this.tb_UserAdmin.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(5, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 36);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID admin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(5, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 36);
            this.label8.TabIndex = 21;
            this.label8.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(5, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 36);
            this.label9.TabIndex = 19;
            this.label9.Text = "User name:";
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
            this.groupControl3.Controls.Add(this.dataGridView2);
            this.groupControl3.Location = new System.Drawing.Point(492, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1192, 1069);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Dữ liệu admin";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAdminDataGridViewTextBoxColumn1,
            this.hoTenAdminDataGridViewTextBoxColumn,
            this.ngaySinhAdminDataGridViewTextBoxColumn,
            this.diaChiAdminDataGridViewTextBoxColumn,
            this.emailAdminDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cTUSERADMINBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1188, 1022);
            this.dataGridView2.TabIndex = 6;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERADMINBindingSource
            // 
            this.uSERADMINBindingSource.DataMember = "USERADMIN";
            this.uSERADMINBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // uSERADMINTableAdapter
            // 
            this.uSERADMINTableAdapter.ClearBeforeFill = true;
            // 
            // userNameAdminDataGridViewTextBoxColumn
            // 
            this.userNameAdminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userNameAdminDataGridViewTextBoxColumn.DataPropertyName = "UserNameAdmin";
            this.userNameAdminDataGridViewTextBoxColumn.HeaderText = "User name admin";
            this.userNameAdminDataGridViewTextBoxColumn.Name = "userNameAdminDataGridViewTextBoxColumn";
            this.userNameAdminDataGridViewTextBoxColumn.Width = 260;
            // 
            // passwordAdminDataGridViewTextBoxColumn
            // 
            this.passwordAdminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.passwordAdminDataGridViewTextBoxColumn.DataPropertyName = "PasswordAdmin";
            this.passwordAdminDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordAdminDataGridViewTextBoxColumn.Name = "passwordAdminDataGridViewTextBoxColumn";
            this.passwordAdminDataGridViewTextBoxColumn.Width = 176;
            // 
            // iDAdminDataGridViewTextBoxColumn
            // 
            this.iDAdminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDAdminDataGridViewTextBoxColumn.DataPropertyName = "IDAdmin";
            this.iDAdminDataGridViewTextBoxColumn.HeaderText = "ID Admin";
            this.iDAdminDataGridViewTextBoxColumn.Name = "iDAdminDataGridViewTextBoxColumn";
            this.iDAdminDataGridViewTextBoxColumn.Width = 161;
            // 
            // cTUSERADMINBindingSource
            // 
            this.cTUSERADMINBindingSource.DataMember = "CT_USERADMIN";
            this.cTUSERADMINBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // cT_USERADMINTableAdapter
            // 
            this.cT_USERADMINTableAdapter.ClearBeforeFill = true;
            // 
            // iDAdminDataGridViewTextBoxColumn1
            // 
            this.iDAdminDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDAdminDataGridViewTextBoxColumn1.DataPropertyName = "IDAdmin";
            this.iDAdminDataGridViewTextBoxColumn1.HeaderText = "ID Admin";
            this.iDAdminDataGridViewTextBoxColumn1.Name = "iDAdminDataGridViewTextBoxColumn1";
            this.iDAdminDataGridViewTextBoxColumn1.Width = 175;
            // 
            // hoTenAdminDataGridViewTextBoxColumn
            // 
            this.hoTenAdminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hoTenAdminDataGridViewTextBoxColumn.DataPropertyName = "HoTenAdmin";
            this.hoTenAdminDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hoTenAdminDataGridViewTextBoxColumn.Name = "hoTenAdminDataGridViewTextBoxColumn";
            this.hoTenAdminDataGridViewTextBoxColumn.Width = 139;
            // 
            // ngaySinhAdminDataGridViewTextBoxColumn
            // 
            this.ngaySinhAdminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngaySinhAdminDataGridViewTextBoxColumn.DataPropertyName = "NgaySinhAdmin";
            this.ngaySinhAdminDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhAdminDataGridViewTextBoxColumn.Name = "ngaySinhAdminDataGridViewTextBoxColumn";
            this.ngaySinhAdminDataGridViewTextBoxColumn.Width = 182;
            // 
            // diaChiAdminDataGridViewTextBoxColumn
            // 
            this.diaChiAdminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.diaChiAdminDataGridViewTextBoxColumn.DataPropertyName = "DiaChiAdmin";
            this.diaChiAdminDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiAdminDataGridViewTextBoxColumn.Name = "diaChiAdminDataGridViewTextBoxColumn";
            this.diaChiAdminDataGridViewTextBoxColumn.Width = 142;
            // 
            // emailAdminDataGridViewTextBoxColumn
            // 
            this.emailAdminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailAdminDataGridViewTextBoxColumn.DataPropertyName = "EmailAdmin";
            this.emailAdminDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailAdminDataGridViewTextBoxColumn.Name = "emailAdminDataGridViewTextBoxColumn";
            this.emailAdminDataGridViewTextBoxColumn.Width = 123;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl4.Appearance.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(486, 1069);
            this.groupControl4.TabIndex = 5;
            this.groupControl4.Text = "Thông tin admin";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 1149);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WarningAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERADMINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTUSERADMINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgv_UserAdmin;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.PictureBox pic_SsAdmin;
        private System.Windows.Forms.PictureBox pic_WarningAdmin;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuTileButton btn_ThemAdmin;
        private System.Windows.Forms.ComboBox cbb_IDAdmin;
        private System.Windows.Forms.TextBox tb_PassAdmin;
        private System.Windows.Forms.TextBox tb_UserAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource uSERADMINBindingSource;
        private QuanLyThuVienDataSetTableAdapters.USERADMINTableAdapter uSERADMINTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cTUSERADMINBindingSource;
        private QuanLyThuVienDataSetTableAdapters.CT_USERADMINTableAdapter cT_USERADMINTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAdminDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAdminDataGridViewTextBoxColumn;
    }
}