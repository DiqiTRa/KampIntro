using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriAdi = "Mustafa";
            musteri1.musteriSoyadi = "Kemal";
            musteri1.kimlikno = "18811938191";
            musteri1.ID = 19051919;

            Musteri musteri2 = new Musteri();
            musteri2.musteriAdi = "Kazım";
            musteri2.musteriSoyadi = "Karabekir";
            musteri2.kimlikno = "23071882191";
            musteri2.ID = 23071882;

            Musteri musteri3 = new Musteri();
            musteri3.musteriAdi = "Winston";
            musteri3.musteriSoyadi = "Churhill";
            musteri3.kimlikno = "30111874000";
            musteri3.ID = 30111874;

            Musteri[] musteriler = { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı : " + musteri.musteriAdi);
                Console.WriteLine("Müşteri Soyadı : " + musteri.musteriSoyadi);
                Console.WriteLine("Kimlik Numarası : " + musteri.kimlikno);
                Console.WriteLine("Müşteri Numarası : " + musteri.ID);
                Console.WriteLine("--------------------------------------------------");
            }


            MusteriManager list = new MusteriManager();
            list.MusteriEklendi(musteri1);
            Console.WriteLine("--------------------------------------------------");
            list.MusteriDegisti(musteri2);
            Console.WriteLine("--------------------------------------------------");
            list.MusteriSilindi(musteri3);

        }
    }
}
