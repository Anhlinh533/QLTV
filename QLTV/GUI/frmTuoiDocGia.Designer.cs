namespace QLTV.GUI
{
    partial class frmTuoiDocGia
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_TuoiDocGia = new Bunifu.Framework.UI.BunifuTileButton();
            this.nbr_TuoiToiDa = new System.Windows.Forms.NumericUpDown();
            this.nbr_TuoiToiThieu = new System.Windows.Forms.NumericUpDown();
            this.group = new DevExpress.XtraEditors.GroupControl();
            this.rtb_Tuoi = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_TuoiToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_TuoiToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group)).BeginInit();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_TuoiDocGia);
            this.panelControl1.Controls.Add(this.nbr_TuoiToiDa);
            this.panelControl1.Controls.Add(this.nbr_TuoiToiThieu);
            this.panelControl1.Controls.Add(this.group);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(674, 577);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_TuoiDocGia
            // 
            this.btn_TuoiDocGia.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_TuoiDocGia.color = System.Drawing.Color.SeaGreen;
            this.btn_TuoiDocGia.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_TuoiDocGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TuoiDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_TuoiDocGia.ForeColor = System.Drawing.Color.White;
            this.btn_TuoiDocGia.Image = global::QLTV.Properties.Resources.icons8_plus_64;
            this.btn_TuoiDocGia.ImagePosition = 20;
            this.btn_TuoiDocGia.ImageZoom = 50;
            this.btn_TuoiDocGia.LabelPosition = 41;
            this.btn_TuoiDocGia.LabelText = "Thêm";
            this.btn_TuoiDocGia.Location = new System.Drawing.Point(459, 266);
            this.btn_TuoiDocGia.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TuoiDocGia.Name = "btn_TuoiDocGia";
            this.btn_TuoiDocGia.Size = new System.Drawing.Size(128, 129);
            this.btn_TuoiDocGia.TabIndex = 6;
            // 
            // nbr_TuoiToiDa
            // 
            this.nbr_TuoiToiDa.Font = new System.Drawing.Font("Tahoma", 15F);
            this.nbr_TuoiToiDa.Location = new System.Drawing.Point(271, 342);
            this.nbr_TuoiToiDa.Name = "nbr_TuoiToiDa";
            this.nbr_TuoiToiDa.Size = new System.Drawing.Size(120, 44);
            this.nbr_TuoiToiDa.TabIndex = 5;
            // 
            // nbr_TuoiToiThieu
            // 
            this.nbr_TuoiToiThieu.Font = new System.Drawing.Font("Tahoma", 15F);
            this.nbr_TuoiToiThieu.Location = new System.Drawing.Point(271, 264);
            this.nbr_TuoiToiThieu.Name = "nbr_TuoiToiThieu";
            this.nbr_TuoiToiThieu.Size = new System.Drawing.Size(120, 44);
            this.nbr_TuoiToiThieu.TabIndex = 4;
            // 
            // group
            // 
            this.group.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(15)));
            this.group.Appearance.Options.UseFont = true;
            this.group.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15F);
            this.group.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.group.AppearanceCaption.Options.UseFont = true;
            this.group.AppearanceCaption.Options.UseForeColor = true;
            this.group.Controls.Add(this.rtb_Tuoi);
            this.group.Dock = System.Windows.Forms.DockStyle.Top;
            this.group.Location = new System.Drawing.Point(3, 3);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(668, 199);
            this.group.TabIndex = 3;
            this.group.Text = "Qui định về tuổi độc giả";
            // 
            // rtb_Tuoi
            // 
            this.rtb_Tuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Tuoi.Location = new System.Drawing.Point(3, 47);
            this.rtb_Tuoi.Name = "rtb_Tuoi";
            this.rtb_Tuoi.Size = new System.Drawing.Size(662, 149);
            this.rtb_Tuoi.TabIndex = 0;
            this.rtb_Tuoi.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(63, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuổi tối đa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(63, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tuổi tối thiểu:";
            // 
            // frmTuoiDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 577);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTuoiDocGia";
            this.Text = "frmTuoiDocGia";
            this.Load += new System.EventHandler(this.frmTuoiDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_TuoiToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_TuoiToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group)).EndInit();
            this.group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl group;
        private System.Windows.Forms.RichTextBox rtb_Tuoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btn_TuoiDocGia;
        private System.Windows.Forms.NumericUpDown nbr_TuoiToiDa;
        private System.Windows.Forms.NumericUpDown nbr_TuoiToiThieu;
    }
}