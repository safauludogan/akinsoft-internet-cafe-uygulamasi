using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace subp2
{
    public partial class sifre_degistir : Form
    {
        public sifre_degistir()
        {
            InitializeComponent();
        }
        subp2.sifre_degistir_sinif sinif_cek = new subp2.sifre_degistir_sinif();
        int degisti;
        string mevcut_sifre;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sifre_degistir_Load(object sender, EventArgs e)
        {
            mevcutTxt.Focus();
            mevcut_sifre = Giris.sifre_gonder;
            ogr_noTxt.Enabled = false;
            ogr_noTxt.Text = durum_paneli.ogrenci_no_yolla.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            degisti = sinif_cek.degistir(mevcutTxt.Text, yeniTxt.Text, tekrarTxt.Text, Convert.ToInt32(ogr_noTxt.Text));
            if (degisti == 1) 
            {
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
