using System;

namespace Harjoitus8KT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan Työntekijä-instanssi
            Tyontekija tyontekija = new Tyontekija("Matti Meikäläinen", "Firma Oy", 3000, 40);
            tyontekija.TulostaTiedot();

            // Luodaan Pomo-instanssi
            try
            {
                Pomo pomo = Pomo.LuoPomo("Johtaja Johtajainen", "Firma Oy", 6000, 1500, "Tesla Model S");
                pomo.TulostaTiedot();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Yritetään luoda toinen Pomo-instanssi, mikä pitäisi epäonnistua
            try
            {
                Pomo toinenPomo = Pomo.LuoPomo("Toinen Johtaja", "Toinen Firma Oy", 6500, 2000, "BMW i8");
                toinenPomo.TulostaTiedot();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}