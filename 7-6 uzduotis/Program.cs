using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var RandomObjektas = new Random();
            var AtsitiktinisSkaicius = RandomObjektas.Next(2, 10);
            int sk = -1;
            do
            {
                Console.WriteLine("Skaicius {0} {1}", sk, (sk < AtsitiktinisSkaicius) ? ("mazesnis") : ("didesnis"));
                Console.WriteLine("Ot ir neatspejai");
                sk = Convert.ToInt32(Console.ReadLine());
            }
            while (AtsitiktinisSkaicius != sk);
            Console.WriteLine("Atspejai {0} skaiciu {1} ", sk, AtsitiktinisSkaicius);
            Console.ReadLine();
        }
    }
}
