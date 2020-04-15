using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace subp2_server
{
    public partial class sifre_guncelle : Form
    {
        subp2_server.bag_class Sinif_cek = new subp2_server.bag_class();        
        public sifre_guncelle()
        {
            InitializeComponent();
        }
           
        void ogrencileri_cek()
        {
            MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
            ogr_no.Enabled = false;           
            string komut = "select * from uyeler";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Öğrenci No";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }
        private void sifre_guncelle_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            ogrencileri_cek();
        }
        MySqlCommand cmd = new MySqlCommand();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
            string komut = "SELECT  * FROM uyeler where ad LIKE '%" + textBox1.Text.ToLower().Trim() + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string no, adi, soyadi;
            no = dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
            adi = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
            soyadi = dataGridView1.Rows[e.RowIndex].Cells[2].Value + "";
            ogr_no.Text = no;
            ad.Text = adi;
            soyad.Text = soyadi;
            sifre.Text = "";
            sifre_tekrar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ogr_no.Text.Length <= 1)
            {
                MessageBox.Show("Lütfen Öğrenci Seçiniz.");
            }
            else
            {
                try
                {
                    if (sifre.Text.Length < 3)
                    {
                        MessageBox.Show("Şifreniz en az 3 karakterden oluşmalıdır");
                    }
                    else
                    {
                        if (sifre.Text == sifre_tekrar.Text)
                        {
                            MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
                            string Query = "UPDATE uyeler SET sifre = '" + sifre.Text + "' WHERE ogrenci_no = " + ogr_no.Text + "";
                            MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                            MySqlDataReader MyReader2;
                            baglanti.Open();
                            MyReader2 = MyCommand2.ExecuteReader();
                            MessageBox.Show("Sifre Güncellendi");
                            sifre.Text = "";
                            ad.Text = "";
                            soyad.Text = "";
                            ogr_no.Text = "";
                            sifre_tekrar.Text = "";
                            baglanti.Clone();
                            ogrencileri_cek();
                            textBox1.Text = "";
                            textBox1.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Şifreler Uyuşmuyor!");
                        }
                    }
                }
                catch
                { MessageBox.Show("Hata!"); }
                finally
                {
                    MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
                    baglanti.Close();
                }
            }
        }

        private void sifre_guncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu frm = new menu();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ad.Text.Trim() == "" || soyad.Text.Trim() == "") 
            {
                MessageBox.Show("Lütfen ad ve soyad kısmını boş bırakmayınız");
            }
            else
            {
                try
                {
                    MySqlConnection baglanti = new MySqlConnection(Sinif_cek.baglan());
                    string Query = "UPDATE uyeler SET ad = '" + ad.Text + "',soyad='" + soyad.Text + "' WHERE ogrenci_no = " + ogr_no.Text + "";
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                    MySqlDataReader MyReader2;
                    baglanti.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    baglanti.Close();
                    MessageBox.Show("Bilgiler Güncellendi.");
                    sifre.Text = "";
                    ad.Text = "";
                    soyad.Text = "";
                    ogr_no.Text = "";
                    sifre_tekrar.Text = "";
                    baglanti.Clone();
                    ogrencileri_cek();
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                catch
                {
                    MessageBox.Show("Hata!");
                }
            }            
        }

    }
}
