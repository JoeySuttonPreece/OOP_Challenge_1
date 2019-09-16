namespace ShapeLib
{
    public class Rectangle : Quadrilateral, IShapeData
    {
        public Rectangle(string colour, double width, double height) : base(colour, width, height, width, height) { }

        public double GetArea()
        {
            return Side1Length * Side2Length;
        }
    }
}
