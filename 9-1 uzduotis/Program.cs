using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var RandomObjektas = new Random();
            var Masyvas = new List<double>();
            Console.Write("Iveskite masyvo ilgi = ", Masyvas.Count);
            int Ilgis = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<Ilgis; i++)
            {
                Masyvas.Add(100*RandomObjektas.NextDouble());
            }
            var min = Masyvas[0];
            var max = Masyvas[0];
            double vid = 0;
            foreach (var sk in Masyvas)
            {
                Console.WriteLine("Skaicius = {0}", sk);
                if (min > sk) min = sk;
                if (max < sk) max = sk;
                vid += sk;
            }

            Console.WriteLine();

            vid = vid / Masyvas.Count;
            foreach (var sk in Masyvas)
            {
                Console.WriteLine( "Skaicius {0} {1} uz vidurki", sk, ((sk < vid)?("mazesnis"):("didesnis")) );
            }

            Console.WriteLine("Min skaicius = {0},max skaicius = {1}, vidurkis = {2}", min, max, vid);
            Console.WriteLine("Is viso masyvo ilgis = {0}", Masyvas.Count);
            Console.ReadLine();
        }
    }
}
