using DevExpress.XtraEditors;
using Stok_Otomasyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Otomasyon
{
    public partial class FrmRapor : DevExpress.XtraEditors.XtraForm
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Urun_ID,UrunAd,Tane_Fiyat,Toplam_Fiyat from dbo.Siparisler order by Toplam_Fiyat desc", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void listele2()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT d.DepartmanAd, s.UrunAd, SUM(s.Adet) AS ToplamAdet, SUM(s.Adet * s.Tane_Fiyat) AS Toplam_Fiyat  FROM Siparisler s JOIN Departman d ON s.Departman_ID = d.Departman_ID GROUP BY  d.DepartmanAd, s.UrunAd ORDER BY  d.DepartmanAd,  s.UrunAd;", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }
        void listele3()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT f.FirmaAd, s.UrunAd,SUM(s.Adet) AS Adet FROM Siparisler s JOIN TedarikFirma f ON s.Firma_ID = f.Firma_ID GROUP BY f.FirmaAd, s.UrunAd ORDER BY Adet DESC, f.FirmaAd ASC;", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;

        }

        public FrmRapor()
        {
            InitializeComponent();
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            listele();
            listele2();
            listele3();
        }
    }
}