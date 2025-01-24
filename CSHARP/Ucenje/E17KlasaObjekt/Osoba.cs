using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    //klasa je opisnik objekta->ovo naučiti napamet
    public class Osoba
    {
        //klasa sadrži svojstva 
        //princip učahurivanja -> najcesce se POCO (plain old c# objekt)
        public int Sifra { get; set; }
        public string? Ime { get; set; } // ? znaci da moze biti null
        public string Prezime { get; set; } = ""; // ="" ce postaviti prazno ,nece biti null
        public DateTime? DatumRodenja { get; set; }


        //klasa može sadrzavati metode


        public string ImePrezime()
        {
            NeVidiSeIzvana()
            return Ime + " " + Prezime;  // nije dobro riješenje
        }

        private string NeVidiSeIzvana()
        {
            return "";
        }

    }
}
