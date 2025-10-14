namespace görsel2_ilkproje
{
    partial class Form2
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
            btnGiris = new Button();
            btnTemizle = new Button();
            lblKulAdi = new Label();
            lblSifre = new Label();
            mtbxSifre = new MaskedTextBox();
            tbxKulAdi = new TextBox();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.LimeGreen;
            btnGiris.Location = new Point(144, 131);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(75, 48);
            btnGiris.TabIndex = 0;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Red;
            btnTemizle.Location = new Point(246, 131);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 48);
            btnTemizle.TabIndex = 1;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lblKulAdi
            // 
            lblKulAdi.AutoSize = true;
            lblKulAdi.Location = new Point(103, 37);
            lblKulAdi.Name = "lblKulAdi";
            lblKulAdi.Size = new Size(74, 15);
            lblKulAdi.TabIndex = 2;
            lblKulAdi.Text = "Kullanıcı adı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(144, 77);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre:";
            // 
            // mtbxSifre
            // 
            mtbxSifre.Location = new Point(190, 74);
            mtbxSifre.Name = "mtbxSifre";
            mtbxSifre.PasswordChar = '*';
            mtbxSifre.Size = new Size(100, 23);
            mtbxSifre.TabIndex = 4;
            // 
            // tbxKulAdi
            // 
            tbxKulAdi.Location = new Point(190, 34);
            tbxKulAdi.Name = "tbxKulAdi";
            tbxKulAdi.Size = new Size(100, 23);
            tbxKulAdi.TabIndex = 5;
            // 
            // Form2
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 222);
            Controls.Add(tbxKulAdi);
            Controls.Add(mtbxSifre);
            Controls.Add(lblSifre);
            Controls.Add(lblKulAdi);
            Controls.Add(btnTemizle);
            Controls.Add(btnGiris);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private Button btnTemizle;
        private Label lblKulAdi;
        private Label lblSifre;
        private MaskedTextBox mtbxSifre;
        private TextBox tbxKulAdi;
    }
}