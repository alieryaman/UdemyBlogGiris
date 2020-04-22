using Ninject;
using Ninject.Modules;
using System;

namespace K07.DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new NinjectBox());
            IMusteriDal dal = kernel.Get<IMusteriDal>();
             dal.Kaydet();
        }
    }

    class NinjectBox : NinjectModule
    {
        public override void Load()
        {
            Bind<IMusteriDal>().To<DpMusteriRepository>();
        }
    }

    class Musteri
    {
        public string Ad { get; set; }
    }

    class EfMusteriRepository : IMusteriDal
    {
        public void Kaydet()
        {
            Console.WriteLine("Database kaydedildi Ef");
        }
    }

    internal interface IMusteriDal
    {
        void Kaydet();
    }

    class DpMusteriRepository : IMusteriDal
    {
        public void Kaydet()
        {
            Console.WriteLine("Database kaydedildi Dp");
        }
    }
}
