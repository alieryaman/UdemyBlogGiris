using System;
using System.Collections.Generic;

namespace K04.ActionDelegeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> ActionSayi = new Action<int>(SayiGetir);
            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<string> isimler = new List<string> { "Yavuz", "Ali", "Ayşe" };

            //sayilar.ForEach(ActionSayi);

            //sayilar.ForEach(I => { Console.WriteLine(I); });

            sayilar.ForEach(SayiGetir);
            //sayilar.ForEach()

            //isimler.ForEach()

            //action delege : t tipinden değer alan=> void
        }
        static void SayiGetir(int i)
        {
            Console.WriteLine(i);
        }

    }
}
