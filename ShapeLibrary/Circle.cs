using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Circle : Shape
    {
        public readonly double PI = Math.Round(Math.PI, 3);
        public double Pi { get; set; }
        public double Radius { get; set; }


        public Circle(string sColour, double r) : base(sColour)
        {       
            Radius = r;
        }

        public double GetPerimeter()
        {
            double perimeter = 2 * PI * Radius;
            return Math.Round(perimeter, 2);
        }

        public double GetArea()
        {
            double area = PI * Radius * Radius;
            return Math.Round(area, 2);
        }

        public override string ToString()
        {
            return "Color: " + Colour + " Radius: " + Radius + " " +"  Area: " + " " + GetArea() + "Perimeter: " + GetPerimeter();
        }

    }
}
