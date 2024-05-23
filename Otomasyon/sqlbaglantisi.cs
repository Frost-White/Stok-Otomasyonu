using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace Stok_Otomasyon
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-R54N54U;Initial Catalog=Stok_Otomasyonu;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
