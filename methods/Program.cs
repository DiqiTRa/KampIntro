using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasaya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 50;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {urun1, urun2 };

            //type safe - tip guvenli ben calisacagim veri tipini bilmek isterim
            //yani bir veriyi yazarken tipiyle yazmani ister 
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("----------------------------");
            }

            Console.WriteLine("----------Metodlar----------");//fonksiyon = metod
            //cw + tab + tab hizli Console.WriteLine yazmak
            //instance - class ornegi olusturma
            //metod bize reusablity verir tekrar tekrar kullanilabilirlik getirir
            //encapsulation-sonradan stok adedi eklemek istendiginde sadece Product kismina prop ile stok adedi ekledik ve hata almadik ama asagida yaptigimiz gibi yaparsak eger tum satirlar uymadigi icin veri eksik oldugu icin hata verecekti
            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);//Metodu cagirma .Ekle ile sepet adi verdigimiz SepetManager cagirdik
            sepet.Ekle(urun2);

            //boyle yapilmamali-asagisiyapilmamali-stok adedi eklendigi zaman asagisi hata verir veri eksikligindan
            sepet.Ekle2("Armut", "Yeşil Armut", 12);
            sepet.Ekle2("Elma", "Yeşil Elma", 8);
            sepet.Ekle2("Karpuz", "Diyarbakir Karpuzu", 30);


        }
    }
}
//Dont repeat yourself - DRY - Clean Code - Best Practise