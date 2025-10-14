namespace görsel2_ilkproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            /*
            //kendi denemem(algoritma olmadan)
            long tc = Convert.ToInt64(tbxTc.Text);
            string kimlik = tbxTc.Text;
            if (kimlik.Length ==11 && 0 == tc % 2)
            {
                lblSonuc.Text = "Sonuç: Geçerli";
            }
            else
            {
                lblSonuc.Text = "Sonuç: Geçersiz.";
            }
            */

            
            string tc  = tbxTc.Text;
            lblSonuc.Text = tc;
            lbxSonuc.Items.Add(tc);
            int uzunluk = tc.Length;

            long part1 = Convert.ToInt64(tc[0]) + Convert.ToInt64(tc[2]) +
                        Convert.ToInt64(tc[4]) + Convert.ToInt64(tc[6]) +
                        Convert.ToInt64(tc[8])-240;

            long part2 = Convert.ToInt64(tc[1]) + Convert.ToInt64(tc[3]) +
                        Convert.ToInt64(tc[5]) + Convert.ToInt64(tc[7])-192;
            long hane10 = ((7 * part1) + (part2*9)) % 10;
            long hane11 = (part1 + part2 + hane10) % 10;
            
            if (tc[0] != '0'&& uzunluk == 11 && Convert.ToInt32(tc[9]-48)==hane10&& Convert.ToInt32(tc[10]-48)==hane11)
            {
                lblSonuc.Text += "Geçerli TC";
            }
            else
            {
                lblSonuc.Text += "Geçersiz TC";
            }
            
                lbxSonuc.Items.Add("Girilen TC uzunluğu: " + uzunluk.ToString());
            for (int i =0; i< uzunluk; i++)
            {
                lbxSonuc.Items.Add((i+1).ToString() + ": "+tc[i]);
            }
            
        }
    }
}
