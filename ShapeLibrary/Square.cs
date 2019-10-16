using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Square : Quadrilateral
    {
        public Square(string sColour, int SideLength) : base(sColour, SideLength, SideLength, SideLength, SideLength)
        {
           
        }

        public double GetArea()
        {
            return Side1Length * Side1Length;
        }
        
    }
}
