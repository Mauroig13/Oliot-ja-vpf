using System;

namespace Harjoitus3_Kiaus
{
    class Kiuas
    {
        private bool päällä;
        private int lämpötila;
        private int kosteus;

        // Konstruktori Kiuas-luokalle
        public Kiuas()
        {
            päällä = false;
            lämpötila = 0;
            kosteus = 0;
        }

        // Metodi kiuas päälle
        public void Käynnistä()
        {
            päällä = true;
            Console.WriteLine("Kiuas on nyt päällä.");
        }

        // Metodi kiuas pois päältä
        public void Sammuta()
        {
            päällä = false;
            Console.WriteLine("Kiuas on nyt pois päältä.");
        }

        // Metodi lämpötilan säätöön
        public void SäädäLämpötila(int uusiLämpötila)
        {
            lämpötila = uusiLämpötila;
            Console.WriteLine("Lämpötila asetettu: " + lämpötila + " astetta.");
        }

        // Metodi kosteuden säätöön
        public void SäädäKosteus(int uusiKosteus)
        {
            kosteus = uusiKosteus;
            Console.WriteLine("Kosteus asetettu: " + kosteus + "%.");
        }

        // Metodi tulostamaan kiuas tiedot
        public void TulostaTiedot()
        {
            Console.WriteLine("Kiuas päällä: " + (päällä ? "Kyllä" : "Ei"));
            Console.WriteLine("Lämpötila: " + lämpötila + " astetta");
            Console.WriteLine("Kosteus: " + kosteus + "%");
        }
    }
}

