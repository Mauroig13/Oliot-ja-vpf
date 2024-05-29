using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_23
{
    class Kiuas
    {
        public int Lämpötila { get; set; }
        public int Kosteus { get; set; }
        public bool OnkoPäällä { get; set; }

        public void VaihdaLämpötila(int uusiLämpötila)
        {
            Lämpötila = uusiLämpötila;

            if (Lämpötila > 120)
                Lämpötila = 120;

            if (Lämpötila < 10)
                Lämpötila = 10;
        }

        public void VaihdaKosteutta(int uusiKosteus)
        {
            Kosteus = uusiKosteus;

            if (Kosteus > 100)
                Kosteus = 100;

            if (Kosteus < 0)
                Kosteus = 0;
        }
    }
}