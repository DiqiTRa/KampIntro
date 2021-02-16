using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class SepetManager
    {
        //naming convention
        //syntax farklilik gosterir sadece
        public void Ekle(Product product)// Parantez goruyorsan orda bir metod calisiyor demek--parantez ici bosken
        {//Parantez ici ne ekleyecegimizi belirttigimiz parametre yeri--parantez ici bosken
            
            Console.WriteLine("Sepete Eklendi : " + product.Adi);
            Console.WriteLine("Sepet Fiyatı");
            Console.WriteLine(sepetFiyati);
        }
        public void Ekle2(string Adi, string Aciklama, double Fiyati)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi :" + Adi);
        }
    }
}
