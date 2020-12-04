using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktori
{
    class PrvaKlasa
    {
       
        string ime;

        string prezime;

        static int brojac;

       public override void ToString()

        {

         Console.WriteLine("Redni broj: " +brojac+ "," + ime+prezime);

                                                                          }

      public PrvaKlasa()
      {
        brojac++;
                     }
       
        public static int Counter { get => brojac; }

        public string Ime { get => ime; set => ime = value; }

        public string Prezime { get => prezime; set => prezime = value; }

    }
}
