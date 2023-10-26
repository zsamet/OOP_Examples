using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Personel
    {
        public Personel(string gAd, string gAdres, int gYas, int gMesai, string gUnvan)
        {
            this.ad = gAd;
            this.adres = gAdres;
            this.yas = gYas;
            this.mesai = gMesai;
            this.unvan = gUnvan;
        }

        public int ucretHesapla()
        {
            return this.Mesai * 100;
        }

        string unvan;
        public string Unvan
        {
            get => unvan; set => unvan = value;
        }


        int mesai;
        public int Mesai
        {
            get => mesai; set => mesai = value; 
        }

        string ad;
        public string Ad 
        {
            get => ad; set => ad = value;
        }

        string adres;
        public string Adres 
        {
            get => adres; set => adres = value;
        }   

        int yas;
        public int Yas
        {
            get => yas; set => yas = value;
        }

        string eposta;
        public string Eposta 
        { 
            get => eposta; set => eposta = value; 
        }

        public void ucretHesapla(int ekUcret)
        {
            MessageBox.Show((this.Mesai * 100 + ekUcret).ToString());
        }
    }
}
