using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var sk1 = Convert.ToInt16(Console.ReadLine());
                var sk2 = Convert.ToInt16(Console.ReadLine());
                var sk3 = Convert.ToInt16(Console.ReadLine());
                if (sk1 > sk2)
                {
                    Console.WriteLine("sk1 > sk2");
                }
                else if (sk2 < sk3)
                {
                    Console.WriteLine("sk2 > sk3");
                }
                Console.WriteLine("Programos pabaiga");
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
