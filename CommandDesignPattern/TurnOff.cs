using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    // When the TurnOff command is run,
    // the operations to be performed are inherited from the ICommand interface.
    public class TurnOff : ICommand
    {
        private Bulb _bulb;
        // In the constructor method, the bulb object is given as a parameter
        public TurnOff(Bulb bulb)
        {
            _bulb = bulb ?? throw new ArgumentNullException("Bulb", "Bulb cannot be null");
        }
        //  This is what the command will do.
        public void Execute()
        {
            _bulb.TurnOff();
        }

        // Running the command again
        public void Redo()
        {
            Execute();
        }

        // undo command
        public void Undo()
        {
            _bulb.TurnOn();
        }
    }
}
