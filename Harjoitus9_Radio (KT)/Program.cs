using System;

namespace Harjoitus9KT
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();

            while (true)
            {
                Console.WriteLine("\nValitse toiminto:");
                Console.WriteLine("1: Aseta päälle / pois");
                Console.WriteLine("2: Aseta äänenvoimakkuus (0-9)");
                Console.WriteLine("3: Aseta taajuus (88.0 - 107.9)");
                Console.WriteLine("4: Lopeta");

                int valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        radio.Paalla = !radio.Paalla;
                        break;
                    case 2:
                        Console.Write("Anna äänenvoimakkuus (0-9): ");
                        int aanenvoimakkuus = int.Parse(Console.ReadLine());
                        radio.Aanenvoimakkuus = aanenvoimakkuus;
                        break;
                    case 3:
                        Console.Write("Anna taajuus (88.0 - 107.9): ");
                        double taajuus = double.Parse(Console.ReadLine());
                        radio.Taajuus = taajuus;
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Virheellinen valinta.");
                        break;
                }
            }
        }
    }
}