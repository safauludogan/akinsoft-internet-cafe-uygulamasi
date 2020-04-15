using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace subp2_server
{
    class sureleri_yenile
    {
        string sql, z;
        subp2_server.bag_class Sinif_cek = new subp2_server.bag_class();
       public void guncelle()
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
                baglanti.Open();
                sql = "SELECT * FROM kalan_zaman";
                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    z = rdr[0].ToString();
                }

                string Query = "UPDATE hesaplar SET kalan_sure = '" + z + "'";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                MySqlDataReader MyReader2;
                baglanti.Close();
                baglanti.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Süreler Yenilendi");
            }
            catch
            {
                MessageBox.Show("Veri tabanı bağlantısını kontrol ediniz...");
            }
        }
    }
}
