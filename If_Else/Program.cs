using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
           int time = DateTime.Now.Hour;
           if(time<=18)
           {
            Console.WriteLine("İyi Günler");
           }
           
           else if(time>6 && time<=11)
           {

            Console.WriteLine("Günaydın");
           }
           else 
           {

            Console.WriteLine("İyi Geceler");
           }

           string sonuc = time<=18 ? "İyi Günler":"İyi Geceler";
           Console.WriteLine(sonuc);
           string sonuc2 = time>6 && time<=11 ?"Günaydın!": time<=18 ? "İyi Günler":"İyi Geceler";
           Console.WriteLine(sonuc2);

        }
    }
}
