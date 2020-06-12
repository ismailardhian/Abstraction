using System;
namespace Abstraction.AbstractClass
{
    public class Pesawat : Transportasi
    {
        public override void Kendaraan()
        {
            Console.WriteLine("Pesawat");
            Console.WriteLine("Pesawat terbang adalah pesawat udara yang lebih berat dari udara, bersayap tetap, dan dapat terbang dengan tenaga sendiri.");
            Console.WriteLine("Secara umum istilah pesawat terbang sering juga disebut dengan pesawat udara atau kapal terbang atau cukup pesawat dengan tujuan pendefenisian yang sama sebagai kendaraan yang mampu terbang di atmosfer atau udara.");
        }
    }
}