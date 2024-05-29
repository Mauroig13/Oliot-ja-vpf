using System;
using System.Collections.Generic;

namespace Harjoitus13KT
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue joukkue = new Joukkue("JYP", "Jyväskylä");

            while (true)
            {
                Console.WriteLine("\nValitse toiminto:");
                Console.WriteLine("1: Lisää pelaaja");
                Console.WriteLine("2: Poista pelaaja");
                Console.WriteLine("3: Hae pelaaja");
                Console.WriteLine("4: Näytä kaikki pelaajat");
                Console.WriteLine("5: Lopeta");

                int valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        try
                        {
                            Console.Write("Anna etunimi: ");
                            string etunimi = Console.ReadLine();
                            Console.Write("Anna sukunimi: ");
                            string sukunimi = Console.ReadLine();
                            Console.Write("Anna pelaajan numero: ");
                            int numero = int.Parse(Console.ReadLine());

                            Pelaaja pelaaja = new Pelaaja(etunimi, sukunimi, numero);
                            joukkue.LisaaPelaaja(pelaaja);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Virhe: {e.Message}");
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.Write("Anna pelaajan numero, joka poistetaan: ");
                            int numero = int.Parse(Console.ReadLine());
                            joukkue.PoistaPelaaja(numero);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Virhe: {e.Message}");
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.Write("Anna pelaajan numero: ");
                            int numero = int.Parse(Console.ReadLine());
                            Pelaaja pelaaja = joukkue.HaePelaaja(numero);
                            Console.WriteLine(pelaaja);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Virhe: {e.Message}");
                        }
                        break;
                    case 4:
                        List<Pelaaja> pelaajat = joukkue.HaePelaajat();
                        if (pelaajat.Count > 0)
                        {
                            Console.WriteLine("Joukkueen pelaajat:");
                            foreach (Pelaaja p in pelaajat)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Joukkueessa ei ole pelaajia.");
                        }
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Virheellinen valinta.");
                        break;
                }
            }
        }
    }
}