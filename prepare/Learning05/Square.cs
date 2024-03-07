public class Square : Shape
{
    private double _length;                                         // initialize _length to blank

    public Square(string color, double length) : base (color)       // constructor
    {
        _length = length;
    }

    public override double GetArea()                                // get area
    {
        return _length * _length;
    }
}