public class Circle : Shape
{
    private double _radius;                                         // initialize _radius to blank

    public Circle(string color, double radius) : base (color)       // constructor
    {
        _radius = radius;
    }

    public override double GetArea()                                // get area
    {
        return Math.Pow(_radius,2) * Math.PI;
    }
}