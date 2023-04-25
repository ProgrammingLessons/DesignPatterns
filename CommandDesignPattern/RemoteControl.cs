using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    // Invoker
    // The class that the client interacts with
    public class RemoteControl
    {
        // Can run the bulb's commands via the method
        public void Submit(ICommand command)
        {
            command.Execute();
        }
    }
}
