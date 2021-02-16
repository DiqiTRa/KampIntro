using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip guvenligi- string bir bir veri tanimlamak istiyorsan onun veri tipini onune yazmak zorundasin
            // Dont repeat yourself-kendini tekrar etme-bu yuzden degiskenler onemli
            //kategoriEtiketi deger tutucudur - etiket - alias
            string kategoriEtiketi = "Kategori";
            Console.WriteLine("Kategori1");
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true; //sistemi dallandirma
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici Ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }
            

            Console.WriteLine(ogrenciSayisi);
        }
    }
}
