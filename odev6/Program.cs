using System;

namespace odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Products urun1 = new Products();
            urun1.UrunAdi = "iPhone 12";
            urun1.UrunTuru = "Telefon";
            urun1.UrunFiyati = 14500;

            Products urun2 = new Products();
            urun2.UrunAdi = "Macbook Air";
            urun2.UrunTuru = "Dizüstü Bilgisayar";
            urun2.UrunFiyati = 12000;

            Products urun3 = new Products();
            urun3.UrunAdi = "Mac Mini";
            urun3.UrunTuru = "Bilgisayar";
            urun3.UrunFiyati = 8000;

            Products urun4 = new Products();
            urun4.UrunAdi = "iPad Pro";
            urun4.UrunTuru = "Tablet";
            urun4.UrunFiyati = 9000;

            Products[] products = new Products[] { urun1, urun2, urun3, urun4 };

            foreach (var product in products)
            {
                Console.WriteLine("Ürün Adi :" + product.UrunAdi);
                Console.WriteLine("Ürün Türü :" + product.UrunTuru);
                Console.WriteLine("Ürün Fiyatı :" + product.UrunFiyati);
            }
            Console.WriteLine("------------------------------------------------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Adi :" + products[i].UrunAdi);
                Console.WriteLine("Ürün Türü :" + products[i].UrunTuru);
                Console.WriteLine("Ürün Fiyatı :" + products[i].UrunFiyati);
            }
            Console.WriteLine("------------------------------------------------------------");
            int x = 0;
            while( x < products.Length)
            {
                Console.WriteLine("Ürün Adi :" + products[x].UrunAdi);
                Console.WriteLine("Ürün Türü :" + products[x].UrunTuru);
                Console.WriteLine("Ürün Fiyatı :" + products[x].UrunFiyati);
                x++;
            }    
        }
    }
    class Products 
    { 
        public string UrunAdi { get; set; }
        public string UrunTuru { get; set; }
        public int UrunFiyati { get; set; }
    }
}
