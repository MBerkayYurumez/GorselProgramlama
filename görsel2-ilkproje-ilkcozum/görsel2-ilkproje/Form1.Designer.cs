namespace görsel2_ilkproje
{
    partial class Form1
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
            btnKontrol = new Button();
            lblTc = new Label();
            lblSonuc = new Label();
            tbxTc = new TextBox();
            lbxSonuc = new ListBox();
            SuspendLayout();
            // 
            // btnKontrol
            // 
            btnKontrol.BackColor = SystemColors.ControlDarkDark;
            btnKontrol.Font = new Font("Segoe UI", 18F);
            btnKontrol.ForeColor = Color.Snow;
            btnKontrol.Location = new Point(359, 58);
            btnKontrol.Name = "btnKontrol";
            btnKontrol.Size = new Size(136, 48);
            btnKontrol.TabIndex = 0;
            btnKontrol.Text = "Kontrol Et";
            btnKontrol.UseVisualStyleBackColor = false;
            btnKontrol.Click += btnKontrol_Click;
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.BackColor = SystemColors.AppWorkspace;
            lblTc.Font = new Font("Segoe UI", 18F);
            lblTc.ForeColor = SystemColors.ButtonHighlight;
            lblTc.Location = new Point(12, 66);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(151, 32);
            lblTc.TabIndex = 1;
            lblTc.Text = "TC kimlik no:";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 18F);
            lblSonuc.ForeColor = SystemColors.ButtonHighlight;
            lblSonuc.Location = new Point(78, 118);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(85, 32);
            lblSonuc.TabIndex = 2;
            lblSonuc.Text = "Sonuç:";
            // 
            // tbxTc
            // 
            tbxTc.Font = new Font("Segoe UI", 18F);
            tbxTc.Location = new Point(169, 63);
            tbxTc.Name = "tbxTc";
            tbxTc.Size = new Size(184, 39);
            tbxTc.TabIndex = 3;
            // 
            // lbxSonuc
            // 
            lbxSonuc.FormattingEnabled = true;
            lbxSonuc.ItemHeight = 15;
            lbxSonuc.Location = new Point(12, 186);
            lbxSonuc.Name = "lbxSonuc";
            lbxSonuc.Size = new Size(404, 184);
            lbxSonuc.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(553, 453);
            Controls.Add(lbxSonuc);
            Controls.Add(tbxTc);
            Controls.Add(lblSonuc);
            Controls.Add(lblTc);
            Controls.Add(btnKontrol);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKontrol;
        private Label lblTc;
        private Label lblSonuc;
        private TextBox tbxTc;
        private ListBox lbxSonuc;
    }
}
