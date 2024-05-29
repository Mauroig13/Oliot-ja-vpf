using Harjoitus26_Oma_SovellusWPF__KT_;
using System;
using System.Collections.Generic;

namespace Harjoitus26_Oma_SovellusWPF__KT_
{
    public class Tehtavalista
    {
        private List<Tehtava> tehtavat;

        public Tehtavalista()
        {
            tehtavat = new List<Tehtava>();
        }

        public void LisaaTehtava(Tehtava tehtava)
        {
            if (string.IsNullOrWhiteSpace(tehtava.Nimi))
            {
                throw new ArgumentException("Tehtävällä tulee olla nimi.");
            }

            tehtavat.Add(tehtava);
        }

        public void PoistaTehtava(Tehtava tehtava)
        {
            tehtavat.Remove(tehtava);
        }

        public void SuoritaKaikkiTehtavat()
        {
            foreach (Tehtava tehtava in tehtavat)
            {
                tehtava.Suorita();
            }
        }
    }
}
