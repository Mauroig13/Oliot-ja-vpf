using System;
using System.Collections.Generic;

namespace Harjoitus13KT
{
    public class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        private Dictionary<int, Pelaaja> Pelaajat { get; set; }

        public Joukkue(string nimi, string kotikaupunki)
        {
            Nimi = nimi;
            Kotikaupunki = kotikaupunki;
            Pelaajat = new Dictionary<int, Pelaaja>();
        }

        public Pelaaja HaePelaaja(int numero)
        {
            if (Pelaajat.ContainsKey(numero))
            {
                return Pelaajat[numero];
            }
            else
            {
                throw new KeyNotFoundException("Pelaajaa ei löytynyt annetulla numerolla.");
            }
        }

        public void LisaaPelaaja(Pelaaja pelaaja)
        {
            if (!Pelaajat.ContainsKey(pelaaja.Numero))
            {
                Pelaajat[pelaaja.Numero] = pelaaja;
                Console.WriteLine($"Pelaaja {pelaaja} lisätty joukkueeseen {Nimi}.");
            }
            else
            {
                throw new ArgumentException("Pelaaja numerolla on jo olemassa joukkueessa.");
            }
        }

        public void PoistaPelaaja(int numero)
        {
            if (Pelaajat.ContainsKey(numero))
            {
                Pelaajat.Remove(numero);
                Console.WriteLine($"Pelaaja numerolla {numero} poistettu joukkueesta {Nimi}.");
            }
            else
            {
                throw new KeyNotFoundException("Pelaajaa ei löytynyt annetulla numerolla.");
            }
        }

        public List<Pelaaja> HaePelaajat()
        {
            return new List<Pelaaja>(Pelaajat.Values);
        }
    }
}
