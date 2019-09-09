using System;

namespace ShapeLib
{
    public class RightAngleTriangle : Triangle
    {
        public RightAngleTriangle(string colour, float side1Length, float side2Length)
            : base(colour, side1Length, side2Length, (float)Math.Sqrt(side1Length * side1Length + side2Length * side2Length)) { }

        public float GetArea()
        {
            return Side1Length * Side2Length / 2;
        }
    }
}
