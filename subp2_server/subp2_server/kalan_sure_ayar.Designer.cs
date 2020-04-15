namespace subp2_server
{
    partial class kalan_sure_ayar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kalan_sure_ayar));
            this.saatTxt = new System.Windows.Forms.TextBox();
            this.dakikaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.s_azalt = new System.Windows.Forms.Button();
            this.s_arttir = new System.Windows.Forms.Button();
            this.d_azalt = new System.Windows.Forms.Button();
            this.d_arttir = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saatTxt
            // 
            this.saatTxt.Location = new System.Drawing.Point(79, 71);
            this.saatTxt.Name = "saatTxt";
            this.saatTxt.Size = new System.Drawing.Size(54, 22);
            this.saatTxt.TabIndex = 0;
            // 
            // dakikaTxt
            // 
            this.dakikaTxt.Location = new System.Drawing.Point(148, 71);
            this.dakikaTxt.Name = "dakikaTxt";
            this.dakikaTxt.Size = new System.Drawing.Size(54, 22);
            this.dakikaTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dakika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // s_azalt
            // 
            this.s_azalt.Location = new System.Drawing.Point(79, 99);
            this.s_azalt.Name = "s_azalt";
            this.s_azalt.Size = new System.Drawing.Size(24, 23);
            this.s_azalt.TabIndex = 5;
            this.s_azalt.Text = "<";
            this.s_azalt.UseVisualStyleBackColor = true;
            this.s_azalt.Click += new System.EventHandler(this.s_azalt_Click);
            // 
            // s_arttir
            // 
            this.s_arttir.Location = new System.Drawing.Point(109, 99);
            this.s_arttir.Name = "s_arttir";
            this.s_arttir.Size = new System.Drawing.Size(24, 23);
            this.s_arttir.TabIndex = 6;
            this.s_arttir.Text = ">";
            this.s_arttir.UseVisualStyleBackColor = true;
            this.s_arttir.Click += new System.EventHandler(this.s_arttir_Click);
            // 
            // d_azalt
            // 
            this.d_azalt.Location = new System.Drawing.Point(148, 99);
            this.d_azalt.Name = "d_azalt";
            this.d_azalt.Size = new System.Drawing.Size(24, 23);
            this.d_azalt.TabIndex = 7;
            this.d_azalt.Text = "<";
            this.d_azalt.UseVisualStyleBackColor = true;
            this.d_azalt.Click += new System.EventHandler(this.d_azalt_Click);
            // 
            // d_arttir
            // 
            this.d_arttir.Location = new System.Drawing.Point(178, 99);
            this.d_arttir.Name = "d_arttir";
            this.d_arttir.Size = new System.Drawing.Size(24, 23);
            this.d_arttir.TabIndex = 8;
            this.d_arttir.Text = ">";
            this.d_arttir.UseVisualStyleBackColor = true;
            this.d_arttir.Click += new System.EventHandler(this.d_arttir_Click);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.FloralWhite;
            this.guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guncelle.Location = new System.Drawing.Point(196, 153);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(93, 40);
            this.guncelle.TabIndex = 9;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // kalan_sure_ayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(295, 199);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.d_arttir);
            this.Controls.Add(this.d_azalt);
            this.Controls.Add(this.s_arttir);
            this.Controls.Add(this.s_azalt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dakikaTxt);
            this.Controls.Add(this.saatTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "kalan_sure_ayar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalan Süreyi Ayarla";
            this.Load += new System.EventHandler(this.kalan_sure_ayar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saatTxt;
        private System.Windows.Forms.TextBox dakikaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button s_azalt;
        private System.Windows.Forms.Button s_arttir;
        private System.Windows.Forms.Button d_azalt;
        private System.Windows.Forms.Button d_arttir;
        private System.Windows.Forms.Button guncelle;
    }
}