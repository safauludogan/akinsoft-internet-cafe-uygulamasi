using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace subp2_server
{
    class oturum_secenekleri
    {
        subp2_server.bag_class Sinif_cek = new bag_class();
        public void cek(int k,int y,int o)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
                string Query = "UPDATE oturum_secenekleri SET kapat = " + k + " , yeniden_baslat=" + y + " ,oturum_kapat=" + o + "";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                MySqlDataReader MyReader2;
                baglanti.Open();
                MyReader2 = MyCommand2.ExecuteReader();
            }
            catch
            {
 
            }
        }
    }
}
