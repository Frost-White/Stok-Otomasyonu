namespace Stok_Otomasyon
{
    partial class FrmUrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrun));
            this.UrunGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UrunSilButon = new DevExpress.XtraEditors.SimpleButton();
            this.UrunEkleButon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.cmbFirmaID = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.UrunGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirmaID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // UrunGrid
            // 
            this.UrunGrid.Location = new System.Drawing.Point(3, 2);
            this.UrunGrid.MainView = this.gridView1;
            this.UrunGrid.Name = "UrunGrid";
            this.UrunGrid.Size = new System.Drawing.Size(587, 509);
            this.UrunGrid.TabIndex = 0;
            this.UrunGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.UrunGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // UrunSilButon
            // 
            this.UrunSilButon.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.UrunSilButon.Appearance.Options.UseFont = true;
            this.UrunSilButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("UrunSilButon.ImageOptions.SvgImage")));
            this.UrunSilButon.Location = new System.Drawing.Point(635, 389);
            this.UrunSilButon.Name = "UrunSilButon";
            this.UrunSilButon.Size = new System.Drawing.Size(144, 53);
            this.UrunSilButon.TabIndex = 3;
            this.UrunSilButon.Text = "Sil";
            this.UrunSilButon.Click += new System.EventHandler(this.UrunSilButon_Click);
            // 
            // UrunEkleButon
            // 
            this.UrunEkleButon.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.UrunEkleButon.Appearance.Options.UseFont = true;
            this.UrunEkleButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("UrunEkleButon.ImageOptions.SvgImage")));
            this.UrunEkleButon.Location = new System.Drawing.Point(635, 300);
            this.UrunEkleButon.Name = "UrunEkleButon";
            this.UrunEkleButon.Size = new System.Drawing.Size(144, 53);
            this.UrunEkleButon.TabIndex = 4;
            this.UrunEkleButon.Text = "Ekle";
            this.UrunEkleButon.Click += new System.EventHandler(this.UrunEkleButon_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(635, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 22);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Ürün Adı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(635, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 22);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Firma_ID";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(635, 109);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUrunAd.Properties.Appearance.Options.UseFont = true;
            this.txtUrunAd.Size = new System.Drawing.Size(144, 28);
            this.txtUrunAd.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(635, 205);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 22);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Fiyat";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(635, 233);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtFiyat.Properties.Appearance.Options.UseFont = true;
            this.TxtFiyat.Size = new System.Drawing.Size(144, 28);
            this.TxtFiyat.TabIndex = 9;
            // 
            // cmbFirmaID
            // 
            this.cmbFirmaID.Location = new System.Drawing.Point(635, 171);
            this.cmbFirmaID.Name = "cmbFirmaID";
            this.cmbFirmaID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbFirmaID.Properties.Appearance.Options.UseFont = true;
            this.cmbFirmaID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFirmaID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbFirmaID.Size = new System.Drawing.Size(144, 28);
            this.cmbFirmaID.TabIndex = 11;
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 525);
            this.Controls.Add(this.cmbFirmaID);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.UrunEkleButon);
            this.Controls.Add(this.UrunSilButon);
            this.Controls.Add(this.UrunGrid);
            this.Name = "FrmUrun";
            this.Text = "Ürün Ekle/Çıkar";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UrunGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirmaID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl UrunGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton UrunSilButon;
        private DevExpress.XtraEditors.SimpleButton UrunEkleButon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtFiyat;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFirmaID;
    }
}