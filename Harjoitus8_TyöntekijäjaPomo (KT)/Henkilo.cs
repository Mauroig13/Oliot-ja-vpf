using System;

namespace Harjoitus8KT
{
    public abstract class Henkilo
    {
        public string Nimi { get; set; }
        public string Tyopaikka { get; set; }
        public decimal Palkka { get; set; }

        public Henkilo(string nimi, string tyopaikka, decimal palkka)
        {
            Nimi = nimi;
            Tyopaikka = tyopaikka;
            Palkka = palkka;
        }

        public abstract void TulostaTiedot();
    }
}
