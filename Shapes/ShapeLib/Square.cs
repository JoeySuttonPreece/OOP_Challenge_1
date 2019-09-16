namespace ShapeLib
{
    public class Square : Quadrilateral, IShapeData
    {
        public Square(string colour, double sideLength) : base(colour, sideLength, sideLength, sideLength, sideLength) { }

        public double GetArea()
        {
            return Side1Length * Side1Length;
        }
    }
}
