public class Rectangle : Shape
{
    private double _length;                                         // initialize _length to blank
    private double _width;                                          // initialize _width to blank

    public Rectangle(string color, double length, double width)     // constructor
        : base (color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()                                // get area
    {
        return _length * _width;
    }
}