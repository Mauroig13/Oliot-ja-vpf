using Harjoitus3_Kiaus;

class Program
{
    static void Main(string[] args)
    {
        // Luodaan uusi kiuas-olio
        Kiuas kiuas = new Kiuas();

        // Käynnistetään kiuas, säädellään lämpötilaa ja kosteutta, tulostetaan tiedot
        kiuas.Käynnistä();
        kiuas.SäädäLämpötila(70);
        kiuas.SäädäKosteus(50);
        kiuas.TulostaTiedot();

        // Sammutetaan kiuas
        kiuas.Sammuta();
    }
}
