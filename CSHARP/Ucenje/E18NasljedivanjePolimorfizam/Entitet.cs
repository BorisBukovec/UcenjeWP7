using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{
    // Nasljedivanje je OOP princip pomocu kojeg jedna klasa moze naslijediti javna i zasticena svojstva i metode druge klase
    public class Entitet : Object // svaka klasa nasljeduje klasu Object htjela ona to ili ne
    {

        private string NeVidimUPodKlasama = "";
        protected string VidimUPodKlasama = "";

        public Entitet()
        {
            Console.WriteLine("Prazan konstruktor u Entitet");
        }

        public Entitet(int sifra)
        {
            Sifra = sifra;
        }

        public int Sifra { get; set; }

        public void TestNacinaPristupa()
        {
            Sifra = 1;
            NeVidimUPodKlasama = "u ovoj klasi vidim";
            VidimUPodKlasama = "vidim";
        }


        // prepisana metoda iz klase Object
        override public string ToString()
        {
            return $"Sifra: {Sifra}";
        }

    }
}
