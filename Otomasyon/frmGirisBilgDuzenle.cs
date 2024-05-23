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
    public partial class FrmGirisBilgDuzenle : Form
    {
        public FrmGirisBilgDuzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listeleYetki()
        {
            cmbYetki.Properties.Items.Add("1");
            cmbYetki.Properties.Items.Add("2");
            cmbYetki.Properties.Items.Add("3");
        }
        void listeleGirisBilgGrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from GirisBilg", bgl.baglanti());
            da.Fill(dt);
            GirisBilgGrid.DataSource = dt;
        }
        private void FrmGirisBilgDuzenle_Load(object sender, EventArgs e)
        {
            listeleGirisBilgGrid();
            listeleYetki();
        }
        private void EkleButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into GirisBilg (Personel_ID,KAdı,Sifre,Yetki)" +
                " Values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Convert.ToInt32(txtPersonelID.Text));
            komut.Parameters.AddWithValue("@p2", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSifre.Text);
            komut.Parameters.AddWithValue("@p4", Convert.ToInt32(cmbYetki.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Giriş Bilgileri Eklendi");
            listeleGirisBilgGrid();
        }

        private void GuncelleButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update GirisBilg set KAdı=@p1,Sifre=@p2,Yetki=@p3 " +
                "where Personel_ID = @p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p4", Convert.ToInt32(txtPersonelID.Text));
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt32(cmbYetki.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Giriş Bilgileri Güncellendi");
            listeleGirisBilgGrid();
        }

        private void KaldırButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from GirisBilg where Personel_ID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(txtPersonelID.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Giriş Bilgileri Silindi");
            listeleGirisBilgGrid();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtPersonelID.Text = dr["Personel_ID"].ToString();
                txtKullaniciAd.Text = dr["KAdı"].ToString();
                txtSifre.Text = dr["Sifre"].ToString();
                cmbYetki.Text = dr["Yetki"].ToString();
            }
        }
    }
}
