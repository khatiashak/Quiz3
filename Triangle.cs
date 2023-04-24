using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Triangle : IShape
    {
        private double _SideA;
        private double _SideB;
        private double _SideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _SideA = sideA;
            _SideB = sideB;
            _SideC = sideC;
        }

        // Methods
        public double GetPerimeter()
        {
            return _SideA + _SideB + _SideC;
        }

        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - _SideA) * (p - _SideB) * (p - _SideC));
        }
    }
}
