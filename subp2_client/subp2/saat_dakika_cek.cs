using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace subp2
{
    class saat_dakika_cek
    {
        int ver = 0;
        public int getir(int no)
        {
            ver = no;
            return no;
        }
        string kalan_s = "";
        int dakika = 0, saat = 0;
        subp2.bag_class sinif_cek = new subp2.bag_class();
        public int sd_cek(int secim, int hangi_form)
        {
            MySqlCommand komut = new MySqlCommand();
            MySqlConnection baglanti = new MySqlConnection(sinif_cek.baglan());
            if (hangi_form == 1)
            {
                komut.CommandText = "select * from hesaplar where ogr_no=" + Convert.ToInt32(ver) + "";
            }
            else
            {
                komut.CommandText = "select * from hesaplar where ogr_no=" + Convert.ToInt32(Giris.ogr_no_yolla) + "";
            }
            komut.Connection = baglanti;
            baglanti.Close();
            baglanti.Open();
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kalan_s = dr[1].ToString();
            }
            if (secim == 1)
            {
                return saat = Convert.ToInt32(kalan_s.Substring(0, 1));
            }
            else
            {
                return dakika = Convert.ToInt32(kalan_s.Substring(2, 2));
            }
        }
    }
}
