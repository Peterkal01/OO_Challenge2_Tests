using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class RightAngle : Triangle
    {
        public RightAngle(string sColour, double s1, double s2, double s3) : base(sColour, s1, s2, s3)
        {

        }

        public double GetArea()
        {
            return (Side1Length * Side2Length * (double)Math.Sqrt(Side1Length * Side1Length + Side2Length * Side2Length));
        }
    }
}
