using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel2_ders2_KayitFormlari
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = tbxAd.Text;
            string soyad = tbxSoyad.Text;
            string telefon = tbxTelefon.Text;
            string eposta = tbxPosta.Text;
            string adres = tbxAdres.Text;
            string tc = tbxTc.Text;
            MessageBox.Show(ad + "\n" + soyad + "\n" + telefon + "\n" + eposta + "\n" + adres + "\n" + tc);

        }

        private void tbxPosta_Click(object sender, EventArgs e)
        {
            if (tbxPosta.Text == "Mailinizi giriniz.")
            {
                tbxPosta.Text = "";
                tbxPosta.ForeColor = Color.Black;
            }
        }

    }
}
