namespace Harjoitus9KT
{
    public class Kanava
    {
        public string Nimi { get; set; }
        public double Taajuus { get; set; }

        public Kanava(string nimi, double taajuus)
        {
            if (taajuus < 88.0 || taajuus > 107.9)
                throw new ArgumentOutOfRangeException(nameof(taajuus), "Taajuuden tulee olla välillä 88.0 - 107.9");
            Nimi = nimi;
            Taajuus = taajuus;
        }
    }
}