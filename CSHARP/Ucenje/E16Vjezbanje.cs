using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16Vjezbanje
    {

        public static void Izvedi()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dobro došli u vježbanje srijedom");
            Console.ResetColor();
            Izbornik();
            Console.WriteLine("Doviđenja");
                  
              
        }


        private static void Izbornik()
        {
            Console.WriteLine();
            Console.WriteLine("1. Za uneseni broj provjeri da li je parni ili ne?");
            Console.WriteLine("2 Riječ unazad");
            Console.WriteLine("3. Provjera sigurnosti lozinke");
            Console.WriteLine("0. Izlaz iz aplikacije");
            OdabirOpcijeIzbornika();

                                
        }

        private static void OdabirOpcijeIzbornika()
        {
            switch (E14Metode.UcitajBroj("Odaberi opciju izbornika"))
            {
                case 1:
                    ParnostBroja();
                    Izbornik();
                    break;

                case 2:
                    RijecUnazad();
                    Izbornik();
                    break;
                                    case 0:
                    break;
                default:
                    Console.WriteLine("Nije opcija izbornika");
                    Izbornik();
                    break;


            }

           
        }
        public static void RijecUnazad()
        {

            NaslovPrograma("Program za unesenu riječ ispisuje istu nazad.");
                string unos = E14Metode.UcitajString("Unesi riječ", "Nisi unio riječ");


        }
        private static char z = '-';

        public static void NaslovPrograma(string v)
        {
            for (int i = 0; i < v.Length + 6; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-- {0} --",v);
            Linija(v.Length + 6);
        }

        private static void Linija(int v)
        {
            for (int i = 0; i < v; i++)
            {
                Console.Write(z);
            }
            Console.WriteLine();
        
        }

        public static void ParnostBroja()
        {

            Console.WriteLine("------------------------");
            Console.WriteLine("--Program za uneseni broj ispisuje da li je paran ili ne");
            Console.WriteLine("------------------------");
            int broj = E14Metode.UcitajBroj("Unesi cijeli broj za provjeru",1,100);
            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj {0} je paran ", broj);

            }
            else
            {
                Console.WriteLine("Broj {0} je paran ", broj);
            
            }
            Console.WriteLine("-- Kraj programa provjere parnosti broja --");


        }


    }
}
