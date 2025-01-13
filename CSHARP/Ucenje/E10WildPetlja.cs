using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10WildPetlja
    {

        public static void Izvedi()
        {


            //Console.WriteLine("E10");

            //while radi s bool

            //beskonačna petlja
            while (true) 
            {
                Console.WriteLine("ispis iz beskonačne petlje nakon čega je break");
                break;
            
            
            }

            int i = 0;
            while (i++ < 10) 
            {
                Console.WriteLine(i);
            
            }


            //continue radi na isti način
            int j = 0;
            while (i <= 10 && j++ < 10) // može još i || te !
            {
                Console.WriteLine(i*j);
            
            }

            int odBroja = 0;
            int doBroja = 10;


            for (int x = odBroja; x <doBroja; x++)
            {
                Console.WriteLine(x);
            }

            bool uvjet = false;

            while (uvjet)
            {
                Console.WriteLine("Neće se ispisati");
            
            }
        
        
        
        
        }







    }
}
