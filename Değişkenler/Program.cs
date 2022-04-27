using System;

namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("");
         
         byte b=5;     //1 byte
         byte c=5;     //1 byte


         short s =5;    //2 byte
         ushort us=5;   //2 byte
         
         
         Int16 i16=2;   //2byte
         int i=2;       //4 byte
         Int32 i36 =2;  //4 byte
         Int64 i64 =2;  //8 byte

         uint ui =2;    //4byte
         long l  =4;    //8 byte
         ulong ul =4;   //8 byte;


        //Reel sayılar
         float f=5;     //4 byte
         double d = 5;  //8 byte
         decimal dc=3;  //16 byte

         char ch= 'H';    //2 byte
         string st= "Hilal"; //Sınırsız
         bool b1= true;
         bool b2=false;

         DateTime dt = DateTime.Now;
         Console.WriteLine(dt);

         object o1= "z";
         object o2=  2;
         object o3 = 4.3;

         //string ifadeler

         string str1= string.Empty;
         str1 = "Bugun hava cok guzel";
         string s2 ="Anibal";
         string s3 ="Anadolu Lisesi";
         string birlestir= s2 +" "+s3;

         Console.WriteLine(birlestir);

         //integer tanımlama şekilleri
         int int1 = 5;
         int int2 = 6;
         int toplam = int1 + int2;

         //boolean

         bool bool1=10<2;

         //Değişken dönüşümleri

         string strx="20";
         int    inty=30;
         string yenideger=strx +" "+inty.ToString();
         Console.WriteLine(yenideger);

         int int21= inty + Convert.ToInt32(strx);
         Console.WriteLine(int21);

         int int22 = inty+ int.Parse(strx);
         Console.WriteLine(int22);

         // datetime
         string datetime = DateTime.Now.ToString("dd.MM.yyyy");
         Console.WriteLine(datetime);
         string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
         Console.WriteLine(datetime1);





























         




        }
    }
}
