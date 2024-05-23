namespace Stok_Otomasyon
{
    partial class FrmFirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirma));
            this.FirmaGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtFirmaAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirmaKategori = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.FirmaEkleButon = new DevExpress.XtraEditors.SimpleButton();
            this.FirmaSilButon = new DevExpress.XtraEditors.SimpleButton();
            this.txtFirmaID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.FirmaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // FirmaGrid
            // 
            this.FirmaGrid.Location = new System.Drawing.Point(12, 12);
            this.FirmaGrid.MainView = this.gridView1;
            this.FirmaGrid.Name = "FirmaGrid";
            this.FirmaGrid.Size = new System.Drawing.Size(742, 502);
            this.FirmaGrid.TabIndex = 0;
            this.FirmaGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.FirmaGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged_1);
            // 
            // txtFirmaAd
            // 
            this.txtFirmaAd.Location = new System.Drawing.Point(787, 156);
            this.txtFirmaAd.Name = "txtFirmaAd";
            this.txtFirmaAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFirmaAd.Properties.Appearance.Options.UseFont = true;
            this.txtFirmaAd.Size = new System.Drawing.Size(204, 28);
            this.txtFirmaAd.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(787, 128);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 22);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Firma Adı:";
            // 
            // txtFirmaKategori
            // 
            this.txtFirmaKategori.Location = new System.Drawing.Point(787, 218);
            this.txtFirmaKategori.Name = "txtFirmaKategori";
            this.txtFirmaKategori.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFirmaKategori.Properties.Appearance.Options.UseFont = true;
            this.txtFirmaKategori.Size = new System.Drawing.Size(204, 28);
            this.txtFirmaKategori.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(787, 190);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(120, 22);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Firma Kategori:";
            // 
            // FirmaEkleButon
            // 
            this.FirmaEkleButon.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FirmaEkleButon.Appearance.Options.UseFont = true;
            this.FirmaEkleButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FirmaEkleButon.ImageOptions.SvgImage")));
            this.FirmaEkleButon.Location = new System.Drawing.Point(787, 332);
            this.FirmaEkleButon.Name = "FirmaEkleButon";
            this.FirmaEkleButon.Size = new System.Drawing.Size(140, 52);
            this.FirmaEkleButon.TabIndex = 7;
            this.FirmaEkleButon.Text = "Ekle";
            this.FirmaEkleButon.Click += new System.EventHandler(this.FirmaEkleButon_Click);
            // 
            // FirmaSilButon
            // 
            this.FirmaSilButon.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FirmaSilButon.Appearance.Options.UseFont = true;
            this.FirmaSilButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FirmaSilButon.ImageOptions.SvgImage")));
            this.FirmaSilButon.Location = new System.Drawing.Point(787, 412);
            this.FirmaSilButon.Name = "FirmaSilButon";
            this.FirmaSilButon.Size = new System.Drawing.Size(140, 52);
            this.FirmaSilButon.TabIndex = 8;
            this.FirmaSilButon.Text = "Sil";
            this.FirmaSilButon.Click += new System.EventHandler(this.FirmaSilButon_Click);
            // 
            // txtFirmaID
            // 
            this.txtFirmaID.Enabled = false;
            this.txtFirmaID.Location = new System.Drawing.Point(787, 94);
            this.txtFirmaID.Name = "txtFirmaID";
            this.txtFirmaID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFirmaID.Properties.Appearance.Options.UseFont = true;
            this.txtFirmaID.Size = new System.Drawing.Size(204, 28);
            this.txtFirmaID.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(787, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 22);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Firma_ID:";
            // 
            // FrmFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 532);
            this.Controls.Add(this.txtFirmaID);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.FirmaSilButon);
            this.Controls.Add(this.FirmaEkleButon);
            this.Controls.Add(this.txtFirmaKategori);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtFirmaAd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.FirmaGrid);
            this.Name = "FrmFirma";
            this.Text = "Firmalar";
            this.Load += new System.EventHandler(this.FrmFirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirmaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl FirmaGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtFirmaAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFirmaKategori;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton FirmaEkleButon;
        private DevExpress.XtraEditors.SimpleButton FirmaSilButon;
        private DevExpress.XtraEditors.TextEdit txtFirmaID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}