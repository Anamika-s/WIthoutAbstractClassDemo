using System;

namespace AbstractClass_InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square -------- ");
            Square square = new Square();
            square.GetDimensions();
            square.CalculateArea();
            square.DisplayArea();

            Console.WriteLine("Rectangle -------- ");
            Rectangle rectangle = new Rectangle();
            rectangle.GetDimensions();
            rectangle.CalculateArea();
            rectangle.DisplayArea();

            Console.WriteLine("Triangle -------- ");
            Triangle triangle = new Triangle();
            triangle.GetDimensions();
            triangle.CalculateArea();
            triangle.DisplayArea();

        }
    }
}
