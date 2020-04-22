using System;
using System.Collections.Generic;
using System.Linq;

namespace K06.FuncDelegeler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<string> isimler = new List<string> { "Yavuz", "Ali", "Ayşe" };

            //Func<string, bool> funcDelegate = new Func<string, bool>(YavuzuBul);
            //IEnumerable<string> gelenIsimler= isimler.Where(funcDelegate);
            //foreach (var item in gelenIsimler)
            //{
            //    Console.WriteLine(item);
            //}

            isimler.Where(I => I == "Yavuz" || I == "Ayşe").ToList().ForEach(I=> {
                Console.WriteLine(I);
            });
        }

        private static bool YavuzuBul(string arg)
        {
            return arg == "Yavuz" ? true : false;
        }
    }
}
