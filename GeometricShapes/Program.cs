using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqr3 = new Sqr3(7);
            Console.WriteLine($"The perimeter of the square is {sqr3.Perimeter()} and the area is {sqr3.Area()}");


            var rect3 = new Rect3(5,2);
            Console.WriteLine($"The perimeter of the square is {rect3.Perimeter()}");

            var x = 0;


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
