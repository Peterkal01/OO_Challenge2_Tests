using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        public double Side1Length { get; set; }
        public double Side2Length { get; set; }
        public double Side3Length { get; set; }

        public Triangle(string sColour, double s1, double s2, double s3) : base(sColour)
        {
            Side1Length = s1;
            Side2Length = s2;
            Side3Length = s3;
        }

        public double GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }

    }
}
