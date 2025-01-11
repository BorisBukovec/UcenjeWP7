using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07SubotaZ2
    {

        // Program od korisnika traži unos broj godina koje ima korisnik
        // Program ispisuje da li je korisnik punoljetna osoba ili ne
        // dodatno: ako je unos ispod nula godine ili iznad 112 godina ispisati GREŠKA
        public static void Izvedi()
        {

            Console.Write("Unesi svoj broj godina: ");
            int godine = int.Parse(Console.ReadLine());
            if (godine >= 18)
            {
                Console.WriteLine("Korisnik je punoljetna osoba");
            }
            else
            { 
            Console.WriteLine("Korisnik nije punoljetna osoba");
            }

            Console.WriteLine("Korisnik {0} punoljetna osoba ({1})", godine>= 18 ? "je" : "nije", godine);

        
        
        }


    }
}
