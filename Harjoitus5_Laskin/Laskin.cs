﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus5_Laskin
{
    // Staattinen luokka määritellään lisäämällä "static" avainsana "class" määrittelyn eteen.
    static class Laskin
    {
        // Staattinen metodi, joka palauttaa float-tyyppisen arvon return-lauseella ja saa parametreikseen kaksi float-arvoa.
        // Esimerkiksi pääohjelmassa kutsumalla "float a = Laskin.Summa(10, 15)" asettaisi muuttujan "a" arvoksi 25.
        public static float Summa(float a, float b)
        {
            return a + b;
        }

        public static float Erotus(float a, float b)
        {
            return a - b;
        }

        public static float Kertolasku(float a, float b)
        {
            return a * b;
        }

        public static float Jakolasku(float a, float b)
        {
            return a / b;
        }
    }
}
