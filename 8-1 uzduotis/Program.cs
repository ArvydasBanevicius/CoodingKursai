using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var tekstai = new string[100];
            for (int i = 0; i < tekstai.Length; i++)
            {
                //if ((i & 1) == 0)
                {
                    tekstai[i] = "Tekstas " + i;// Convert.ToString(i);
                    Console.WriteLine(tekstai[i]);
                }
            }
            Console.WriteLine("Masyvo ilgis = "+tekstai.Length);
            Console.WriteLine("Masyvo pirmas elemantas = " + tekstai.First());
            Console.WriteLine("Masyvo paskutinis elemantas = " + tekstai.Last());
            Console.ReadLine();
        }
    }
}
