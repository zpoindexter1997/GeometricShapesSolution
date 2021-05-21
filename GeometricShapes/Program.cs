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
            var sqr1 = new Sqr(9);
            var rect1 = new Rect(7,2);
            var quad1 = new Quad(4,6,1,3);
            Console.WriteLine($"The perimeter of the square is {sqr1.Perimeter()} and the area is {sqr1.Area()}");
            Console.WriteLine($"The perimeter of the rectangle is {rect1.Perimeter()} and the area is {rect1.Area()}");
            Console.WriteLine($"The perimeter of the quadrilater is {quad1.Perimeter()}");
            var sqr2 = new Sqr2(5);
            var rect2 = new Rect2(6, 3);
        }
    }
}
