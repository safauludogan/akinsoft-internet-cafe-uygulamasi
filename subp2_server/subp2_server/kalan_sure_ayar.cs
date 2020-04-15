using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace subp2_server
{
    public partial class kalan_sure_ayar : Form
    {
        public kalan_sure_ayar()
        {
            InitializeComponent();
        }
        int saat_ayarla = 1;
        int dakika_ayarla;
        subp2_server.kalan_sure_duzenle sinif_cek = new subp2_server.kalan_sure_duzenle();
        private void kalan_sure_ayar_Load(object sender, EventArgs e)
        {
            saatTxt.Text = "1";
            dakikaTxt.Text = "00";
            saatTxt.Enabled = false;
            dakikaTxt.Enabled = false;
        }

        private void s_arttir_Click(object sender, EventArgs e)
        {
            if (saat_ayarla < 5)
            {
                saat_ayarla += 1;
                saatTxt.Text = saat_ayarla.ToString();
            }
        }

        private void s_azalt_Click(object sender, EventArgs e)
        {
            if (saat_ayarla > 1)
            {
                saat_ayarla -= 1;
                saatTxt.Text = saat_ayarla.ToString();
            }
        }

        private void d_azalt_Click(object sender, EventArgs e)
        {
            dakika_ayarla -= 10;
            if (dakika_ayarla < 0)
            {
                dakika_ayarla = 50;
            }
            dakikaTxt.Text = dakika_ayarla.ToString();
            if (dakika_ayarla == 0)
            {
                dakikaTxt.Text = "00";
            }
        }

        private void d_arttir_Click(object sender, EventArgs e)
        {
            dakika_ayarla += 10;
            if (dakika_ayarla > 50)
            {
                dakika_ayarla = 0;
            }
            dakikaTxt.Text = dakika_ayarla.ToString();
            if (dakika_ayarla == 0)
            {
                dakikaTxt.Text = "00";
            }
        }
        string zaman = "";
        private void guncelle_Click(object sender, EventArgs e)
        {
            zaman = saatTxt.Text.ToString() + ":" + dakikaTxt.Text.ToString();
            sinif_cek.duzenle(zaman);
            this.Hide();
        }

    }
}
