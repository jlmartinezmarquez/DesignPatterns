using System;

namespace AbstractFactory.Resolution.Machines
{
    public class MicrowaveOven : IMachine
    {
        public string Name => "microwave oven";

        public void TurnOn()
        {
            Console.WriteLine("Microwave oven is starting.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Microwave oven is stopping.");
        }
    }
}