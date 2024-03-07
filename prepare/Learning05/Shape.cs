public abstract class Shape
{
    private string _color;              // initialize _color to an empty string

    public Shape(string color)          // constructor
    {
        _color = color;
    }

    public string GetColor()            // get color
    {
        return _color;
    }

    public void SetColor(string color)  // set color
    {
        _color = color;
    }

    public abstract double GetArea();   // get area (abstract method)
}