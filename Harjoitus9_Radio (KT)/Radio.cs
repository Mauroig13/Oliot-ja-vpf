using System;

namespace Harjoitus9KT
{
    public class Radio
    {
        private bool _paalla;
        private int _aanenvoimakkuus;
        private double _taajuus;

        public bool Paalla
        {
            get => _paalla;
            set
            {
                _paalla = value;
                Console.WriteLine(_paalla ? "Radio on päällä." : "Radio on pois päältä.");
            }
        }

        public int Aanenvoimakkuus
        {
            get => _aanenvoimakkuus;
            set
            {
                if (value < 0) _aanenvoimakkuus = 0;
                else if (value > 9) _aanenvoimakkuus = 9;
                else _aanenvoimakkuus = value;
                Console.WriteLine($"Äänenvoimakkuus on asetettu arvoon: {_aanenvoimakkuus}");
            }
        }

        public double Taajuus
        {
            get => _taajuus;
            set
            {
                if (value < 88.0) _taajuus = 88.0;
                else if (value > 107.9) _taajuus = 107.9;
                else _taajuus = value;
                Console.WriteLine($"Taajuus on asetettu arvoon: {_taajuus}");
            }
        }

        public Radio()
        {
            _paalla = false;
            _aanenvoimakkuus = 0;
            _taajuus = 88.0;
        }
    }
}
