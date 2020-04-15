namespace subp2_server
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.oturum_secenekleri_sifirla = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tarih_kontrol = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kayıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bilgisayarlarıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgisayarlarıYenidenBaşlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oturumlarıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(209, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifre Değiştir";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgisayarlarıKapatToolStripMenuItem,
            this.bilgisayarlarıYenidenBaşlatToolStripMenuItem,
            this.oturumlarıKapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(264, 76);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(372, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oturum Seçenekleri";
            // 
            // oturum_secenekleri_sifirla
            // 
            this.oturum_secenekleri_sifirla.Interval = 1000;
            this.oturum_secenekleri_sifirla.Tick += new System.EventHandler(this.oturum_secenekleri_sifirla_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(582, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Süreleri Yenile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(760, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kalan Süreyi Ayarla";
            // 
            // tarih_kontrol
            // 
            this.tarih_kontrol.Interval = 10000;
            this.tarih_kontrol.Tick += new System.EventHandler(this.tarih_kontrol_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(26, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Öğrenci Ekle";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtEkleToolStripMenuItem,
            this.kayıtDüzenleToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(170, 52);
            // 
            // kayıtEkleToolStripMenuItem
            // 
            this.kayıtEkleToolStripMenuItem.Image = global::subp2_server.Properties.Resources.ekle;
            this.kayıtEkleToolStripMenuItem.Name = "kayıtEkleToolStripMenuItem";
            this.kayıtEkleToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.kayıtEkleToolStripMenuItem.Text = "Kayıt Ekle";
            this.kayıtEkleToolStripMenuItem.Click += new System.EventHandler(this.kayıtEkleToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::subp2_server.Properties.Resources.kayit_ekle;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.ContextMenuStrip = this.contextMenuStrip2;
            this.button5.Location = new System.Drawing.Point(38, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 90);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::subp2_server.Properties.Resources.kalan_sure;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(793, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 90);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::subp2_server.Properties.Resources.yenile;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(598, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 90);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::subp2_server.Properties.Resources.windows;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(413, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 90);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::subp2_server.Properties.Resources.change;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(223, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 90);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bilgisayarlarıKapatToolStripMenuItem
            // 
            this.bilgisayarlarıKapatToolStripMenuItem.Image = global::subp2_server.Properties.Resources.close;
            this.bilgisayarlarıKapatToolStripMenuItem.Name = "bilgisayarlarıKapatToolStripMenuItem";
            this.bilgisayarlarıKapatToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.bilgisayarlarıKapatToolStripMenuItem.Text = "Bilgisayarları Kapat";
            this.bilgisayarlarıKapatToolStripMenuItem.Click += new System.EventHandler(this.bilgisayarlarıKapatToolStripMenuItem_Click);
            // 
            // bilgisayarlarıYenidenBaşlatToolStripMenuItem
            // 
            this.bilgisayarlarıYenidenBaşlatToolStripMenuItem.Image = global::subp2_server.Properties.Resources.restart;
            this.bilgisayarlarıYenidenBaşlatToolStripMenuItem.Name = "bilgisayarlarıYenidenBaşlatToolStripMenuItem";
            this.bilgisayarlarıYenidenBaşlatToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.bilgisayarlarıYenidenBaşlatToolStripMenuItem.Text = "Bilgisayarları Yeniden Başlat";
            this.bilgisayarlarıYenidenBaşlatToolStripMenuItem.Click += new System.EventHandler(this.bilgisayarlarıYenidenBaşlatToolStripMenuItem_Click);
            // 
            // oturumlarıKapatToolStripMenuItem
            // 
            this.oturumlarıKapatToolStripMenuItem.Image = global::subp2_server.Properties.Resources.oturum_close;
            this.oturumlarıKapatToolStripMenuItem.Name = "oturumlarıKapatToolStripMenuItem";
            this.oturumlarıKapatToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.oturumlarıKapatToolStripMenuItem.Text = "Oturumları Kapat";
            this.oturumlarıKapatToolStripMenuItem.Click += new System.EventHandler(this.oturumlarıKapatToolStripMenuItem_Click);
            // 
            // kayıtDüzenleToolStripMenuItem
            // 
            this.kayıtDüzenleToolStripMenuItem.Image = global::subp2_server.Properties.Resources.guncelle;
            this.kayıtDüzenleToolStripMenuItem.Name = "kayıtDüzenleToolStripMenuItem";
            this.kayıtDüzenleToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.kayıtDüzenleToolStripMenuItem.Text = "Kayıt Düzenle";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(951, 156);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menu_FormClosed);
            this.Load += new System.EventHandler(this.menu_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bilgisayarlarıKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgisayarlarıYenidenBaşlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oturumlarıKapatToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer oturum_secenekleri_sifirla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tarih_kontrol;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem kayıtEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtDüzenleToolStripMenuItem;
    }
}

