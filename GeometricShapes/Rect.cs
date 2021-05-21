using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Rect
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public int Perimeter()
        {
            return Length + Length + Width + Width;
        }
        public int Area()
        {
            return Length * Width;
        }
        public Rect(int s1, int s2)
        {
            Length = s1;
            Width = s2;
        }
    }
}
