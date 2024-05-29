using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    class Varis : Animal, ICanFly
    {
        public float WingSize { get; set; }

        public Varis(float wingSize)
        {
            WingSize = wingSize;
        }

        public void Fly()
        {
            Console.WriteLine("Varis lentää. Variksen siipien koko on " + WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("Kakaaw Kakaaw");
        }
    }
}