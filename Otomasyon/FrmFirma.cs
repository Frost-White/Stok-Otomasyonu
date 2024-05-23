using DevExpress.Utils.CodedUISupport;
using DevExpress.XtraDashboardLayout;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Otomasyon
{
    public partial class FrmFirma : Form
    {
        public FrmFirma()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listeleFirmaGrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TedarikFirma", bgl.baglanti());
            da.Fill(dt);
            FirmaGrid.DataSource = dt;
        }
        private void FrmFirma_Load(object sender, EventArgs e)
        {
            listeleFirmaGrid();       
        }

        private void FirmaEkleButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TedarikFirma (FirmaAd,Kategori) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtFirmaAd.Text);
            komut.Parameters.AddWithValue("@p2", txtFirmaKategori.Text);
            komut.ExecuteNonQuery();
            listeleFirmaGrid();
            MessageBox.Show("Firma Eklendi");
        }

        

        private void FirmaSilButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select * From Urun where Firma_ID=@p1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(txtFirmaID.Text));
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand komut1 = new SqlCommand("Delete From Urun where Firma_ID = @p1", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(txtFirmaID.Text));
                komut1.ExecuteNonQuery();
                MessageBox.Show("Firma ürünleri silindi");
            }
            else
            {
                MessageBox.Show("Firmanın silinecek ürünü yok");
            }
            
            SqlCommand komut = new SqlCommand("Delete From TedarikFirma where FirmaAd = @p1 and Kategori = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtFirmaAd.Text);
            komut.Parameters.AddWithValue("@p2", txtFirmaKategori.Text);
            int a = komut.ExecuteNonQuery();
            if (a == 0)
            {
                MessageBox.Show("Firma adı veya kategorisi yanlış tekrar deneyin");
                txtFirmaAd.Text = "";
                txtFirmaKategori.Text = "";
            }
            else
            {
                listeleFirmaGrid();
                MessageBox.Show("Firma silindi");
            }
        }

        private void gridView1_FocusedRowObjectChanged_1(object sender, FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtFirmaID.Text = dr["Firma_ID"].ToString();
                txtFirmaAd.Text = dr["FirmaAd"].ToString();
                txtFirmaKategori.Text = dr["Kategori"].ToString();
            }
        }
    }
}
