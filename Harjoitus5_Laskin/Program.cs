using System;

namespace Harjoitus5_Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 15;
            float b = 30;


            // Staattisia luokkia ja metodeja voidaan aina kutsua ilman, että niistä tarvitsee luoda oliota.
            Console.WriteLine(a + " + " + b + " = " + Laskin.Summa(a, b));
            Console.WriteLine(a + " - " + b + " = " + Laskin.Erotus(a, b));
            Console.WriteLine(a + " * " + b + " = " + Laskin.Kertolasku(a, b));
            Console.WriteLine(a + " / " + b + " = " + Laskin.Jakolasku(a, b));
        }
    }
}