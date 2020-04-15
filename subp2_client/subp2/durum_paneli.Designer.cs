namespace subp2
{
    partial class durum_paneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(durum_paneli));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kalan_sure = new System.Windows.Forms.Timer(this.components);
            this.ogr_no = new System.Windows.Forms.Label();
            this.ogr_soyad = new System.Windows.Forms.Label();
            this.ogr_adi = new System.Windows.Forms.Label();
            this.sadasdsadasdasd = new System.Windows.Forms.Label();
            this.asdasd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.sure_isle = new System.Windows.Forms.Timer(this.components);
            this.veritabani_baglanti_kontrol = new System.Windows.Forms.Timer(this.components);
            this.i_baglanti_kontrol = new System.Windows.Forms.Timer(this.components);
            this.oturum_secenekleri = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::subp2.Properties.Resources.exit_buton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(344, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 38);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kalan Süreniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "1:30";
            // 
            // kalan_sure
            // 
            this.kalan_sure.Interval = 1000;
            this.kalan_sure.Tick += new System.EventHandler(this.kalan_sure_Tick);
            // 
            // ogr_no
            // 
            this.ogr_no.AutoSize = true;
            this.ogr_no.BackColor = System.Drawing.Color.Transparent;
            this.ogr_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ogr_no.ForeColor = System.Drawing.Color.Yellow;
            this.ogr_no.Location = new System.Drawing.Point(114, 41);
            this.ogr_no.Name = "ogr_no";
            this.ogr_no.Size = new System.Drawing.Size(16, 20);
            this.ogr_no.TabIndex = 9;
            this.ogr_no.Text = "-";
            // 
            // ogr_soyad
            // 
            this.ogr_soyad.AutoSize = true;
            this.ogr_soyad.BackColor = System.Drawing.Color.Transparent;
            this.ogr_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ogr_soyad.ForeColor = System.Drawing.Color.Yellow;
            this.ogr_soyad.Location = new System.Drawing.Point(113, 115);
            this.ogr_soyad.Name = "ogr_soyad";
            this.ogr_soyad.Size = new System.Drawing.Size(16, 20);
            this.ogr_soyad.TabIndex = 8;
            this.ogr_soyad.Text = "-";
            // 
            // ogr_adi
            // 
            this.ogr_adi.AutoSize = true;
            this.ogr_adi.BackColor = System.Drawing.Color.Transparent;
            this.ogr_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ogr_adi.ForeColor = System.Drawing.Color.Yellow;
            this.ogr_adi.Location = new System.Drawing.Point(114, 77);
            this.ogr_adi.Name = "ogr_adi";
            this.ogr_adi.Size = new System.Drawing.Size(16, 20);
            this.ogr_adi.TabIndex = 7;
            this.ogr_adi.Text = "-";
            // 
            // sadasdsadasdasd
            // 
            this.sadasdsadasdasd.AutoSize = true;
            this.sadasdsadasdasd.BackColor = System.Drawing.Color.Transparent;
            this.sadasdsadasdasd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sadasdsadasdasd.ForeColor = System.Drawing.Color.White;
            this.sadasdsadasdasd.Location = new System.Drawing.Point(6, 39);
            this.sadasdsadasdasd.Name = "sadasdsadasdasd";
            this.sadasdsadasdasd.Size = new System.Drawing.Size(101, 20);
            this.sadasdsadasdasd.TabIndex = 6;
            this.sadasdsadasdasd.Text = "Numarası :";
            // 
            // asdasd
            // 
            this.asdasd.AutoSize = true;
            this.asdasd.BackColor = System.Drawing.Color.Transparent;
            this.asdasd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asdasd.ForeColor = System.Drawing.Color.White;
            this.asdasd.Location = new System.Drawing.Point(31, 115);
            this.asdasd.Name = "asdasd";
            this.asdasd.Size = new System.Drawing.Size(83, 20);
            this.asdasd.TabIndex = 5;
            this.asdasd.Text = "Soyadı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adı :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 620);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(355, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(6, 41);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Öğrenci Giriş";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.linkLabel5);
            this.groupBox1.Controls.Add(this.ogr_no);
            this.groupBox1.Controls.Add(this.sadasdsadasdasd);
            this.groupBox1.Controls.Add(this.ogr_soyad);
            this.groupBox1.Controls.Add(this.ogr_adi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.asdasd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox1.Location = new System.Drawing.Point(18, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 196);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.linkLabel5.ForeColor = System.Drawing.Color.Yellow;
            this.linkLabel5.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel5.Location = new System.Drawing.Point(11, 164);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(122, 20);
            this.linkLabel5.TabIndex = 10;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Şifre Değiştir";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.linkLabel4);
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox2.Location = new System.Drawing.Point(18, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 187);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linkler";
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.linkLabel4.ForeColor = System.Drawing.Color.Yellow;
            this.linkLabel4.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel4.Location = new System.Drawing.Point(6, 144);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(91, 20);
            this.linkLabel4.TabIndex = 13;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Webtekno";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.linkLabel3.ForeColor = System.Drawing.Color.Yellow;
            this.linkLabel3.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel3.Location = new System.Drawing.Point(6, 108);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(113, 20);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "CHIP Online";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.linkLabel2.ForeColor = System.Drawing.Color.Yellow;
            this.linkLabel2.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Location = new System.Drawing.Point(5, 75);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(171, 20);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Selçuk Üniversitesi";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // sure_isle
            // 
            this.sure_isle.Interval = 1000;
            this.sure_isle.Tick += new System.EventHandler(this.sure_isle_Tick);
            // 
            // veritabani_baglanti_kontrol
            // 
            this.veritabani_baglanti_kontrol.Interval = 10;
            this.veritabani_baglanti_kontrol.Tick += new System.EventHandler(this.veritabani_baglanti_kontrol_Tick);
            // 
            // i_baglanti_kontrol
            // 
            this.i_baglanti_kontrol.Interval = 1000;
            this.i_baglanti_kontrol.Tick += new System.EventHandler(this.i_baglanti_kontrol_Tick_1);
            // 
            // oturum_secenekleri
            // 
            this.oturum_secenekleri.Interval = 10;
            this.oturum_secenekleri.Tick += new System.EventHandler(this.oturum_secenekleri_Tick);
            // 
            // durum_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::subp2.Properties.Resources.durum_paneli;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 659);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "durum_paneli";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.durum_paneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer kalan_sure;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label sadasdsadasdasd;
        private System.Windows.Forms.Label asdasd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ogr_no;
        private System.Windows.Forms.Label ogr_soyad;
        private System.Windows.Forms.Label ogr_adi;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Timer sure_isle;
        private System.Windows.Forms.Timer veritabani_baglanti_kontrol;
        private System.Windows.Forms.Timer i_baglanti_kontrol;
        private System.Windows.Forms.Timer oturum_secenekleri;
        private System.Windows.Forms.LinkLabel linkLabel5;
    }
}