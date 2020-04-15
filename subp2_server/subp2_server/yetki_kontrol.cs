using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace subp2_server
{
    class yetki_kontrol
    {
        string sql;
        int y_kontrol;
        subp2_server.bag_class Sinif_cek = new bag_class();
        public int kontrol_et(int no, string sifre)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
                baglanti.Open();
                sql = "SELECT * FROM uyeler where ogrenci_no=" + no + " and sifre='" + sifre + "'";
                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    y_kontrol = Convert.ToInt32(rdr[4]);
                }
                rdr.Close();
                if (y_kontrol != 1 && sifre != "")
                {
                    MessageBox.Show("Giriş başarısız, lütfen yetkili bir hesap ile giriş yapınız.");
                }
            }
            catch
            {
                MessageBox.Show("Veri tabanı bağlantınızı kontrol ediniz.");
            }
            return y_kontrol;
        }
    }
}
