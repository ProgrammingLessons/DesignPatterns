using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class Bulb
    {
        // bulb class will have two actions
        // just turnOn and turnOff
        public void TurnOn()
        {
            Console.WriteLine("Bulb has been lit");
        }

        public void TurnOff()
        {
            Console.WriteLine("Darkness!");
        }
    }
}
