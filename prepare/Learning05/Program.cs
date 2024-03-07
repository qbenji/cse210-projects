using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();                             // create a list of shapes

        Square sq = new Square("Red", 3);               shapes.Add(sq);     // create a red square of length 3 and add it to the list
        Rectangle rec = new Rectangle("Blue", 4, 5);    shapes.Add(rec);    // create a blue rectangle of length 4 and width 5 and add it to the list
        Circle cir = new Circle("Green", 6);            shapes.Add(cir);    // create a green circle of radius 6 and add it to the list

        foreach (Shape s in shapes)                                         // loop through the list of shapes and call the GetArea and GetColor methods on each shape and print each result
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}