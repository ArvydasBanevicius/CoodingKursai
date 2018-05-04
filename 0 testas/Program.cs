using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_testas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Iveskite pin koda = ");
            //var kodas = Console.ReadLine();
            //Console.WriteLine("Ivestas pin kodas yra \"" + kodas + '\"');

            //Console.Write("Iveskite amzius = ");
            //var amzius = Console.ReadLine();
            //Console.WriteLine("Ivestas amzius yra \"" + Convert.ToInt32(amzius) + '\"');

            var skaicius = Convert.ToDateTime( Console.ReadLine() );
            Console.WriteLine("Ivestas laikas yra \"" + skaicius + '\"');

           Console.ReadLine();
        }
    }
}
