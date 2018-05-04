using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var RandomObjektas = new Random();
            Console.WriteLine("Iveskite masyvo ilgi = ");
            var Ilgis = Convert.ToInt32(Console.ReadLine());
            var masyvas = new int[Ilgis];
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = RandomObjektas.Next(100);
            }
            var min = 500;
            foreach (var Skaicius in masyvas)
            {
                Console.Write("Masyvo elementas = " + Skaicius);
                if (min > Skaicius)
                {
                    Console.WriteLine(" radau mazesni uz {0} = {1}", min, Skaicius);
                    min = Skaicius;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Arba galima suarsti min su \"masyvas.Min()\" = " + masyvas.Min());
            Console.ReadLine();
        }
    }
}
