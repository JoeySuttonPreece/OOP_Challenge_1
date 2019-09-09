using System;
using NUnit.Framework;
using ShapeLib;

namespace ShapeTests
{
    public class Tests
    {
        [TestCase("Blue", 4, 16, 16)]
        [TestCase("Blue", 6, 36, 24)]
        [TestCase("Blue", 5, 25, 20)]
        [TestCase("Blue", 15, 225, 60)]
        [TestCase("Blue", 7, 49, 28)]
        public void SquareTest(string colour, int sideLength, int area, int perimeter)
        {
            Square square = new Square(colour, sideLength);

            Assert.AreEqual(area, square.GetArea());
            Assert.AreEqual(perimeter, square.GetPerimeter());
        }

        [TestCase("Red", 4, 3, 12, 14)]
        [TestCase("Red", 5, 4, 20, 18)]
        [TestCase("Red", 5, 10, 50, 30)]
        [TestCase("Red", 4, 6, 24, 20)]
        [TestCase("Red", 9, 7, 63, 32)]
        public void RectangleTest(string colour, int width, int height, int area, int perimeter)
        {
            Rectangle rectangle = new Rectangle(colour, width, height);

            Assert.AreEqual(area, rectangle.GetArea());
            Assert.AreEqual(perimeter, rectangle.GetPerimeter());
        }

        [TestCase("a", typeof(FormatException))]
        [TestCase("-23", typeof(LessThanOneException))]
        [TestCase("2.3", typeof(DecimalInputException))]
        public void ExceptionTest(string input, Type e)
        {
            Assert.Throws(e , delegate {
                float num = float.Parse(input);

                if (num < 1)
                {
                    throw new LessThanOneException();
                }

                if (num != (int)num)
                {
                    throw new DecimalInputException();
                }
            });
        }
    }
}