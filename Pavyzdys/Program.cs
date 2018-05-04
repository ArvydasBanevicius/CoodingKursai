using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirmas = Convert.ToDouble(Console.ReadLine());
            var antras = Convert.ToDouble(Console.ReadLine());
            var trecia = Convert.ToDouble(Console.ReadLine());
            if (pirmas == antras)
            {
                Console.WriteLine("Pirmas skaicius = Antras skaicius");
            }
            if (pirmas == trecia)
            {
                Console.WriteLine("Pirmas skaicius = Tracias skaicius");
            }
            if (pirmas > antras)
            {
                Console.WriteLine("Pirmas skaicius > Antras skaicius");
            }
            if (antras > trecia*2)
            {
                Console.WriteLine("Pirmas skaicius > Trecia*2 skaicius");
            }
            if (pirmas % 2 == 0)
            {
                Console.WriteLine("Pirmas skaicius lyginis");
            }
            if (antras % 2 == 0)
            {
                Console.WriteLine("Antras skaicius lyginis");
            }
            if (trecia > 0)
            {
                Console.WriteLine("Tracias skaicius daugiau uz nuli");
            }
            if (trecia < 0)
            {
                Console.WriteLine("Tracias skaicius neigiamas");
            }
            Console.ReadLine();
        }
    }
}
