﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Quadrilateral : Shape
    {
        public double Side1Length { get; set; }
        public double Side2Length { get; set; }
        public double Side3Length { get; set; }
        public double Side4Length { get; set; }

        public Quadrilateral(string sColour, double s1, double s2, double s3, double s4) : base(sColour, s1, s2, s3, s4)
        {

            Side1Length = s1;
            Side2Length = s2;
            Side3Length = s3;
            Side4Length = s4;

        }

        public double GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length + Side4Length;

        }
    }
}