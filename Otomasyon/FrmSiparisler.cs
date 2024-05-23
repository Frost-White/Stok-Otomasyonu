using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.Utils;
using DevExpress.Utils.Extensions;

namespace Stok_Otomasyon
{
    public partial class FrmSiparisler : Form
    {
        public int DepartmanIDAl { get; set; }
        public FrmSiparisler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listeleSiparisGrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Siparisler where Durum='Beklemede'", bgl.baglanti());
            da.Fill(dt);
            SiparisGrid.DataSource = dt;
        }
        void listeleEskiSipGrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Siparisler where Durum='Onaylandı'", bgl.baglanti());
            da.Fill(dt);
            EskiSipGrid.DataSource = dt;
        }
        void listeleRedSipGrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Siparisler where Durum='Reddedildi'", bgl.baglanti());
            da.Fill(dt);
            RedSipGrid.DataSource = dt;
        }
        void listeleUrunGrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Urun_ID,UrunAd,Firma_ID from Urun", bgl.baglanti());
            da.Fill(dt);
            urungrid.DataSource = dt;
        }
        void Urunekle() 
        {
            SqlCommand komut = new SqlCommand("Select Urun_ID from Urun",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbUrunID.Properties.Items.Add(dr[0]);
            }
        }
        private void FrmSiparisler_Load(object sender, EventArgs e)
        {
            listeleSiparisGrid();
            listeleEskiSipGrid();
            listeleRedSipGrid();
            listeleUrunGrid();
            Urunekle();
        }
        private void cmbUrunID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFirmaID.Properties.Items.Clear();

            SqlCommand komut = new SqlCommand("Select * from Urun where Urun_ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbUrunID.SelectedItem);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txttanefiyat.Text = dr[3].ToString();
                txturunad.Text = dr[1].ToString();
                cmbFirmaID.Properties.Items.Add(dr[2]);
            }
        }
        private void SipEkleButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Siparisler (Urun_ID,UrunAd,Adet,Tane_Fiyat,Toplam_Fiyat,Firma_ID,Departman_ID,Durum)" +
                " Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,'Beklemede')", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(cmbUrunID.Text));
            komut.Parameters.AddWithValue("@p2", txturunad.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt32(txtadet.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToInt32(txttanefiyat.Text));
            komut.Parameters.AddWithValue("@p5", Convert.ToInt32(txttoplamfiyat.Text));
            komut.Parameters.AddWithValue("@p6", Convert.ToInt32(cmbFirmaID.Text));
            komut.Parameters.AddWithValue("@p7", DepartmanIDAl);
            komut.ExecuteNonQuery();
            MessageBox.Show("Sipariş Eklendi", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            listeleSiparisGrid();
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttanefiyat.Text) && !string.IsNullOrEmpty(txtadet.Text))
            {
                int tanefiyat;
                int adet;
                if (int.TryParse(txttanefiyat.Text, out tanefiyat) && int.TryParse(txtadet.Text, out adet))
                {
                    txttoplamfiyat.Text = (tanefiyat * adet).ToString();
                }
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
