using System;

namespace donguler_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar=new int[5];
            Console.WriteLine("Lütfen beş adet sayı giriniz..");
            Console.Write("Sayı 1=");
            sayilar[0]=Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 2=");
            sayilar[1]=Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 3=");
            sayilar[2]=Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 4=");
            sayilar[3]=Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 5=");
            sayilar[4]=Convert.ToInt32(Console.ReadLine());
            
           

           for (int i = 0; i < sayilar.Length; i++)
           {
              //komutlar
              //Console.WriteLine(sayilar[i]);
           if(sayilar[i]%2==0)
           {
               Console.WriteLine(sayilar[i]+" sayısı 2 ile tam bölünür");
               
           }
           else
               {
                  int kalan=sayilar[i]%2; 
                  Console.WriteLine(sayilar[i]+" Sayısının 2 ye bölümünden kalan "+kalan);
               }
            

           }
        }
    }
}
