class Program
{
    static void Main(string[] args)
    {
        // Luodaan kappaleita
        Kappale kappale1 = new Kappale("Rahh", "MSG", 240);
        Kappale kappale2 = new Kappale("Dahh", "MSG", 180);
        Kappale kappale3 = new Kappale("Bahh", "MSG", 320);

        // Luodaan albumi ja lisätään siihen kappaleita
        Albumi albumi = new Albumi("Albumi Loco", "Mauro Sanchez Gonzalez");
        albumi.LisääKappale(kappale1);
        albumi.LisääKappale(kappale2);
        albumi.LisääKappale(kappale3);

        // Tulostetaan albumin tiedot
        albumi.TulostaAlbuminTiedot();
    }
}