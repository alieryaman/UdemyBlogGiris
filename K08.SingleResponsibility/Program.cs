using System;
using System.ComponentModel.DataAnnotations;

namespace K08.SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Musteri
    {
      
        public string Ad { get; set; }      
    }

    class MusteriValidator
    {
        public bool AdDogula(string ad)
        {
            if (string.IsNullOrEmpty(ad))
            
                return false;
            
            else return true;
        }
    }

    class EfMusteriRepository
    {
        public void Kaydet()
        {
            Console.WriteLine("kaydedildi");
        }

    }
}
