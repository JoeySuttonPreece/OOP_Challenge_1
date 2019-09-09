namespace ShapeLib
{
    public class Square : Quadrilateral
    {
        public Square(string colour, int sideLength) : base(colour, sideLength, sideLength, sideLength, sideLength) { }

        public int GetArea()
        {
            return Side1Length * Side1Length;
        }
    }
}
