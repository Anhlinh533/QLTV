namespace QLTV.GUI
{
    partial class frmDangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKi));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_Ss = new System.Windows.Forms.PictureBox();
            this.pic_Warning = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_NgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new Bunifu.Framework.UI.BunifuTileButton();
            this.cbb_LoaiDocGia = new System.Windows.Forms.ComboBox();
            this.lOAIDOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet = new QLTV.QuanLyThuVienDataSet();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lOAIDOCGIATableAdapter = new QLTV.QuanLyThuVienDataSetTableAdapters.LOAIDOCGIATableAdapter();
            this.bunifuGradientPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(635, 846);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pic_Ss);
            this.groupBox1.Controls.Add(this.pic_Warning);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtp_NgayLapThe);
            this.groupBox1.Controls.Add(this.dtp_NgaySinh);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.cbb_LoaiDocGia);
            this.groupBox1.Controls.Add(this.tb_Email);
            this.groupBox1.Controls.Add(this.tb_DiaChi);
            this.groupBox1.Controls.Add(this.tb_HoTenDocGia);
            this.groupBox1.Controls.Add(this.tb_IDDocGia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 739);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả";
            // 
            // pic_Ss
            // 
            this.pic_Ss.Image = global::QLTV.Properties.Resources.icons8_ok_40;
            this.pic_Ss.Location = new System.Drawing.Point(566, 67);
            this.pic_Ss.Name = "pic_Ss";
            this.pic_Ss.Size = new System.Drawing.Size(37, 36);
            this.pic_Ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ss.TabIndex = 32;
            this.pic_Ss.TabStop = false;
            // 
            // pic_Warning
            // 
            this.pic_Warning.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.pic_Warning.Location = new System.Drawing.Point(566, 67);
            this.pic_Warning.Name = "pic_Warning";
            this.pic_Warning.Size = new System.Drawing.Size(37, 36);
            this.pic_Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Warning.TabIndex = 31;
            this.pic_Warning.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(281, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "label9";
            // 
            // dtp_NgayLapThe
            // 
            this.dtp_NgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLapThe.Location = new System.Drawing.Point(285, 448);
            this.dtp_NgayLapThe.Name = "dtp_NgayLapThe";
            this.dtp_NgayLapThe.Size = new System.Drawing.Size(275, 44);
            this.dtp_NgayLapThe.TabIndex = 28;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(285, 208);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(275, 44);
            this.dtp_NgaySinh.TabIndex = 20;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Them.color = System.Drawing.Color.PaleGreen;
            this.btn_Them.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Them.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.Image = global::QLTV.Properties.Resources.icons8_add_user_male_48;
            this.btn_Them.ImagePosition = 20;
            this.btn_Them.ImageZoom = 50;
            this.btn_Them.LabelPosition = 41;
            this.btn_Them.LabelText = "Đăng kí";
            this.btn_Them.Location = new System.Drawing.Point(252, 540);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(128, 147);
            this.btn_Them.TabIndex = 29;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cbb_LoaiDocGia
            // 
            this.cbb_LoaiDocGia.DataSource = this.lOAIDOCGIABindingSource;
            this.cbb_LoaiDocGia.DisplayMember = "IDLoaiDG";
            this.cbb_LoaiDocGia.FormattingEnabled = true;
            this.cbb_LoaiDocGia.Location = new System.Drawing.Point(285, 391);
            this.cbb_LoaiDocGia.Name = "cbb_LoaiDocGia";
            this.cbb_LoaiDocGia.Size = new System.Drawing.Size(275, 44);
            this.cbb_LoaiDocGia.TabIndex = 26;
            this.cbb_LoaiDocGia.ValueMember = "IDLoaiDG";
            // 
            // lOAIDOCGIABindingSource
            // 
            this.lOAIDOCGIABindingSource.DataMember = "LOAIDOCGIA";
            this.lOAIDOCGIABindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(285, 331);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(275, 44);
            this.tb_Email.TabIndex = 24;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(285, 271);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(275, 44);
            this.tb_DiaChi.TabIndex = 22;
            // 
            // tb_HoTenDocGia
            // 
            this.tb_HoTenDocGia.Location = new System.Drawing.Point(285, 151);
            this.tb_HoTenDocGia.Name = "tb_HoTenDocGia";
            this.tb_HoTenDocGia.Size = new System.Drawing.Size(275, 44);
            this.tb_HoTenDocGia.TabIndex = 18;
            // 
            // tb_IDDocGia
            // 
            this.tb_IDDocGia.Location = new System.Drawing.Point(285, 67);
            this.tb_IDDocGia.MaxLength = 3;
            this.tb_IDDocGia.Name = "tb_IDDocGia";
            this.tb_IDDocGia.Size = new System.Drawing.Size(275, 44);
            this.tb_IDDocGia.TabIndex = 16;
            this.tb_IDDocGia.TextChanged += new System.EventHandler(this.tb_IDDocGia_TextChanged);
            this.tb_IDDocGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(84, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 36);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ngày lập thẻ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(84, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 36);
            this.label6.TabIndex = 25;
            this.label6.Text = "Loại độc giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(84, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 36);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(84, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 36);
            this.label4.TabIndex = 21;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(84, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(84, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "Họ và tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(84, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 36);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(180, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng kí tài khoản";
            // 
            // lOAIDOCGIATableAdapter
            // 
            this.lOAIDOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // frmDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 846);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí thông tin độc giả";
            this.Load += new System.EventHandler(this.frmDangKi_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapThe;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private Bunifu.Framework.UI.BunifuTileButton btn_Them;
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
        private System.Windows.Forms.Label label8;
        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource lOAIDOCGIABindingSource;
        private QuanLyThuVienDataSetTableAdapters.LOAIDOCGIATableAdapter lOAIDOCGIATableAdapter;
        private System.Windows.Forms.PictureBox pic_Ss;
        private System.Windows.Forms.PictureBox pic_Warning;
        private System.Windows.Forms.Label label9;
    }
}