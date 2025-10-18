namespace Gorsel2_ders2_KayitFormlari
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMusteriEkle = new Button();
            btnAracEkle = new Button();
            btnAracKirala = new Button();
            SuspendLayout();
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.BackColor = Color.DarkSeaGreen;
            btnMusteriEkle.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnMusteriEkle.ForeColor = Color.MintCream;
            btnMusteriEkle.Location = new Point(169, 58);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(434, 101);
            btnMusteriEkle.TabIndex = 0;
            btnMusteriEkle.Text = "Müşteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = false;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // btnAracEkle
            // 
            btnAracEkle.BackColor = Color.DarkSeaGreen;
            btnAracEkle.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAracEkle.ForeColor = Color.MintCream;
            btnAracEkle.Location = new Point(169, 196);
            btnAracEkle.Name = "btnAracEkle";
            btnAracEkle.Size = new Size(434, 101);
            btnAracEkle.TabIndex = 1;
            btnAracEkle.Text = "Araç Ekle";
            btnAracEkle.UseVisualStyleBackColor = false;
            btnAracEkle.Click += btnAracEkle_Click;
            // 
            // btnAracKirala
            // 
            btnAracKirala.BackColor = Color.DarkSeaGreen;
            btnAracKirala.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAracKirala.ForeColor = Color.MintCream;
            btnAracKirala.Location = new Point(169, 332);
            btnAracKirala.Name = "btnAracKirala";
            btnAracKirala.Size = new Size(434, 101);
            btnAracKirala.TabIndex = 2;
            btnAracKirala.Text = "Araç Kirala";
            btnAracKirala.UseVisualStyleBackColor = false;
            btnAracKirala.Click += btnAracKirala_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(784, 561);
            Controls.Add(btnAracKirala);
            Controls.Add(btnAracEkle);
            Controls.Add(btnMusteriEkle);
            Name = "frmMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMusteriEkle;
        private Button btnAracEkle;
        private Button btnAracKirala;
    }
}
