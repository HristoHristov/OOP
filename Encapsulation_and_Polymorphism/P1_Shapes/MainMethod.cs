using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Shapes
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle("Triangle", 2, 5, 20, 5);

            Rectangle rect = new Rectangle("Rectangle", 10, 10);

            Circle circle = new Circle("Circle", 5);

            BasicShape[] shapes = { triangle, rect, circle };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0}   Area: {1};   Perimeter: {2}", shape.ShapeName, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
