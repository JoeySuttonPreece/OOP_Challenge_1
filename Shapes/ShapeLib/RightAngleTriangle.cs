using System;

namespace ShapeLib
{
    public class RightAngleTriangle : Triangle, IShapeData
    {
        public RightAngleTriangle(string colour, double side1Length, double side2Length)
            : base(colour, side1Length, side2Length, Math.Sqrt(side1Length * side1Length + side2Length * side2Length)) { }

        public double GetArea()
        {
            return Side1Length * Side2Length / 2;
        }

        public double GetHypotenuse()
        {
            return Math.Sqrt(Side1Length * Side1Length + Side2Length * Side2Length);
        }
    }
}
