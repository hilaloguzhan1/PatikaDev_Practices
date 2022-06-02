using System;

namespace Method_Overloding
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler

            string sayi = "999";
            int outSayi;
          bool sonuc=  int.TryParse(sayi, out outSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metodlar instance = new Metodlar();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Method Overloding-->Aşırı Yükleme

            int ifade = 888;
            instance.Ekranayazdir(Convert.ToString(ifade));
            instance.Ekranayazdir(ifade);
            instance.Ekranayazdir("Fikriye" + "Ürkmez");
            //Method İmzası
            //Method Adı + parametre sayısı + parametre
        }
    }

    class Metodlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void Ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void Ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void Ekranayazdir(string veri,string veri2)
        {
            Console.WriteLine(veri);

        }
        public void Ekranayazdir(int veri1,int veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
