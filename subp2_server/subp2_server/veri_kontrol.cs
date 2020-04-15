using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace subp2_server
{
    class veri_kontrol
    {
        int yolla = 0;
        string sql, sql2, z = "1:30";
        subp2_server.bag_class Sinif_cek = new subp2_server.bag_class();
        public void cek(int tablo_kontrol)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
                baglanti.Open();
                if (tablo_kontrol == 1)
                {
                    sql = "SELECT count(kapat) FROM oturum_secenekleri";
                }
                if (tablo_kontrol == 2)
                {
                    sql = "SELECT count(kalan_sure) FROM kalan_zaman";
                }
                if (tablo_kontrol == 3)
                {
                    sql = "SELECT count(tarih) FROM tarih";
                }
                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    yolla = Convert.ToInt32(rdr[0]);
                }
                rdr.Close();
                if (yolla <= 0)
                {
                    baglanti.Close();//Veri yoksa 000 yazdır
                    baglanti.Open();
                    if (tablo_kontrol == 1)
                    {
                        sql2 = "insert into oturum_secenekleri(kapat,yeniden_baslat,oturum_kapat) values(" + 0 + "," + 0 + "," + 0 + ")";
                    }
                    if (tablo_kontrol == 2)
                    {
                        sql2 = "insert into kalan_zaman(kalan_sure) values('" + z + "')";
                    }
                    if (tablo_kontrol == 3)
                    {
                        sql2 = "insert into tarih(tarih) values('" + DateTime.Now.ToShortDateString() + "')";
                    }
                    MySqlCommand cmd2 = new MySqlCommand(sql2, baglanti);
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            catch
            {
                MessageBox.Show("Veri tabanı bağlantısında bir sorun var!...");
            }
        }
    }
}
