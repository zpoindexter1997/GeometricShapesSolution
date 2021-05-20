/* 
Homework
Create a new project called GeometricShapes

Create a class for Quadrilateral(Quad)
Have properties that you can keep track of the 4 sides
Have a method for perimeter of the Quad
Perimeter- sum of length of all sides

Create another class for a Rectangle (Rect) (opposite sides are =)
Have properties that you can keep track of the 4 sides
Have a method for perimeter of the Rect
Have a method to calculate area (l * w)


Create a class for a square (all sides are =)
Have properties that you can keep track of
Have a method for perimeter of the Sqr
Have a method for area (l^2)
*/

using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqr1 = new Sqr();
            sqr1.Side = 4;
            var rect1 = new Rect();
            rect1.Length = 7;
            rect1.Width = 5;
            var quad1 = new Quad();
            quad1.SideA = 4;
            quad1.SideB = 6;
            quad1.SideC = 9;
            quad1.SideD = 2;
            Console.WriteLine($"The perimeter of the square is {sqr1.Perimeter()} and the area is {sqr1.Area()}");
            Console.WriteLine($"The perimeter of the rectangle is {rect1.Perimeter()} and the area is {rect1.Area()}");
            Console.WriteLine($"The perimeter of the quadrilater is {quad1.Perimeter()}");
        }
    }
}
