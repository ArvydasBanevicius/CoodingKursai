using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_uzduotis2
{
    class Suo
    {
        public int Amzius;
        public string Veisle;
        public string Vardas;
        public Suo(int amzius, string veisle, string vardas)
        {
            Amzius = amzius;
            Veisle = veisle;
            Vardas = vardas;
        }

        public Suo()
        {
            Console.Write("Įveskite amziu: ");
            Amzius = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Įveskite veisle: ");
            Veisle = Console.ReadLine();
            Console.Write("Įveskite varda: ");
            Vardas = Console.ReadLine();
        }

        public void Isvedimas()
        {
            Console.WriteLine("Suns vardas: {0}, amzius: {1}, veisle: {2}", Vardas, Amzius, Veisle);
        }
    }
}
