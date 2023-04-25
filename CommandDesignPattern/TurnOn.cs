using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    // When the TurnOn command is run,
    // the operations to be performed are inherited from the ICommand interface.
    public class TurnOn : ICommand
    {
        private Bulb _bulb;
        // In the constructor method, the bulb object is given as a parameter
        public TurnOn(Bulb bulb)
        {
            _bulb = bulb ?? throw new ArgumentNullException("Bulb", "Bulb cannot be null");
        }

       //  This is what the command will do.
        public void Execute()
        {
            _bulb.TurnOn();
        }

        // Running the command again
        public void Redo()
        {
            Execute();
        }

        // undo command
        public void Undo()
        {
            _bulb.TurnOff();
        }
    }
}
