using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace subp2_server
{
    class tarih_kontrol_et
    {
        string bak,kalan_s;
        subp2_server.bag_class Sinif_cek = new subp2_server.bag_class();
        public void kontrol()
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tarih", baglanti);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    bak = rdr[0].ToString();
                }
                if (bak != DateTime.Now.ToShortDateString())
                {
                    MySqlCommand MyCommand2 = new MySqlCommand("UPDATE tarih SET tarih = '" + DateTime.Now.ToShortDateString() + "'", baglanti);
                    MySqlDataReader MyReader2;
                    baglanti.Close();
                    baglanti.Open();
                    MyReader2 = MyCommand2.ExecuteReader();

                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM kalan_zaman", baglanti);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        kalan_s = rdr2[0].ToString();
                    }


                    MySqlCommand MyCommand3 = new MySqlCommand("UPDATE hesaplar SET kalan_sure = '" + kalan_s + "'", baglanti);
                    MySqlDataReader MyReader3;
                    baglanti.Close();
                    baglanti.Open();
                    MyReader3 = MyCommand3.ExecuteReader();

                    MessageBox.Show("Süreler Yenilendi");
                }
                rdr.Close();
            }
            catch
            { }
        
        }
    }
}
