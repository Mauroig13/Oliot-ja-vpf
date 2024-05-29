using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    class Sorsa : Animal, ICanFly, ICanSwim
    {
        public float WingSize { get; set; }
        public float SwimSpeed { get; set; }

        public Sorsa(float wingSize, float swimSpeed)
        {
            WingSize = wingSize;
            SwimSpeed = swimSpeed;
        }

        public void Fly()
        {
            Console.WriteLine("Sorsa lentää. Sorsan siipien koko on " + WingSize);
        }

        public void Swim()
        {
            Console.WriteLine("Sorsa ui. Sorsan uinti nopeus on " + SwimSpeed);
        }

        public override void MakeASound()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}