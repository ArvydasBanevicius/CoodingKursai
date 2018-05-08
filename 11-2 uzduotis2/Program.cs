using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_uzduotis2
{
    class Program
    {
        static void Main(string[] args)
        {
            var prieglauda = new Prieglauda("Penkta koja","Kuršių g. 9",
                                new List<Suo>
                                {
                                    new Suo(5,"haskis","Pirmas"),
                                    new Suo(8,"Bokseris", "Antras"),
                                    new Suo(10, "Kazkoks", "Trečias")
                                });
            prieglauda.Isvedimas();

            prieglauda.CheckIn();
            prieglauda.Isvedimas();

            Console.ReadLine();

        }
    }
}
