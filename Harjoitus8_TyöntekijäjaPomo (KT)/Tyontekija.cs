using System;

namespace Harjoitus8KT
{
    public class Tyontekija : Henkilo
    {
        public int ViikottaisetTunnit { get; set; }

        public Tyontekija(string nimi, string tyopaikka, decimal palkka, int viikottaisetTunnit)
            : base(nimi, tyopaikka, palkka)
        {
            ViikottaisetTunnit = viikottaisetTunnit;
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine($"Nimi: {Nimi}, Työpaikka: {Tyopaikka}, Palkka: {Palkka}, Viikottaiset tunnit: {ViikottaisetTunnit}");
        }
    }
}