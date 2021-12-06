using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    abstract class Shape
    {
        private String _name;
        private float _perimeter;
        private float _area;
        public float Area
        {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
            }
        }
        public float Perimeter
        {
            get
            {
                return _perimeter;
            }
            set
            {
                _perimeter = value;
            }
        }
        public String Name
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

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }
}
