using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace subp2
{
    class oturum_secenekleri_kontrol
    {
        int[] dizi = new int[3];
        subp2.bag_class sinif_cek = new subp2.bag_class();
        public void cek()
        {
            MySqlConnection baglanti = new MySqlConnection(sinif_cek.baglan());
            try
            {
                baglanti.Open();

                string sql = "SELECT * FROM oturum_secenekleri";
                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dizi[0] = Convert.ToInt32(dr[0]);
                    dizi[1] = Convert.ToInt32(dr[1]);
                    dizi[2] = Convert.ToInt32(dr[2]);
                }
                ProcessStartInfo prs = new ProcessStartInfo();
                string dizin = "C:\\\\windows\\\\system32\\\\shutdown.exe";
                if (dizi[0] == 1)
                {
                    prs.FileName = dizin;
                    prs.Arguments = "-f -s -c " + " -t ";
                    Process.Start(prs);//kapat
                }
                if (dizi[1] == 1)
                {
                    prs.FileName = dizin;
                    prs.Arguments = "-f -r -c " + " -t ";
                    Process.Start(prs);//res
                }
                if (dizi[2] == 1)
                {
                    prs.FileName = dizin;
                    prs.Arguments = "-l -t ";
                    Process.Start(prs);//oturum_kapat
                }
                dr.Close();
            }
            catch
            { }
        }
    }
}
