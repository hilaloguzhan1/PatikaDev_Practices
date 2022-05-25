using System;

namespace Method
{
    class Program
    {
        //Methodun class içinde yazılması lazım
        //tek başlarına yazılabilen yapılan değiller
        //Aynı mevcut çalıştığınız classdan erişecekseniz direk method adıyla erişim sağlanabilir
        //Ama başaka bir classtan methoda erişim sağlamak istiyorsak bir erişim sağlamak instınsını yaratmak(örneğini) gerekir.


        static void Main(string[] args)
        {
            //erisimBelirteci_geriDonusTipi_methodAdi(parametreListesi/arguman)
            //  {
                      //komutlar
            //  }

            int a=2;
            int b=3;
            int Toplam=a+b;
            //Console.WriteLine(Toplam);
            int sonuc=Topla(a,b);
             Console.WriteLine(Toplam);
             Methodlar ornek = new Methodlar();
             ornek.EkraYazdir(Convert.ToString(sonuc));
             
             int sonuc2=ornek.ArttırveTopla(a,b);


            static int Topla(int deger1, int deger2)
            {
                return (deger1+deger2);
            }

        
        }
        
    }
    class Methodlar
            {
                public void EkraYazdir(string veri)
                {
                    Console.WriteLine(veri);
                }

                public int ArttırveTopla(int deger1, int deger2)
                {
                    deger1+=1;
                    deger2+=1;
                    int topla=deger1+deger2;
                    return topla;
                }
            }
}
