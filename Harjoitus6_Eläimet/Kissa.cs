using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6_Eläimet
{
    class Kissa : Eläimet
    {
        public string Väri; 
        public int Ikä; 

        // laskuri
        public static int instanssit = 0;
        public Kissa(string väri, int ikä)
        {
            Väri = väri;
            Ikä = ikä;

            instanssit++; // Joka kerta, kun koira luodaan, lisätään instanssimäärään 1.
        }
        public static new void KuinkaMonta() 
        {
            Console.WriteLine("Kissat elossa: " + instanssit);
        }
        public override void Ääntele()
        {
            Console.WriteLine("Meow");
        }
    }
}
