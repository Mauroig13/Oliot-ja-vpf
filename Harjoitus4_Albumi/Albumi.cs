using System;
using System.Collections.Generic;

// Luodaan Kappale-luokka
class Kappale
{
    public string Nimi { get; set; }
    public string Artisti { get; set; }
    public double Kesto { get; set; } 

    // Konstruktori
    public Kappale(string nimi, string artisti, double kesto)
    {
        Nimi = nimi;
        Artisti = artisti;
        Kesto = kesto;
    }

    // Override ToString method to print song details
    public override string ToString()
    {
        return $"Kappale: {Nimi} - Artisti: {Artisti} - Kesto: {Kesto} sekuntia";
    }
}

// Luodaan Albumi-luokka, joka sisältää kappaleita
class Albumi
{
    public string Nimi { get; set; }
    public string Artisti { get; set; }
    public List<Kappale> Kappaleet { get; set; }

    // Konstruktori
    public Albumi(string nimi, string artisti)
    {
        Nimi = nimi;
        Artisti = artisti;
        Kappaleet = new List<Kappale>(); // Alustetaan lista kappaleille
    }

    // Lisää kappale albumiin
    public void LisääKappale(Kappale kappale)
    {
        Kappaleet.Add(kappale);
    }

    // Tulosta albumin tiedot
    public void TulostaAlbuminTiedot()
    {
        Console.WriteLine($"Albumi: {Nimi} - Artisti: {Artisti}");
        Console.WriteLine("Kappaleet:");
        foreach (var kappale in Kappaleet)
        {
            Console.WriteLine(kappale);
        }
    }
}
