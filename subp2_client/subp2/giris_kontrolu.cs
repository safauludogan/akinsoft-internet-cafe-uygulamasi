using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace subp2
{
    class giris_kontrolu
    {
        int ver = 0;
        public int getir(int no)
        {
            ver = no;
            return no;
        }
        string ogr_no = "", sifre = "";
        subp2.bag_class Sinif_cek = new subp2.bag_class();
        public string giris(int secim)
        {
            MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
            MySqlCommand komut = new MySqlCommand();
            komut.CommandText = "select * from uyeler where ogrenci_no=" + Convert.ToInt32(ver) + "";
            komut.Connection = baglanti;
            baglanti.Close();
            baglanti.Open();
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ogr_no = dr[0].ToString();
                sifre = dr[3].ToString();
            }
            if (secim == 1)
            {
                return ogr_no;
            }
            else
            {
                return sifre;
            }
        }
    }
}
