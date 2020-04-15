using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace subp2
{
    class sifre_degistir_sinif
    {
        int kapansinmi;
        string sifre_ne;
        public int degistir(string mevcut, string sifre, string tekrar, int ogr_no)
        {
            subp2.bag_class sinif_cek = new subp2.bag_class();
            try
            {
                MySqlConnection baglanti = new MySqlConnection(sinif_cek.baglan());
                if (sifre.Length < 3)
                {
                    MessageBox.Show("Şifreniz en az 3 karakterden oluşmalıdır");
                }
                else
                {

                    MySqlCommand komut = new MySqlCommand();
                    komut.CommandText = "select * from uyeler where ogrenci_no=" + ogr_no + "";
                    komut.Connection = baglanti;
                    baglanti.Close();
                    baglanti.Open();
                    MySqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        sifre_ne = dr[3].ToString();
                    }

                    if (mevcut == sifre_ne)
                    {
                        if (sifre == tekrar)
                        {
                            string Query = "UPDATE uyeler SET sifre = '" + sifre + "' WHERE ogrenci_no = " + ogr_no + "";
                            MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                            MySqlDataReader MyReader2;
                            baglanti.Close();
                            baglanti.Open();
                            MyReader2 = MyCommand2.ExecuteReader();
                            MessageBox.Show("Sifre Güncellendi");
                            kapansinmi = 1;
                        }
                        else
                        {
                            MessageBox.Show("Şifreler Uyuşmuyor!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mevcut şifrenizi yanlış girdiniz.");
                    }
                }
            }
            catch
            { MessageBox.Show("Hata!"); }
            return kapansinmi;
        }
    }
}
