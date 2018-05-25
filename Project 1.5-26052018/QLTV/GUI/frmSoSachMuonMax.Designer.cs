namespace QLTV.GUI
{
    partial class frmSoSachMuonMax
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
            this.btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.tb_SoSachMuonMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
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
            this.groupControl1.Controls.Add(this.btn_Them);
            this.groupControl1.Controls.Add(this.btn_Thoat);
            this.groupControl1.Controls.Add(this.tb_SoSachMuonMax);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(711, 342);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Chỉnh sửa qui định về số sách mượn max";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Thoat.Appearance.Options.UseFont = true;
            this.btn_Thoat.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_cancel_40;
            this.btn_Thoat.Location = new System.Drawing.Point(328, 247);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(141, 59);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Đóng";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // tb_SoSachMuonMax
            // 
            this.tb_SoSachMuonMax.Location = new System.Drawing.Point(328, 176);
            this.tb_SoSachMuonMax.Name = "tb_SoSachMuonMax";
            this.tb_SoSachMuonMax.Size = new System.Drawing.Size(167, 44);
            this.tb_SoSachMuonMax.TabIndex = 1;
            this.tb_SoSachMuonMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(43, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số sách mượn max:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(130, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thay đổi số sách mượn max";
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.ImageOptions.Image = global::QLTV.Properties.Resources.icons8_pencil_40;
            this.btn_Them.Location = new System.Drawing.Point(522, 166);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(168, 68);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thay đổi";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frmSoSachMuonMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 342);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSoSachMuonMax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Số sách mượn max";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox tb_SoSachMuonMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_Thoat;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
    }
}