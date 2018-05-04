using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.LabaDiena();
            prog.AtliktiFunkcija();
            Console.ReadLine();
        }

        public void AtliktiFunkcija()
        {
            Console.WriteLine("Isvedame teksta");
        }
        public void LabaDiena()
        {
            Console.WriteLine("Laba diena");
        }
    }
}
