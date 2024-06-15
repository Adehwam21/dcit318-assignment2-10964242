using System;

class Program
{
    // Abstract base class
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    
    public class Circle : Shape     // Derived class which inherits from abstract base class
    {
        public int Radius { get; set; }

        // Constructor 
        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public override double GetArea()    // Overriding abstract method
        {
            return Math.PI * (this.Radius * this.Radius);
        }
    }

    public class Rectangle : Shape      // Derived class which inherits from abstract base class
    {
        public int Length { get; set; }
        public int Width { get; set; }

        // Constructor
        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double GetArea()    // Overriding abstract method
        {
            return 1.0 * (this.Length * this.Width);
        }
    }

    public static void Main(string[] args)
    {

        Circle circle = new Circle(radius: 5);  // Instance of Circle
        Rectangle rectangle = new Rectangle(length: 2, width: 3);   // Instance of Rectangle

        Console.WriteLine($"A circle of radius {circle.Radius} must have an area of {circle.GetArea()} sq.units");
        Console.WriteLine($"A rectangle of length {rectangle.Length} and width {rectangle.Width} must have an area of {rectangle.GetArea()} sq.units");

    }
}

