using System;
using System.Collections.Generic;

namespace K03.Delegeler
{
    delegate void BenimDelegem(int sayi1, int sayi2);
    class Program
    {
        static void Main(string[] args)
        {
            BenimDelegem benimDelegem = new BenimDelegem(Topla);
            benimDelegem += Carp;
            benimDelegem.Invoke(5, 3);
        }
        static void Topla(int deger1, int deger2)
        {
            Console.WriteLine($"toplam {deger1+deger2}");
        }
        static void Carp(int deger1, int deger2)
        {
            Console.WriteLine($"sonuc {deger1 * deger2}");
        }
    }
}
