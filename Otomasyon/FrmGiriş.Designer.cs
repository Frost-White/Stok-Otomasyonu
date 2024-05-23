namespace Stok_Otomasyon
{
    partial class FrmGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiriş));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKAdı = new DevExpress.XtraEditors.TextEdit();
            this.YoneticiGirButon = new DevExpress.XtraEditors.SimpleButton();
            this.DepoGirişButon = new DevExpress.XtraEditors.SimpleButton();
            this.DepartmanGirisButon = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(73, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(559, 72);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Otomasyon Girişi";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 208);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kullanıcı Adı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 290);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 22);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Şifre:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // txtKAdı
            // 
            this.txtKAdı.Location = new System.Drawing.Point(38, 245);
            this.txtKAdı.Name = "txtKAdı";
            this.txtKAdı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtKAdı.Properties.Appearance.Options.UseFont = true;
            this.txtKAdı.Size = new System.Drawing.Size(195, 28);
            this.txtKAdı.TabIndex = 3;
            // 
            // YoneticiGirButon
            // 
            this.YoneticiGirButon.Location = new System.Drawing.Point(38, 441);
            this.YoneticiGirButon.Name = "YoneticiGirButon";
            this.YoneticiGirButon.Size = new System.Drawing.Size(164, 75);
            this.YoneticiGirButon.TabIndex = 5;
            this.YoneticiGirButon.Text = "Yönetici Giriş";
            this.YoneticiGirButon.Click += new System.EventHandler(this.YoneticiGirButon_Click);
            // 
            // DepoGirişButon
            // 
            this.DepoGirişButon.Location = new System.Drawing.Point(288, 441);
            this.DepoGirişButon.Name = "DepoGirişButon";
            this.DepoGirişButon.Size = new System.Drawing.Size(164, 75);
            this.DepoGirişButon.TabIndex = 6;
            this.DepoGirişButon.Text = "Depo Sorumlusu Giriş";
            this.DepoGirişButon.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // DepartmanGirisButon
            // 
            this.DepartmanGirisButon.Location = new System.Drawing.Point(527, 441);
            this.DepartmanGirisButon.Name = "DepartmanGirisButon";
            this.DepartmanGirisButon.Size = new System.Drawing.Size(167, 75);
            this.DepartmanGirisButon.TabIndex = 7;
            this.DepartmanGirisButon.Text = "Departmanlar Giriş";
            this.DepartmanGirisButon.Click += new System.EventHandler(this.DepartmanGirisButon_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(38, 328);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(195, 28);
            this.txtSifre.TabIndex = 8;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(288, 151);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(376, 255);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 9;
            this.svgImageBox1.Text = "svgImageBox1";
            this.svgImageBox1.Click += new System.EventHandler(this.svgImageBox1_Click);
            // 
            // FrmGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.DepartmanGirisButon);
            this.Controls.Add(this.DepoGirişButon);
            this.Controls.Add(this.YoneticiGirButon);
            this.Controls.Add(this.txtKAdı);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiriş";
            this.Load += new System.EventHandler(this.FrmGiriş_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKAdı;
        private DevExpress.XtraEditors.SimpleButton YoneticiGirButon;
        private DevExpress.XtraEditors.SimpleButton DepoGirişButon;
        private DevExpress.XtraEditors.SimpleButton DepartmanGirisButon;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
    }
}