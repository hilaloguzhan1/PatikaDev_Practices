using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] renkler=new string[5];
            string [] hayvanlar={"kedi","köpek","at","tavşan"};
            int [] dizi;
            dizi=new int[5];
            //Dizlere değer atama ve erişim
            renkler[0]="mavi";
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(hayvanlar[1]);
            dizi[3]=10;
            Console.WriteLine(dizi[3]);

            //Döngülerde dizi kullanımı
            //klavyeden girilien n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz..");
            int diziUzunlugu=int.Parse(Console.ReadLine());
            int [] sayiDizisi =new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz=", i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());

            }
            int Toplam=0;
            foreach (var sayi in sayiDizisi)
            {
                
                Toplam+=sayi;
                Console.WriteLine("Ortalama="+Toplam/diziUzunlugu);

            }

            









        }
    }
}
