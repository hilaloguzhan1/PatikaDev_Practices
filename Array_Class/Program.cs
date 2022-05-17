using System;

namespace Array_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int [] sayiDizisi={23,12,86,72,3,11,17};
            Console.WriteLine("******Sırasız Liste********");
            foreach (var sayi in sayiDizisi)
            {
               
                Console.WriteLine(sayi);
            }
            Console.WriteLine("******Sıralı Liste********");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear
            Console.WriteLine("******array Clear********");
             Array.Clear(sayiDizisi,2,3);//sayı dizisi elemanlarını kullanarak 2. indexten itibaren 3 tane elemanı sıfırlar.

             foreach (var sayi in sayiDizisi)
             {
                 Console.WriteLine(sayi);
             }
            //Reverse **Verdiğiniz diziyi ortadan itibaren aynalıyormuş gibi yer değiştirir.
            //İlk eleman son son eleman ilk olur
            Console.WriteLine("******Array Reverse********");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf
            Console.WriteLine("******Index Of********");
            //Verilen dizinin indexini döner

            Array.IndexOf(sayiDizisi,3);

            Console.WriteLine(Array.IndexOf(sayiDizisi,72));

            //Resize***Yeniden boyutlandırma yapar
            Console.WriteLine("******Resize*******");
            Array.Resize<int>(ref sayiDizisi,9);

            sayiDizisi[8]=99;
            foreach (var sayi in sayiDizisi)
            {
                
            Console.WriteLine(sayi);
            }













        }
    }
}
