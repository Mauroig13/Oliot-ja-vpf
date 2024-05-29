using System;
using System.Collections.Generic;

namespace Harjoitus_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICanFly> lentoEläimet = new List<ICanFly>();
            List<ICanSwim> uimaEläimet = new List<ICanSwim>();

            Varis varis1 = new Varis(5);
            Sorsa sorsa1 = new Sorsa(4, 7);

            varis1.Fly();
            varis1.MakeASound();

            sorsa1.Fly();
            sorsa1.MakeASound();
            sorsa1.Swim();

            Console.WriteLine("Variksen tyyppi on " + varis1.GetType());

            lentoEläimet.Add(varis1);
            lentoEläimet.Add(sorsa1);

            uimaEläimet.Add(sorsa1);
        }
    }
}