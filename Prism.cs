using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        public class Prism
        {

        private double _BaseArea;
        private double _Height;

        public Prism(double BaseArea, double Height)
        {
            _BaseArea = BaseArea;
            _Height = Height;
        }

        // Methods
        public double Volume()
            {
                return _BaseArea * _Height;
            }

            public double SurfaceArea()
            {
                double lateralArea = 2 * Math.PI * (_BaseArea / (2 * Math.PI)) * _Height;
                double baseArea = _BaseArea * 2;
                return lateralArea + baseArea;
            }
        }
    }
