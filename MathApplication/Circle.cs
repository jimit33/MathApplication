using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    class Circle : Shape
    {
        private String _name;
        private float _radius;
        private float _pi = 3.14F;
        public Circle(String name, float radius)
        {
            _name = name;
            _radius = radius;
        }
        public float Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        public new String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public override void CalculateArea()
        {
            this.Area = _pi * (_radius * _radius);
            Console.WriteLine("Area of " + this.Name + " is " + this.Area);
        }
        public override void CalculatePerimeter()
        {
            this.Perimeter = 2 * _pi * _radius;
            Console.WriteLine("Perimeter of " + this.Name + " is " + this.Perimeter);
        }
    }
}
