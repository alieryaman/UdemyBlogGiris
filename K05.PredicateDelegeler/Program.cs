using System;
using System.Collections.Generic;

namespace K05.PredicateDelegeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Predicate<int> predicateSayi = new Predicate<int>(CiftSayiBul);
            //Predicate<string> predicateIsim = new Predicate<string>(YavuzuBul);

            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<string> isimler = new List<string> { "Yavuz", "Ali", "Ayşe" };


            sayilar.FindAll(I => I % 2 == 0).ForEach(a=> {
                Console.WriteLine(a);
            });
            Console.WriteLine(isimler.Find(I => I == "Yavuz")); 

            
            //List<int> ciftSayilar = sayilar.FindAll(predicateSayi);
            //string bulunan = isimler.Find(predicateIsim);

            //foreach (var item in ciftSayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(bulunan);

            //sayilar.Find();
            //isimler.Find()
        }

        private static bool YavuzuBul(string obj)
        {
            return obj.ToLower() == "yavuz" ? true : false;
        }

        private static bool CiftSayiBul(int i)
        {
            return i % 2 == 0 ? true : false;
        }
    }
}
