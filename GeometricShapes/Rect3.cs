﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Rect3 : Quad
    {
        public Rect3() { }

        public Rect3(int s1, int s2) : base(s1, s2, s1, s2) { }
        public int Area()
        {
            return SideA * SideB;
        }


    }
}
