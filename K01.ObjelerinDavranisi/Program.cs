using System;
using System.Collections.Generic;

namespace K01.ObjelerinDavranisi
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = string.Empty;
            List<string> isimler = new List<string>();

            Musteri musteri = new Musteri();
            List<Musteri> musteriler = new List<Musteri>();

            for (int i = 0; i < 30; i++)
            {
                ad = FakeData.NameData.GetFirstName();
                isimler.Add(ad);
            }
            Console.WriteLine("primitive davranis");
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < 30; i++)
            {
                musteri.Ad = FakeData.NameData.GetFirstName();
                musteriler.Add(musteri);
            }
            Console.WriteLine("Refere davranis");
            foreach (var item in musteriler)
            {
                Console.WriteLine(item.Ad);
            }

        }
    }

    class Musteri
    {
        public string Ad { get; set; }
    }
}
