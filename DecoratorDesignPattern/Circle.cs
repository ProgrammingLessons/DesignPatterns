using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    // ConcreteComponent part is defined
    class Circle : IShape
    {
        // The draw method is implemented.
        public void Draw(Size size, int location)
        {
            Console.WriteLine("The circle has been drawn.");
        }
    }
}
