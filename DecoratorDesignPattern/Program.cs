using System;
using System.Drawing;

namespace DecoratorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle");
            Circle circle = new Circle();
            circle.Draw(new Size(3, 10), 100);

            Console.WriteLine("\nCircleEdge");
            Console.WriteLine("****************");
            // An object of class CircleEdge is created
            CircleEdge circleEdge = new CircleEdge(circle);
            // The overridden method is called.
            circleEdge.Draw(new Size(3, 10), 100);

            Console.WriteLine("\nCircleFill");
            Console.WriteLine("****************");
            // An object of class CircleFill is created
            CircleFill circleFill = new CircleFill(circle);
            // The overridden method is called.
            circleFill.Draw(new Size(3, 10), 100);

            Console.WriteLine("\nCircleFull");
            Console.WriteLine("****************");
            // An object of class CircleFull is created
            CircleFull circleFull = new CircleFull(circle);
            // The overridden method is called.
            circleFull.Draw(new Size(3, 10), 100);
        }
    }
}
