using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public abstract class Quadrilateral : Shape, IShapeCalc
    {
        public double Side1Length { get; set; }
        public double Side2Length { get; set; }
        public double Side3Length { get; set; }
        public double Side4Length { get; set; }

        public Quadrilateral(string sColour, double s1, double s2, double s3, double s4) : base(sColour)
        {

            Side1Length = s1;
            Side2Length = s2;
            Side3Length = s3;
            Side4Length = s4;

        }

        public virtual double GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length + Side4Length;

        }
        public override string ToString()
        {
            return "Color: " + Colour + " Perimeter: " + GetPerimeter() + "  Area: " + GetArea() + " ";
        }


        public virtual double GetArea()
        {
            return Side1Length * Side2Length;
        }

        
    }
}
