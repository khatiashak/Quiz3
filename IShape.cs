using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;

public interface IShape
{
    double GetArea();
    double GetPerimeter();
}

public class Triangle2 : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double Side1 { get; set; }
    public double Side2 { get; set; }

    public double GetArea()
    {
        return 0.5 * Base * Height;
    }

    public double GetPerimeter()
    {
        return Base + Side1 + Side2;
    }
}

public class Rectangle2 : IShape
{
    public double length { get; set; }
    public double width { get; set; }

    public double GetArea()
    {
        return width * length;
    }

    public double GetPerimeter()
    {
        return 2 * (width + length);
    }
}
