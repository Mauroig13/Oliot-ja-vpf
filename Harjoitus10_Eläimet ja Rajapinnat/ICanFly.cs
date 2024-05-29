using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    interface ICanFly
    {
        public float WingSize { get; set; }

        public void Fly();
    }
}