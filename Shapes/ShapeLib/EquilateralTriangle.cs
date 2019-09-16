using System;

namespace ShapeLib
{
    public class EquilateralTriangle : Triangle, IShapeData
    {
        public EquilateralTriangle(string colour, double sideLength) : base(colour, sideLength, sideLength, sideLength) { }

        public double GetArea()
        {
            return Math.Sqrt(3) * Side1Length * Side1Length / 4;
        }
    }
}
