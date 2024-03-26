using System;

namespace Harjoitus2_Opiskelija
{
    class Progam
    { 
    static void Main(string[] args)
    {
        //luodaan Opiskelija olio
        Opiskelija opiskelija1 = new Opiskelija("Matti", "TVT1234", 0);

        opiskelija1.TulostaData();
        opiskelija1.MuokkaaOpintopisteitä(5);
        opiskelija1.TulostaData();

        }
    }
}