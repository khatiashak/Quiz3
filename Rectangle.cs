using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Rectangle : IShape
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public double GetArea()
        {
            return _length * _width;
        }

        public double GetPerimeter()
        {
            return 2 * (_length + _width);
        }

 
    }
}
