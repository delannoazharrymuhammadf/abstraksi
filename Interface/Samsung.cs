using System;

namespace Abstraction.Interface
{
    public class Samsung : ISmartphone
    {
        public void Merk()
        {
            Console.WriteLine("Samsung adalah Smartphone yang memiliki kualitas kamera dan audio yang baik");
            Console.WriteLine("Harga yang Bervariasi");
        }
    }
}
