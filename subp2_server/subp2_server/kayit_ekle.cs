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
    public partial class kayit_ekle : Form
    {
        public kayit_ekle()
        {
            InitializeComponent();
        }
        subp2_server.kayit_ekle_sinif sinif_cek2 = new subp2_server.kayit_ekle_sinif();
        int y_ac;
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();
            textBox3.Text = textBox3.Text.Trim();
            if (textBox1.Text.Length == 9) 
            {
                if (textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "") 
                {
                    MessageBox.Show("Lütfen isim ve soyisim giriniz");
                }
                else
                {
                    y_ac = sinif_cek2.ekle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text);
                    if (y_ac == 1)
                    {
                        kayit_ekle frm = new kayit_ekle();
                        frm.Show();
                        this.Hide();
                    }
                }                
            }
            else
            {
                MessageBox.Show("Lütfen öğrenci numarasını eksiksiz giriniz.");
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kayit_ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu frm = new menu();
            frm.Show();
            this.Hide();
        }

    }
}
