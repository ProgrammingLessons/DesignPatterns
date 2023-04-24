using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    // CircleFull class is defined
    class CircleFull : Decorator
    {
        readonly IShape _shape;
        // The shape object is sent with base to the Decorator class, which takes a parameter.
        public CircleFull(IShape shape) : base(shape)
        {
            _shape = shape;
        }

        private void ColorEdge()
        {
            Console.WriteLine("The edges are colored.");
        }
        private void ColorFill()
        {
            Console.WriteLine("The interior has been colored.");
        }

        public override void Draw(Size size, int location)
        {
            // Calling the Draw method in the Circle class. 
            base.Draw(size, location);
            ColorEdge();
            ColorFill();
        }
    }
}
