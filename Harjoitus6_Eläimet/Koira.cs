using Harjoitus6_Eläimet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_6
{
    class Koira : Eläimet
    {
        public string Rotu; 
        public int Ikä; 

        // laskuri
        public static int instanssit = 0;

        public Koira(string rotu, int ikä)
        {
            Rotu = rotu;
            Ikä = ikä;

            instanssit++; // Joka kerta kun koira luodaan lisätään instanssimäärään 1.
        }
        public static new void KuinkaMonta() 
        {
            Console.WriteLine("Koirat elossa: " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("Woof");
        }
    }
}
