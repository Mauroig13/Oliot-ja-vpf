namespace Harjoitus13KT
{
    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Numero { get; set; }

        public Pelaaja(string etunimi, string sukunimi, int numero)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Numero = numero;
        }

        public override string ToString()
        {
            return $"{Numero}: {Etunimi} {Sukunimi}";
        }
    }
}