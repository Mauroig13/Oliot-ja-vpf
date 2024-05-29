using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus7_Hissi
{
    class Hissi
    {
        private int minKerros; // alin kerros
        private int maxKerros; //ylin kerros

        private int nykyinenKerros; 

        public Hissi(int minKerros, int maxKerros) 
        {
            this.minKerros = minKerros;
            this.maxKerros = maxKerros;

            NykyinenKerros = minKerros; 
        }

        public int NykyinenKerros 
        {
            get => nykyinenKerros; // Palautetaan
            set 
            {
                if (value > maxKerros || value < minKerros)
                {
                    Console.WriteLine("Errr Wrong Floor mf");
                }
                else
                {
                    nykyinenKerros = value;
                }
            }
        }
    }
}
