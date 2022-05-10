using System;

namespace Donguler_for_patika
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Lütfen bir sayi giriniz..");
         int sayi=int.Parse(Console.ReadLine());
          int tekSayitoplam=0;
          int ciftSayiToplam=0;
         for (int i = 0; i <= sayi; i++)
         {
            
             
             if(i%2==1)
             {
                
                tekSayitoplam=tekSayitoplam+i;
                
             }
             else
             {
               ciftSayiToplam=ciftSayiToplam+i;
               

             }
             
         }
         Console.WriteLine("Tek sayıların toplamı= "+ tekSayitoplam);
         Console.WriteLine("Çift sayıların toplamı= " +ciftSayiToplam);
         
         for (int i = 0; i < 10; i++)
         {
             if(i==4){
                break;
             }
             Console.WriteLine(i);
         }
         for (int i = 0; i < 10; i++)
         {
             if(i==4){
                continue;
             }
             Console.WriteLine(i);
         }
        }
    }
}
