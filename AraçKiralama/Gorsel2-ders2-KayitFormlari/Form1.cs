namespace Gorsel2_ders2_KayitFormlari
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frmMusteri = new frmMusteriEkle();
            frmMusteri.Show();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            frmAracEkle frmEkle = new frmAracEkle();
            frmEkle.Show();
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            frmAracKirala frmKirala = new frmAracKirala();
            frmKirala.Show();
        }
    }
}
