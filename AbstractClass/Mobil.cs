using System;
namespace Abstraction.AbstractClass
{
    public class Mobil : Transportasi
    {
        public override void Kendaraan()
        {
            Console.WriteLine("Mobil");
            Console.WriteLine("Mobil adalah kendaraan darat yang digerakkan oleh tenaga mesin, beroda empat atau lebih (selalu genap)");
            Console.WriteLine("Mobil kependekan dari otomobil yang berasal dari [bahasa Yunani] 'autos' (sendiri) dan Latin 'movére' (bergerak).");
            Console.WriteLine("Biasanya menggunakan bahan bakar minyak (bensin atau solar) untuk menghidupkan mesinnya.");
     
        }
    }
}