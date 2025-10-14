using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsel2_ilkproje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string kullaniciadi = "benimkullaniciadim";
        string sifre = "sifrem123degil";
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxKulAdi.Clear();
            mtbxSifre.Clear();
            tbxKulAdi.Focus();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (tbxKulAdi.Text == kullaniciadi&&mtbxSifre.Text == sifre)
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalıdır.");
            }
        }
    }
}
