using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Equilateral : Triangle
    {
        public Equilateral(string sColour, double s1) : base(sColour, s1, s1, s1)
        {
           
        }

       public double GetArea()
        {
            return Math.Sqrt(3)/(4)*(Side1Length * Side1Length);
        }
        public override string ToString()
        {
            return "Color: " + Colour + "  Side Length: " + Side1Length + "  Area: " + GetArea();
        }


    }
}
