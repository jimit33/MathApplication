using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    class Quadrilaterals : Shape
    {
        private String _name;
        private float _width;
        private float _length;
        public Quadrilaterals(String name, float width, float length)
        {
            Name = name;
            _width = width;
            _length = length;
        }

        public string Name { get => _name; set => _name = value; }
        public float Width { get => _width; set => _width = value; }
        public float Length { get => _length; set => _length = value; }

        public override void CalculateArea()
        {
            this.Area = Width * Length;
            Console.WriteLine("Area of " + this.Name + " is " + this.Area);
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = 2 * (Width + Length);
            Console.WriteLine("Perimeter of " + this.Name + " is " + this.Perimeter);
        }
    }
}
