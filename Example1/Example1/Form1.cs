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
            // Form �zerindeki girdileri al�n
            string ad = adtxt.Text;
            string adres = adrestxt.Text;
            int yas = Convert.ToInt32(yastxt.Text);
            int mesai = Convert.ToInt32(mesaitxt.Text);
            string unvan = unvantxt.Text;

            // Personel nesnesini olu�turun
            Personel pers = new Personel(ad, adres, yas, mesai, unvan);

            // MessageBox ile t�m bilgileri g�sterin
            string message = "Ad = " + ad + "\nAdres = " + adres + "\nYa� = " + yas + "\nMesai �creti = " + pers.ucretHesapla().ToString();

            // ComboBox'tan se�ilen de�ere ba�l� olarak ek mesai �creti hesaplay�n
            if (comboBox1.Text == "Analist")
            {
                message += "\nEk Mesai �creti = " + pers.ucretHesapla().ToString();
            }
            else
            {
                int ekUcret = 1000; // Varsay�lan ek mesai �creti
                pers.ucretHesapla(ekUcret);
                message += "\nEk Mesai �creti = " + (pers.ucretHesapla() + ekUcret).ToString();
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

        private void �nvan_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}