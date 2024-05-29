using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_20
{
    class Opiskelija
    {
        string etunimi;
        string sukunimi;
        string puhelinnumero;
        string sähköposti;
        string opiskelijaID;

        public Opiskelija(string etunimi, string sukunimi, string puhelinnumero, string sähköposti, string opiskelijaID)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Puhelinnumero = puhelinnumero;
            Sähköposti = sähköposti;
            OpiskelijaID = opiskelijaID;
        }

        public string Etunimi { get => etunimi; set => etunimi = value; }
        public string Sukunimi { get => sukunimi; set => sukunimi = value; }
        public string Puhelinnumero { get => puhelinnumero; set => puhelinnumero = value; }
        public string Sähköposti { get => sähköposti; set => sähköposti = value; }
        public string OpiskelijaID { get => opiskelijaID; set => opiskelijaID = value; }
    }
}