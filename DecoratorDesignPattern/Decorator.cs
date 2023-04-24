using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    // The Decorator class is defined.
    class Decorator : IShape
    {
        readonly IShape _shape;
        // Constracture is defined
        public Decorator(IShape shape)
        {
            _shape = shape;
        }

        // Virtual is used to override.
        public virtual void Draw(Size size, int location)
        {
            _shape.Draw(size, location);
        }
    }
}
