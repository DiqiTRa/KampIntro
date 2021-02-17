using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEklendi(Musteri musteri)
        {
            Console.WriteLine("Müşteri listeye eklendi. Hoşgeldiniz Sayın "+ musteri.musteriAdi + " " + musteri.musteriSoyadi);
            Console.WriteLine("Müşteri numaranız : " + musteri.ID);
        }

        public void MusteriSilindi(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla silindi. Hoşçakal "+musteri.musteriAdi + " " + musteri.musteriSoyadi);
        }

        public void MusteriDegisti(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri başarıyla değiştirildi.");
            Console.WriteLine("Yeni bilgileriniz E-posta yoluyla iletilecektir. Sayın " + musteri.musteriAdi + " " + musteri.musteriSoyadi);
        }


    }
}
