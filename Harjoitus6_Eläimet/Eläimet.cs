using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6_Eläimet
{
    abstract class Eläimet 
    {
        private static int instanssit = 0; // laskuri

        public Eläimet()
        {
            instanssit++; 
        }
        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimet elossa: " + instanssit);
        }

        public abstract void Ääntele(); 
    }
}
