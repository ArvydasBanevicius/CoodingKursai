using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var RandomObjektas = new Random();
            var SavaitesDienos = new double[7];
            for (int i = 0; i<SavaitesDienos.Length; i++)
            {
                SavaitesDienos[i] = 20*RandomObjektas.NextDouble();
            }

            double min = SavaitesDienos[0];
            double max = SavaitesDienos[0];
            double vidurkis = 0;
            foreach (var Temperatura in SavaitesDienos)
            {
                if (min > Temperatura)
                {
                    min = Temperatura;
                }
                if (max < Temperatura)
                {
                    max = Temperatura;
                }
                vidurkis += Temperatura;
                Console.WriteLine("Temperaturos yra = {0}", Temperatura);
            }
            vidurkis = vidurkis / SavaitesDienos.Length;

            Console.WriteLine();
            foreach (var Temperatura in SavaitesDienos)
            {
                if (vidurkis > Temperatura)
                {
                    Console.WriteLine("Temperaturos mazesne uz vidurki = {0}", Temperatura);
                }
                if (vidurkis < Temperatura)
                {
                    Console.WriteLine("Temperaturos didesne uz vidurki = {0}", Temperatura);
                }
            }
            Console.WriteLine("Ir taip gavom min = {0}, max = {1}, vid = {2}", min, max, vidurkis);
            Console.ReadLine();
        }
    }
}
