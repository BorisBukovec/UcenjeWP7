using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07SubotaZ3
    {
        //Program od korisnika traži unos dva cijela broja
        //Program ispisuje manji
        //Unos 5 i 2 -> 2
        //unos 3 i 8 -> 3
        //unos 4 i 4 -> Brojevi su jednaki
        public static void Izvedi()
        {

            Console.Write("Unesi prvi broj: ");
            int pb = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            int db = int.Parse(Console.ReadLine());

            Console.WriteLine(pb<db ? pb : db<pb ? db : "Jednaki su");

        }




    }
}
