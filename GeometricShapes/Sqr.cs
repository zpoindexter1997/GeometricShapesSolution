using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Sqr
    {
        public int Side { get; set; }

        public int Perimeter()
        {
            return Side * 4;
        }
        public int Area()
        {
            return Side * Side;
        }
        public Sqr(int s1)
        {
            Side = s1;
        }
    }
}
