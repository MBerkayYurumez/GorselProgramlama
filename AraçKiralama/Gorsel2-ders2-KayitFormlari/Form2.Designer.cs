namespace Gorsel2_ders2_KayitFormlari
{
    partial class frmMusteriEkle
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblTelefon = new Label();
            lblEposta = new Label();
            lblAdres = new Label();
            tbxAd = new TextBox();
            tbxSoyad = new TextBox();
            tbxTelefon = new TextBox();
            tbxPosta = new TextBox();
            tbxAdres = new TextBox();
            tbxTc = new TextBox();
            lblTc = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 16F);
            lblAd.Location = new Point(175, 27);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(51, 30);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 16F);
            lblSoyad.Location = new Point(142, 62);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(84, 30);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad :";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 16F);
            lblTelefon.Location = new Point(131, 97);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(95, 30);
            lblTelefon.TabIndex = 2;
            lblTelefon.Text = "Telefon :";
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI", 16F);
            lblEposta.Location = new Point(129, 132);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(97, 30);
            lblEposta.TabIndex = 3;
            lblEposta.Text = "E-posta :";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Segoe UI", 16F);
            lblAdres.Location = new Point(146, 206);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(80, 30);
            lblAdres.TabIndex = 4;
            lblAdres.Text = "Adres :";
            // 
            // tbxAd
            // 
            tbxAd.Font = new Font("Segoe UI", 12F);
            tbxAd.Location = new Point(232, 31);
            tbxAd.Name = "tbxAd";
            tbxAd.Size = new Size(278, 29);
            tbxAd.TabIndex = 5;
            // 
            // tbxSoyad
            // 
            tbxSoyad.Font = new Font("Segoe UI", 12F);
            tbxSoyad.Location = new Point(232, 66);
            tbxSoyad.Name = "tbxSoyad";
            tbxSoyad.Size = new Size(278, 29);
            tbxSoyad.TabIndex = 6;
            // 
            // tbxTelefon
            // 
            tbxTelefon.Font = new Font("Segoe UI", 12F);
            tbxTelefon.Location = new Point(232, 101);
            tbxTelefon.Name = "tbxTelefon";
            tbxTelefon.PlaceholderText = "(___) ___ ____";
            tbxTelefon.Size = new Size(278, 29);
            tbxTelefon.TabIndex = 7;
            // 
            // tbxPosta
            // 
            tbxPosta.Font = new Font("Segoe UI", 12F);
            tbxPosta.ForeColor = SystemColors.ScrollBar;
            tbxPosta.Location = new Point(232, 136);
            tbxPosta.Name = "tbxPosta";
            tbxPosta.Size = new Size(278, 29);
            tbxPosta.TabIndex = 8;
            tbxPosta.Text = "Mailinizi giriniz.";
            tbxPosta.Click += tbxPosta_Click;
            // 
            // tbxAdres
            // 
            tbxAdres.Font = new Font("Segoe UI", 12F);
            tbxAdres.Location = new Point(232, 206);
            tbxAdres.Multiline = true;
            tbxAdres.Name = "tbxAdres";
            tbxAdres.Size = new Size(278, 103);
            tbxAdres.TabIndex = 9;
            // 
            // tbxTc
            // 
            tbxTc.Font = new Font("Segoe UI", 12F);
            tbxTc.Location = new Point(232, 171);
            tbxTc.Name = "tbxTc";
            tbxTc.Size = new Size(278, 29);
            tbxTc.TabIndex = 10;
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Segoe UI", 16F);
            lblTc.Location = new Point(84, 167);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(142, 30);
            lblTc.TabIndex = 11;
            lblTc.Text = "TC kimlik no :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(232, 332);
            button1.Name = "button1";
            button1.Size = new Size(174, 43);
            button1.TabIndex = 12;
            button1.Text = "Müşteri Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMusteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(784, 561);
            Controls.Add(button1);
            Controls.Add(lblTc);
            Controls.Add(tbxTc);
            Controls.Add(tbxAdres);
            Controls.Add(tbxPosta);
            Controls.Add(tbxTelefon);
            Controls.Add(tbxSoyad);
            Controls.Add(tbxAd);
            Controls.Add(lblAdres);
            Controls.Add(lblEposta);
            Controls.Add(lblTelefon);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "frmMusteriEkle";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblTelefon;
        private Label lblEposta;
        private Label lblAdres;
        private TextBox tbxAd;
        private TextBox tbxSoyad;
        private TextBox tbxTelefon;
        private TextBox tbxPosta;
        private TextBox tbxAdres;
        private TextBox tbxTc;
        private Label lblTc;
        private Button button1;
    }
}