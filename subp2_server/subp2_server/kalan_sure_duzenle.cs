using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace subp2_server
{
    class kalan_sure_duzenle
    {
        subp2_server.bag_class Sinif_cek = new bag_class();
       public void duzenle(string zaman)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
                string Query = "UPDATE kalan_zaman SET kalan_sure = '" + zaman + "'";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                MySqlDataReader MyReader2;
                baglanti.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Süreler Yenilendi");
            }
            catch
            {
                MessageBox.Show("Veri tabanı bağlantısını kontrol ediniz.");
            }

        }
    }
}
