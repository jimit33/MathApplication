using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shape circle = new Circle("circle1", 5);
            Shape square = new Quadrilaterals("Square1", 5, 5);
            circle.CalculateArea();
            square.CalculatePerimeter();
            Console.ReadLine();
        }
    }
}
