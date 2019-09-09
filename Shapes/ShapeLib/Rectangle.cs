namespace ShapeLib
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string colour, int width, int height) : base(colour, width, height, width, height) { }

        public int GetArea()
        {
            return Side1Length * Side2Length;
        }
    }
}
