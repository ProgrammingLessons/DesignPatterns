using System.Drawing;

namespace DecoratorDesignPattern
{
    // Component part is defined
    interface IShape
    {
        void Draw(Size size, int location);
    }
}
