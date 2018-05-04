using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var RandomObjektas = new Random();
            Console.WriteLine("Iveskite masyvo ilgi = ");
            var Ilgis = Convert.ToInt32( Console.ReadLine() );
            var masyvas = new int[Ilgis];
            int suma = 0;
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = RandomObjektas.Next(100);
            }
            foreach (var Skaicius in masyvas)
            {
                suma += Skaicius;
                Console.WriteLine("Prikedam skaiciu = " + Skaicius + ", suma bus = " + suma);
            }
            
            Console.WriteLine("Bendra suma = " + suma);
            Console.WriteLine("Arba galima skaiciuoti bendra suma su \"masyvas.Sum()\" = " + masyvas.Sum());
            Console.ReadLine();
        }
    }
}
