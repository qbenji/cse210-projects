using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();         // create a list of shapes

        Square sq = new Square("Red", 3);               // create a red square of length 3
        shapes.Add(sq);                                 // add the square to the list

        Rectangle rec = new Rectangle("Blue", 4, 5);    // create a blue rectangle of length 4 and width 5
        shapes.Add(rec);                                // add the rectangle to the list

        Circle cir = new Circle("Green", 6);            // create a green circle of radius 6
        shapes.Add(cir);                                // add the circle to the list

        foreach (Shape s in shapes)                     // loop through the list of shapes
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}