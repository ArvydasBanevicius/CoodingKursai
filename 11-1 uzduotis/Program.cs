using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_uzduotis
{
    class Automobilis
    {
        public int GimimoMetai;
        public string Spalva;
        public string Marke;
        public string VIN;
        public string VatstyvinisNumeris;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Automobilis auto = new Automobilis();
            auto.GimimoMetai = 2005;
            auto.Spalva = "Raudona";
            Console.WriteLine(auto.GimimoMetai);
            Console.WriteLine(auto.Spalva);

            Console.ReadLine();
        }
    }
}
