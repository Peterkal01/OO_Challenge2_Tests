using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Square : Quadrilateral
    {
        public Square(string sColour, double SideLength) : base(sColour, SideLength, SideLength, SideLength, SideLength)
        {
           
        }

        public double GetArea()
        {
            return Side1Length * Side1Length;
        }

        public override string ToString()
        {
            return "Color: " + Colour + "  Side Length: " + Side1Length + "  Area: " + GetArea();
        }
    }
}
