namespace Stok_Otomasyon
{
    partial class FrmGirisBilgDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisBilgDuzenle));
            this.GirisBilgGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EkleButon = new DevExpress.XtraEditors.SimpleButton();
            this.GuncelleButon = new DevExpress.XtraEditors.SimpleButton();
            this.SilButon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAd = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbYetki = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPersonelID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GirisBilgGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYetki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisBilgGrid
            // 
            this.GirisBilgGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GirisBilgGrid.Location = new System.Drawing.Point(13, 13);
            this.GirisBilgGrid.MainView = this.gridView1;
            this.GirisBilgGrid.Margin = new System.Windows.Forms.Padding(4);
            this.GirisBilgGrid.Name = "GirisBilgGrid";
            this.GirisBilgGrid.Size = new System.Drawing.Size(648, 508);
            this.GirisBilgGrid.TabIndex = 0;
            this.GirisBilgGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.GridControl = this.GirisBilgGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // EkleButon
            // 
            this.EkleButon.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.EkleButon.Appearance.Options.UseFont = true;
            this.EkleButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EkleButon.ImageOptions.SvgImage")));
            this.EkleButon.Location = new System.Drawing.Point(704, 324);
            this.EkleButon.Margin = new System.Windows.Forms.Padding(4);
            this.EkleButon.Name = "EkleButon";
            this.EkleButon.Size = new System.Drawing.Size(190, 59);
            this.EkleButon.TabIndex = 1;
            this.EkleButon.Text = "Ekle";
            this.EkleButon.Click += new System.EventHandler(this.EkleButon_Click);
            // 
            // GuncelleButon
            // 
            this.GuncelleButon.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.GuncelleButon.Appearance.Options.UseFont = true;
            this.GuncelleButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GuncelleButon.ImageOptions.SvgImage")));
            this.GuncelleButon.Location = new System.Drawing.Point(704, 392);
            this.GuncelleButon.Margin = new System.Windows.Forms.Padding(5);
            this.GuncelleButon.Name = "GuncelleButon";
            this.GuncelleButon.Size = new System.Drawing.Size(190, 59);
            this.GuncelleButon.TabIndex = 2;
            this.GuncelleButon.Text = "Güncelle";
            this.GuncelleButon.Click += new System.EventHandler(this.GuncelleButon_Click);
            // 
            // SilButon
            // 
            this.SilButon.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.SilButon.Appearance.Options.UseFont = true;
            this.SilButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SilButon.ImageOptions.SvgImage")));
            this.SilButon.Location = new System.Drawing.Point(704, 462);
            this.SilButon.Margin = new System.Windows.Forms.Padding(6);
            this.SilButon.Name = "SilButon";
            this.SilButon.Size = new System.Drawing.Size(190, 59);
            this.SilButon.TabIndex = 3;
            this.SilButon.Text = "Sil";
            this.SilButon.Click += new System.EventHandler(this.KaldırButon_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(704, 92);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 22);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(704, 122);
            this.txtKullaniciAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtKullaniciAd.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAd.Size = new System.Drawing.Size(157, 28);
            this.txtKullaniciAd.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(704, 191);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(5);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Size = new System.Drawing.Size(157, 28);
            this.txtSifre.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(704, 159);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 22);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Sifre:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(704, 229);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 22);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Yetki:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(704, 23);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 22);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Personel_ID:";
            // 
            // cmbYetki
            // 
            this.cmbYetki.Location = new System.Drawing.Point(704, 260);
            this.cmbYetki.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbYetki.Properties.Appearance.Options.UseFont = true;
            this.cmbYetki.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYetki.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbYetki.Size = new System.Drawing.Size(157, 28);
            this.cmbYetki.TabIndex = 12;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(704, 54);
            this.txtPersonelID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelID.Properties.Appearance.Options.UseFont = true;
            this.txtPersonelID.Size = new System.Drawing.Size(157, 28);
            this.txtPersonelID.TabIndex = 13;
            // 
            // FrmGirisBilgDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 540);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.cmbYetki);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.SilButon);
            this.Controls.Add(this.GuncelleButon);
            this.Controls.Add(this.EkleButon);
            this.Controls.Add(this.GirisBilgGrid);
            this.Name = "FrmGirisBilgDuzenle";
            this.Text = "Giriş Bilgilerini Düzenle";
            this.Load += new System.EventHandler(this.FrmGirisBilgDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GirisBilgGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYetki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GirisBilgGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton EkleButon;
        private DevExpress.XtraEditors.SimpleButton GuncelleButon;
        private DevExpress.XtraEditors.SimpleButton SilButon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAd;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbYetki;
        private DevExpress.XtraEditors.TextEdit txtPersonelID;
    }
}