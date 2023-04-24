using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Trapeze
    {
        private double _LeftSide;
        private double _RightSide;
        private double _TopSide;
        private double _BottomSide;
        private double _Height;

        public Trapeze(double LeftSide, double RightSide, double TopSide, double BottomSide, double Height)
        {
            _LeftSide = LeftSide;
            _RightSide = RightSide;
            _TopSide = TopSide;
            _BottomSide = BottomSide;
            _Height = Height;
        }

        public double GetPerimeter()
        {
            return _TopSide + _BottomSide + _LeftSide + _RightSide;
        }

        public double GetArea()
        {
            return ((_TopSide + _BottomSide) * _Height) / 2;
        }

    }

}
