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
        public void SquareTest(string colour, double sideLength, double area, double perimeter)
        {
            Square square = new Square(colour, sideLength);

            Assert.AreEqual(area, square.GetArea());
            Assert.AreEqual(perimeter, square.GetPerimeter());

            Assert.IsTrue(square is IShapeData);
        }

        [TestCase("Red", 4, 3, 12, 14)]
        [TestCase("Red", 5, 4, 20, 18)]
        [TestCase("Red", 5, 10, 50, 30)]
        [TestCase("Red", 4, 6, 24, 20)]
        [TestCase("Red", 9, 7, 63, 32)]
        public void RectangleTest(string colour, double width, double height, double area, double perimeter)
        {
            Rectangle rectangle = new Rectangle(colour, width, height);

            Assert.AreEqual(area, rectangle.GetArea());
            Assert.AreEqual(perimeter, rectangle.GetPerimeter());

            Assert.IsTrue(rectangle is IShapeData);
        }

        [TestCase("a", typeof(FormatException))]
        [TestCase("-23", typeof(LessThanOneException))]
        [TestCase("2.3", typeof(DecimalInputException))]
        public void ExceptionTest(string input, Type e)
        {
            Assert.Throws(e, delegate
            {
                float num = float.Parse(input);

                if (num < 1)
                {
                    throw new LessThanOneException();
                }

                if (num % 1 != 0)
                {
                    throw new DecimalInputException();
                }
            });
        }

        [TestCase("Green", 5, 10.83, 15)]
        [TestCase("Green", 15, 97.43, 45)]
        [TestCase("Green", 7, 21.22, 21)]
        public void EquilateralTriangleTest(string colour, double sideLength, double area, double perimeter)
        {
            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(colour, sideLength);

            Assert.AreEqual(area, Math.Round(equilateralTriangle.GetArea(), 2));
            Assert.AreEqual(perimeter, Math.Round(equilateralTriangle.GetPerimeter(), 2));

            Assert.IsTrue(equilateralTriangle is IShapeData);
        }

        [TestCase("Orange", 5, 10, 25, 26.18)]
        [TestCase("Orange", 4, 6, 12, 17.21)]
        [TestCase("Orange", 9, 7, 31.5, 27.4)]
        public void RightAngleTriangleTest(string colour, double width, double height, double area, double perimeter)
        {
            RightAngleTriangle rightAngleTriangle = new RightAngleTriangle(colour, width, height);

            Assert.AreEqual(area, Math.Round(rightAngleTriangle.GetArea(), 2));
            Assert.AreEqual(perimeter, Math.Round(rightAngleTriangle.GetPerimeter(), 2));

            Assert.IsTrue(rightAngleTriangle is IShapeData);
        }

        [TestCase("Purple", 5, 78.55, 31.42)]
        [TestCase("Purple", 15, 706.95, 94.26)]
        [TestCase("Purple", 7, 153.96, 43.99)]
        public void CircleTest(string colour, double radius, double area, double perimeter)
        {
            Circle circle = new Circle(colour, radius);

            Assert.AreEqual(area, Math.Round(circle.GetArea(), 2));
            Assert.AreEqual(perimeter, Math.Round(circle.GetPerimeter(), 2));

            Assert.IsTrue(circle is IShapeData);
        }
    }
}
