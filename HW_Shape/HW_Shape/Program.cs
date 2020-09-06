using System;

namespace HW_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangle
            double l = 5;
            double w = 3;
            var rectangleLengths = new double[] { l, w };

            var rectangle = new Rectangle();
            
            var rectangleCircumference = rectangle.GetCircumference(rectangleLengths);
            var rectangleArea = rectangle.GetArea(rectangleLengths);

            Console.WriteLine("Rectagle.");
            Console.WriteLine("Length is: {0}. Width is: {1}.", l, w);
            Console.WriteLine("Circumference is {0}.", rectangleCircumference);
            Console.WriteLine("Area is {0}.", rectangleArea);
            Console.WriteLine();

            // Circle
            double r = 6;
            var circleLengths = new double[] { r };

            var circle = new Circle();

            var circleCircumference = circle.GetCircumference(circleLengths);
            var circleArea = circle.GetArea(circleLengths);

            Console.WriteLine("Circle.");
            Console.WriteLine("Radius is: {0}.", r);
            Console.WriteLine("Circumference is {0}.", circleCircumference);
            Console.WriteLine("Area is {0}.", circleArea);
            Console.WriteLine();

            // Triangle

            double a = 2;
            double b = 4;
            double c = 3;
            var triangleLengths = new double[] { a, b, c };

            var triangle = new Triangle();


            var triangleCircumference = triangle.GetCircumference(triangleLengths);
            var triangleArea = triangle.GetArea(triangleLengths);

            Console.WriteLine("Triangle.");
            Console.WriteLine("Three sides are: a = {0}, b = {1}, c = {2}.", a, b, c);
            Console.WriteLine("Circumference is {0}.", triangleCircumference);
            Console.WriteLine("Area is {0}.", triangleArea);
            Console.WriteLine();

        }
    }
}
