namespace QLTV.GUI
{
    partial class frmKhoangCachXuatBan
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Them = new Bunifu.Framework.UI.BunifuTileButton();
            this.tb_KhoangCach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_Thoat);
            this.groupControl1.Controls.Add(this.btn_Them);
            this.groupControl1.Controls.Add(this.tb_KhoangCach);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(661, 342);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Chỉnh sửa qui định về khoảng cách xuất bản";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Them.color = System.Drawing.Color.SeaGreen;
            this.btn_Them.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = global::QLTV.Properties.Resources.icons8_pencil_80;
            this.btn_Them.ImagePosition = 20;
            this.btn_Them.ImageZoom = 50;
            this.btn_Them.LabelPosition = 41;
            this.btn_Them.LabelText = "Sửa";
            this.btn_Them.Location = new System.Drawing.Point(477, 124);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(128, 144);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tb_KhoangCach
            // 
            this.tb_KhoangCach.Location = new System.Drawing.Point(269, 171);
            this.tb_KhoangCach.Name = "tb_KhoangCach";
            this.tb_KhoangCach.Size = new System.Drawing.Size(167, 44);
            this.tb_KhoangCach.TabIndex = 1;
            this.tb_KhoangCach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(66, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoảng cách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(105, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thay đổi khoảng cách năm xuất bản";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Thoat.Appearance.Options.UseFont = true;
            this.btn_Thoat.Location = new System.Drawing.Point(269, 276);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(112, 34);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Đóng";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frmKhoangCachXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 342);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmKhoangCachXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khoảng cách xuất bản";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Bunifu.Framework.UI.BunifuTileButton btn_Them;
        private System.Windows.Forms.TextBox tb_KhoangCach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_Thoat;
    }
}