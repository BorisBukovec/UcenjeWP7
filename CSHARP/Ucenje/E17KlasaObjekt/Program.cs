using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    public class Program
    {

        // 5. vrsta metode je konstruktor


        public Program()
        {
            Console.WriteLine("E17");

            // objekt je pojavnost /instance klase -> ovo nauciti napamet
            // 

            Osoba osoba = new Osoba();

            osoba.Sifra = 1;
            osoba.Ime = "Pero";
            osoba.Prezime = "Perić";
            osoba.DatumRodenja = new DateTime(2000, 1, 1);

            Console.WriteLine(osoba.Ime);

            Osoba[] osobe = new Osoba[2];

            osobe[0] = osoba;

            osobe[1] = new Osoba { Ime = "Ana",Prezime = "Anić" };

            Console.WriteLine(osobe[1].Ime);

            Console.WriteLine("**********************");
            foreach (Osoba o in osobe)
            {
                Console.WriteLine(o.Ime);
            
            }

            Console.WriteLine("**********************");


            Console.WriteLine(osoba);






        }

    }
}
