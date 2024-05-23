namespace Stok_Otomasyon
{
    partial class FrmSiparisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparisler));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.SiparisGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.EskiSipGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.RedSipGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtadet = new DevExpress.XtraEditors.TextEdit();
            this.txttanefiyat = new DevExpress.XtraEditors.TextEdit();
            this.txttoplamfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SipEkleButon = new DevExpress.XtraEditors.SimpleButton();
            this.cmbUrunID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txturunad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.urungrid = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbFirmaID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SiparisGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EskiSipGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedSipGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttanefiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoplamfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUrunID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urungrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirmaID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1, 1);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(994, 535);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.SiparisGrid);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(992, 505);
            this.xtraTabPage1.Text = "Güncel Siparişler";
            // 
            // SiparisGrid
            // 
            this.SiparisGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.SiparisGrid.Location = new System.Drawing.Point(5, 5);
            this.SiparisGrid.MainView = this.gridView1;
            this.SiparisGrid.Margin = new System.Windows.Forms.Padding(5);
            this.SiparisGrid.Name = "SiparisGrid";
            this.SiparisGrid.Size = new System.Drawing.Size(982, 495);
            this.SiparisGrid.TabIndex = 0;
            this.SiparisGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.SiparisGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1250;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.EskiSipGrid);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(992, 505);
            this.xtraTabPage2.Text = "Onaylanan Siparişler";
            // 
            // EskiSipGrid
            // 
            this.EskiSipGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.EskiSipGrid.Location = new System.Drawing.Point(5, 5);
            this.EskiSipGrid.MainView = this.gridView2;
            this.EskiSipGrid.Margin = new System.Windows.Forms.Padding(5);
            this.EskiSipGrid.Name = "EskiSipGrid";
            this.EskiSipGrid.Size = new System.Drawing.Size(982, 495);
            this.EskiSipGrid.TabIndex = 0;
            this.EskiSipGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 546;
            this.gridView2.GridControl = this.EskiSipGrid;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 1250;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.RedSipGrid);
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(5);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(992, 505);
            this.xtraTabPage3.Text = "Reddedilen Siparişler";
            // 
            // RedSipGrid
            // 
            this.RedSipGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.RedSipGrid.Location = new System.Drawing.Point(5, 5);
            this.RedSipGrid.MainView = this.gridView3;
            this.RedSipGrid.Margin = new System.Windows.Forms.Padding(5);
            this.RedSipGrid.Name = "RedSipGrid";
            this.RedSipGrid.Size = new System.Drawing.Size(982, 495);
            this.RedSipGrid.TabIndex = 1;
            this.RedSipGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.DetailHeight = 546;
            this.gridView3.GridControl = this.RedSipGrid;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsEditForm.PopupEditFormWidth = 1250;
            this.gridView3.OptionsFind.AlwaysVisible = true;
            // 
            // txtadet
            // 
            this.txtadet.Location = new System.Drawing.Point(1021, 207);
            this.txtadet.Margin = new System.Windows.Forms.Padding(5);
            this.txtadet.Name = "txtadet";
            this.txtadet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtadet.Properties.Appearance.Options.UseFont = true;
            this.txtadet.Size = new System.Drawing.Size(228, 28);
            this.txtadet.TabIndex = 10;
            this.txtadet.EditValueChanged += new System.EventHandler(this.textEdit4_EditValueChanged);
            // 
            // txttanefiyat
            // 
            this.txttanefiyat.Enabled = false;
            this.txttanefiyat.Location = new System.Drawing.Point(1021, 277);
            this.txttanefiyat.Margin = new System.Windows.Forms.Padding(5);
            this.txttanefiyat.Name = "txttanefiyat";
            this.txttanefiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txttanefiyat.Properties.Appearance.Options.UseFont = true;
            this.txttanefiyat.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txttanefiyat.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txttanefiyat.Size = new System.Drawing.Size(228, 28);
            this.txttanefiyat.TabIndex = 9;
            // 
            // txttoplamfiyat
            // 
            this.txttoplamfiyat.Enabled = false;
            this.txttoplamfiyat.Location = new System.Drawing.Point(1021, 347);
            this.txttoplamfiyat.Margin = new System.Windows.Forms.Padding(5);
            this.txttoplamfiyat.Name = "txttoplamfiyat";
            this.txttoplamfiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txttoplamfiyat.Properties.Appearance.Options.UseFont = true;
            this.txttoplamfiyat.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txttoplamfiyat.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txttoplamfiyat.Size = new System.Drawing.Size(228, 28);
            this.txttoplamfiyat.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(1021, 245);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 22);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Tane Fiyat:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1021, 315);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(108, 22);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Toplam Fiyat:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1021, 175);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 22);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Adet:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1021, 35);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 22);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ürün ID:";
            // 
            // SipEkleButon
            // 
            this.SipEkleButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SipEkleButon.ImageOptions.SvgImage")));
            this.SipEkleButon.Location = new System.Drawing.Point(1021, 467);
            this.SipEkleButon.Margin = new System.Windows.Forms.Padding(5);
            this.SipEkleButon.Name = "SipEkleButon";
            this.SipEkleButon.Size = new System.Drawing.Size(228, 69);
            this.SipEkleButon.TabIndex = 1;
            this.SipEkleButon.Text = "Sipariş Ekle";
            this.SipEkleButon.Click += new System.EventHandler(this.SipEkleButon_Click);
            // 
            // cmbUrunID
            // 
            this.cmbUrunID.Location = new System.Drawing.Point(1021, 67);
            this.cmbUrunID.Margin = new System.Windows.Forms.Padding(5);
            this.cmbUrunID.Name = "cmbUrunID";
            this.cmbUrunID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbUrunID.Properties.Appearance.Options.UseFont = true;
            this.cmbUrunID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUrunID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbUrunID.Size = new System.Drawing.Size(228, 28);
            this.cmbUrunID.TabIndex = 11;
            this.cmbUrunID.SelectedIndexChanged += new System.EventHandler(this.cmbUrunID_SelectedIndexChanged);
            // 
            // txturunad
            // 
            this.txturunad.Enabled = false;
            this.txturunad.Location = new System.Drawing.Point(1021, 137);
            this.txturunad.Margin = new System.Windows.Forms.Padding(5);
            this.txturunad.Name = "txturunad";
            this.txturunad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txturunad.Properties.Appearance.Options.UseFont = true;
            this.txturunad.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txturunad.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txturunad.Size = new System.Drawing.Size(228, 28);
            this.txturunad.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1021, 105);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 22);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Ürün Adı:";
            // 
            // urungrid
            // 
            this.urungrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.urungrid.Enabled = false;
            this.urungrid.Location = new System.Drawing.Point(1299, 35);
            this.urungrid.MainView = this.gridView4;
            this.urungrid.Margin = new System.Windows.Forms.Padding(5);
            this.urungrid.Name = "urungrid";
            this.urungrid.Size = new System.Drawing.Size(338, 501);
            this.urungrid.TabIndex = 14;
            this.urungrid.UseDisabledStatePainter = false;
            this.urungrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.DetailHeight = 546;
            this.gridView4.GridControl = this.urungrid;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsEditForm.PopupEditFormWidth = 1250;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // cmbFirmaID
            // 
            this.cmbFirmaID.Location = new System.Drawing.Point(1021, 417);
            this.cmbFirmaID.Margin = new System.Windows.Forms.Padding(5);
            this.cmbFirmaID.Name = "cmbFirmaID";
            this.cmbFirmaID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbFirmaID.Properties.Appearance.Options.UseFont = true;
            this.cmbFirmaID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFirmaID.Size = new System.Drawing.Size(228, 28);
            this.cmbFirmaID.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(1021, 385);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 22);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Firma_ID:";
            // 
            // FrmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1651, 551);
            this.Controls.Add(this.cmbFirmaID);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.urungrid);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.cmbUrunID);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.txtadet);
            this.Controls.Add(this.SipEkleButon);
            this.Controls.Add(this.txttanefiyat);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txttoplamfiyat);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Name = "FrmSiparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişler Ekranı";
            this.Load += new System.EventHandler(this.FrmSiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SiparisGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EskiSipGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RedSipGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttanefiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoplamfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUrunID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urungrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirmaID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl SiparisGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtadet;
        private DevExpress.XtraEditors.TextEdit txttanefiyat;
        private DevExpress.XtraEditors.TextEdit txttoplamfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton SipEkleButon;
        private DevExpress.XtraGrid.GridControl EskiSipGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl RedSipGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUrunID;
        private DevExpress.XtraEditors.TextEdit txturunad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl urungrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFirmaID;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}