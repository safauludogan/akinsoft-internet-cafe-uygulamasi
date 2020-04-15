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
    public partial class giris : Form
    {
        public static int ogr;
        public giris()
        {
            InitializeComponent();
        }
        subp2_server.yetki_kontrol Sinif_cek = new subp2_server.yetki_kontrol();
        int yetki;
        private void button1_Click(object sender, EventArgs e)
        {
            yetki = Sinif_cek.kontrol_et(Convert.ToInt32(ogr_no.Text), sifre.Text);            
            if (yetki == 1) 
            {
                MessageBox.Show("Giriş başarılı");
                ogr = Convert.ToInt32(ogr_no.Text);
                menu frm = new menu();
                frm.Show();
                this.Hide();
            }
        }

        private void giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
