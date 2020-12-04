using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktori
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa();

            PrvaKlasa y = new PrvaKlasa();

            PrvaKlasa z = new PrvaKlasa();

            Console.WriteLine(PrvaKlasa.Counter);

            Console.ReadKey();

          
        }
    }
}
