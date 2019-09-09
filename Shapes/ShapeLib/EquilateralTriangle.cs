using System;

namespace ShapeLib
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(string colour, float sideLength) : base(colour, sideLength, sideLength, sideLength) { }

        public float GetArea()
        {
            return (float)Math.Sqrt(3) * Side1Length * Side1Length / 4;
        }
    }
}
