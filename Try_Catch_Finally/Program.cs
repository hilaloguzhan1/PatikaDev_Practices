using System;

namespace Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
           // try
           //{
            
            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Girmiş Olduğunuz sayi: "+sayi);  
            //}
            //catch(Exception ex)
            //{Console.WriteLine("Hata:"+ex.Message.ToString());  
            //}
            //finally
            //{
                //Console.WriteLine("İşlem Tamamlandı");
            //}
            
            try
            {
                //int a =int.Parse(null);
                //int a=int.Parse("hilal");
                int a= int.Parse("-2000000000");
            }
            catch (ArgumentNullException ex1)
            {
                
                Console.WriteLine("Boş değer girdiniz:"+ ex1);
                Console.WriteLine(ex1);            
            }
             
             catch (FormatException ex)
            {
                
                Console.WriteLine("Veri Tipi Uygun değil:"+ex);            
                Console.WriteLine(ex);            
            }
             catch (OverflowException ex2)
            {
                
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz:"+ex2);            
                Console.WriteLine(ex2);            
            }
    }   }
}
