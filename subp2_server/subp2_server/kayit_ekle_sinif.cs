using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace subp2_server
{
    class kayit_ekle_sinif
    {
        subp2_server.bag_class sinif_cek = new subp2_server.bag_class();
        string sql,sql2,sure_cek;
        int kontrol, yeniden_ac;
        public int ekle(int ogr, string ad, string soyad)
        {
            MySqlConnection baglanti = new MySqlConnection(sinif_cek.baglan());
            try
            {
                baglanti.Close();
                baglanti.Open();
                sql = "SELECT * FROM uyeler";
                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    kontrol = Convert.ToInt32(rdr[0]);
                    if (kontrol == ogr)
                    {
                        MessageBox.Show("Öğrenci zaten kayıt edilmiş.");
                        break;
                    }
                }

                baglanti.Close();
                baglanti.Open();
                sql2 = "SELECT * FROM kalan_zaman";
                MySqlCommand cmd2 = new MySqlCommand(sql2, baglanti);
                MySqlDataReader rdr2 = cmd2.ExecuteReader();

                while (rdr2.Read())
                {
                    sure_cek = rdr2[0].ToString();
                }

                if (kontrol != ogr)
                {
                    baglanti.Close();
                    baglanti.Open();
                    string komut = "insert into hesaplar(ogr_no,kalan_sure,yetki) values(" + ogr + ", '" + sure_cek + "', '" + 0 + "')";
                    MySqlCommand kmt = new MySqlCommand(komut, baglanti);
                    kmt.ExecuteNonQuery();

                    baglanti.Close();
                    baglanti.Open();
                    string komut2 = "insert into uyeler(ogrenci_no,ad,soyad,sifre,yetki) values(" + ogr + ", '" + ad + "', '" + soyad + "','" + "a123456" + "'," + 0 + ")";
                    MySqlCommand kmt2 = new MySqlCommand(komut2, baglanti);
                    kmt2.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Eklendi.");
                    yeniden_ac = 1;
                }
                rdr.Close();
            }
            catch
            {
                MessageBox.Show("Kayıt Eklenemedi.");
            }
            return yeniden_ac;
        }
    }
}
