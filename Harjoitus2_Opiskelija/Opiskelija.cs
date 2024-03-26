using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2_Opiskelija
{
    class Opiskelija
    {
        private string Nimi {  get; set; }
        private string OpiskelijaID { get; set; }
        private int Opintopisteet { get; set; }


        //Konstruktori Opiskelija -luokalle
        public Opiskelija(string _nimi, string _id, int _op)
        {
            Nimi = _nimi;
            OpiskelijaID = _id;
            Opintopisteet = _op;
        }   

        public void TulostaData()
        {
            Console.WriteLine("");
            Console.WriteLine("Opiskelija: ");
            Console.WriteLine("-- Nimi: " + Nimi);
            Console.WriteLine("-- Opiskelija ID: " + OpiskelijaID);
            Console.WriteLine("--Opintopisteet: " + Opintopisteet);
            Console.WriteLine("");
        }
            

        //Metodi, joka ottaa parametriksi integer - arvon.
        public void MuokkaaOpintopisteitä(int i)
        {
            Opintopisteet += i;

            if (Opintopisteet < 0)
            {
                Opintopisteet = 0;
            }
        }
    }
}
