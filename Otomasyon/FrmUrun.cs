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

namespace Stok_Otomasyon
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listeleUrunGrid() 
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Urun", bgl.baglanti());
            da.Fill(dt);
            UrunGrid.DataSource = dt;
        }
        void FirmaEkle()
        {
            SqlCommand komut = new SqlCommand("Select Firma_ID from TedarikFirma ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbFirmaID.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            listeleUrunGrid();
            FirmaEkle();
        }

        private void UrunEkleButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Urun (UrunAd,Firma_ID,Fiyat) values (@p1,@p2,@p3)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", Convert.ToInt32(cmbFirmaID.Text));
            komut.Parameters.AddWithValue("@p3",Convert.ToInt32(TxtFiyat.Text));
            komut.ExecuteNonQuery();
            listeleUrunGrid();
            MessageBox.Show("Ürün Eklendi");
        }

        private void UrunSilButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Urun where UrunAd = @p1 and Firma_ID = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", cmbFirmaID.Text);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            int a = komut.ExecuteNonQuery();
            if (a == 0)
            {
                MessageBox.Show("Ürün adı yanlış tekrar deneyin");
                txtUrunAd.Text = "";
            }
            else
            {
                listeleUrunGrid();
                MessageBox.Show("Ürün Silindi");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtUrunAd.Text = dr["UrunAd"].ToString();
                cmbFirmaID.Text = dr["Firma_ID"].ToString();
                TxtFiyat.Text = dr["Fiyat"].ToString();
            }
        }
    }
}
