namespace Stok_Otomasyon
{
    partial class FrmDepo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepo));
            this.DepoGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SipGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSipID = new DevExpress.XtraEditors.TextEdit();
            this.RedButon = new DevExpress.XtraEditors.SimpleButton();
            this.OnayButon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSipadet = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunID = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.DepoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SipGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSipID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSipadet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // DepoGrid
            // 
            this.DepoGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.DepoGrid.Location = new System.Drawing.Point(16, 69);
            this.DepoGrid.MainView = this.gridView1;
            this.DepoGrid.Margin = new System.Windows.Forms.Padding(5);
            this.DepoGrid.Name = "DepoGrid";
            this.DepoGrid.Size = new System.Drawing.Size(497, 504);
            this.DepoGrid.TabIndex = 0;
            this.DepoGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.DepoGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1000;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // SipGrid
            // 
            this.SipGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.SipGrid.Location = new System.Drawing.Point(523, 69);
            this.SipGrid.MainView = this.gridView2;
            this.SipGrid.Margin = new System.Windows.Forms.Padding(5);
            this.SipGrid.Name = "SipGrid";
            this.SipGrid.Size = new System.Drawing.Size(665, 504);
            this.SipGrid.TabIndex = 1;
            this.SipGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 437;
            this.gridView2.GridControl = this.SipGrid;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 1000;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView2_FocusedRowObjectChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1198, 69);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 22);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Sipariş_ID:";
            // 
            // txtSipID
            // 
            this.txtSipID.Enabled = false;
            this.txtSipID.Location = new System.Drawing.Point(1198, 101);
            this.txtSipID.Margin = new System.Windows.Forms.Padding(5);
            this.txtSipID.Name = "txtSipID";
            this.txtSipID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSipID.Properties.Appearance.Options.UseFont = true;
            this.txtSipID.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtSipID.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtSipID.Size = new System.Drawing.Size(190, 28);
            this.txtSipID.TabIndex = 3;
            // 
            // RedButon
            // 
            this.RedButon.Appearance.BackColor = System.Drawing.Color.White;
            this.RedButon.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.RedButon.Appearance.Options.UseBackColor = true;
            this.RedButon.Appearance.Options.UseFont = true;
            this.RedButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("RedButon.ImageOptions.SvgImage")));
            this.RedButon.Location = new System.Drawing.Point(1198, 453);
            this.RedButon.Margin = new System.Windows.Forms.Padding(5);
            this.RedButon.Name = "RedButon";
            this.RedButon.Size = new System.Drawing.Size(190, 64);
            this.RedButon.TabIndex = 4;
            this.RedButon.Text = "Reddet";
            this.RedButon.Click += new System.EventHandler(this.RedButon_Click);
            // 
            // OnayButon
            // 
            this.OnayButon.Appearance.BackColor = System.Drawing.Color.White;
            this.OnayButon.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.OnayButon.Appearance.Options.UseBackColor = true;
            this.OnayButon.Appearance.Options.UseFont = true;
            this.OnayButon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("OnayButon.ImageOptions.SvgImage")));
            this.OnayButon.Location = new System.Drawing.Point(1198, 330);
            this.OnayButon.Margin = new System.Windows.Forms.Padding(6);
            this.OnayButon.Name = "OnayButon";
            this.OnayButon.Size = new System.Drawing.Size(190, 64);
            this.OnayButon.TabIndex = 5;
            this.OnayButon.Text = "Onayla";
            this.OnayButon.Click += new System.EventHandler(this.OnayButon_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1199, 140);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 22);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Sipariş Adet:";
            // 
            // txtSipadet
            // 
            this.txtSipadet.Enabled = false;
            this.txtSipadet.Location = new System.Drawing.Point(1198, 174);
            this.txtSipadet.Margin = new System.Windows.Forms.Padding(6);
            this.txtSipadet.Name = "txtSipadet";
            this.txtSipadet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSipadet.Properties.Appearance.Options.UseFont = true;
            this.txtSipadet.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtSipadet.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtSipadet.Size = new System.Drawing.Size(190, 28);
            this.txtSipadet.TabIndex = 7;
            // 
            // txtUrunID
            // 
            this.txtUrunID.Enabled = false;
            this.txtUrunID.Location = new System.Drawing.Point(1198, 254);
            this.txtUrunID.Margin = new System.Windows.Forms.Padding(8);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUrunID.Properties.Appearance.Options.UseFont = true;
            this.txtUrunID.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtUrunID.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtUrunID.Size = new System.Drawing.Size(190, 28);
            this.txtUrunID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Location = new System.Drawing.Point(1198, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürün ID:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(172, 22);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 30);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Depo İçeriği";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(795, 22);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 30);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Siparişler";
            // 
            // FrmDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 580);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.OnayButon);
            this.Controls.Add(this.RedButon);
            this.Controls.Add(this.txtSipID);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.DepoGrid);
            this.Controls.Add(this.txtSipadet);
            this.Controls.Add(this.SipGrid);
            this.Name = "FrmDepo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo";
            this.Load += new System.EventHandler(this.FrmDepo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SipGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSipID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSipadet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DepoGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl SipGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSipID;
        private DevExpress.XtraEditors.SimpleButton RedButon;
        private DevExpress.XtraEditors.SimpleButton OnayButon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSipadet;
        private DevExpress.XtraEditors.TextEdit txtUrunID;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}