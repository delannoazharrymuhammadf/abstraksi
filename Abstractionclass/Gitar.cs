using System;

namespace Abstraction.Abstractclass
{
    public class Gitar : AlatMusik
    {
        public override void Bunyi()
        {
            Console.WriteLine("Untuk Menghasilkan Bunyi Gitar Yang Baik yaitu dengan cara dipetik");
            Console.WriteLine("Gitar Merupakan Instrumen yang sangat penting untuk sebagian besar band");
        }
    }
}