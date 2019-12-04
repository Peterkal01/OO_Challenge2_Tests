using System;
using NUnit.Framework;
using ShapeLibrary;


namespace Quadrilateral_Tests
{
    [TestFixture]
    public class Tests
    {
        Square sq1 { get; set; }
        Rectangle rec1 { get; set; }

        Square sq2 { get; set; }
        Rectangle rec2 { get; set; }

        [SetUp]
        public void Init()
        {
            sq1 = new Square("Blue", 5);
            rec1 = new Rectangle("Red", 4, 3);

            sq2 = new Square("Blue", 6);
            rec2 = new Rectangle("Red", 5, 4);
        }

        [Test]
        [TestCase(5, 25)]
        [TestCase(15, 225)]
        [TestCase(7, 49)]
        public void Square_GetArea_ValidInput_CorrectReturn(int side, int expected)
        {

            var sq = new Square("blue", side);
            var result = sq.GetArea();

            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase(5, 20)]
        [TestCase(15, 60)]
        [TestCase(7, 28)]
        public void Square_GetPerimeter_ValidInput_CorrectReturn(int side, int expected)
        {
            var sq = new Square("blue", side);
            var result = sq.GetPerimeter();

            Assert.AreEqual(result, expected);
        }


        [Test]
        [TestCase(5, 10, 50)]
        [TestCase(4, 6, 24)]
        [TestCase(9, 7, 63)]
        public void Rectangle_GetArea_ValidInput_CorrectReturn(double side1, double side2, double expected)
        {

            var rec = new Rectangle("blue", side1, side2);
            var result = rec.GetArea();

            Assert.AreEqual(result, expected);


        }


        [Test]
        [TestCase(5, 10, 30)]
        [TestCase(4, 6, 20)]
        [TestCase(9, 7, 32)]
        public void Rectangle_GetPerimeter_ValidInput_CorrectReturn(double side1, double side2, double expected)
        {

            var rec = new Rectangle("blue", side1, side2);
            var result = rec.GetPerimeter();

            Assert.AreEqual(result, expected);


        }

    }
}