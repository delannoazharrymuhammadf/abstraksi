using System;
using Abstraction.Abstractclass;

namespace Abstractionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            AlatMusik alatMusik;

            alatMusik = new Piano();
            alatMusik.Bunyi();

            Console.ReadKey();
        }
    }
}
