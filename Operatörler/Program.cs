using System;

namespace Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama
            Console.WriteLine("Atama İşlemleri"); 
            int x =1;
            int y =2;
         
            Console.WriteLine(y);//İlk y değerini yazdırır
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(x);//İlk x değerini yazdırır
            x+=2;
            Console.WriteLine(x);

            //mantıksal Operatörler
            //veya,ve,değil
            Console.WriteLine("Mantıksal Operatörler"); 

            bool isSuccess=true;
            bool isCompleted =false;

            if(isSuccess && isCompleted)
            {
                Console.WriteLine("perfect!!");
            }
            if(isSuccess || isCompleted)
            {
                Console.WriteLine("great!!");
            }
            if(isSuccess  && ! isCompleted)
            {
                Console.WriteLine("fine!!");
            }

            //İlişkisel operatörler
            //<,>,<=,>=,==,!=
            Console.WriteLine("İlişkisel Operatörler"); 
            int a=1;
            int b=4;
            bool sonuc=a<b;
            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc=a<=b;
            Console.WriteLine(sonuc);
            sonuc=a==b;
            Console.WriteLine(sonuc);
            sonuc=a!=b;
            Console.WriteLine(sonuc);

            //Aritmetik Operatörler
            //+,-,*,/
            Console.WriteLine("Aritmetik Operatörler");
            int sayi1=10;
            int sayi2=2;
            int sonuc1=sayi1+sayi2;

            Console.WriteLine(sonuc1);
            sonuc1=sayi1-sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);

            //% mod alır
            Console.WriteLine("Mod Alma");
            int sonuc2=20%3;
            Console.WriteLine(sonuc2);
        }
    }
}
