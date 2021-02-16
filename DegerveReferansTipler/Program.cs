using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);// sayi1 30 basar cunku sayi1'e sayi2'nin degerini atadin sadece degerle ilgilenir asagida tamamen referansiyla ilgilenir. Burada sadece degerle ilgilendiginden degeri atadiktan sonra sayi2 ile ne yaptigin onemli degildir
            Console.WriteLine(sayi2);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);//999 olur conku class array interfaceler referans tiptir ve artik sayilar 1 dizisi sayilar 2 dizisionin elemanllarini kendi elemani olarak gorur
            Console.WriteLine(sayilar1[1]);
            Console.WriteLine(sayilar1[2]);
        }
    }
}
