using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.Win32;
namespace subp2
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        public static int kapan = 0, ustte_tut = 0, form_kapandi = 0, ogr_no_yolla = 0, tuslari_serbest_birak = 0;
        public static string sifre_gonder;
        string ogrenciNo_Kontrol = "", sifre_kontrol = "";
        int b_durumu, saat = 0, dakika = 0, oturum_secenekleri_kontrol;
        subp2.giris_kontrolu sinif_cek2 = new subp2.giris_kontrolu();
        subp2.saat_dakika_cek sinif_cek = new subp2.saat_dakika_cek();
        subp2.oturum_secenekleri_kontrol sinif_cek4 = new subp2.oturum_secenekleri_kontrol();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            button1.Enabled = false;
            buton_durumu.Start();
            if (textBox2.Text == "kodlayan")
            {
                formu_onde_tut.Stop();
                MessageBox.Show("Bu bu program bilgisayar 2.Sınıf Öğrencisi Safa Uludoğan tarafından kodlanmıştır :)");
                formu_onde_tut.Start();
            }
            if (textBox2.Text=="ideapad510")
            {
                Application.Exit();
            }
            if (textBox2.Text=="altintepesafiye")
            {
                MessageBox.Show("Seni Çok Seviyorum Safiye :) \n Safa :D");
            }
            else
            {
                if (textBox1.Text.Trim() == "" || textBox2.Text == ""||textBox1.Text.Length<9)
                {
                    formu_onde_tut.Stop();
                    MessageBox.Show("Lütfen öğrenci numaranızı ve şifrenizi doğru girdiğinizden emin olunuz!");
                    formu_onde_tut.Start();
                }
                else
                {
                    try
                    {
                        sinif_cek2.getir(Convert.ToInt32(textBox1.Text));//kullanıcı bilgilerini çek
                        ogrenciNo_Kontrol = (sinif_cek2.giris(1)).ToString();//kullanıcı bilgilerini çek
                        sifre_kontrol = (sinif_cek2.giris(2)).ToString();//kullanıcı bilgilerini çek                       
                        if (ogrenciNo_Kontrol == textBox1.Text && sifre_kontrol == textBox2.Text)
                        {
                            sinif_cek.getir(Convert.ToInt32(textBox1.Text));//zaman kontrol sınıfı
                            saat = Convert.ToInt32(sinif_cek.sd_cek(1, 1));//zaman kontrol sınıfı
                            dakika = Convert.ToInt32(sinif_cek.sd_cek(2, 1));//zaman kontrol sınıfı
                            if (saat == 0 && dakika <= 2)
                            {
                                formu_onde_tut.Stop();
                                MessageBox.Show("Bugünlük kullanım hakkınızı doldurunuz!");
                                formu_onde_tut.Start();
                            }
                            else
                            {
                                formu_onde_tut.Stop();
                                sifre_gonder = textBox2.Text;
                                if (textBox2.Text == "a123456") 
                                {
                                    MessageBox.Show("Sistemin verdiği şifreyi kullanıyorsunuz, değiştirmeniz önerilir. Durum panelinden şifre değiştir linkine tıklayarak şifrenizi değiştirebilirsiniz.");
                                }
                                MessageBox.Show("Giriş Başarılı");
                                tuslari_serbest_birak = 1;
                                ogr_no_yolla = Convert.ToInt32(ogrenciNo_Kontrol);
                                kapan = 1;
                                durum_paneli frm = new durum_paneli();
                                frm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            formu_onde_tut.Stop();
                            MessageBox.Show("Öğrenci Bulunamadı öğrenci numaranızı ve şifrenizi kontrol ediniz");
                            formu_onde_tut.Start();
                        }
                    }
                    catch
                    {
                        formu_onde_tut.Stop();
                        MessageBox.Show("Sunucu bağlantısı yapılamadı. Lütfen sunucu bilgisayarını kontrol ediniz");
                        formu_onde_tut.Start();
                    }
                }
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            oturum_secenekleri.Start();
            formu_onde_tut.Start();
            this.TopMost = true;
        }
        private void formu_onde_tut_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ustte_tut = 1;
            form_kapandi = 1;
            this.Hide();
            formu_onde_tut.Stop();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void oturum_secenekleri_Tick(object sender, EventArgs e)
        {
            oturum_secenekleri_kontrol += 1;
            if (oturum_secenekleri_kontrol >= 5)
            {
                sinif_cek4.cek();
                oturum_secenekleri_kontrol = 0;
            }
        }

        private void buton_durumu_Tick(object sender, EventArgs e)
        {
            b_durumu += 1;
            if (b_durumu >= 3) 
            {                
                button1.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

