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
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmGiriş_Load(object sender, EventArgs e)
        {
            
        }
        private void YoneticiGirButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select KAdı,Sifre,Yetki from GirisBilg where KAdı=@p1 and Sifre=@p2 and Yetki=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKAdı.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.Parameters.AddWithValue("@p3", 3);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaEkran form1 = new FrmAnaEkran();
                form1.Show();
                this.Hide();
                txtKAdı.Text = "";
                txtSifre.Text = "";
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Yada Şifre");
                txtKAdı.Text = "";
                txtSifre.Text = "";
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select KAdı,Sifre,Yetki from GirisBilg where KAdı=@p1 and Sifre=@p2 and Yetki=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKAdı.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.Parameters.AddWithValue("@p3", 2);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDepo form1 = new FrmDepo();
                form1.Show();
                this.Hide();
                txtKAdı.Text = "";
                txtSifre.Text = "";
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Yada Şifre");
                txtKAdı.Text = "";
                txtSifre.Text = "";
            }
        }

        private void DepartmanGirisButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select KAdı,Sifre,Yetki from GirisBilg where KAdı=@p1 and Sifre=@p2 and Yetki=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKAdı.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.Parameters.AddWithValue("@p3", 1);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand komut1 = new SqlCommand("select Departman from Personel where Personel_ID= " +
                    "(select Personel_ID from GirisBilg where KAdı=@p1 and Sifre=@p2)",bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txtKAdı.Text);
                komut1.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader dr1 = komut1.ExecuteReader();
                int a = 0;
                while (dr1.Read())
                {
                   a = Convert.ToInt32(dr1[0]);
                }
                FrmSiparisler form1 = new FrmSiparisler();
                form1.DepartmanIDAl = a;
                form1.Show();
                this.Hide();
                txtKAdı.Text = "";
                txtSifre.Text = "";
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Yada Şifre");
                txtKAdı.Text = "";
                txtSifre.Text = "";
            }
        }

        private void svgImageBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}
