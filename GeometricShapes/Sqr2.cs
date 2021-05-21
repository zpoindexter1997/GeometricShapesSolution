using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Sqr2
    {
        public Rect quad { get; set; }
        public int Perimeter()
        {
            return quad.Perimeter();
        }
        public int Area()
        {
            return quad.Area();
        }
        public Sqr2(int s1)
        {
           quad = new Rect(s1, s1);
        }
    }
}
