using System;
using Abstraction.Interface;

namespace Abstractionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            ISmartphone ismartphone;


            ismartphone = new Iphone();
            ismartphone.Merk();

            Console.WriteLine();
            ismartphone = new Samsung();
            ismartphone.Merk();
            Console.ReadKey();
        }
    }
}
