using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("E18");
        }

        // preopterećenje konstruktora

        public Program(string naslov):this()
        {
            Console.WriteLine(naslov);


            Smjer smjer = new(); // 1. poziv konstruktora klase Smjer

            smjer.Sifra = 1;
            smjer.Naziv = "Web programiranje";
            //smjer.VidimUPodKlasama = "ne vidim"; // protected svojstvo iz nadklase


            var s = new Smjer { Sifra=2, Naziv = "Programiranje" }; // 2. poziv konstruktora klase Smjer


            var s2 = new Smjer(3, "Serviser"); // 3. poziv konstruktora klase Smjer ali onaj s dva parametra


            Console.WriteLine(s2.Naziv);


            Polaznik polaznik = new Polaznik();

            string a = "AA";

            Console.WriteLine(a.GetHashCode());

            a = "bb";

            Console.WriteLine(a.GetHashCode());

            // razlog zasto su vrijednosti ispisa razlicite je taj sto je string immutable (nepromjenjiv)

            a = "AA" + a + "BB"; // ovo nije dobra praksa

            // dobra praska za rad s stringovima
            var sb = new StringBuilder();
            sb.Append("AA");

            Console.WriteLine($"vrijednost: {sb}, hashcode: {sb.GetHashCode()}" );

            sb.Clear().Append("bb");

            Console.WriteLine($"vrijednost: {sb}, hashcode: {sb.GetHashCode()}");

            Console.WriteLine(s2);
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                s = new Smjer(i+1,$"Naziv {r.Next(1,100)}");
                Console.WriteLine(s);
            }


            s = new() { Naziv = "Web programiranje" };
            Console.WriteLine(s.GetHashCode());
            s2 = new() { Naziv = "Web programiranje" };
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s.Equals(s2));


        }

    }
}
