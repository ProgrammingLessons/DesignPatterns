using System;

namespace CommandDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bulb is defined
            var bulb = new Bulb();

            // Commands are defined
            var turnOn = new TurnOn(bulb);
            var turnOff = new TurnOff(bulb);

            // access to commands
            var remote = new RemoteControl();
            remote.Submit(turnOn);
            remote.Submit(turnOff);
        }
    }
}
