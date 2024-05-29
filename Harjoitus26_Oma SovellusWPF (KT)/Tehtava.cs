using System;

namespace Harjoitus26_Oma_SovellusWPF__KT_
{
    public abstract class Tehtava
    {
        public string Nimi { get; set; }
        public string Kuvaus { get; set; }

        public abstract void Suorita();
    }

    public class KertaTehtava : Tehtava
    {
        public override void Suorita()
        {
            Console.WriteLine($"Suoritetaan kertaustehtävä: {Nimi} - {Kuvaus}");
        }
    }

    public class ToistuvaTehtava : Tehtava
    {
        public DateTime AloitusPvm { get; set; }
        public TimeSpan Toistojakso { get; set; }

        public override void Suorita()
        {
            Console.WriteLine($"Suoritetaan toistuva tehtävä: {Nimi} - {Kuvaus}");
        }
    }
}
