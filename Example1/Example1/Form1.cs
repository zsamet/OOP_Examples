namespace Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            // Form üzerindeki girdileri alýn
            string ad = adtxt.Text;
            string adres = adrestxt.Text;
            int yas = Convert.ToInt32(yastxt.Text);
            int mesai = Convert.ToInt32(mesaitxt.Text);
            string unvan = unvantxt.Text;

            // Personel nesnesini oluþturun
            Personel pers = new Personel(ad, adres, yas, mesai, unvan);

            // MessageBox ile tüm bilgileri gösterin
            string message = "Ad = " + ad + "\nAdres = " + adres + "\nYaþ = " + yas + "\nMesai Ücreti = " + pers.ucretHesapla().ToString();

            // ComboBox'tan seçilen deðere baðlý olarak ek mesai ücreti hesaplayýn
            if (comboBox1.Text == "Analist")
            {
                message += "\nEk Mesai Ücreti = " + pers.ucretHesapla().ToString();
            }
            else
            {
                int ekUcret = 1000; // Varsayýlan ek mesai ücreti
                pers.ucretHesapla(ekUcret);
                message += "\nEk Mesai Ücreti = " + (pers.ucretHesapla() + ekUcret).ToString();
            }

            MessageBox.Show(message);
        }






        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Ünvan_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}