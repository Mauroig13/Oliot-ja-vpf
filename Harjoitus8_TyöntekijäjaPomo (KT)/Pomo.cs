using System;

namespace Harjoitus8KT
{
    public class Pomo : Henkilo
    {
        private static Pomo _instance;
        public decimal Bonus { get; set; }
        public string Auto { get; set; }

        private Pomo(string nimi, string tyopaikka, decimal palkka, decimal bonus, string auto)
            : base(nimi, tyopaikka, palkka)
        {
            Bonus = bonus;
            Auto = auto;
        }

        public static Pomo LuoPomo(string nimi, string tyopaikka, decimal palkka, decimal bonus, string auto)
        {
            if (_instance == null)
            {
                _instance = new Pomo(nimi, tyopaikka, palkka, bonus, auto);
            }
            else
            {
                throw new Exception("Vain yksi Pomo voi olla olemassa.");
            }
            return _instance;
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine($"Nimi: {Nimi}, Työpaikka: {Tyopaikka}, Palkka: {Palkka}, Bonus: {Bonus}, Auto: {Auto}");
        }
    }
}
