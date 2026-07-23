using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Circle
            Console.Write("Enter radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circleArea = CalculateCircleArea(radius);
            Console.WriteLine("Area of the circle: " + circleArea);

            // Rectangle
            Console.Write("Enter length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            double rectangleArea = CalculateRectangleArea(length, width);
            Console.WriteLine("Area of the rectangle: " + rectangleArea);

            // Triangle
            Console.Write("Enter base of the triangle: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double triangleArea = CalculateTriangleArea(baseLength, height);
            Console.WriteLine("Area of the triangle: " + triangleArea);
        }

        static double CalculateCircleArea(double radius)
        {
            const double Pi = 3.14159;
            return Pi * radius * radius;
        }

        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
    }
}

