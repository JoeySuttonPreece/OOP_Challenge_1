namespace ShapeLib
{
    public class Circle : Shape, IShapeData
    {
        public const double PI = 3.142;
        public double Radius;

        public Circle(string colour, double radius) : base(colour)
        {
            Radius = radius;
        }

        public double GetPerimeter()
        {
            return 2 * PI * Radius;
        }

        public double GetArea()
        {
            return PI * Radius * Radius;
        }
    }
}
