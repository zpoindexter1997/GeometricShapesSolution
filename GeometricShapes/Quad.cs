

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
        public Quad(int s1, int s2, int s3, int s4)
        {
            SideA = s1;
            SideB = s2;
            SideC = s3;
            SideD = s4;
        }
    }
}
