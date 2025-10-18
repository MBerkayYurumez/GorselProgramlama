namespace Gorsel2_ders2_KayitFormlari
{
    partial class frmAracEkle
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
            button1 = new Button();
            tbxMarka = new TextBox();
            tbxYili = new TextBox();
            lblMarka = new Label();
            tbxModel = new TextBox();
            lblYili = new Label();
            lblModel = new Label();
            lblPlaka = new Label();
            tbxPlaka = new TextBox();
            lblRenk = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(232, 216);
            button1.Name = "button1";
            button1.Size = new Size(174, 40);
            button1.TabIndex = 0;
            button1.Text = "Araç Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbxMarka
            // 
            tbxMarka.Font = new Font("Segoe UI", 12F);
            tbxMarka.Location = new Point(232, 29);
            tbxMarka.Name = "tbxMarka";
            tbxMarka.Size = new Size(174, 29);
            tbxMarka.TabIndex = 1;
            // 
            // tbxYili
            // 
            tbxYili.Font = new Font("Segoe UI", 12F);
            tbxYili.Location = new Point(232, 64);
            tbxYili.Name = "tbxYili";
            tbxYili.Size = new Size(174, 29);
            tbxYili.TabIndex = 2;
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Font = new Font("Segoe UI", 16F);
            lblMarka.Location = new Point(78, 25);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(148, 30);
            lblMarka.TabIndex = 3;
            lblMarka.Text = "Araç Markası :";
            // 
            // tbxModel
            // 
            tbxModel.Font = new Font("Segoe UI", 12F);
            tbxModel.Location = new Point(232, 99);
            tbxModel.Name = "tbxModel";
            tbxModel.Size = new Size(174, 29);
            tbxModel.TabIndex = 4;
            // 
            // lblYili
            // 
            lblYili.AutoSize = true;
            lblYili.Font = new Font("Segoe UI", 16F);
            lblYili.Location = new Point(132, 60);
            lblYili.Name = "lblYili";
            lblYili.Size = new Size(94, 30);
            lblYili.TabIndex = 5;
            lblYili.Text = "Araç Yılı:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 16F);
            lblModel.Location = new Point(139, 95);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(87, 30);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model :";
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Font = new Font("Segoe UI", 16F);
            lblPlaka.Location = new Point(152, 130);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(74, 30);
            lblPlaka.TabIndex = 7;
            lblPlaka.Text = "Plaka :";
            // 
            // tbxPlaka
            // 
            tbxPlaka.Font = new Font("Segoe UI", 12F);
            tbxPlaka.Location = new Point(232, 134);
            tbxPlaka.Name = "tbxPlaka";
            tbxPlaka.Size = new Size(174, 29);
            tbxPlaka.TabIndex = 8;
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Font = new Font("Segoe UI", 16F);
            lblRenk.Location = new Point(155, 165);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(71, 30);
            lblRenk.TabIndex = 9;
            lblRenk.Text = "Renk :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(232, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 29);
            textBox1.TabIndex = 10;
            // 
            // frmAracEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(784, 561);
            Controls.Add(textBox1);
            Controls.Add(lblRenk);
            Controls.Add(tbxPlaka);
            Controls.Add(lblPlaka);
            Controls.Add(lblModel);
            Controls.Add(lblYili);
            Controls.Add(tbxModel);
            Controls.Add(lblMarka);
            Controls.Add(tbxYili);
            Controls.Add(tbxMarka);
            Controls.Add(button1);
            Name = "frmAracEkle";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbxMarka;
        private TextBox tbxYili;
        private Label lblMarka;
        private TextBox tbxModel;
        private Label lblYili;
        private Label lblModel;
        private Label lblPlaka;
        private TextBox tbxPlaka;
        private Label lblRenk;
        private TextBox textBox1;
    }
}