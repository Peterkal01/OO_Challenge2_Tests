using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string sColour, double Length, double Width) : base(sColour, Length, Width, Length, Width)
        {
        }

        public double GetArea()
        {
            return Side1Length * Side2Length;
        }
        public override string ToString()
        {
            return "Color: " + Colour + "  Side Length: " + Side1Length + "  Area: " + GetArea();
        }

    }
}
