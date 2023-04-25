using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{

    public interface ICommand
    {
        // The operations that the customer can do on the bulb are defined in the interface.
        void Execute();
        void Undo();
        void Redo();
    }
}
