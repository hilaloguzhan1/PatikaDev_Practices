using System;

namespace While_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //n kadar girilen sayının(sayı dahil) ortalamasını hesaplayan kod
            // Console.WriteLine("Lütfen bir sayı giriniz");
            // int sayi=int.Parse(Console.ReadLine());
            // int sayac=1;
            // int toplam=0;
            // while (sayac<=sayi)
            // {
                
            //     toplam=toplam+sayac;
            //     sayac++;
            // }
            // Console.WriteLine(toplam/sayi);

            // char character='a';
            // while (character<='z')
            // {
            //     Console.WriteLine(character);
            //     character++;
            // }

            //Foreach
            string [] arabalar={"bmw","ford","toyota","nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }  
    }
}
