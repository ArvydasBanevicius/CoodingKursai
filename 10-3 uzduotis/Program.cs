using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.LabaDiena();
            Program.AtliktiFunkcija();

            LabaDiena();
            AtliktiFunkcija();

            Console.ReadLine();
        }

        public static void AtliktiFunkcija()
        {
            Console.WriteLine("Isvedame teksta");
        }
        public static void LabaDiena()
        {
            Console.WriteLine("Laba diena");
        }
    }
}
