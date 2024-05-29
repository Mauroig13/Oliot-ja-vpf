using Harjoitus6_Eläimet;
using System;

namespace Harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa.KuinkaMonta(); 
            Koira.KuinkaMonta(); 
            Eläimet.KuinkaMonta(); 

            Kissa kissa1 = new Kissa("Esim1kissa", 1);
            Kissa kissa2 = new Kissa("Esim2kissa", 3);
            Koira koira1 = new Koira("Esim1koira", 2);
            Koira koira2 = new Koira("Esim2koira", 4);

            // Äännellään 
            kissa1.Ääntele();
            koira1.Ääntele();

            
            Kissa.KuinkaMonta(); // Koiria 2 
            Koira.KuinkaMonta(); // Kissoja 2 
            Eläimet.KuinkaMonta(); // Eläimiä 4 

            kissa2.Ääntele();
            koira2.Ääntele();
        }
    }
}