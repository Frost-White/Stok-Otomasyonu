namespace Stok_Otomasyon
{
    partial class FrmAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaEkran));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.GirisEkranButon = new DevExpress.XtraBars.BarButtonItem();
            this.FirmaButon = new DevExpress.XtraBars.BarButtonItem();
            this.UrunEkleButon = new DevExpress.XtraBars.BarButtonItem();
            this.GirisBilgButon = new DevExpress.XtraBars.BarButtonItem();
            this.RaporlarButon = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(57);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.GirisEkranButon,
            this.FirmaButon,
            this.UrunEkleButon,
            this.GirisBilgButon,
            this.RaporlarButon});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 644;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(882, 183);
            // 
            // GirisEkranButon
            // 
            this.GirisEkranButon.Caption = "Giriş Ekranı";
            this.GirisEkranButon.Id = 1;
            this.GirisEkranButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GirisEkranButon.ImageOptions.SvgImage")));
            this.GirisEkranButon.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.GirisEkranButon.ItemAppearance.Normal.Options.UseFont = true;
            this.GirisEkranButon.Name = "GirisEkranButon";
            this.GirisEkranButon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GirisEkranButon_ItemClick);
            // 
            // FirmaButon
            // 
            this.FirmaButon.Caption = "Firma Ekle/Çıkar";
            this.FirmaButon.Id = 4;
            this.FirmaButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FirmaButon.ImageOptions.SvgImage")));
            this.FirmaButon.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FirmaButon.ItemAppearance.Normal.Options.UseFont = true;
            this.FirmaButon.Name = "FirmaButon";
            this.FirmaButon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SistemYöneticisiButon_ItemClick);
            // 
            // UrunEkleButon
            // 
            this.UrunEkleButon.Caption = "Ürün Ekle/Çıkar";
            this.UrunEkleButon.Id = 5;
            this.UrunEkleButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("UrunEkleButon.ImageOptions.SvgImage")));
            this.UrunEkleButon.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.UrunEkleButon.ItemAppearance.Normal.Options.UseFont = true;
            this.UrunEkleButon.Name = "UrunEkleButon";
            this.UrunEkleButon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UrunEkleButon_ItemClick);
            // 
            // GirisBilgButon
            // 
            this.GirisBilgButon.Caption = "Giriş Bilgi Düzenle";
            this.GirisBilgButon.Id = 6;
            this.GirisBilgButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GirisBilgButon.ImageOptions.SvgImage")));
            this.GirisBilgButon.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.GirisBilgButon.ItemAppearance.Normal.Options.UseFont = true;
            this.GirisBilgButon.Name = "GirisBilgButon";
            this.GirisBilgButon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GirisBilgButon_ItemClick);
            // 
            // RaporlarButon
            // 
            this.RaporlarButon.Caption = "Raporlar";
            this.RaporlarButon.Id = 7;
            this.RaporlarButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("RaporlarButon.ImageOptions.SvgImage")));
            this.RaporlarButon.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.RaporlarButon.ItemAppearance.Normal.Options.UseFont = true;
            this.RaporlarButon.Name = "RaporlarButon";
            this.RaporlarButon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RaporlarButon_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Stok Otomasyon Ekranı";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.GirisEkranButon);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.UrunEkleButon);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.FirmaButon);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.GirisBilgButon);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.RaporlarButon);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 623);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.IsMdiContainer = true;
            this.Name = "FrmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A Firması";
            this.Load += new System.EventHandler(this.FrmAnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem GirisEkranButon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem FirmaButon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem UrunEkleButon;
        private DevExpress.XtraBars.BarButtonItem GirisBilgButon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem RaporlarButon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
    }
}

