using Harjoitus1_Ajoneuvo;

internal class Program
{
    private static void Main(string[] args)
    {
        //Olio Ajoneuvo -luokasta
        Ajoneuvo auto = new Ajoneuvo();

        //Asetetaan oliolle "auto" arvot
        auto.Nimi = "Toyota";
        auto.Nopeus = 120;
        auto.Renkaat = 4;

        //Käytetään "auto" olion toimintoja
        auto.TulostaData();

        string autonTiedot = auto.ToString();
        
        Console.WriteLine(autonTiedot);

        //Tyhjä rivi
        Console.WriteLine();

        Ajoneuvo moottoripyora = new Ajoneuvo();
        moottoripyora.Nimi = "BMW s1000rr";
        moottoripyora.Nopeus = 310;
        moottoripyora.Renkaat = 2;

        moottoripyora.TulostaData();
        
        string moottoripyoraTiedot= moottoripyora.ToString();
        Console.WriteLine(moottoripyoraTiedot);



    }
}