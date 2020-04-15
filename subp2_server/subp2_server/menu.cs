using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;  
namespace subp2_server
{
    public partial class menu : Form
    {
        subp2_server.oturum_secenekleri Sinif_cek = new subp2_server.oturum_secenekleri();
        subp2_server.veri_kontrol Sinif_cek2 = new subp2_server.veri_kontrol();
        subp2_server.sureleri_yenile Sinif_cek3 = new subp2_server.sureleri_yenile();
        subp2_server.yetki_kontrol Sinif_cek4 = new subp2_server.yetki_kontrol();
        subp2_server.tarih_kontrol_et Sinif_cek5 = new subp2_server.tarih_kontrol_et();
        int o_k_s = 0, ogrenci_no, yetki;
        string kontrol = "";
        public menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kontrol = Microsoft.VisualBasic.Interaction.InputBox("Şifrenizi Giriniz", "Yetkili Girişi", "", 200, 200);
            yetki = Sinif_cek4.kontrol_et(Convert.ToInt32(giris.ogr), kontrol);
            if (yetki == 1)
            {
                MessageBox.Show("Giriş başarılı");
                sifre_guncelle frm = new sifre_guncelle();
                frm.Show();
                this.Hide();
            }            
        }
        private void bilgisayarlarıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontrol = Microsoft.VisualBasic.Interaction.InputBox("Şifrenizi Giriniz", "Yetkili Girişi", "", 200, 200);
            yetki = Sinif_cek4.kontrol_et(Convert.ToInt32(giris.ogr), kontrol);
            if (yetki == 1)
            {
                MessageBox.Show("Bilgisayarlar kapatıldı");
                Sinif_cek.cek(1, 0, 0);
                oturum_secenekleri_sifirla.Start();
                bilgisayarlarıYenidenBaşlatToolStripMenuItem.Enabled = false;
                bilgisayarlarıKapatToolStripMenuItem.Enabled = false;
                oturumlarıKapatToolStripMenuItem.Enabled = false;                
            }
        }
        private void menu_Load(object sender, EventArgs e)
        {
            tarih_kontrol.Start();
            ogrenci_no = giris.ogr;
            Sinif_cek.cek(0, 0, 0);
            Sinif_cek2.cek(1);
            Sinif_cek2.cek(2);
            Sinif_cek2.cek(3);
        }

        private void bilgisayarlarıYenidenBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontrol = Microsoft.VisualBasic.Interaction.InputBox("Şifrenizi Giriniz", "Yetkili Girişi", "", 200, 200);
            yetki = Sinif_cek4.kontrol_et(Convert.ToInt32(giris.ogr), kontrol);
            if (yetki == 1)
            {
                MessageBox.Show("Bilgisayarlar yeniden başlatıldı");
                Sinif_cek.cek(0, 1, 0);
                oturum_secenekleri_sifirla.Start();
                bilgisayarlarıYenidenBaşlatToolStripMenuItem.Enabled = false;
                bilgisayarlarıKapatToolStripMenuItem.Enabled = false;
                oturumlarıKapatToolStripMenuItem.Enabled = false;               
            }
        }

        private void oturumlarıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontrol = Microsoft.VisualBasic.Interaction.InputBox("Şifrenizi Giriniz", "Yetkili Girişi", "", 200, 200);
            yetki = Sinif_cek4.kontrol_et(Convert.ToInt32(giris.ogr), kontrol);
            if (yetki == 1)
            {
                MessageBox.Show("Oturumlar kapatıldı");
            Sinif_cek.cek(0, 0, 1);
            oturum_secenekleri_sifirla.Start();
            bilgisayarlarıYenidenBaşlatToolStripMenuItem.Enabled = false;
            bilgisayarlarıKapatToolStripMenuItem.Enabled = false;
            oturumlarıKapatToolStripMenuItem.Enabled = false;
                        }
        }
       
        private void oturum_secenekleri_sifirla_Tick(object sender, EventArgs e)
        {
            o_k_s += 1;
            if (o_k_s >= 30)
            {
                Sinif_cek.cek(0, 0, 0);
                o_k_s = 0;
                bilgisayarlarıYenidenBaşlatToolStripMenuItem.Enabled = true;
                bilgisayarlarıKapatToolStripMenuItem.Enabled = true;
                oturumlarıKapatToolStripMenuItem.Enabled = true;
                oturum_secenekleri_sifirla.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oturum seçenekleri için butona sağ tıklayın");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kontrol = Microsoft.VisualBasic.Interaction.InputBox("Şifrenizi Giriniz", "Yetkili Girişi", "", 200, 200);
            yetki = Sinif_cek4.kontrol_et(Convert.ToInt32(giris.ogr), kontrol);
            if (yetki == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Kabul ederseniz bütün süreler sıfırlanacak", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Sinif_cek3.guncelle();
                    menu frm = new menu();

                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kontrol = Microsoft.VisualBasic.Interaction.InputBox("Şifrenizi Giriniz", "Yetkili Girişi", "", 200, 200);
            yetki = Sinif_cek4.kontrol_et(Convert.ToInt32(giris.ogr), kontrol);
            if (yetki == 1)
            {
                MessageBox.Show("Giriş Başarılı");
                kalan_sure_ayar frm = new kalan_sure_ayar();
                frm.ShowDialog();
            }
        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            giris frm = new giris();
            frm.Show();
            this.Hide();
        }

        private void tarih_kontrol_Tick(object sender, EventArgs e)
        {
            Sinif_cek5.kontrol();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt ekleme ve düzenlemek için sağ tıklayın.");
        }

        private void kayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontrol = Microsoft.VisualBasic.Interaction.InputBox("Şifrenizi Giriniz", "Yetkili Girişi", "", 200, 200);
            yetki = Sinif_cek4.kontrol_et(Convert.ToInt32(giris.ogr), kontrol);
            if (yetki == 1)
            {
                kayit_ekle frm = new kayit_ekle();
                frm.Show();
                this.Hide();
            }
        }
    }
}
