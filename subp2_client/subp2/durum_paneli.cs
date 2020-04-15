using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace subp2
{
    public partial class durum_paneli : Form
    {
        public durum_paneli()
        {
            InitializeComponent();
        }
        public static int ogrenci_no_yolla;
        int yetki,oturum_secenekleri_kontrol, saniye_geri_sayim = 60, dakika = 0, saat = 0, no = 0, mesajGoster = 0, mesajGoster2 = 0, durdur = 0, sure_isle_sayac = 180, veri_baglanti_kontrol = 0, oturum_kapat_geri_sayim = 0, bir_sefer_uyari_goster = 0,bir_sefer_uyari_goster2=0 ,i_baglanti_kontrol_anahtar = 0;
        subp2.saat_dakika_cek sinif_cek = new subp2.saat_dakika_cek();
        subp2.oturum_secenekleri_kontrol sinif_cek3 = new subp2.oturum_secenekleri_kontrol();
        subp2.i_control InternetKontrolEt = new subp2.i_control();
        subp2.bag_class sinif_cek4 = new subp2.bag_class();
        private void button1_Click(object sender, EventArgs e)
        {
            if (yetki == 0) 
            {
                notifyIcon1.ShowBalloonTip(1, "Bilgi", "Kalan sürenizi buradan takip ediniz!", ToolTipIcon.Info);                
            }
            this.Hide();
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
        private void durum_paneli_Load(object sender, EventArgs e)
        {
            oturum_secenekleri.Start();
            MySqlConnection baglanti = new MySqlConnection(sinif_cek4.baglan());
            veritabani_baglanti_kontrol.Start();
            i_baglanti_kontrol.Start();
            try
            {
                MySqlCommand komut2 = new MySqlCommand();
                komut2.CommandText = "select * from uyeler where ogrenci_no=" + Convert.ToInt32(Giris.ogr_no_yolla) + "";
                komut2.Connection = baglanti;
                baglanti.Close();
                baglanti.Open();
                MySqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    ogr_adi.Text = dr2[1].ToString();
                    ogr_soyad.Text = dr2[2].ToString();
                    ogr_no.Text = dr2[0].ToString();
                    no = Convert.ToInt32(dr2[0]);
                    yetki = Convert.ToInt32(dr2[4]);

                }
                this.Left = (Screen.PrimaryScreen.WorkingArea.Size.Width - this.Width);
                this.Top = (Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height);
                progressBar1.Maximum = saat * 60 + dakika;
                sure_isle.Start();
                kalan_sure.Start();
                saat = Convert.ToInt32(sinif_cek.sd_cek(1, 2));
                dakika = Convert.ToInt32(sinif_cek.sd_cek(2, 2));
                label2.Text = saat + ":" + dakika;
                if (dakika < 0)
                {
                    dakika = 59;
                    saat -= 1;
                }
                if (dakika < 10)
                {
                    label2.Text = saat + ":" + "0" + dakika;
                }
            }
            catch
            { }
            if (yetki==1)
            {
                label2.Text = "Sınırsız";
                label2.Left -= 16;              
            }
            ogrenci_no_yolla = Convert.ToInt32(ogr_no.Text);
        }
        private void kalan_sure_Tick(object sender, EventArgs e)
        {
            if (yetki == 0)
            {
                if (saat == 0 && dakika == 0)
                {
                    durdur = 1;
                }
                if (durdur == 0)
                {
                    saniye_geri_sayim -= 1;
                    if (saniye_geri_sayim <= 0)
                    {
                        dakika -= 1;
                        if (progressBar1.Value < progressBar1.Maximum)
                        {
                            progressBar1.Value += 1;
                        }

                        saniye_geri_sayim = 60;
                        if (dakika < 0)
                        {
                            dakika = 59;
                            saat -= 1;
                        }
                        if (dakika < 10)
                        {
                            label2.Text = saat + ":" + "0" + dakika;
                        }
                        else
                        {
                            label2.Text = saat + ":" + dakika;
                        }
                    }
                }
                else
                {
                    label2.Text = "0:00";
                    kalan_sure.Stop();
                    System.Diagnostics.Process.Start("ShutDown", "/r -f -t 1");
                }
                if (saat == 0 && dakika == 5)
                {
                    if (mesajGoster == 0)
                    {
                        notifyIcon1.ShowBalloonTip(1, "Uyarı", "Süreniz doluyor bilgisayar 5 dakika içerisinde kapanacak", ToolTipIcon.Info);
                        mesajGoster = 1;
                    }
                }
                if (saat == 0 && dakika == 1 && saniye_geri_sayim <= 30)
                {
                    if (mesajGoster2 == 0)
                    {
                        notifyIcon1.ShowBalloonTip(1, "Uyarı", "Süreniz doluyor bilgisayar 30 saniye içerisinde kapanacak", ToolTipIcon.Info);
                        mesajGoster2 = 1;
                    }
                }
            }
            else
            {
                kalan_sure.Stop();
            }
        }
        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            if (yetki == 0)
            {
                if (dakika < 10)
                    notifyIcon1.Text = saat + ":" + "0" + dakika;
                else
                    notifyIcon1.Text = saat + ":" + dakika;
            }
            else
            {
                notifyIcon1.Text = "Admin";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://asp1.selcuk.edu.tr/asp/ogrstd/giris.asp");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.selcuk.edu.tr/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.chip.com.tr/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.webtekno.com/");
        }
        private void sure_isle_Tick(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(sinif_cek4.baglan());
            if (yetki == 0)
            {
                sure_isle_sayac--;
                if (sure_isle_sayac <= 0)
                {
                    try
                    {
                        sure_isle_sayac = 180;
                        MySqlCommand updatecom = new MySqlCommand("Update hesaplar  set kalan_sure = '" + label2.Text + "' where ogr_no =" + Convert.ToInt32(no) + "", baglanti);
                        baglanti.Close();
                        baglanti.Open();
                        updatecom.ExecuteNonQuery();
                        baglanti.Close();

                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                sure_isle.Stop();
            }
        }

        [DllImport("user32.dll")]
        public static extern void LockWorkStation();
        [DllImport("user32.dll")]
        public static extern int ExitWindowsEx(int uFlags, int dwReason);
        private void veritabani_baglanti_kontrol_Tick(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(sinif_cek4.baglan());
            if (yetki == 0)
            {
                veri_baglanti_kontrol += 1;
                if (veri_baglanti_kontrol >= 350)
                {
                    try
                    {
                        baglanti.Close();
                        baglanti.Open();
                    }
                    catch
                    {
                        if (oturum_kapat_geri_sayim >= 60)
                        {
                            System.Diagnostics.Process.Start("shutdown", "-l -f");
                        }
                        else
                        {
                            oturum_kapat_geri_sayim += 1;
                            if (bir_sefer_uyari_goster == 0)
                            {
                                notifyIcon1.ShowBalloonTip(1, "Uyarı!", "Sunucu bağlantısı koptu oturum 1 dakika sonra kapanacak!", ToolTipIcon.Info);
                                bir_sefer_uyari_goster = 1;
                            }
                        }
                    }
                    baglanti.Close();
                }
            }
            else
            {
                veritabani_baglanti_kontrol.Stop();
            }

        }
        private void i_baglanti_kontrol_Tick_1(object sender, EventArgs e)
        {
            if (yetki == 0)
            {
                i_baglanti_kontrol_anahtar += 1;
                if (i_baglanti_kontrol_anahtar >= 30)
                {
                    bool kontrol = InternetKontrolEt.InternetKontrol();
                    if (kontrol != true)
                    {
                        kalan_sure.Stop();
                        sure_isle.Stop();
                        if (bir_sefer_uyari_goster2 == 0)
                        {
                            notifyIcon1.ShowBalloonTip(1, "Uyarı!", "İnternet bağlantısı kesildi süreniz durduruldu.", ToolTipIcon.Info);
                            bir_sefer_uyari_goster2 = 1;
                        }
                    }
                    else
                    {
                        kalan_sure.Start();
                        sure_isle.Start();
                        bir_sefer_uyari_goster2 = 0;
                    }
                }
            }
            else
            {
                i_baglanti_kontrol.Stop();
            }
        }
        private void oturum_secenekleri_Tick(object sender, EventArgs e)
        {
            oturum_secenekleri_kontrol += 1;
            if (oturum_secenekleri_kontrol >= 350)
            {
                sinif_cek3.cek();
                oturum_secenekleri_kontrol = 0;
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifre_degistir frm = new sifre_degistir();
            frm.ShowDialog();
        }

    }
}
