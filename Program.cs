using System;

using Abstraction.AbstractClass;    // Menggunakan Abstract Class
//using Abstraction.Interface;      // Menggunakan Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Transportasi transportasi;          // Menggunakan Abstract Class
            transportasi = new Pesawat();
            transportasi.Kendaraan();

            Console.WriteLine();
            transportasi = new Mobil();
            transportasi.Kendaraan();

            Console.WriteLine();
            transportasi = new Motor();
            transportasi.Kendaraan();


            /*ITransportasi transportasi;       // Menggunakan Abstract Class
            transportasi = new Pesawat();
            transportasi.Kendaraan();
            Console.WriteLine();
            transportasi = new Mobil();
            transportasi.Kendaraan();
            Console.WriteLine();
            transportasi = new Motor();
            transportasi.Kendaraan();*/

            Console.ReadKey();
        }
    }
}
