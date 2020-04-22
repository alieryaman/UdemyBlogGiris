using System;

namespace K02.ExtensionMetodlar
{
    class Program
    {
      
        static void Main(string[] args)
        {          
            MatematikselIslem islem = new MatematikselIslem();
            Console.WriteLine(islem.Cikar(10, 2));
            
        }
    }


    class MatematikselIslem
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }
    }

    static class MatExtension
    {
        public static int Cikar(this MatematikselIslem mat,int sayi1,int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
