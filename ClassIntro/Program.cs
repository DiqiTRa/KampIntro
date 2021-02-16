using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //BIR E TICARET SITESINDEKI HER BIR URUN ASLINDA BIR CLASSTIR
            string adi = "Merthan";
            int yasi = 21;
            Kurs kurs1 = new Kurs(); //Kurs bir veri tipi kendi veri tipimizi yazıyorum
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmen = "Merthan";
            kurs1.IzlenmeOrani = 75;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmen = "Ali";
            kurs2.IzlenmeOrani = 24;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmen = "Veli";
            kurs3.IzlenmeOrani = 76;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursEgitmen = "Berk";
            kurs4.IzlenmeOrani = 87;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursEgitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };//içinde Kurs classı olan bir kurs arrayi
            
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursEgitmen);
            }
        }
    }

    class Kurs//Kodlama io sitesinin ana sayfasında kurslar kutu kutu gözüküyor o kutunun birini yapıyoruz
    {
        public string KursAdi { get; set; } //prop yazıyoruz tab tab yapıyoruz-Proporties
        public string KursEgitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
