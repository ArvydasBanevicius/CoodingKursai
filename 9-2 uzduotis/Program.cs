using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var ZodziuMasyvas = new List<String>();
            string tekstas;
            Console.WriteLine("Iveskite tekstus");
            Console.WriteLine();
            while ((tekstas = Console.ReadLine()) != "exit") 
            {
                ZodziuMasyvas.Add(tekstas);
            }
            Console.WriteLine("Masyvo ilgis = {0}", ZodziuMasyvas.Count);

            int max = 0;
            int Index = 0;
            for (int i=0; i<ZodziuMasyvas.Count; i++)
            {
                if (max < ZodziuMasyvas[i].Length)
                {
                    max = ZodziuMasyvas[i].Length;
                    Index = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Ilgiausio zodzio ilgis = {0}", ZodziuMasyvas[Index].Length);
            Console.WriteLine("Ilgiausias zodis {0} indeksu = {1}", ZodziuMasyvas[Index], Index);
            Console.ReadLine();
        }
    }
}
