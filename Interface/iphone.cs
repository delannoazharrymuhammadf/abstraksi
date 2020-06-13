using System;

namespace Abstraction.Interface
{
    public class Iphone : ISmartphone
    {
        public void Merk()
        {
            Console.WriteLine("Iphone adalah Smartphone yang memiliki kualitas kamera yang baik");
            Console.WriteLine("Dengan Harga diatas rata-rata Smartphone Lainnya Iphone Memiliki Fitur yang lengkap");
        }
    }
}
