using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Otomasyon
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }
        FrmSiparisler frm1;
        FrmDepo frm2;
        FrmFirma frm3;
        FrmGiriş frm4;
        FrmUrun frm5;
        FrmGirisBilgDuzenle frm6;
        FrmRapor frm7;

        private void SiparisButon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
            frm1 = new FrmSiparisler();
            frm1.MdiParent = this;
            frm1.Show();
            }
        }

        private void DepoButon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new FrmDepo();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        private void SistemYöneticisiButon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new FrmFirma();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void GirisEkranButon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new FrmGiriş();
                frm4.Show();
                this.Hide();
            }
        }

        private void UrunEkleButon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new FrmUrun();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }

        private void GirisBilgButon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new FrmGirisBilgDuzenle();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }

        private void RaporlarButon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new FrmRapor();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
