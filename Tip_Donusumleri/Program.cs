using System;

namespace Tip_Donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
         //Implisit Conversion(Bilinçsiz Dönüşüm)
         Console.WriteLine("******Bilinçsiz Dönüşüm****");
        byte a=5;
        sbyte b=30;
        short c=10;
        int d=a+b+c;
        Console.WriteLine("d:"+d);

        long h=d;
        Console.WriteLine("h:"+h);
        float i=h;
        Console.WriteLine("i:"+i);

        string st="Zikriye";
        char ch='k';
        object ob=st+ch+d;

        Console.WriteLine("ob:"+ob);

         //Exlisit Conversion(Bilinçli Dönüşüm)
        Console.WriteLine("******Bilinçli Dönüşüm****");
        int x=4;
        byte y= (byte)x;
        Console.WriteLine("y:"+y);

        int z=100;
        byte k=(byte)z;
        Console.WriteLine("K:"+k);

        float f=10.3f;
        byte w=(byte)f;
        Console.WriteLine("w:"+w);

        //**ToString Metodu**
        Console.WriteLine("******ToString****");

        int xx=6;
        string yy=xx.ToString();
        Console.WriteLine("yy:"+yy);

        string aa=12.5.ToString();
        Console.WriteLine("aa:"+aa);

        //System.Convert
        Console.WriteLine("******System.Convert****");
        string s1="10";
        string s2="20";
        int sayi1,sayi2;
        int Toplam;

        sayi1=Convert.ToInt32(s1);
        sayi2=Convert.ToInt32(s2);
        Toplam=sayi1+sayi2;
        Console.WriteLine("Toplam:"+Toplam);

        //Parse
        Console.WriteLine("******Parse Methodu****");
        parseMethod();

        }

        public static void parseMethod()
        {
            string metin1="10";
            string metin2="10.53";
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1);
            double1=Double.Parse(metin2);
            
            Console.WriteLine("rakam1:"+rakam1);

            Console.WriteLine("double1:"+double1);





        }
    }
}
