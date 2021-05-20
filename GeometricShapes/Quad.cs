

using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Quad
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public int SideD { get; set; }

        public int Perimeter()
        {
            return SideA + SideB + SideC + SideD;
        }
    }
}
