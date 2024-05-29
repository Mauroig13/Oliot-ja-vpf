using Harjoitus7_Hissi;
using System;

namespace Harjoitus7_Hissi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1, 10); // Min 1 kerros, Max 10 kerroksia
            string syöte; 

            while (true)
            {
                Console.WriteLine("Kerros on " + hissi.NykyinenKerros);
                Console.WriteLine("Mihin kerrokseen haluaisit mennä?");
                syöte = Console.ReadLine();

                if (syöte == "poistu")
                {
                    Console.WriteLine("Poistuit Hissistä");
                    break;
                }
                else
                {
                    hissi.NykyinenKerros = int.Parse(syöte);
                }
            }
        }
    }
}