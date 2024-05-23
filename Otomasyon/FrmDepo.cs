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
using DevExpress.Utils.Html;
using DevExpress.XtraExport.Xls;

namespace Stok_Otomasyon
{
    public partial class FrmDepo : Form
    {
        public FrmDepo()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void listeleSipGrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Siparisler where Durum='Beklemede'", bgl.baglanti());
            da.Fill(dt);
            SipGrid.DataSource = dt;
        }
        void listeleDepoGrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Depo_Icerik", bgl.baglanti());
            da.Fill(dt);
            DepoGrid.DataSource = dt;
        }

        private void FrmDepo_Load(object sender, EventArgs e)
        {
            listeleDepoGrid();
            listeleSipGrid();
        }

        private void OnayButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Update Siparisler Set Durum=@p4 Where Siparis_ID=@p3 ",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p4", "Onaylandı");
            komut1.Parameters.AddWithValue("@p3",Convert.ToInt32(txtSipID.Text));
            komut1.ExecuteNonQuery();
            SqlCommand komut = new SqlCommand("Update Depo_Icerik Set Adet=Adet-@p1 where Urun_ID=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Convert.ToInt32(txtSipadet.Text));
            komut.Parameters.AddWithValue("@p2",Convert.ToInt32(txtUrunID.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün Birime Gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeleDepoGrid();
            listeleSipGrid();
            
        }

        private void RedButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Update Siparisler Set Durum=@p4 Where Siparis_ID=@p3 ", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p4", "Reddedildi");
            komut1.Parameters.AddWithValue("@p3", Convert.ToInt32(txtSipID.Text));
            komut1.ExecuteNonQuery();
            MessageBox.Show("Sipariş İptal Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeleSipGrid();
        }
        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                txtSipID.Text = dr["Siparis_ID"].ToString();
                txtSipadet.Text = dr["Adet"].ToString();
                txtUrunID.Text = dr["Urun_ID"].ToString();
            }
        }
    }
}
