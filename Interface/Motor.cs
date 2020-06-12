using System;
namespace Abstraction.Interface
{
    public class Motor : ITransportasi
    {
        public void Kendaraan()
        {
            Console.WriteLine("Motor");
            Console.WriteLine("Sepeda motor adalah kendaraan beroda dua yang digerakkan oleh sebuah mesin.");
            Console.WriteLine("kecepatan tinggi sepeda motor tetap stabil disebabkan oleh gaya giroskopik.");
            Console.WriteLine("Sedangkan pada kecepatan rendah, kestabilan atau keseimbangan sepeda motor bergantung kepada pengaturan setang oleh pengendara.");
        }
    }
}