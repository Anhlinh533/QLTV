namespace QLTV.GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DangKi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_DangNhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            resources.ApplyResources(this.bunifuGradientPanel1, "bunifuGradientPanel1");
            this.bunifuGradientPanel1.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_DangKi);
            this.groupBox1.Controls.Add(this.btn_DangNhap);
            this.groupBox1.Controls.Add(this.tb_MatKhau);
            this.groupBox1.Controls.Add(this.tb_UserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btn_DangKi
            // 
            this.btn_DangKi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_DangKi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btn_DangKi, "btn_DangKi");
            this.btn_DangKi.BorderRadius = 0;
            this.btn_DangKi.ButtonText = "Đăng kí";
            this.btn_DangKi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangKi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_DangKi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_DangKi.Iconimage = global::QLTV.Properties.Resources.icons8_add_user_male_48;
            this.btn_DangKi.Iconimage_right = null;
            this.btn_DangKi.Iconimage_right_Selected = null;
            this.btn_DangKi.Iconimage_Selected = null;
            this.btn_DangKi.IconMarginLeft = 0;
            this.btn_DangKi.IconMarginRight = 0;
            this.btn_DangKi.IconRightVisible = true;
            this.btn_DangKi.IconRightZoom = 0D;
            this.btn_DangKi.IconVisible = true;
            this.btn_DangKi.IconZoom = 60D;
            this.btn_DangKi.IsTab = false;
            this.btn_DangKi.Name = "btn_DangKi";
            this.btn_DangKi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_DangKi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_DangKi.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_DangKi.selected = false;
            this.btn_DangKi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangKi.Textcolor = System.Drawing.Color.Red;
            this.btn_DangKi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKi.Click += new System.EventHandler(this.btn_DangKi_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btn_DangNhap, "btn_DangNhap");
            this.btn_DangNhap.BorderRadius = 0;
            this.btn_DangNhap.ButtonText = "Đăng nhập";
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.DisabledColor = System.Drawing.Color.Gray;
            this.btn_DangNhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_DangNhap.Iconimage = global::QLTV.Properties.Resources.icons8_enter_64;
            this.btn_DangNhap.Iconimage_right = null;
            this.btn_DangNhap.Iconimage_right_Selected = null;
            this.btn_DangNhap.Iconimage_Selected = null;
            this.btn_DangNhap.IconMarginLeft = 0;
            this.btn_DangNhap.IconMarginRight = 0;
            this.btn_DangNhap.IconRightVisible = true;
            this.btn_DangNhap.IconRightZoom = 0D;
            this.btn_DangNhap.IconVisible = true;
            this.btn_DangNhap.IconZoom = 60D;
            this.btn_DangNhap.IsTab = false;
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_DangNhap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_DangNhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_DangNhap.selected = false;
            this.btn_DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangNhap.Textcolor = System.Drawing.Color.Red;
            this.btn_DangNhap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // tb_MatKhau
            // 
            resources.ApplyResources(this.tb_MatKhau, "tb_MatKhau");
            this.tb_MatKhau.Name = "tb_MatKhau";
            // 
            // tb_UserName
            // 
            resources.ApplyResources(this.tb_UserName, "tb_UserName");
            this.tb_UserName.Name = "tb_UserName";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTV.Properties.Resources.if_mypc_lock_41753;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // frmLogin
            // 
            this.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("frmLogin.Appearance.ForeColor")));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_DangNhap;
        private Bunifu.Framework.UI.BunifuFlatButton btn_DangKi;
    }
}