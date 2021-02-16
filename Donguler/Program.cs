using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi

            string[] kurslar = new string[] {"Yazılım G.Y.K","P.B.i.T.K","Java","Python" };

            
            for (int i = 0; i < kurslar.Length; i++)//kurslar.Lenght kurslar kaç elemanlıysa o kadar sınır koy
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa Sonu - Footer");
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)//dizi temelli yapıları tek tek döner
            {//kursları dolaşır ve her bir elemanı kurs adı olarak tanımlar FOREACH DIZILERE UYGULANIR
                Console.WriteLine(kurs);
            }
        }
    }
}


